namespace APO
{
    partial class APO
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEqualizationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posteriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ąsiedztwaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logiczneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFiltrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coherentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeletonizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watershedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.lab3ToolStripMenuItem,
            this.lab4ToolStripMenuItem,
            this.lab5ToolStripMenuItem,
            this.egzToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitToolStripMenuItem,
            this.duplicateToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.bitToolStripMenuItem.Text = "8 bit";
            this.bitToolStripMenuItem.Click += new System.EventHandler(this.bitToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.duplicateToolStripMenuItem.Text = "duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tresholdToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.uOPToolStripMenuItem,
            this.negacjaToolStripMenuItem,
            this.posteriseToolStripMenuItem,
            this.stretchImageToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // tresholdToolStripMenuItem
            // 
            this.tresholdToolStripMenuItem.Name = "tresholdToolStripMenuItem";
            this.tresholdToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.tresholdToolStripMenuItem.Text = "Treshold";
            this.tresholdToolStripMenuItem.Click += new System.EventHandler(this.tresholdToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramEqualizationToolStripMenuItem1});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // histogramEqualizationToolStripMenuItem1
            // 
            this.histogramEqualizationToolStripMenuItem1.Name = "histogramEqualizationToolStripMenuItem1";
            this.histogramEqualizationToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.histogramEqualizationToolStripMenuItem1.Text = "HistogramEqualization";
            this.histogramEqualizationToolStripMenuItem1.Click += new System.EventHandler(this.histogramEqualizationToolStripMenuItem1_Click);
            // 
            // uOPToolStripMenuItem
            // 
            this.uOPToolStripMenuItem.Name = "uOPToolStripMenuItem";
            this.uOPToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.uOPToolStripMenuItem.Text = "UOP";
            this.uOPToolStripMenuItem.Click += new System.EventHandler(this.uOPToolStripMenuItem_Click);
            // 
            // negacjaToolStripMenuItem
            // 
            this.negacjaToolStripMenuItem.Name = "negacjaToolStripMenuItem";
            this.negacjaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.negacjaToolStripMenuItem.Text = "Negative";
            this.negacjaToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // posteriseToolStripMenuItem
            // 
            this.posteriseToolStripMenuItem.Name = "posteriseToolStripMenuItem";
            this.posteriseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.posteriseToolStripMenuItem.Text = "Posterise";
            this.posteriseToolStripMenuItem.Click += new System.EventHandler(this.posteriseToolStripMenuItem_Click);
            // 
            // stretchImageToolStripMenuItem
            // 
            this.stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            this.stretchImageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.stretchImageToolStripMenuItem.Text = "Stretch Image";
            this.stretchImageToolStripMenuItem.Click += new System.EventHandler(this.stretchImageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lab3ToolStripMenuItem
            // 
            this.lab3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ąsiedztwaToolStripMenuItem,
            this.logiczneToolStripMenuItem,
            this.medianFiltrationToolStripMenuItem,
            this.aDDToolStripMenuItem,
            this.minusToolStripMenuItem,
            this.edgeToolStripMenuItem});
            this.lab3ToolStripMenuItem.Name = "lab3ToolStripMenuItem";
            this.lab3ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lab3ToolStripMenuItem.Text = "Lab 3";
            // 
            // ąsiedztwaToolStripMenuItem
            // 
            this.ąsiedztwaToolStripMenuItem.Name = "ąsiedztwaToolStripMenuItem";
            this.ąsiedztwaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ąsiedztwaToolStripMenuItem.Text = "Operacje sasiedztwa";
            this.ąsiedztwaToolStripMenuItem.Click += new System.EventHandler(this.ąsiedztwaToolStripMenuItem_Click);
            // 
            // logiczneToolStripMenuItem
            // 
            this.logiczneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNDToolStripMenuItem,
            this.oRToolStripMenuItem,
            this.xORToolStripMenuItem});
            this.logiczneToolStripMenuItem.Name = "logiczneToolStripMenuItem";
            this.logiczneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logiczneToolStripMenuItem.Text = "Logic";
            // 
            // aNDToolStripMenuItem
            // 
            this.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            this.aNDToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.aNDToolStripMenuItem.Text = "AND";
            this.aNDToolStripMenuItem.Click += new System.EventHandler(this.aNDToolStripMenuItem_Click);
            // 
            // oRToolStripMenuItem
            // 
            this.oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            this.oRToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.oRToolStripMenuItem.Text = "OR";
            this.oRToolStripMenuItem.Click += new System.EventHandler(this.oRToolStripMenuItem_Click);
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.xORToolStripMenuItem.Text = "XOR";
            this.xORToolStripMenuItem.Click += new System.EventHandler(this.xORToolStripMenuItem_Click);
            // 
            // medianFiltrationToolStripMenuItem
            // 
            this.medianFiltrationToolStripMenuItem.Name = "medianFiltrationToolStripMenuItem";
            this.medianFiltrationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianFiltrationToolStripMenuItem.Text = "Median filtration";
            this.medianFiltrationToolStripMenuItem.Click += new System.EventHandler(this.medianFiltrationToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDDToolStripMenuItem.Text = "Add";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // minusToolStripMenuItem
            // 
            this.minusToolStripMenuItem.Name = "minusToolStripMenuItem";
            this.minusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minusToolStripMenuItem.Text = "Minus";
            this.minusToolStripMenuItem.Click += new System.EventHandler(this.minusToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem,
            this.cannyToolStripMenuItem});
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edgeToolStripMenuItem.Text = "Edge";
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // lab4ToolStripMenuItem
            // 
            this.lab4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.skeletonizationToolStripMenuItem});
            this.lab4ToolStripMenuItem.Name = "lab4ToolStripMenuItem";
            this.lab4ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lab4ToolStripMenuItem.Text = "Lab4";
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coherentToolStripMenuItem,
            this.connectedToolStripMenuItem});
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            // 
            // coherentToolStripMenuItem
            // 
            this.coherentToolStripMenuItem.Name = "coherentToolStripMenuItem";
            this.coherentToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.coherentToolStripMenuItem.Text = "4-connected";
            this.coherentToolStripMenuItem.Click += new System.EventHandler(this.Erosion4connectedToolStripMenuItem_Click);
            // 
            // connectedToolStripMenuItem
            // 
            this.connectedToolStripMenuItem.Name = "connectedToolStripMenuItem";
            this.connectedToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.connectedToolStripMenuItem.Text = "8-connected";
            this.connectedToolStripMenuItem.Click += new System.EventHandler(this.Erosion8connectedToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedToolStripMenuItem1,
            this.connectedToolStripMenuItem2});
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            // 
            // connectedToolStripMenuItem1
            // 
            this.connectedToolStripMenuItem1.Name = "connectedToolStripMenuItem1";
            this.connectedToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.connectedToolStripMenuItem1.Text = "4-connected";
            this.connectedToolStripMenuItem1.Click += new System.EventHandler(this.Dilation4connectedToolStripMenuItem1_Click);
            // 
            // connectedToolStripMenuItem2
            // 
            this.connectedToolStripMenuItem2.Name = "connectedToolStripMenuItem2";
            this.connectedToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.connectedToolStripMenuItem2.Text = "8-connected";
            this.connectedToolStripMenuItem2.Click += new System.EventHandler(this.Dilation8connectedToolStripMenuItem2_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedToolStripMenuItem3,
            this.connectedToolStripMenuItem4});
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            // 
            // connectedToolStripMenuItem3
            // 
            this.connectedToolStripMenuItem3.Name = "connectedToolStripMenuItem3";
            this.connectedToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
            this.connectedToolStripMenuItem3.Text = "4-connected";
            this.connectedToolStripMenuItem3.Click += new System.EventHandler(this.Opening4connectedToolStripMenuItem3_Click);
            // 
            // connectedToolStripMenuItem4
            // 
            this.connectedToolStripMenuItem4.Name = "connectedToolStripMenuItem4";
            this.connectedToolStripMenuItem4.Size = new System.Drawing.Size(141, 22);
            this.connectedToolStripMenuItem4.Text = "8-connected";
            this.connectedToolStripMenuItem4.Click += new System.EventHandler(this.Opening8connectedToolStripMenuItem4_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedToolStripMenuItem5,
            this.connectedToolStripMenuItem6});
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            // 
            // connectedToolStripMenuItem5
            // 
            this.connectedToolStripMenuItem5.Name = "connectedToolStripMenuItem5";
            this.connectedToolStripMenuItem5.Size = new System.Drawing.Size(141, 22);
            this.connectedToolStripMenuItem5.Text = "4-connected";
            this.connectedToolStripMenuItem5.Click += new System.EventHandler(this.Closing4connectedToolStripMenuItem5_Click);
            // 
            // connectedToolStripMenuItem6
            // 
            this.connectedToolStripMenuItem6.Name = "connectedToolStripMenuItem6";
            this.connectedToolStripMenuItem6.Size = new System.Drawing.Size(141, 22);
            this.connectedToolStripMenuItem6.Text = "8-connected";
            this.connectedToolStripMenuItem6.Click += new System.EventHandler(this.Closing8connectedToolStripMenuItem6_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // skeletonizationToolStripMenuItem
            // 
            this.skeletonizationToolStripMenuItem.Name = "skeletonizationToolStripMenuItem";
            this.skeletonizationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.skeletonizationToolStripMenuItem.Text = "Skeletonization";
            this.skeletonizationToolStripMenuItem.Click += new System.EventHandler(this.skeletonizationToolStripMenuItem_Click);
            // 
            // lab5ToolStripMenuItem
            // 
            this.lab5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segmentationToolStripMenuItem,
            this.watershedToolStripMenuItem});
            this.lab5ToolStripMenuItem.Name = "lab5ToolStripMenuItem";
            this.lab5ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lab5ToolStripMenuItem.Text = "Lab5";
            // 
            // segmentationToolStripMenuItem
            // 
            this.segmentationToolStripMenuItem.Name = "segmentationToolStripMenuItem";
            this.segmentationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.segmentationToolStripMenuItem.Text = "Segmentation";
            this.segmentationToolStripMenuItem.Click += new System.EventHandler(this.segmentationToolStripMenuItem_Click);
            // 
            // watershedToolStripMenuItem
            // 
            this.watershedToolStripMenuItem.Name = "watershedToolStripMenuItem";
            this.watershedToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.watershedToolStripMenuItem.Text = "Watershed";
            this.watershedToolStripMenuItem.Click += new System.EventHandler(this.watershedToolStripMenuItem_Click);
            // 
            // egzToolStripMenuItem
            // 
            this.egzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem1,
            this.dilationToolStripMenuItem1});
            this.egzToolStripMenuItem.Name = "egzToolStripMenuItem";
            this.egzToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.egzToolStripMenuItem.Text = "Egz";
            this.egzToolStripMenuItem.Click += new System.EventHandler(this.egzToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem1
            // 
            this.erosionToolStripMenuItem1.Name = "erosionToolStripMenuItem1";
            this.erosionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.erosionToolStripMenuItem1.Text = "Erosion";
            this.erosionToolStripMenuItem1.Click += new System.EventHandler(this.erosionToolStripMenuItem1_Click);
            // 
            // dilationToolStripMenuItem1
            // 
            this.dilationToolStripMenuItem1.Name = "dilationToolStripMenuItem1";
            this.dilationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dilationToolStripMenuItem1.Text = "Dilation";
            this.dilationToolStripMenuItem1.Click += new System.EventHandler(this.dilationToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // APO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "APO";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEqualizationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posteriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ąsiedztwaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logiczneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFiltrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coherentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeletonizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watershedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem1;
    }
}

