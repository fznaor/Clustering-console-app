using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZavrsniRad
{
    public partial class MainForm : Form
    {
        Dictionary<Chart, Dictionary<string, Control>> controls = new Dictionary<Chart, Dictionary<string, Control>>();
        public Presenter presenter { private get; set; }
        public int dimension { private get; set; }
        private int currentlyRunningAlgorithms = 0;

        public MainForm()
        {
            InitializeComponent();
            labelKmeansDimensionMsg.Visible = false;
            labelKMeansppDimensionMsg.Visible = false;
            labelKMedoidsDimensionMsg.Visible = false;
            labelChangeableDimensionMsg.Visible = false;
            Dictionary<string, Control> chartKmeansControls = new Dictionary<string, Control> { { "Iterations", labelKmeansIterCount }, { "CH", labelKmeansCH }, { "DB", labelKmeansDB }, { "Export", buttonExportKmeans }, { "Execution time", labelKmeansExecTime }, { "Silhouette", labelKmeansSilhouette }, { "Checkbox", checkBoxKmeansCentroids }, { "Run", buttonRunKmeans }, { "Zoom", buttonZoomKmeans }, { "Dimension message", labelKmeansDimensionMsg }, { "Max iterations", textBoxKmeansMaxIter } };
            Dictionary<string, Control> chartKmeansppControls = new Dictionary<string, Control> { { "Iterations", labelKmeansppIterCount }, { "CH", labelKmeansppCH }, { "DB", labelKmeansppDB }, { "Export", buttonExportKmeanspp }, { "Execution time", labelKmeansppExecTime }, { "Silhouette", labelKmeansppSilhouette }, { "Checkbox", checkBoxKmeansppCentroids }, { "Run", buttonRunKmeanspp }, { "Zoom", buttonZoomKmeanspp }, { "Dimension message", labelKMeansppDimensionMsg }, { "Max iterations", textBoxKmeansppMaxIter } };
            Dictionary<string, Control> chartKmedoidsControls = new Dictionary<string, Control> { { "Iterations", labelKmedoidsIterCount }, { "CH", labelKmedoidsCH }, { "DB", labelKmedoidsDB }, { "Export", buttonExportKmedoids }, { "Execution time", labelKmedoidsExecTime }, { "Silhouette", labelKmedoidsSilhouette }, { "Checkbox", checkBoxKmedoidsMedoids }, { "Run", buttonRunKmedoids }, { "Zoom", buttonZoomKmedoids }, { "Dimension message", labelKMedoidsDimensionMsg }, { "Random init", radioButtonKmedoidsRandom }, { "Kmeanspp init", radioButtonKmedoidsKmeanspp }, { "Max iterations", textBoxKmedoidsMaxIter } };
            Dictionary<string, Control> chartChangeableControls = new Dictionary<string, Control> { { "Iterations", labelChangeableIterCount }, { "CH", labelChangeableCH }, { "DB", labelChangeableDB }, { "Export", buttonExportChangeable }, { "Execution time", labelChangeableExecTime }, { "Silhouette", labelChangeableSilhouette }, { "Checkbox", checkBoxChangeableCentroids }, { "Run", buttonRunChangeable }, { "Zoom", buttonZoomChangeable }, { "Dimension message", labelChangeableDimensionMsg }, { "Random init", radioButtonChangeableRandom }, { "Kmeanspp init", radioButtonChangeableKmeanspp }, { "Max iterations", textBoxChangeableMaxIter } };
            controls.Add(chartKmeans, chartKmeansControls);
            controls.Add(chartKmeanspp, chartKmeansppControls);
            controls.Add(chartKmedoids, chartKmedoidsControls);
            controls.Add(chartChangeable, chartChangeableControls);
            string[] algorithms = new string[] { "k-means", "k-means++", "k-medoids", "FCM" };
            comboBoxAlgorithm.Items.AddRange(algorithms);
            comboBoxAlgorithm.SelectedIndex = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialogChooseFile.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
            if (openFileDialogChooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogChooseFile.FileName;
                if (presenter.loadPointsFromFile(filePath))
                {
                    labelFilename.Text = Path.GetFileName(filePath);
                    buttonRunAll.Enabled = true;
                    buttonRunKmeans.Enabled = true;
                    buttonRunKmeanspp.Enabled = true;
                    buttonRunKmedoids.Enabled = true;
                    buttonRunChangeable.Enabled = true;
                }
            }
        }

        public void showEmptyFileMessage()
        {
            MessageBox.Show("Datoteka je prazna!", "Pogreška");
        }

        public void showWrongDimensionMessage()
        {
            MessageBox.Show("Podatci nisu jednakih dimenzija!", "Pogreška");
        }

        public void showWrongFormatMessage()
        {
            MessageBox.Show("Podatci nisu u ispravnom formatu!", "Pogreška");
        }

        public void showOnePointMessage()
        {
            MessageBox.Show("Datoteka mora sadržavati barem 2 točke!", "Pogreška");
        }

        private void displayClusterCountErrorMessage()
        {
            MessageBox.Show("Broj grozdova ne može biti veći od broja točaka!", "Pogreška");
        }

        private bool isMaxIterationsValid(TextBox textBox)
        {
            int maxIterations;
            if (!int.TryParse(textBox.Text, out maxIterations))
            {
                MessageBox.Show("Maksimalni broj iteracija mora biti cijeli broj!", "Pogreška");
                return false;
            }
            else if (maxIterations <= 0)
            {
                MessageBox.Show("Maksimalni broj iteracija mora biti veći od 0!", "Pogreška");
                return false;
            }
            return true;
        }

        private void buttonRunAll_Click(object sender, EventArgs e)
        {
            int clusterCount = Convert.ToInt32(numericUpDownClusterCount.Value);
            if (!presenter.isClusterCountValid(clusterCount))
            {
                displayClusterCountErrorMessage();
                return;
            }
            performKmeans(chartKmeans);
            performKmeanspp(chartKmeanspp);
            switch (comboBoxAlgorithm.SelectedIndex)
            {
                case 0: performKmeans(chartChangeable); break;
                case 1: performKmeanspp(chartChangeable); break;
                case 2: performKmedoids(chartChangeable); break;
                default: performFCM(chartChangeable); break;
            }
            performKmedoids(chartKmedoids);
        }

        private void buttonRunKmeans_Click(object sender, EventArgs e)
        {
            performKmeans(chartKmeans);
        }

        private async void performKmeans(Chart chart)
        {
            int clusterCount = Convert.ToInt32(numericUpDownClusterCount.Value);
            if (!presenter.isClusterCountValid(clusterCount))
            {
                displayClusterCountErrorMessage();
                return;
            }

            int maxIterations;
            if (isMaxIterationsValid((TextBox)controls[chart]["Max iterations"]))
            {
                maxIterations = Convert.ToInt32(controls[chart]["Max iterations"].Text);
            }
            else return;

            int distance;
            if (radioButtonEuclidean.Checked) { distance = 1; }
            else distance = 2;

            setUpAlgorithmControls(chart);

            await presenter.performKmeans(clusterCount, maxIterations, distance, chart);

            updateControlsAfterAlgorithm(chart);
        }

        private void buttonRunKmeanspp_Click(object sender, EventArgs e)
        {
            performKmeanspp(chartKmeanspp);
        }

        private async void performKmeanspp(Chart chart)
        {
            int clusterCount = Convert.ToInt32(numericUpDownClusterCount.Value);
            if (!presenter.isClusterCountValid(clusterCount))
            {
                displayClusterCountErrorMessage();
                return;
            }

            int maxIterations;
            if (isMaxIterationsValid((TextBox)controls[chart]["Max iterations"]))
            {
                maxIterations = Convert.ToInt32(controls[chart]["Max iterations"].Text);
            }
            else return;

            int distance;
            if (radioButtonEuclidean.Checked) { distance = 1; }
            else distance = 2;

            setUpAlgorithmControls(chart);

            await presenter.performKmeanspp(clusterCount, maxIterations, distance, chart);

            updateControlsAfterAlgorithm(chart);
        }

        private void buttonRunKmedoids_Click(object sender, EventArgs e)
        {
            performKmedoids(chartKmedoids);
        }

        private async void performKmedoids(Chart chart)
        {
            int clusterCount = Convert.ToInt32(numericUpDownClusterCount.Value);
            if (!presenter.isClusterCountValid(clusterCount))
            {
                displayClusterCountErrorMessage();
                return;
            }

            int maxIterations;
            if (isMaxIterationsValid((TextBox)controls[chart]["Max iterations"]))
            {
                maxIterations = Convert.ToInt32(controls[chart]["Max iterations"].Text);
            }
            else return;

            int initialization;
            RadioButton random = (RadioButton)controls[chart]["Random init"];
            if (random.Checked) { initialization = 1; }
            else initialization = 2;
            Debug.WriteLine(initialization);

            int distance;
            if (radioButtonEuclidean.Checked) { distance = 1; }
            else distance = 2;

            setUpAlgorithmControls(chart);

            await presenter.performKmedoids(clusterCount, maxIterations, initialization, distance, chart);

            updateControlsAfterAlgorithm(chart);
        }

        private void buttonRunChangeable_Click(object sender, EventArgs e)
        {
            switch (comboBoxAlgorithm.SelectedIndex)
            {
                case 0: performKmeans(chartChangeable); break;
                case 1: performKmeanspp(chartChangeable); break;
                case 2: performKmedoids(chartChangeable); break;
                default: performFCM(chartChangeable); break;
            }
        }

        private async void performFCM(Chart chart)
        {
            int clusterCount = Convert.ToInt32(numericUpDownClusterCount.Value);
            if (!presenter.isClusterCountValid(clusterCount))
            {
                displayClusterCountErrorMessage();
                return;
            }

            int maxIterations;
            if (isMaxIterationsValid((TextBox)controls[chart]["Max iterations"]))
            {
                maxIterations = Convert.ToInt32(controls[chart]["Max iterations"].Text);
            }
            else return;

            double m;
            if (!double.TryParse(textBoxFCMmCoeff.Text, out m))
            {
                MessageBox.Show("Koeficijent m mora biti brojčana vrijednost!", "Pogreška");
                return;
            }
            else if (m < 1)
            {
                MessageBox.Show("Koeficijent m ne može biti manji od 1!", "Pogreška");
                return;
            }

            double epsilon;
            if (!double.TryParse(textBoxFCMEpsilon.Text, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out epsilon))
            {
                MessageBox.Show("Kriterij zaustavljanja mora biti brojčana vrijednost!", "Pogreška");
                return;
            }
            else if (m < 0)
            {
                MessageBox.Show("Kriterij zaustavljanja ne može biti negativan broj!", "Pogreška");
                return;
            }

            int distance;
            if (radioButtonEuclidean.Checked) { distance = 1; }
            else distance = 2;

            setUpAlgorithmControls(chart);

            await presenter.performFCM(clusterCount, maxIterations, m, epsilon, distance, chart);

            updateControlsAfterAlgorithm(chart);
        }


        private void setUpAlgorithmControls(Chart chart)
        {
            if (chart == chartChangeable) comboBoxAlgorithm.Enabled = false;
            setUpChart(chart);

            currentlyRunningAlgorithms++;
            buttonRunAll.Enabled = false;
            buttonChooseFile.Enabled = false;

            controls[chart]["Checkbox"].Enabled = false;
            controls[chart]["Run"].Enabled = false;
            toggleControlVisibility(chart, false);

            controls[chart]["Zoom"].Enabled = dimension <= 2;
            controls[chart]["Dimension message"].Visible = dimension > 2;
            controls[chart]["Dimension message"].Update();
        }

        private void updateControlsAfterAlgorithm(Chart chart)
        {
            controls[chart]["Checkbox"].Enabled = dimension <= 2;
            controls[chart]["Run"].Enabled = true;
            toggleControlVisibility(chart, true);

            if (--currentlyRunningAlgorithms == 0)
            {
                buttonRunAll.Enabled = true;
                buttonChooseFile.Enabled = true;
            }

            if (chart == chartChangeable) comboBoxAlgorithm.Enabled = true;
        }

        public void setUpChart(Chart chart)
        {
            chart.Series.Clear();
            for (int i = 0; i < Convert.ToInt32(numericUpDownClusterCount.Value); i++)
            {
                Series series = new Series(i.ToString());
                series.ChartType = SeriesChartType.FastPoint;
                series.MarkerStyle = MarkerStyle.Circle;
                series.CustomProperties = "IsXAxisQuantitative=True";
                chart.Series.Add(series);
            }
            for (int i = Convert.ToInt32(numericUpDownClusterCount.Value); i < 2 * Convert.ToInt32(numericUpDownClusterCount.Value); i++)
            {
                Series series = new Series(i.ToString());
                series.ChartType = SeriesChartType.FastPoint;
                series.MarkerStyle = MarkerStyle.Diamond;
                series.Color = Color.White;
                series.MarkerSize = 7;
                series.MarkerBorderColor = Color.Black;
                series.MarkerBorderWidth = 2;
                series.CustomProperties = "IsXAxisQuantitative=True";
                chart.Series.Add(series);
            }
            chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart.Update();
        }

        public void graphResults(Chart chart, Point[] points, Cluster[] clusters, int[] results)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].dimension == 2)
                    chart.Series[results[i].ToString()].Points.AddXY(points[i].coordinates[0], points[i].coordinates[1]);
                else if (points[i].dimension == 1)
                    chart.Series[results[i].ToString()].Points.AddXY(points[i].coordinates[0], 0);
            }
            for (int i = 0; i < clusters.Length; i++)
            {
                if (clusters[i].centroid.dimension == 2)
                    chart.Series[i + clusters.Length].Points.AddXY(clusters[i].centroid.coordinates[0],
                        clusters[i].centroid.coordinates[1]);
                else if (clusters[i].centroid.dimension == 1)
                    chart.Series[i + clusters.Length].Points.AddXY(clusters[i].centroid.coordinates[0], 0);
            }
            chart.ResetAutoValues();
            chart.Update();
        }

        public void displayData(Chart chart, long executionTime, int iterationCount, double CHIndex, double DBIndex, double silhouette)
        {
            displayExecutionTime((Label)controls[chart]["Execution time"], executionTime);
            displayIterationCount((Label)controls[chart]["Iterations"], iterationCount);
            displayCalinskiHarabaszIndex((Label)controls[chart]["CH"], CHIndex);
            displayDaviesBouldinIndex((Label)controls[chart]["DB"], DBIndex);
            displaySilhouetteCoefficient((Label)controls[chart]["Silhouette"], silhouette);
        }

        private void displayExecutionTime(Label label, long executionTime)
        {
            label.Text = "Vrijeme izvođenja: " + executionTime.ToString() + " ms";
        }

        private void displayIterationCount(Label label, int iterationCount)
        {
            label.Text = "Broj iteracija: " + iterationCount.ToString();
        }

        private void displayCalinskiHarabaszIndex(Label label, double CHIndex)
        {
            label.Text = "Calinski-Harabaszov indeks: " + CHIndex.ToString("0.000");
        }

        private void displayDaviesBouldinIndex(Label label, double DBIndex)
        {
            label.Text = "Davies-Bouldinov indeks: " + DBIndex.ToString("0.000");
        }

        private void displaySilhouetteCoefficient(Label label, double silhouette)
        {
            label.Text = "Koeficijent siluete: " + silhouette.ToString("0.000");
        }

        private void checkBoxKmeansCentroids_CheckedChanged(object sender, EventArgs e)
        {
            toggleCentroidVisibility(chartKmeans);
        }

        private void checkBoxKmeansppCentroids_CheckedChanged(object sender, EventArgs e)
        {
            toggleCentroidVisibility(chartKmeanspp);
        }

        private void checkBoxKmedoidsMedoids_CheckedChanged(object sender, EventArgs e)
        {
            toggleCentroidVisibility(chartKmedoids);
        }

        private void checkBoxChangeableCentroids_CheckedChanged(object sender, EventArgs e)
        {
            toggleCentroidVisibility(chartChangeable);
        }

        public void toggleCentroidVisibility(Chart chart)
        {
            for (int i = chart.Series.Count - 1; i >= chart.Series.Count / 2; i--)
            {
                CheckBox checkBox = (CheckBox)controls[chart]["Checkbox"];
                chart.Series.ElementAt(i).Enabled = checkBox.Checked;
            }
            chart.Update();
        }

        private void buttonZoomKmeans_Click(object sender, EventArgs e)
        {
            ZoomForm zoomForm = new ZoomForm(chartKmeans);
            zoomForm.ShowDialog();
        }

        private void buttonZoomKmeanspp_Click(object sender, EventArgs e)
        {
            ZoomForm zoomForm = new ZoomForm(chartKmeanspp);
            zoomForm.ShowDialog();
        }

        private void buttonZoomKmedoids_Click(object sender, EventArgs e)
        {
            ZoomForm zoomForm = new ZoomForm(chartKmedoids);
            zoomForm.ShowDialog();
        }

        private void buttonZoomFCM_Click(object sender, EventArgs e)
        {
            ZoomForm zoomForm = new ZoomForm(chartChangeable);
            zoomForm.ShowDialog();
        }

        private void buttonExportKmeans_Click(object sender, EventArgs e)
        {
            presenter.exportKmeansResults();
        }

        private void buttonExportKmeanspp_Click(object sender, EventArgs e)
        {
            presenter.exportKmeansppResults();
        }

        private void buttonExportKmedoids_Click(object sender, EventArgs e)
        {
            presenter.exportKmedoidsResults();
        }

        private void buttonExportChangeable_Click(object sender, EventArgs e)
        {
            presenter.exportChangeableResults(comboBoxAlgorithm.SelectedIndex);
        }

        public void exportResults(Point[] points, int[] results, string filename)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
            {
                for (int i = 0; i < points.Length; i++)
                {
                    StringBuilder builder = new StringBuilder();
                    for (int j = 0; j < points[i].dimension; j++)
                    {
                        builder.Append(points[i].coordinates[j]).Append(',');
                    }
                    builder.Append("Grozd_").Append(results[i]);
                    writer.WriteLine(builder.ToString());
                }
            }
            Process.Start(filename);
        }

        public void exportResults(Point[] points, double[][] results, string filename)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
            {
                for (int i = 0; i < points.Length; i++)
                {
                    StringBuilder builder = new StringBuilder();
                    for (int j = 0; j < points[i].dimension; j++)
                    {
                        builder.Append(points[i].coordinates[j]).Append(',');
                    }
                    for (int j = 0; j < results[0].Length; j++)
                    {
                        builder.Append(results[i][j]);
                        if (j != results[0].Length - 1) builder.Append(',');
                    }

                    writer.WriteLine(builder.ToString());
                }
            }
            Process.Start(filename);
        }

        private void comboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleFCMControlVisibility(comboBoxAlgorithm.SelectedIndex == 3);
            toggleKmedoidsControlVisibility(comboBoxAlgorithm.SelectedIndex == 2);
            setUpChart(chartChangeable);
            controls[chartChangeable]["Checkbox"].Enabled = false;
            toggleControlVisibility(chartChangeable, false);
        }

        private void toggleControlVisibility(Chart chart, bool state)
        {
            List<string> keys = new List<string> { "Iterations", "CH", "DB", "Export", "Execution time", "Silhouette" };
            foreach (string key in keys)
            {
                controls[chart][key].Visible = state;
                controls[chart][key].Update();
            }
        }

        private void toggleFCMControlVisibility(bool state)
        {
            labelFCMmCoeff.Visible = state;
            labelFCMEpsilon.Visible = state;
            textBoxFCMmCoeff.Visible = state;
            textBoxFCMEpsilon.Visible = state;
        }

        private void toggleKmedoidsControlVisibility(bool state)
        {
            labelChangeableInit.Visible = state;
            groupBoxChangeableInit.Visible = state;
        }
    }
}
