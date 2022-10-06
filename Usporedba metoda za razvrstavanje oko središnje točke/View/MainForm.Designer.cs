namespace ZavrsniRad
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chartKmeans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelKmeansIterCount = new System.Windows.Forms.Label();
            this.chartKmeanspp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelKmeansppIterCount = new System.Windows.Forms.Label();
            this.labelKmeansTitle = new System.Windows.Forms.Label();
            this.labelKmeansppTitle = new System.Windows.Forms.Label();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.openFileDialogChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.labelClusterCount = new System.Windows.Forms.Label();
            this.chartKmedoids = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelKmedoidsIterCount = new System.Windows.Forms.Label();
            this.labelKmedoidsTitle = new System.Windows.Forms.Label();
            this.chartChangeable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChangeableIterCount = new System.Windows.Forms.Label();
            this.buttonRunKmeans = new System.Windows.Forms.Button();
            this.buttonRunKmeanspp = new System.Windows.Forms.Button();
            this.buttonRunKmedoids = new System.Windows.Forms.Button();
            this.buttonRunChangeable = new System.Windows.Forms.Button();
            this.checkBoxKmeansCentroids = new System.Windows.Forms.CheckBox();
            this.checkBoxKmeansppCentroids = new System.Windows.Forms.CheckBox();
            this.checkBoxKmedoidsMedoids = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeableCentroids = new System.Windows.Forms.CheckBox();
            this.buttonZoomKmeans = new System.Windows.Forms.Button();
            this.buttonZoomKmeanspp = new System.Windows.Forms.Button();
            this.buttonZoomKmedoids = new System.Windows.Forms.Button();
            this.buttonZoomChangeable = new System.Windows.Forms.Button();
            this.labelFilename = new System.Windows.Forms.Label();
            this.numericUpDownClusterCount = new System.Windows.Forms.NumericUpDown();
            this.labelKmeansMaxIter = new System.Windows.Forms.Label();
            this.textBoxKmeansMaxIter = new System.Windows.Forms.TextBox();
            this.textBoxKmeansppMaxIter = new System.Windows.Forms.TextBox();
            this.labelKmeansppMaxIter = new System.Windows.Forms.Label();
            this.textBoxKmedoidsMaxIter = new System.Windows.Forms.TextBox();
            this.labelKmedoidsMaxIter = new System.Windows.Forms.Label();
            this.textBoxChangeableMaxIter = new System.Windows.Forms.TextBox();
            this.labelChangeableMaxIter = new System.Windows.Forms.Label();
            this.labelKmeansCH = new System.Windows.Forms.Label();
            this.labelKmeansDB = new System.Windows.Forms.Label();
            this.labelKmeansppCH = new System.Windows.Forms.Label();
            this.labelKmeansppDB = new System.Windows.Forms.Label();
            this.labelKmedoidsCH = new System.Windows.Forms.Label();
            this.labelKmedoidsDB = new System.Windows.Forms.Label();
            this.labelChangeableCH = new System.Windows.Forms.Label();
            this.labelChangeableDB = new System.Windows.Forms.Label();
            this.labelFCMmCoeff = new System.Windows.Forms.Label();
            this.textBoxFCMmCoeff = new System.Windows.Forms.TextBox();
            this.buttonExportKmeans = new System.Windows.Forms.Button();
            this.buttonExportKmeanspp = new System.Windows.Forms.Button();
            this.buttonExportKmedoids = new System.Windows.Forms.Button();
            this.buttonExportChangeable = new System.Windows.Forms.Button();
            this.labelKmeansDimensionMsg = new System.Windows.Forms.Label();
            this.labelKMeansppDimensionMsg = new System.Windows.Forms.Label();
            this.labelKMedoidsDimensionMsg = new System.Windows.Forms.Label();
            this.labelChangeableDimensionMsg = new System.Windows.Forms.Label();
            this.labelKmeansExecTime = new System.Windows.Forms.Label();
            this.labelKmeansppExecTime = new System.Windows.Forms.Label();
            this.labelKmedoidsExecTime = new System.Windows.Forms.Label();
            this.labelChangeableExecTime = new System.Windows.Forms.Label();
            this.labelKmeansSilhouette = new System.Windows.Forms.Label();
            this.labelKmeansppSilhouette = new System.Windows.Forms.Label();
            this.labelKmedoidsSilhouette = new System.Windows.Forms.Label();
            this.labelChangeableSilhouette = new System.Windows.Forms.Label();
            this.labelKmedoidsInit = new System.Windows.Forms.Label();
            this.radioButtonKmedoidsRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonKmedoidsKmeanspp = new System.Windows.Forms.RadioButton();
            this.groupBoxKmedoidsInit = new System.Windows.Forms.GroupBox();
            this.buttonRunAll = new System.Windows.Forms.Button();
            this.labelDataFormatInfo = new System.Windows.Forms.Label();
            this.groupBoxDistance = new System.Windows.Forms.GroupBox();
            this.radioButtonEuclidean = new System.Windows.Forms.RadioButton();
            this.radioButtonManhattan = new System.Windows.Forms.RadioButton();
            this.labelDistance = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.textBoxFCMEpsilon = new System.Windows.Forms.TextBox();
            this.labelFCMEpsilon = new System.Windows.Forms.Label();
            this.groupBoxChangeableInit = new System.Windows.Forms.GroupBox();
            this.radioButtonChangeableRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonChangeableKmeanspp = new System.Windows.Forms.RadioButton();
            this.labelChangeableInit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartKmeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKmeanspp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKmedoids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChangeable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClusterCount)).BeginInit();
            this.groupBoxKmedoidsInit.SuspendLayout();
            this.groupBoxDistance.SuspendLayout();
            this.groupBoxChangeableInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartKmeans
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartKmeans.ChartAreas.Add(chartArea1);
            this.chartKmeans.Location = new System.Drawing.Point(12, 133);
            this.chartKmeans.Name = "chartKmeans";
            this.chartKmeans.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartKmeans.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(254))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(103))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(0)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(181))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(246))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(251)))), ((int)(((byte)(146))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(2)))), ((int)(((byte)(157))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(137)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(71)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(45)))), ((int)(((byte)(210))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(169)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(36)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(61)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(198)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(211)))), ((int)(((byte)(147))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(23))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(142))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(159))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(163))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(111)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(161))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(208)))), ((int)(((byte)(203))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(153)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(138)))), ((int)(((byte)(232))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(44))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(116))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(198))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(2))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(14)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(156))))),
        System.Drawing.Color.Black};
            this.chartKmeans.Size = new System.Drawing.Size(467, 334);
            this.chartKmeans.TabIndex = 0;
            this.chartKmeans.Text = "chart1";
            // 
            // labelKmeansIterCount
            // 
            this.labelKmeansIterCount.AutoSize = true;
            this.labelKmeansIterCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansIterCount.Location = new System.Drawing.Point(485, 250);
            this.labelKmeansIterCount.Name = "labelKmeansIterCount";
            this.labelKmeansIterCount.Size = new System.Drawing.Size(84, 16);
            this.labelKmeansIterCount.TabIndex = 2;
            this.labelKmeansIterCount.Text = "Broj iteracija:";
            this.labelKmeansIterCount.Visible = false;
            // 
            // chartKmeanspp
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartKmeanspp.ChartAreas.Add(chartArea2);
            this.chartKmeanspp.Location = new System.Drawing.Point(843, 133);
            this.chartKmeanspp.Name = "chartKmeanspp";
            this.chartKmeanspp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartKmeanspp.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(254))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(103))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(0)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(181))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(246))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(251)))), ((int)(((byte)(146))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(2)))), ((int)(((byte)(157))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(137)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(71)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(45)))), ((int)(((byte)(210))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(169)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(36)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(61)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(198)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(211)))), ((int)(((byte)(147))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(23))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(142))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(159))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(163))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(111)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(161))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(208)))), ((int)(((byte)(203))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(153)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(138)))), ((int)(((byte)(232))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(44))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(116))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(198))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(2))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(14)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(156))))),
        System.Drawing.Color.Black};
            this.chartKmeanspp.Size = new System.Drawing.Size(467, 334);
            this.chartKmeanspp.TabIndex = 3;
            this.chartKmeanspp.Text = "chart2";
            // 
            // labelKmeansppIterCount
            // 
            this.labelKmeansppIterCount.AutoSize = true;
            this.labelKmeansppIterCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansppIterCount.Location = new System.Drawing.Point(1316, 250);
            this.labelKmeansppIterCount.Name = "labelKmeansppIterCount";
            this.labelKmeansppIterCount.Size = new System.Drawing.Size(84, 16);
            this.labelKmeansppIterCount.TabIndex = 4;
            this.labelKmeansppIterCount.Text = "Broj iteracija:";
            this.labelKmeansppIterCount.Visible = false;
            // 
            // labelKmeansTitle
            // 
            this.labelKmeansTitle.AutoSize = true;
            this.labelKmeansTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansTitle.Location = new System.Drawing.Point(219, 112);
            this.labelKmeansTitle.Name = "labelKmeansTitle";
            this.labelKmeansTitle.Size = new System.Drawing.Size(67, 18);
            this.labelKmeansTitle.TabIndex = 5;
            this.labelKmeansTitle.Text = "k-means";
            // 
            // labelKmeansppTitle
            // 
            this.labelKmeansppTitle.AutoSize = true;
            this.labelKmeansppTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansppTitle.Location = new System.Drawing.Point(1050, 112);
            this.labelKmeansppTitle.Name = "labelKmeansppTitle";
            this.labelKmeansppTitle.Size = new System.Drawing.Size(85, 18);
            this.labelKmeansppTitle.TabIndex = 6;
            this.labelKmeansppTitle.Text = "k-means++";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseFile.Location = new System.Drawing.Point(131, 37);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(179, 23);
            this.buttonChooseFile.TabIndex = 7;
            this.buttonChooseFile.Text = "Odaberi datoteku";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // openFileDialogChooseFile
            // 
            this.openFileDialogChooseFile.FileName = "openFileDialog1";
            // 
            // labelClusterCount
            // 
            this.labelClusterCount.AutoSize = true;
            this.labelClusterCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClusterCount.Location = new System.Drawing.Point(590, 41);
            this.labelClusterCount.Name = "labelClusterCount";
            this.labelClusterCount.Size = new System.Drawing.Size(90, 16);
            this.labelClusterCount.TabIndex = 8;
            this.labelClusterCount.Text = "Broj grozdova:";
            // 
            // chartKmedoids
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chartKmedoids.ChartAreas.Add(chartArea3);
            this.chartKmedoids.Location = new System.Drawing.Point(12, 559);
            this.chartKmedoids.Name = "chartKmedoids";
            this.chartKmedoids.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartKmedoids.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(254))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(103))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(0)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(181))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(246))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(251)))), ((int)(((byte)(146))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(2)))), ((int)(((byte)(157))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(137)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(71)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(45)))), ((int)(((byte)(210))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(169)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(36)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(61)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(198)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(211)))), ((int)(((byte)(147))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(23))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(142))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(159))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(163))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(111)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(161))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(208)))), ((int)(((byte)(203))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(153)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(138)))), ((int)(((byte)(232))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(44))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(116))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(198))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(2))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(14)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(156))))),
        System.Drawing.Color.Black};
            this.chartKmedoids.Size = new System.Drawing.Size(467, 334);
            this.chartKmedoids.TabIndex = 10;
            this.chartKmedoids.Text = "chart3";
            // 
            // labelKmedoidsIterCount
            // 
            this.labelKmedoidsIterCount.AutoSize = true;
            this.labelKmedoidsIterCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsIterCount.Location = new System.Drawing.Point(485, 683);
            this.labelKmedoidsIterCount.Name = "labelKmedoidsIterCount";
            this.labelKmedoidsIterCount.Size = new System.Drawing.Size(84, 16);
            this.labelKmedoidsIterCount.TabIndex = 11;
            this.labelKmedoidsIterCount.Text = "Broj iteracija:";
            this.labelKmedoidsIterCount.Visible = false;
            // 
            // labelKmedoidsTitle
            // 
            this.labelKmedoidsTitle.AutoSize = true;
            this.labelKmedoidsTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsTitle.Location = new System.Drawing.Point(205, 538);
            this.labelKmedoidsTitle.Name = "labelKmedoidsTitle";
            this.labelKmedoidsTitle.Size = new System.Drawing.Size(81, 18);
            this.labelKmedoidsTitle.TabIndex = 12;
            this.labelKmedoidsTitle.Text = "k-medoids";
            // 
            // chartChangeable
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.BorderWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.chartChangeable.ChartAreas.Add(chartArea4);
            this.chartChangeable.Location = new System.Drawing.Point(843, 559);
            this.chartChangeable.Name = "chartChangeable";
            this.chartChangeable.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartChangeable.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(254))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(1))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(103))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(0)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(181))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(246))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(77)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(251)))), ((int)(((byte)(146))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(2)))), ((int)(((byte)(157))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(137)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(71)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(45)))), ((int)(((byte)(210))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(169)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(36)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(61)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(198)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(211)))), ((int)(((byte)(147))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(23))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(142))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(140)))), ((int)(((byte)(159))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(163))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(111)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(161))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(208)))), ((int)(((byte)(203))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(153)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(138)))), ((int)(((byte)(232))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(44))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(116))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(198))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(2))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(14)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(156))))),
        System.Drawing.Color.Black};
            this.chartChangeable.Size = new System.Drawing.Size(467, 334);
            this.chartChangeable.TabIndex = 13;
            this.chartChangeable.Text = "chart4";
            // 
            // labelChangeableIterCount
            // 
            this.labelChangeableIterCount.AutoSize = true;
            this.labelChangeableIterCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableIterCount.Location = new System.Drawing.Point(1316, 683);
            this.labelChangeableIterCount.Name = "labelChangeableIterCount";
            this.labelChangeableIterCount.Size = new System.Drawing.Size(84, 16);
            this.labelChangeableIterCount.TabIndex = 14;
            this.labelChangeableIterCount.Text = "Broj iteracija:";
            this.labelChangeableIterCount.Visible = false;
            // 
            // buttonRunKmeans
            // 
            this.buttonRunKmeans.Enabled = false;
            this.buttonRunKmeans.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunKmeans.Location = new System.Drawing.Point(12, 470);
            this.buttonRunKmeans.Name = "buttonRunKmeans";
            this.buttonRunKmeans.Size = new System.Drawing.Size(75, 23);
            this.buttonRunKmeans.TabIndex = 16;
            this.buttonRunKmeans.Text = "Pokreni";
            this.buttonRunKmeans.UseVisualStyleBackColor = true;
            this.buttonRunKmeans.Click += new System.EventHandler(this.buttonRunKmeans_Click);
            // 
            // buttonRunKmeanspp
            // 
            this.buttonRunKmeanspp.Enabled = false;
            this.buttonRunKmeanspp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunKmeanspp.Location = new System.Drawing.Point(843, 470);
            this.buttonRunKmeanspp.Name = "buttonRunKmeanspp";
            this.buttonRunKmeanspp.Size = new System.Drawing.Size(75, 23);
            this.buttonRunKmeanspp.TabIndex = 17;
            this.buttonRunKmeanspp.Text = "Pokreni";
            this.buttonRunKmeanspp.UseVisualStyleBackColor = true;
            this.buttonRunKmeanspp.Click += new System.EventHandler(this.buttonRunKmeanspp_Click);
            // 
            // buttonRunKmedoids
            // 
            this.buttonRunKmedoids.Enabled = false;
            this.buttonRunKmedoids.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunKmedoids.Location = new System.Drawing.Point(12, 895);
            this.buttonRunKmedoids.Name = "buttonRunKmedoids";
            this.buttonRunKmedoids.Size = new System.Drawing.Size(75, 23);
            this.buttonRunKmedoids.TabIndex = 18;
            this.buttonRunKmedoids.Text = "Pokreni";
            this.buttonRunKmedoids.UseVisualStyleBackColor = true;
            this.buttonRunKmedoids.Click += new System.EventHandler(this.buttonRunKmedoids_Click);
            // 
            // buttonRunChangeable
            // 
            this.buttonRunChangeable.Enabled = false;
            this.buttonRunChangeable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunChangeable.Location = new System.Drawing.Point(843, 895);
            this.buttonRunChangeable.Name = "buttonRunChangeable";
            this.buttonRunChangeable.Size = new System.Drawing.Size(75, 23);
            this.buttonRunChangeable.TabIndex = 19;
            this.buttonRunChangeable.Text = "Pokreni";
            this.buttonRunChangeable.UseVisualStyleBackColor = true;
            this.buttonRunChangeable.Click += new System.EventHandler(this.buttonRunChangeable_Click);
            // 
            // checkBoxKmeansCentroids
            // 
            this.checkBoxKmeansCentroids.AutoSize = true;
            this.checkBoxKmeansCentroids.Enabled = false;
            this.checkBoxKmeansCentroids.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKmeansCentroids.Location = new System.Drawing.Point(355, 473);
            this.checkBoxKmeansCentroids.Name = "checkBoxKmeansCentroids";
            this.checkBoxKmeansCentroids.Size = new System.Drawing.Size(124, 20);
            this.checkBoxKmeansCentroids.TabIndex = 20;
            this.checkBoxKmeansCentroids.Text = "Prikaži centroide";
            this.checkBoxKmeansCentroids.UseVisualStyleBackColor = true;
            this.checkBoxKmeansCentroids.CheckedChanged += new System.EventHandler(this.checkBoxKmeansCentroids_CheckedChanged);
            // 
            // checkBoxKmeansppCentroids
            // 
            this.checkBoxKmeansppCentroids.AutoSize = true;
            this.checkBoxKmeansppCentroids.Enabled = false;
            this.checkBoxKmeansppCentroids.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKmeansppCentroids.Location = new System.Drawing.Point(1186, 473);
            this.checkBoxKmeansppCentroids.Name = "checkBoxKmeansppCentroids";
            this.checkBoxKmeansppCentroids.Size = new System.Drawing.Size(124, 20);
            this.checkBoxKmeansppCentroids.TabIndex = 21;
            this.checkBoxKmeansppCentroids.Text = "Prikaži centroide";
            this.checkBoxKmeansppCentroids.UseVisualStyleBackColor = true;
            this.checkBoxKmeansppCentroids.CheckedChanged += new System.EventHandler(this.checkBoxKmeansppCentroids_CheckedChanged);
            // 
            // checkBoxKmedoidsMedoids
            // 
            this.checkBoxKmedoidsMedoids.AutoSize = true;
            this.checkBoxKmedoidsMedoids.Enabled = false;
            this.checkBoxKmedoidsMedoids.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKmedoidsMedoids.Location = new System.Drawing.Point(359, 901);
            this.checkBoxKmedoidsMedoids.Name = "checkBoxKmedoidsMedoids";
            this.checkBoxKmedoidsMedoids.Size = new System.Drawing.Size(120, 20);
            this.checkBoxKmedoidsMedoids.TabIndex = 22;
            this.checkBoxKmedoidsMedoids.Text = "Prikaži medoide";
            this.checkBoxKmedoidsMedoids.UseVisualStyleBackColor = true;
            this.checkBoxKmedoidsMedoids.CheckedChanged += new System.EventHandler(this.checkBoxKmedoidsMedoids_CheckedChanged);
            // 
            // checkBoxChangeableCentroids
            // 
            this.checkBoxChangeableCentroids.AutoSize = true;
            this.checkBoxChangeableCentroids.Enabled = false;
            this.checkBoxChangeableCentroids.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChangeableCentroids.Location = new System.Drawing.Point(1186, 896);
            this.checkBoxChangeableCentroids.Name = "checkBoxChangeableCentroids";
            this.checkBoxChangeableCentroids.Size = new System.Drawing.Size(124, 20);
            this.checkBoxChangeableCentroids.TabIndex = 23;
            this.checkBoxChangeableCentroids.Text = "Prikaži centroide";
            this.checkBoxChangeableCentroids.UseVisualStyleBackColor = true;
            this.checkBoxChangeableCentroids.CheckedChanged += new System.EventHandler(this.checkBoxChangeableCentroids_CheckedChanged);
            // 
            // buttonZoomKmeans
            // 
            this.buttonZoomKmeans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZoomKmeans.BackgroundImage")));
            this.buttonZoomKmeans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZoomKmeans.Enabled = false;
            this.buttonZoomKmeans.Location = new System.Drawing.Point(446, 133);
            this.buttonZoomKmeans.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomKmeans.Name = "buttonZoomKmeans";
            this.buttonZoomKmeans.Size = new System.Drawing.Size(33, 23);
            this.buttonZoomKmeans.TabIndex = 24;
            this.buttonZoomKmeans.UseVisualStyleBackColor = true;
            this.buttonZoomKmeans.Click += new System.EventHandler(this.buttonZoomKmeans_Click);
            // 
            // buttonZoomKmeanspp
            // 
            this.buttonZoomKmeanspp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZoomKmeanspp.BackgroundImage")));
            this.buttonZoomKmeanspp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZoomKmeanspp.Enabled = false;
            this.buttonZoomKmeanspp.Location = new System.Drawing.Point(1277, 133);
            this.buttonZoomKmeanspp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomKmeanspp.Name = "buttonZoomKmeanspp";
            this.buttonZoomKmeanspp.Size = new System.Drawing.Size(33, 23);
            this.buttonZoomKmeanspp.TabIndex = 25;
            this.buttonZoomKmeanspp.UseVisualStyleBackColor = true;
            this.buttonZoomKmeanspp.Click += new System.EventHandler(this.buttonZoomKmeanspp_Click);
            // 
            // buttonZoomKmedoids
            // 
            this.buttonZoomKmedoids.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZoomKmedoids.BackgroundImage")));
            this.buttonZoomKmedoids.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZoomKmedoids.Enabled = false;
            this.buttonZoomKmedoids.Location = new System.Drawing.Point(446, 559);
            this.buttonZoomKmedoids.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomKmedoids.Name = "buttonZoomKmedoids";
            this.buttonZoomKmedoids.Size = new System.Drawing.Size(33, 23);
            this.buttonZoomKmedoids.TabIndex = 26;
            this.buttonZoomKmedoids.UseVisualStyleBackColor = true;
            this.buttonZoomKmedoids.Click += new System.EventHandler(this.buttonZoomKmedoids_Click);
            // 
            // buttonZoomChangeable
            // 
            this.buttonZoomChangeable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZoomChangeable.BackgroundImage")));
            this.buttonZoomChangeable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZoomChangeable.Enabled = false;
            this.buttonZoomChangeable.Location = new System.Drawing.Point(1277, 559);
            this.buttonZoomChangeable.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomChangeable.Name = "buttonZoomChangeable";
            this.buttonZoomChangeable.Size = new System.Drawing.Size(33, 23);
            this.buttonZoomChangeable.TabIndex = 27;
            this.buttonZoomChangeable.UseVisualStyleBackColor = true;
            this.buttonZoomChangeable.Click += new System.EventHandler(this.buttonZoomFCM_Click);
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilename.Location = new System.Drawing.Point(316, 40);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(141, 16);
            this.labelFilename.TabIndex = 28;
            this.labelFilename.Text = "Nije odabrana datoteka";
            // 
            // numericUpDownClusterCount
            // 
            this.numericUpDownClusterCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownClusterCount.Location = new System.Drawing.Point(676, 39);
            this.numericUpDownClusterCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownClusterCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownClusterCount.Name = "numericUpDownClusterCount";
            this.numericUpDownClusterCount.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownClusterCount.TabIndex = 29;
            this.numericUpDownClusterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownClusterCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelKmeansMaxIter
            // 
            this.labelKmeansMaxIter.AutoSize = true;
            this.labelKmeansMaxIter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansMaxIter.Location = new System.Drawing.Point(164, 473);
            this.labelKmeansMaxIter.Name = "labelKmeansMaxIter";
            this.labelKmeansMaxIter.Size = new System.Drawing.Size(111, 16);
            this.labelKmeansMaxIter.TabIndex = 34;
            this.labelKmeansMaxIter.Text = "Max broj iteracija:";
            // 
            // textBoxKmeansMaxIter
            // 
            this.textBoxKmeansMaxIter.Location = new System.Drawing.Point(270, 472);
            this.textBoxKmeansMaxIter.Name = "textBoxKmeansMaxIter";
            this.textBoxKmeansMaxIter.Size = new System.Drawing.Size(40, 20);
            this.textBoxKmeansMaxIter.TabIndex = 35;
            this.textBoxKmeansMaxIter.Text = "100";
            this.textBoxKmeansMaxIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKmeansppMaxIter
            // 
            this.textBoxKmeansppMaxIter.Location = new System.Drawing.Point(1104, 472);
            this.textBoxKmeansppMaxIter.Name = "textBoxKmeansppMaxIter";
            this.textBoxKmeansppMaxIter.Size = new System.Drawing.Size(40, 20);
            this.textBoxKmeansppMaxIter.TabIndex = 37;
            this.textBoxKmeansppMaxIter.Text = "100";
            this.textBoxKmeansppMaxIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKmeansppMaxIter
            // 
            this.labelKmeansppMaxIter.AutoSize = true;
            this.labelKmeansppMaxIter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansppMaxIter.Location = new System.Drawing.Point(998, 473);
            this.labelKmeansppMaxIter.Name = "labelKmeansppMaxIter";
            this.labelKmeansppMaxIter.Size = new System.Drawing.Size(111, 16);
            this.labelKmeansppMaxIter.TabIndex = 36;
            this.labelKmeansppMaxIter.Text = "Max broj iteracija:";
            // 
            // textBoxKmedoidsMaxIter
            // 
            this.textBoxKmedoidsMaxIter.Location = new System.Drawing.Point(270, 901);
            this.textBoxKmedoidsMaxIter.Name = "textBoxKmedoidsMaxIter";
            this.textBoxKmedoidsMaxIter.Size = new System.Drawing.Size(40, 20);
            this.textBoxKmedoidsMaxIter.TabIndex = 39;
            this.textBoxKmedoidsMaxIter.Text = "100";
            this.textBoxKmedoidsMaxIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKmedoidsMaxIter
            // 
            this.labelKmedoidsMaxIter.AutoSize = true;
            this.labelKmedoidsMaxIter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsMaxIter.Location = new System.Drawing.Point(164, 902);
            this.labelKmedoidsMaxIter.Name = "labelKmedoidsMaxIter";
            this.labelKmedoidsMaxIter.Size = new System.Drawing.Size(111, 16);
            this.labelKmedoidsMaxIter.TabIndex = 38;
            this.labelKmedoidsMaxIter.Text = "Max broj iteracija:";
            // 
            // textBoxChangeableMaxIter
            // 
            this.textBoxChangeableMaxIter.Location = new System.Drawing.Point(1104, 897);
            this.textBoxChangeableMaxIter.Name = "textBoxChangeableMaxIter";
            this.textBoxChangeableMaxIter.Size = new System.Drawing.Size(40, 20);
            this.textBoxChangeableMaxIter.TabIndex = 41;
            this.textBoxChangeableMaxIter.Text = "100";
            this.textBoxChangeableMaxIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelChangeableMaxIter
            // 
            this.labelChangeableMaxIter.AutoSize = true;
            this.labelChangeableMaxIter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableMaxIter.Location = new System.Drawing.Point(998, 898);
            this.labelChangeableMaxIter.Name = "labelChangeableMaxIter";
            this.labelChangeableMaxIter.Size = new System.Drawing.Size(111, 16);
            this.labelChangeableMaxIter.TabIndex = 40;
            this.labelChangeableMaxIter.Text = "Max broj iteracija:";
            // 
            // labelKmeansCH
            // 
            this.labelKmeansCH.AutoSize = true;
            this.labelKmeansCH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansCH.Location = new System.Drawing.Point(485, 276);
            this.labelKmeansCH.Name = "labelKmeansCH";
            this.labelKmeansCH.Size = new System.Drawing.Size(171, 16);
            this.labelKmeansCH.TabIndex = 42;
            this.labelKmeansCH.Text = "Calinski-Harabaszov indeks:";
            this.labelKmeansCH.Visible = false;
            // 
            // labelKmeansDB
            // 
            this.labelKmeansDB.AutoSize = true;
            this.labelKmeansDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansDB.Location = new System.Drawing.Point(485, 301);
            this.labelKmeansDB.Name = "labelKmeansDB";
            this.labelKmeansDB.Size = new System.Drawing.Size(151, 16);
            this.labelKmeansDB.TabIndex = 43;
            this.labelKmeansDB.Text = "Davies-Bouldinov indeks:";
            this.labelKmeansDB.Visible = false;
            // 
            // labelKmeansppCH
            // 
            this.labelKmeansppCH.AutoSize = true;
            this.labelKmeansppCH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansppCH.Location = new System.Drawing.Point(1316, 276);
            this.labelKmeansppCH.Name = "labelKmeansppCH";
            this.labelKmeansppCH.Size = new System.Drawing.Size(171, 16);
            this.labelKmeansppCH.TabIndex = 45;
            this.labelKmeansppCH.Text = "Calinski-Harabaszov indeks:";
            this.labelKmeansppCH.Visible = false;
            // 
            // labelKmeansppDB
            // 
            this.labelKmeansppDB.AutoSize = true;
            this.labelKmeansppDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansppDB.Location = new System.Drawing.Point(1316, 301);
            this.labelKmeansppDB.Name = "labelKmeansppDB";
            this.labelKmeansppDB.Size = new System.Drawing.Size(151, 16);
            this.labelKmeansppDB.TabIndex = 44;
            this.labelKmeansppDB.Text = "Davies-Bouldinov indeks:";
            this.labelKmeansppDB.Visible = false;
            // 
            // labelKmedoidsCH
            // 
            this.labelKmedoidsCH.AutoSize = true;
            this.labelKmedoidsCH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsCH.Location = new System.Drawing.Point(485, 710);
            this.labelKmedoidsCH.Name = "labelKmedoidsCH";
            this.labelKmedoidsCH.Size = new System.Drawing.Size(171, 16);
            this.labelKmedoidsCH.TabIndex = 47;
            this.labelKmedoidsCH.Text = "Calinski-Harabaszov indeks:";
            this.labelKmedoidsCH.Visible = false;
            // 
            // labelKmedoidsDB
            // 
            this.labelKmedoidsDB.AutoSize = true;
            this.labelKmedoidsDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsDB.Location = new System.Drawing.Point(485, 736);
            this.labelKmedoidsDB.Name = "labelKmedoidsDB";
            this.labelKmedoidsDB.Size = new System.Drawing.Size(151, 16);
            this.labelKmedoidsDB.TabIndex = 46;
            this.labelKmedoidsDB.Text = "Davies-Bouldinov indeks:";
            this.labelKmedoidsDB.Visible = false;
            // 
            // labelChangeableCH
            // 
            this.labelChangeableCH.AutoSize = true;
            this.labelChangeableCH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableCH.Location = new System.Drawing.Point(1316, 710);
            this.labelChangeableCH.Name = "labelChangeableCH";
            this.labelChangeableCH.Size = new System.Drawing.Size(171, 16);
            this.labelChangeableCH.TabIndex = 49;
            this.labelChangeableCH.Text = "Calinski-Harabaszov indeks:";
            this.labelChangeableCH.Visible = false;
            // 
            // labelChangeableDB
            // 
            this.labelChangeableDB.AutoSize = true;
            this.labelChangeableDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableDB.Location = new System.Drawing.Point(1316, 736);
            this.labelChangeableDB.Name = "labelChangeableDB";
            this.labelChangeableDB.Size = new System.Drawing.Size(151, 16);
            this.labelChangeableDB.TabIndex = 48;
            this.labelChangeableDB.Text = "Davies-Bouldinov indeks:";
            this.labelChangeableDB.Visible = false;
            // 
            // labelFCMmCoeff
            // 
            this.labelFCMmCoeff.AutoSize = true;
            this.labelFCMmCoeff.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFCMmCoeff.Location = new System.Drawing.Point(840, 934);
            this.labelFCMmCoeff.Name = "labelFCMmCoeff";
            this.labelFCMmCoeff.Size = new System.Drawing.Size(161, 16);
            this.labelFCMmCoeff.TabIndex = 58;
            this.labelFCMmCoeff.Text = "Koeficijent neizrazitosti m:";
            this.labelFCMmCoeff.Visible = false;
            // 
            // textBoxFCMmCoeff
            // 
            this.textBoxFCMmCoeff.Location = new System.Drawing.Point(997, 933);
            this.textBoxFCMmCoeff.Name = "textBoxFCMmCoeff";
            this.textBoxFCMmCoeff.Size = new System.Drawing.Size(40, 20);
            this.textBoxFCMmCoeff.TabIndex = 59;
            this.textBoxFCMmCoeff.Text = "2";
            this.textBoxFCMmCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFCMmCoeff.Visible = false;
            // 
            // buttonExportKmeans
            // 
            this.buttonExportKmeans.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportKmeans.Location = new System.Drawing.Point(488, 361);
            this.buttonExportKmeans.Name = "buttonExportKmeans";
            this.buttonExportKmeans.Size = new System.Drawing.Size(113, 24);
            this.buttonExportKmeans.TabIndex = 60;
            this.buttonExportKmeans.Text = "Ispiši rezultate";
            this.buttonExportKmeans.UseVisualStyleBackColor = true;
            this.buttonExportKmeans.Visible = false;
            this.buttonExportKmeans.Click += new System.EventHandler(this.buttonExportKmeans_Click);
            // 
            // buttonExportKmeanspp
            // 
            this.buttonExportKmeanspp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportKmeanspp.Location = new System.Drawing.Point(1319, 361);
            this.buttonExportKmeanspp.Name = "buttonExportKmeanspp";
            this.buttonExportKmeanspp.Size = new System.Drawing.Size(113, 24);
            this.buttonExportKmeanspp.TabIndex = 61;
            this.buttonExportKmeanspp.Text = "Ispiši rezultate";
            this.buttonExportKmeanspp.UseVisualStyleBackColor = true;
            this.buttonExportKmeanspp.Visible = false;
            this.buttonExportKmeanspp.Click += new System.EventHandler(this.buttonExportKmeanspp_Click);
            // 
            // buttonExportKmedoids
            // 
            this.buttonExportKmedoids.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportKmedoids.Location = new System.Drawing.Point(488, 795);
            this.buttonExportKmedoids.Name = "buttonExportKmedoids";
            this.buttonExportKmedoids.Size = new System.Drawing.Size(113, 24);
            this.buttonExportKmedoids.TabIndex = 62;
            this.buttonExportKmedoids.Text = "Ispiši rezultate";
            this.buttonExportKmedoids.UseVisualStyleBackColor = true;
            this.buttonExportKmedoids.Visible = false;
            this.buttonExportKmedoids.Click += new System.EventHandler(this.buttonExportKmedoids_Click);
            // 
            // buttonExportChangeable
            // 
            this.buttonExportChangeable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportChangeable.Location = new System.Drawing.Point(1319, 795);
            this.buttonExportChangeable.Name = "buttonExportChangeable";
            this.buttonExportChangeable.Size = new System.Drawing.Size(113, 24);
            this.buttonExportChangeable.TabIndex = 63;
            this.buttonExportChangeable.Text = "Ispiši rezultate";
            this.buttonExportChangeable.UseVisualStyleBackColor = true;
            this.buttonExportChangeable.Visible = false;
            this.buttonExportChangeable.Click += new System.EventHandler(this.buttonExportChangeable_Click);
            // 
            // labelKmeansDimensionMsg
            // 
            this.labelKmeansDimensionMsg.AutoSize = true;
            this.labelKmeansDimensionMsg.BackColor = System.Drawing.Color.White;
            this.labelKmeansDimensionMsg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansDimensionMsg.Location = new System.Drawing.Point(30, 291);
            this.labelKmeansDimensionMsg.Name = "labelKmeansDimensionMsg";
            this.labelKmeansDimensionMsg.Size = new System.Drawing.Size(433, 16);
            this.labelKmeansDimensionMsg.TabIndex = 64;
            this.labelKmeansDimensionMsg.Text = "Vizualizacija rezultata nije moguća za podatke čija je dimenzija veća od 2";
            // 
            // labelKMeansppDimensionMsg
            // 
            this.labelKMeansppDimensionMsg.AutoSize = true;
            this.labelKMeansppDimensionMsg.BackColor = System.Drawing.Color.White;
            this.labelKMeansppDimensionMsg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKMeansppDimensionMsg.Location = new System.Drawing.Point(861, 291);
            this.labelKMeansppDimensionMsg.Name = "labelKMeansppDimensionMsg";
            this.labelKMeansppDimensionMsg.Size = new System.Drawing.Size(433, 16);
            this.labelKMeansppDimensionMsg.TabIndex = 65;
            this.labelKMeansppDimensionMsg.Text = "Vizualizacija rezultata nije moguća za podatke čija je dimenzija veća od 2";
            // 
            // labelKMedoidsDimensionMsg
            // 
            this.labelKMedoidsDimensionMsg.AutoSize = true;
            this.labelKMedoidsDimensionMsg.BackColor = System.Drawing.Color.White;
            this.labelKMedoidsDimensionMsg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKMedoidsDimensionMsg.Location = new System.Drawing.Point(30, 726);
            this.labelKMedoidsDimensionMsg.Name = "labelKMedoidsDimensionMsg";
            this.labelKMedoidsDimensionMsg.Size = new System.Drawing.Size(433, 16);
            this.labelKMedoidsDimensionMsg.TabIndex = 66;
            this.labelKMedoidsDimensionMsg.Text = "Vizualizacija rezultata nije moguća za podatke čija je dimenzija veća od 2";
            // 
            // labelChangeableDimensionMsg
            // 
            this.labelChangeableDimensionMsg.AutoSize = true;
            this.labelChangeableDimensionMsg.BackColor = System.Drawing.Color.White;
            this.labelChangeableDimensionMsg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableDimensionMsg.Location = new System.Drawing.Point(861, 726);
            this.labelChangeableDimensionMsg.Name = "labelChangeableDimensionMsg";
            this.labelChangeableDimensionMsg.Size = new System.Drawing.Size(433, 16);
            this.labelChangeableDimensionMsg.TabIndex = 67;
            this.labelChangeableDimensionMsg.Text = "Vizualizacija rezultata nije moguća za podatke čija je dimenzija veća od 2";
            // 
            // labelKmeansExecTime
            // 
            this.labelKmeansExecTime.AutoSize = true;
            this.labelKmeansExecTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansExecTime.Location = new System.Drawing.Point(485, 224);
            this.labelKmeansExecTime.Name = "labelKmeansExecTime";
            this.labelKmeansExecTime.Size = new System.Drawing.Size(113, 16);
            this.labelKmeansExecTime.TabIndex = 68;
            this.labelKmeansExecTime.Text = "Vrijeme izvođenja:";
            this.labelKmeansExecTime.Visible = false;
            // 
            // labelKmeansppExecTime
            // 
            this.labelKmeansppExecTime.AutoSize = true;
            this.labelKmeansppExecTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansppExecTime.Location = new System.Drawing.Point(1316, 224);
            this.labelKmeansppExecTime.Name = "labelKmeansppExecTime";
            this.labelKmeansppExecTime.Size = new System.Drawing.Size(113, 16);
            this.labelKmeansppExecTime.TabIndex = 70;
            this.labelKmeansppExecTime.Text = "Vrijeme izvođenja:";
            this.labelKmeansppExecTime.Visible = false;
            // 
            // labelKmedoidsExecTime
            // 
            this.labelKmedoidsExecTime.AutoSize = true;
            this.labelKmedoidsExecTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsExecTime.Location = new System.Drawing.Point(485, 657);
            this.labelKmedoidsExecTime.Name = "labelKmedoidsExecTime";
            this.labelKmedoidsExecTime.Size = new System.Drawing.Size(113, 16);
            this.labelKmedoidsExecTime.TabIndex = 72;
            this.labelKmedoidsExecTime.Text = "Vrijeme izvođenja:";
            this.labelKmedoidsExecTime.Visible = false;
            // 
            // labelChangeableExecTime
            // 
            this.labelChangeableExecTime.AutoSize = true;
            this.labelChangeableExecTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableExecTime.Location = new System.Drawing.Point(1316, 657);
            this.labelChangeableExecTime.Name = "labelChangeableExecTime";
            this.labelChangeableExecTime.Size = new System.Drawing.Size(113, 16);
            this.labelChangeableExecTime.TabIndex = 74;
            this.labelChangeableExecTime.Text = "Vrijeme izvođenja:";
            this.labelChangeableExecTime.Visible = false;
            // 
            // labelKmeansSilhouette
            // 
            this.labelKmeansSilhouette.AutoSize = true;
            this.labelKmeansSilhouette.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansSilhouette.Location = new System.Drawing.Point(485, 326);
            this.labelKmeansSilhouette.Name = "labelKmeansSilhouette";
            this.labelKmeansSilhouette.Size = new System.Drawing.Size(114, 16);
            this.labelKmeansSilhouette.TabIndex = 76;
            this.labelKmeansSilhouette.Text = "Koeficijent siluete:";
            this.labelKmeansSilhouette.Visible = false;
            // 
            // labelKmeansppSilhouette
            // 
            this.labelKmeansppSilhouette.AutoSize = true;
            this.labelKmeansppSilhouette.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmeansppSilhouette.Location = new System.Drawing.Point(1316, 326);
            this.labelKmeansppSilhouette.Name = "labelKmeansppSilhouette";
            this.labelKmeansppSilhouette.Size = new System.Drawing.Size(114, 16);
            this.labelKmeansppSilhouette.TabIndex = 78;
            this.labelKmeansppSilhouette.Text = "Koeficijent siluete:";
            this.labelKmeansppSilhouette.Visible = false;
            // 
            // labelKmedoidsSilhouette
            // 
            this.labelKmedoidsSilhouette.AutoSize = true;
            this.labelKmedoidsSilhouette.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsSilhouette.Location = new System.Drawing.Point(485, 761);
            this.labelKmedoidsSilhouette.Name = "labelKmedoidsSilhouette";
            this.labelKmedoidsSilhouette.Size = new System.Drawing.Size(114, 16);
            this.labelKmedoidsSilhouette.TabIndex = 80;
            this.labelKmedoidsSilhouette.Text = "Koeficijent siluete:";
            this.labelKmedoidsSilhouette.Visible = false;
            // 
            // labelChangeableSilhouette
            // 
            this.labelChangeableSilhouette.AutoSize = true;
            this.labelChangeableSilhouette.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableSilhouette.Location = new System.Drawing.Point(1316, 761);
            this.labelChangeableSilhouette.Name = "labelChangeableSilhouette";
            this.labelChangeableSilhouette.Size = new System.Drawing.Size(114, 16);
            this.labelChangeableSilhouette.TabIndex = 82;
            this.labelChangeableSilhouette.Text = "Koeficijent siluete:";
            this.labelChangeableSilhouette.Visible = false;
            // 
            // labelKmedoidsInit
            // 
            this.labelKmedoidsInit.AutoSize = true;
            this.labelKmedoidsInit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmedoidsInit.Location = new System.Drawing.Point(50, 934);
            this.labelKmedoidsInit.Name = "labelKmedoidsInit";
            this.labelKmedoidsInit.Size = new System.Drawing.Size(185, 16);
            this.labelKmedoidsInit.TabIndex = 84;
            this.labelKmedoidsInit.Text = "Metoda inicijalizacije medoida:";
            // 
            // radioButtonKmedoidsRandom
            // 
            this.radioButtonKmedoidsRandom.AutoSize = true;
            this.radioButtonKmedoidsRandom.Checked = true;
            this.radioButtonKmedoidsRandom.Location = new System.Drawing.Point(8, 12);
            this.radioButtonKmedoidsRandom.Name = "radioButtonKmedoidsRandom";
            this.radioButtonKmedoidsRandom.Size = new System.Drawing.Size(78, 17);
            this.radioButtonKmedoidsRandom.TabIndex = 85;
            this.radioButtonKmedoidsRandom.TabStop = true;
            this.radioButtonKmedoidsRandom.Text = "Nasumično";
            this.radioButtonKmedoidsRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonKmedoidsKmeanspp
            // 
            this.radioButtonKmedoidsKmeanspp.AutoSize = true;
            this.radioButtonKmedoidsKmeanspp.Location = new System.Drawing.Point(118, 12);
            this.radioButtonKmedoidsKmeanspp.Name = "radioButtonKmedoidsKmeanspp";
            this.radioButtonKmedoidsKmeanspp.Size = new System.Drawing.Size(77, 17);
            this.radioButtonKmedoidsKmeanspp.TabIndex = 86;
            this.radioButtonKmedoidsKmeanspp.Text = "k-means++";
            this.radioButtonKmedoidsKmeanspp.UseVisualStyleBackColor = true;
            // 
            // groupBoxKmedoidsInit
            // 
            this.groupBoxKmedoidsInit.Controls.Add(this.radioButtonKmedoidsRandom);
            this.groupBoxKmedoidsInit.Controls.Add(this.radioButtonKmedoidsKmeanspp);
            this.groupBoxKmedoidsInit.Location = new System.Drawing.Point(240, 922);
            this.groupBoxKmedoidsInit.Name = "groupBoxKmedoidsInit";
            this.groupBoxKmedoidsInit.Size = new System.Drawing.Size(201, 38);
            this.groupBoxKmedoidsInit.TabIndex = 87;
            this.groupBoxKmedoidsInit.TabStop = false;
            // 
            // buttonRunAll
            // 
            this.buttonRunAll.Enabled = false;
            this.buttonRunAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunAll.Location = new System.Drawing.Point(1319, 32);
            this.buttonRunAll.Name = "buttonRunAll";
            this.buttonRunAll.Size = new System.Drawing.Size(90, 34);
            this.buttonRunAll.TabIndex = 88;
            this.buttonRunAll.Text = "Pokreni sve";
            this.buttonRunAll.UseVisualStyleBackColor = true;
            this.buttonRunAll.Click += new System.EventHandler(this.buttonRunAll_Click);
            // 
            // labelDataFormatInfo
            // 
            this.labelDataFormatInfo.AutoSize = true;
            this.labelDataFormatInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFormatInfo.Location = new System.Drawing.Point(130, 63);
            this.labelDataFormatInfo.Name = "labelDataFormatInfo";
            this.labelDataFormatInfo.Size = new System.Drawing.Size(180, 16);
            this.labelDataFormatInfo.TabIndex = 89;
            this.labelDataFormatInfo.Text = "Podaci moraju biti odvojeni zarezima";
            // 
            // groupBoxDistance
            // 
            this.groupBoxDistance.Controls.Add(this.radioButtonEuclidean);
            this.groupBoxDistance.Controls.Add(this.radioButtonManhattan);
            this.groupBoxDistance.Location = new System.Drawing.Point(956, 28);
            this.groupBoxDistance.Name = "groupBoxDistance";
            this.groupBoxDistance.Size = new System.Drawing.Size(201, 38);
            this.groupBoxDistance.TabIndex = 91;
            this.groupBoxDistance.TabStop = false;
            // 
            // radioButtonEuclidean
            // 
            this.radioButtonEuclidean.AutoSize = true;
            this.radioButtonEuclidean.Checked = true;
            this.radioButtonEuclidean.Location = new System.Drawing.Point(8, 12);
            this.radioButtonEuclidean.Name = "radioButtonEuclidean";
            this.radioButtonEuclidean.Size = new System.Drawing.Size(71, 17);
            this.radioButtonEuclidean.TabIndex = 85;
            this.radioButtonEuclidean.TabStop = true;
            this.radioButtonEuclidean.Text = "Euklidska";
            this.radioButtonEuclidean.UseVisualStyleBackColor = true;
            // 
            // radioButtonManhattan
            // 
            this.radioButtonManhattan.AutoSize = true;
            this.radioButtonManhattan.Location = new System.Drawing.Point(118, 12);
            this.radioButtonManhattan.Name = "radioButtonManhattan";
            this.radioButtonManhattan.Size = new System.Drawing.Size(76, 17);
            this.radioButtonManhattan.TabIndex = 86;
            this.radioButtonManhattan.Text = "Manhattan";
            this.radioButtonManhattan.UseVisualStyleBackColor = true;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(840, 41);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(110, 16);
            this.labelDistance.TabIndex = 90;
            this.labelDistance.Text = "Mjera udaljenosti:";
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(1036, 530);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(121, 26);
            this.comboBoxAlgorithm.TabIndex = 92;
            this.comboBoxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithm_SelectedIndexChanged);
            // 
            // textBoxFCMEpsilon
            // 
            this.textBoxFCMEpsilon.Location = new System.Drawing.Point(1249, 934);
            this.textBoxFCMEpsilon.Name = "textBoxFCMEpsilon";
            this.textBoxFCMEpsilon.Size = new System.Drawing.Size(61, 20);
            this.textBoxFCMEpsilon.TabIndex = 94;
            this.textBoxFCMEpsilon.Text = "1e-5";
            this.textBoxFCMEpsilon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFCMEpsilon.Visible = false;
            // 
            // labelFCMEpsilon
            // 
            this.labelFCMEpsilon.AutoSize = true;
            this.labelFCMEpsilon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFCMEpsilon.Location = new System.Drawing.Point(1117, 935);
            this.labelFCMEpsilon.Name = "labelFCMEpsilon";
            this.labelFCMEpsilon.Size = new System.Drawing.Size(137, 16);
            this.labelFCMEpsilon.TabIndex = 93;
            this.labelFCMEpsilon.Text = "Kriterij zaustavljanja ɛ:";
            this.labelFCMEpsilon.Visible = false;
            // 
            // groupBoxChangeableInit
            // 
            this.groupBoxChangeableInit.Controls.Add(this.radioButtonChangeableRandom);
            this.groupBoxChangeableInit.Controls.Add(this.radioButtonChangeableKmeanspp);
            this.groupBoxChangeableInit.Location = new System.Drawing.Point(1069, 923);
            this.groupBoxChangeableInit.Name = "groupBoxChangeableInit";
            this.groupBoxChangeableInit.Size = new System.Drawing.Size(201, 38);
            this.groupBoxChangeableInit.TabIndex = 96;
            this.groupBoxChangeableInit.TabStop = false;
            // 
            // radioButtonChangeableRandom
            // 
            this.radioButtonChangeableRandom.AutoSize = true;
            this.radioButtonChangeableRandom.Checked = true;
            this.radioButtonChangeableRandom.Location = new System.Drawing.Point(8, 12);
            this.radioButtonChangeableRandom.Name = "radioButtonChangeableRandom";
            this.radioButtonChangeableRandom.Size = new System.Drawing.Size(78, 17);
            this.radioButtonChangeableRandom.TabIndex = 85;
            this.radioButtonChangeableRandom.TabStop = true;
            this.radioButtonChangeableRandom.Text = "Nasumično";
            this.radioButtonChangeableRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonChangeableKmeanspp
            // 
            this.radioButtonChangeableKmeanspp.AutoSize = true;
            this.radioButtonChangeableKmeanspp.Location = new System.Drawing.Point(118, 12);
            this.radioButtonChangeableKmeanspp.Name = "radioButtonChangeableKmeanspp";
            this.radioButtonChangeableKmeanspp.Size = new System.Drawing.Size(77, 17);
            this.radioButtonChangeableKmeanspp.TabIndex = 86;
            this.radioButtonChangeableKmeanspp.Text = "k-means++";
            this.radioButtonChangeableKmeanspp.UseVisualStyleBackColor = true;
            // 
            // labelChangeableInit
            // 
            this.labelChangeableInit.AutoSize = true;
            this.labelChangeableInit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeableInit.Location = new System.Drawing.Point(879, 935);
            this.labelChangeableInit.Name = "labelChangeableInit";
            this.labelChangeableInit.Size = new System.Drawing.Size(185, 16);
            this.labelChangeableInit.TabIndex = 95;
            this.labelChangeableInit.Text = "Metoda inicijalizacije medoida:";
            this.labelChangeableInit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 971);
            this.Controls.Add(this.groupBoxChangeableInit);
            this.Controls.Add(this.labelChangeableInit);
            this.Controls.Add(this.textBoxFCMEpsilon);
            this.Controls.Add(this.labelFCMEpsilon);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Controls.Add(this.groupBoxDistance);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.labelDataFormatInfo);
            this.Controls.Add(this.buttonRunAll);
            this.Controls.Add(this.groupBoxKmedoidsInit);
            this.Controls.Add(this.labelKmedoidsInit);
            this.Controls.Add(this.labelChangeableSilhouette);
            this.Controls.Add(this.labelKmedoidsSilhouette);
            this.Controls.Add(this.labelKmeansppSilhouette);
            this.Controls.Add(this.labelKmeansSilhouette);
            this.Controls.Add(this.labelChangeableExecTime);
            this.Controls.Add(this.labelKmedoidsExecTime);
            this.Controls.Add(this.labelKmeansppExecTime);
            this.Controls.Add(this.labelKmeansExecTime);
            this.Controls.Add(this.labelChangeableDimensionMsg);
            this.Controls.Add(this.labelKMedoidsDimensionMsg);
            this.Controls.Add(this.labelKMeansppDimensionMsg);
            this.Controls.Add(this.labelKmeansDimensionMsg);
            this.Controls.Add(this.buttonExportChangeable);
            this.Controls.Add(this.buttonExportKmedoids);
            this.Controls.Add(this.buttonExportKmeanspp);
            this.Controls.Add(this.buttonExportKmeans);
            this.Controls.Add(this.textBoxFCMmCoeff);
            this.Controls.Add(this.labelFCMmCoeff);
            this.Controls.Add(this.labelChangeableCH);
            this.Controls.Add(this.labelChangeableDB);
            this.Controls.Add(this.labelKmedoidsCH);
            this.Controls.Add(this.labelKmedoidsDB);
            this.Controls.Add(this.labelKmeansppCH);
            this.Controls.Add(this.labelKmeansppDB);
            this.Controls.Add(this.labelKmeansDB);
            this.Controls.Add(this.labelKmeansCH);
            this.Controls.Add(this.textBoxChangeableMaxIter);
            this.Controls.Add(this.labelChangeableMaxIter);
            this.Controls.Add(this.textBoxKmedoidsMaxIter);
            this.Controls.Add(this.labelKmedoidsMaxIter);
            this.Controls.Add(this.textBoxKmeansppMaxIter);
            this.Controls.Add(this.labelKmeansppMaxIter);
            this.Controls.Add(this.textBoxKmeansMaxIter);
            this.Controls.Add(this.labelKmeansMaxIter);
            this.Controls.Add(this.numericUpDownClusterCount);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.buttonZoomChangeable);
            this.Controls.Add(this.buttonZoomKmedoids);
            this.Controls.Add(this.buttonZoomKmeanspp);
            this.Controls.Add(this.buttonZoomKmeans);
            this.Controls.Add(this.checkBoxChangeableCentroids);
            this.Controls.Add(this.checkBoxKmedoidsMedoids);
            this.Controls.Add(this.checkBoxKmeansppCentroids);
            this.Controls.Add(this.checkBoxKmeansCentroids);
            this.Controls.Add(this.buttonRunChangeable);
            this.Controls.Add(this.buttonRunKmedoids);
            this.Controls.Add(this.buttonRunKmeanspp);
            this.Controls.Add(this.buttonRunKmeans);
            this.Controls.Add(this.labelChangeableIterCount);
            this.Controls.Add(this.chartChangeable);
            this.Controls.Add(this.labelKmedoidsTitle);
            this.Controls.Add(this.labelKmedoidsIterCount);
            this.Controls.Add(this.chartKmedoids);
            this.Controls.Add(this.labelClusterCount);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.labelKmeansppTitle);
            this.Controls.Add(this.labelKmeansTitle);
            this.Controls.Add(this.labelKmeansppIterCount);
            this.Controls.Add(this.chartKmeanspp);
            this.Controls.Add(this.labelKmeansIterCount);
            this.Controls.Add(this.chartKmeans);
            this.Name = "Form1";
            this.Text = "Usporedba metoda za razvrstavanje oko središnje točke";
            ((System.ComponentModel.ISupportInitialize)(this.chartKmeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKmeanspp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKmedoids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChangeable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClusterCount)).EndInit();
            this.groupBoxKmedoidsInit.ResumeLayout(false);
            this.groupBoxKmedoidsInit.PerformLayout();
            this.groupBoxDistance.ResumeLayout(false);
            this.groupBoxDistance.PerformLayout();
            this.groupBoxChangeableInit.ResumeLayout(false);
            this.groupBoxChangeableInit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartKmeans;
        private System.Windows.Forms.Label labelKmeansIterCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKmeanspp;
        private System.Windows.Forms.Label labelKmeansppIterCount;
        private System.Windows.Forms.Label labelKmeansTitle;
        private System.Windows.Forms.Label labelKmeansppTitle;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogChooseFile;
        private System.Windows.Forms.Label labelClusterCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKmedoids;
        private System.Windows.Forms.Label labelKmedoidsIterCount;
        private System.Windows.Forms.Label labelKmedoidsTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChangeable;
        private System.Windows.Forms.Label labelChangeableIterCount;
        private System.Windows.Forms.Button buttonRunKmeans;
        private System.Windows.Forms.Button buttonRunKmeanspp;
        private System.Windows.Forms.Button buttonRunKmedoids;
        private System.Windows.Forms.Button buttonRunChangeable;
        private System.Windows.Forms.CheckBox checkBoxKmeansCentroids;
        private System.Windows.Forms.CheckBox checkBoxKmeansppCentroids;
        private System.Windows.Forms.CheckBox checkBoxKmedoidsMedoids;
        private System.Windows.Forms.CheckBox checkBoxChangeableCentroids;
        private System.Windows.Forms.Button buttonZoomKmeans;
        private System.Windows.Forms.Button buttonZoomKmeanspp;
        private System.Windows.Forms.Button buttonZoomKmedoids;
        private System.Windows.Forms.Button buttonZoomChangeable;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.NumericUpDown numericUpDownClusterCount;
        private System.Windows.Forms.Label labelKmeansMaxIter;
        private System.Windows.Forms.TextBox textBoxKmeansMaxIter;
        private System.Windows.Forms.TextBox textBoxKmeansppMaxIter;
        private System.Windows.Forms.Label labelKmeansppMaxIter;
        private System.Windows.Forms.TextBox textBoxKmedoidsMaxIter;
        private System.Windows.Forms.Label labelKmedoidsMaxIter;
        private System.Windows.Forms.TextBox textBoxChangeableMaxIter;
        private System.Windows.Forms.Label labelChangeableMaxIter;
        private System.Windows.Forms.Label labelKmeansCH;
        private System.Windows.Forms.Label labelKmeansDB;
        private System.Windows.Forms.Label labelKmeansppCH;
        private System.Windows.Forms.Label labelKmeansppDB;
        private System.Windows.Forms.Label labelKmedoidsCH;
        private System.Windows.Forms.Label labelKmedoidsDB;
        private System.Windows.Forms.Label labelChangeableCH;
        private System.Windows.Forms.Label labelChangeableDB;
        private System.Windows.Forms.Label labelFCMmCoeff;
        private System.Windows.Forms.TextBox textBoxFCMmCoeff;
        private System.Windows.Forms.Button buttonExportKmeans;
        private System.Windows.Forms.Button buttonExportKmeanspp;
        private System.Windows.Forms.Button buttonExportKmedoids;
        private System.Windows.Forms.Button buttonExportChangeable;
        private System.Windows.Forms.Label labelKmeansDimensionMsg;
        private System.Windows.Forms.Label labelKMeansppDimensionMsg;
        private System.Windows.Forms.Label labelKMedoidsDimensionMsg;
        private System.Windows.Forms.Label labelChangeableDimensionMsg;
        private System.Windows.Forms.Label labelKmeansExecTime;
        private System.Windows.Forms.Label labelKmeansppExecTime;
        private System.Windows.Forms.Label labelKmedoidsExecTime;
        private System.Windows.Forms.Label labelChangeableExecTime;
        private System.Windows.Forms.Label labelKmeansSilhouette;
        private System.Windows.Forms.Label labelKmeansppSilhouette;
        private System.Windows.Forms.Label labelKmedoidsSilhouette;
        private System.Windows.Forms.Label labelChangeableSilhouette;
        private System.Windows.Forms.Label labelKmedoidsInit;
        private System.Windows.Forms.RadioButton radioButtonKmedoidsRandom;
        private System.Windows.Forms.RadioButton radioButtonKmedoidsKmeanspp;
        private System.Windows.Forms.GroupBox groupBoxKmedoidsInit;
        private System.Windows.Forms.Button buttonRunAll;
        private System.Windows.Forms.Label labelDataFormatInfo;
        private System.Windows.Forms.GroupBox groupBoxDistance;
        private System.Windows.Forms.RadioButton radioButtonEuclidean;
        private System.Windows.Forms.RadioButton radioButtonManhattan;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.TextBox textBoxFCMEpsilon;
        private System.Windows.Forms.Label labelFCMEpsilon;
        private System.Windows.Forms.GroupBox groupBoxChangeableInit;
        private System.Windows.Forms.RadioButton radioButtonChangeableRandom;
        private System.Windows.Forms.RadioButton radioButtonChangeableKmeanspp;
        private System.Windows.Forms.Label labelChangeableInit;
    }
}

