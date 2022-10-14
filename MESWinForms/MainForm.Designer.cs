namespace MESWinForms
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCenter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCenterBottom = new System.Windows.Forms.Panel();
            this.tlpCenterBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lblSysMgr = new System.Windows.Forms.Label();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.pbCenterCenter = new System.Windows.Forms.PictureBox();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftBottom = new System.Windows.Forms.Panel();
            this.tlpLeftBottom = new System.Windows.Forms.TableLayoutPanel();
            this.fpFailedAnalysis = new ScottPlot.FormsPlot();
            this.fpFailedCase = new ScottPlot.FormsPlot();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.tlpLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleSysInfo = new System.Windows.Forms.Label();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightCenter = new System.Windows.Forms.Panel();
            this.tlpRightCenter = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleFPY = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.tlpRightTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleCalib = new System.Windows.Forms.Label();
            this.fpCalib = new ScottPlot.FormsPlot();
            this.pnlRightBottom = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlpRightBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lvRightBottom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpMain.SuspendLayout();
            this.tlpCenter.SuspendLayout();
            this.pnlCenterBottom.SuspendLayout();
            this.tlpCenterBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenterCenter)).BeginInit();
            this.tlpLeft.SuspendLayout();
            this.pnlLeftBottom.SuspendLayout();
            this.tlpLeftBottom.SuspendLayout();
            this.pnlLeftTop.SuspendLayout();
            this.tlpLeftTop.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.pnlRightCenter.SuspendLayout();
            this.tlpRightCenter.SuspendLayout();
            this.tlpRightTop.SuspendLayout();
            this.pnlRightBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpRightBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackgroundImage = global::MESWinForms.Properties.Resources.bg;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.94737F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.66029F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45215F));
            this.tlpMain.Controls.Add(this.tlpCenter, 1, 1);
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 1);
            this.tlpMain.Controls.Add(this.tlpRight, 2, 1);
            this.tlpMain.Controls.Add(this.pbLogo, 2, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69861F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.30139F));
            this.tlpMain.Size = new System.Drawing.Size(1995, 1384);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpCenter
            // 
            this.tlpCenter.BackgroundImage = global::MESWinForms.Properties.Resources.bg;
            this.tlpCenter.ColumnCount = 1;
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenter.Controls.Add(this.pnlCenterBottom, 0, 2);
            this.tlpCenter.Controls.Add(this.pbCamera, 0, 0);
            this.tlpCenter.Controls.Add(this.pbCenterCenter, 0, 1);
            this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenter.Location = new System.Drawing.Point(580, 164);
            this.tlpCenter.Name = "tlpCenter";
            this.tlpCenter.RowCount = 3;
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenter.Size = new System.Drawing.Size(864, 1217);
            this.tlpCenter.TabIndex = 0;
            // 
            // pnlCenterBottom
            // 
            this.pnlCenterBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlCenterBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCenterBottom.Controls.Add(this.tlpCenterBottom);
            this.pnlCenterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterBottom.Location = new System.Drawing.Point(3, 915);
            this.pnlCenterBottom.Name = "pnlCenterBottom";
            this.pnlCenterBottom.Size = new System.Drawing.Size(858, 299);
            this.pnlCenterBottom.TabIndex = 7;
            // 
            // tlpCenterBottom
            // 
            this.tlpCenterBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpCenterBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpCenterBottom.ColumnCount = 1;
            this.tlpCenterBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenterBottom.Controls.Add(this.lblSysMgr, 0, 0);
            this.tlpCenterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenterBottom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlpCenterBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpCenterBottom.Name = "tlpCenterBottom";
            this.tlpCenterBottom.RowCount = 2;
            this.tlpCenterBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCenterBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpCenterBottom.Size = new System.Drawing.Size(858, 299);
            this.tlpCenterBottom.TabIndex = 8;
            // 
            // lblSysMgr
            // 
            this.lblSysMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSysMgr.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblSysMgr.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSysMgr.Location = new System.Drawing.Point(3, 0);
            this.lblSysMgr.Name = "lblSysMgr";
            this.lblSysMgr.Size = new System.Drawing.Size(852, 59);
            this.lblSysMgr.TabIndex = 0;
            this.lblSysMgr.Text = "系统管理";
            this.lblSysMgr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbCamera
            // 
            this.pbCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCamera.Location = new System.Drawing.Point(3, 3);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(858, 602);
            this.pbCamera.TabIndex = 0;
            this.pbCamera.TabStop = false;
            // 
            // pbCenterCenter
            // 
            this.pbCenterCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCenterCenter.Image = global::MESWinForms.Properties.Resources.prods;
            this.pbCenterCenter.Location = new System.Drawing.Point(3, 611);
            this.pbCenterCenter.Name = "pbCenterCenter";
            this.pbCenterCenter.Size = new System.Drawing.Size(858, 298);
            this.pbCenterCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCenterCenter.TabIndex = 2;
            this.pbCenterCenter.TabStop = false;
            // 
            // tlpLeft
            // 
            this.tlpLeft.BackgroundImage = global::MESWinForms.Properties.Resources.bg;
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Controls.Add(this.pnlLeftBottom, 0, 1);
            this.tlpLeft.Controls.Add(this.pnlLeftTop, 0, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 164);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Size = new System.Drawing.Size(571, 1217);
            this.tlpLeft.TabIndex = 1;
            // 
            // pnlLeftBottom
            // 
            this.pnlLeftBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlLeftBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeftBottom.Controls.Add(this.tlpLeftBottom);
            this.pnlLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftBottom.Location = new System.Drawing.Point(3, 611);
            this.pnlLeftBottom.Name = "pnlLeftBottom";
            this.pnlLeftBottom.Size = new System.Drawing.Size(565, 603);
            this.pnlLeftBottom.TabIndex = 8;
            // 
            // tlpLeftBottom
            // 
            this.tlpLeftBottom.ColumnCount = 1;
            this.tlpLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftBottom.Controls.Add(this.fpFailedAnalysis, 0, 0);
            this.tlpLeftBottom.Controls.Add(this.fpFailedCase, 0, 1);
            this.tlpLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpLeftBottom.Name = "tlpLeftBottom";
            this.tlpLeftBottom.RowCount = 2;
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftBottom.Size = new System.Drawing.Size(565, 603);
            this.tlpLeftBottom.TabIndex = 0;
            // 
            // fpFailedAnalysis
            // 
            this.fpFailedAnalysis.Location = new System.Drawing.Point(7, 5);
            this.fpFailedAnalysis.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.fpFailedAnalysis.Name = "fpFailedAnalysis";
            this.fpFailedAnalysis.Size = new System.Drawing.Size(551, 291);
            this.fpFailedAnalysis.TabIndex = 0;
            // 
            // fpFailedCase
            // 
            this.fpFailedCase.Location = new System.Drawing.Point(7, 306);
            this.fpFailedCase.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.fpFailedCase.Name = "fpFailedCase";
            this.fpFailedCase.Size = new System.Drawing.Size(551, 292);
            this.fpFailedCase.TabIndex = 1;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlLeftTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeftTop.Controls.Add(this.tlpLeftTop);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftTop.Location = new System.Drawing.Point(3, 3);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(565, 602);
            this.pnlLeftTop.TabIndex = 7;
            // 
            // tlpLeftTop
            // 
            this.tlpLeftTop.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpLeftTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpLeftTop.ColumnCount = 1;
            this.tlpLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftTop.Controls.Add(this.lblTitleSysInfo, 0, 0);
            this.tlpLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftTop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlpLeftTop.Location = new System.Drawing.Point(0, 0);
            this.tlpLeftTop.Name = "tlpLeftTop";
            this.tlpLeftTop.RowCount = 2;
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpLeftTop.Size = new System.Drawing.Size(565, 602);
            this.tlpLeftTop.TabIndex = 9;
            // 
            // lblTitleSysInfo
            // 
            this.lblTitleSysInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleSysInfo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTitleSysInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitleSysInfo.Location = new System.Drawing.Point(3, 0);
            this.lblTitleSysInfo.Name = "lblTitleSysInfo";
            this.lblTitleSysInfo.Size = new System.Drawing.Size(559, 120);
            this.lblTitleSysInfo.TabIndex = 0;
            this.lblTitleSysInfo.Text = "系统信息";
            this.lblTitleSysInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tlpRight
            // 
            this.tlpRight.BackgroundImage = global::MESWinForms.Properties.Resources.bg;
            this.tlpRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.pnlRightCenter, 0, 1);
            this.tlpRight.Controls.Add(this.tlpRightTop, 0, 0);
            this.tlpRight.Controls.Add(this.pnlRightBottom, 0, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(1450, 164);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRight.Size = new System.Drawing.Size(542, 1217);
            this.tlpRight.TabIndex = 2;
            // 
            // pnlRightCenter
            // 
            this.pnlRightCenter.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlRightCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRightCenter.Controls.Add(this.tlpRightCenter);
            this.pnlRightCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCenter.Location = new System.Drawing.Point(3, 408);
            this.pnlRightCenter.Name = "pnlRightCenter";
            this.pnlRightCenter.Size = new System.Drawing.Size(536, 399);
            this.pnlRightCenter.TabIndex = 5;
            // 
            // tlpRightCenter
            // 
            this.tlpRightCenter.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpRightCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRightCenter.ColumnCount = 1;
            this.tlpRightCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightCenter.Controls.Add(this.lblTitleFPY, 0, 0);
            this.tlpRightCenter.Controls.Add(this.formsPlot1, 0, 1);
            this.tlpRightCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightCenter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlpRightCenter.Location = new System.Drawing.Point(0, 0);
            this.tlpRightCenter.Name = "tlpRightCenter";
            this.tlpRightCenter.RowCount = 2;
            this.tlpRightCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRightCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpRightCenter.Size = new System.Drawing.Size(536, 399);
            this.tlpRightCenter.TabIndex = 8;
            // 
            // lblTitleFPY
            // 
            this.lblTitleFPY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleFPY.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTitleFPY.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitleFPY.Location = new System.Drawing.Point(3, 0);
            this.lblTitleFPY.Name = "lblTitleFPY";
            this.lblTitleFPY.Size = new System.Drawing.Size(530, 79);
            this.lblTitleFPY.TabIndex = 0;
            this.lblTitleFPY.Text = "FPY统计";
            this.lblTitleFPY.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(30, 84);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(30, 5, 30, 30);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(476, 285);
            this.formsPlot1.TabIndex = 1;
            // 
            // tlpRightTop
            // 
            this.tlpRightTop.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpRightTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRightTop.ColumnCount = 1;
            this.tlpRightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightTop.Controls.Add(this.lblTitleCalib, 0, 0);
            this.tlpRightTop.Controls.Add(this.fpCalib, 0, 1);
            this.tlpRightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightTop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlpRightTop.Location = new System.Drawing.Point(3, 3);
            this.tlpRightTop.Name = "tlpRightTop";
            this.tlpRightTop.RowCount = 2;
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpRightTop.Size = new System.Drawing.Size(536, 399);
            this.tlpRightTop.TabIndex = 7;
            // 
            // lblTitleCalib
            // 
            this.lblTitleCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleCalib.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTitleCalib.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitleCalib.Location = new System.Drawing.Point(3, 0);
            this.lblTitleCalib.Name = "lblTitleCalib";
            this.lblTitleCalib.Size = new System.Drawing.Size(530, 79);
            this.lblTitleCalib.TabIndex = 0;
            this.lblTitleCalib.Text = "校准管理";
            this.lblTitleCalib.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // fpCalib
            // 
            this.fpCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCalib.Location = new System.Drawing.Point(30, 84);
            this.fpCalib.Margin = new System.Windows.Forms.Padding(30, 5, 30, 30);
            this.fpCalib.Name = "fpCalib";
            this.fpCalib.Size = new System.Drawing.Size(476, 285);
            this.fpCalib.TabIndex = 1;
            // 
            // pnlRightBottom
            // 
            this.pnlRightBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRightBottom.Controls.Add(this.tlpRightBottom);
            this.pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightBottom.Location = new System.Drawing.Point(3, 813);
            this.pnlRightBottom.Name = "pnlRightBottom";
            this.pnlRightBottom.Size = new System.Drawing.Size(536, 401);
            this.pnlRightBottom.TabIndex = 8;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(1450, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(542, 155);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // tlpRightBottom
            // 
            this.tlpRightBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRightBottom.ColumnCount = 3;
            this.tlpRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpRightBottom.Controls.Add(this.lvRightBottom, 1, 1);
            this.tlpRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpRightBottom.Name = "tlpRightBottom";
            this.tlpRightBottom.RowCount = 3;
            this.tlpRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tlpRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpRightBottom.Size = new System.Drawing.Size(536, 401);
            this.tlpRightBottom.TabIndex = 0;
            // 
            // lvRightBottom
            // 
            this.lvRightBottom.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lvRightBottom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRightBottom.ForeColor = System.Drawing.SystemColors.Info;
            this.lvRightBottom.HideSelection = false;
            this.lvRightBottom.Location = new System.Drawing.Point(19, 35);
            this.lvRightBottom.Name = "lvRightBottom";
            this.lvRightBottom.Size = new System.Drawing.Size(497, 342);
            this.lvRightBottom.TabIndex = 0;
            this.lvRightBottom.UseCompatibleStateImageBehavior = false;
            this.lvRightBottom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "报警";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "报警系统";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "报警类型";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "严重等级";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "最后值";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1995, 1384);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpCenter.ResumeLayout(false);
            this.pnlCenterBottom.ResumeLayout(false);
            this.tlpCenterBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenterCenter)).EndInit();
            this.tlpLeft.ResumeLayout(false);
            this.pnlLeftBottom.ResumeLayout(false);
            this.tlpLeftBottom.ResumeLayout(false);
            this.pnlLeftTop.ResumeLayout(false);
            this.tlpLeftTop.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.pnlRightCenter.ResumeLayout(false);
            this.tlpRightCenter.ResumeLayout(false);
            this.tlpRightTop.ResumeLayout(false);
            this.pnlRightBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpRightBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpCenter;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.PictureBox pbCenterCenter;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlCenterBottom;
        private System.Windows.Forms.Panel pnlLeftBottom;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.Panel pnlRightCenter;
        private System.Windows.Forms.TableLayoutPanel tlpRightTop;
        private System.Windows.Forms.Label lblTitleCalib;
        private ScottPlot.FormsPlot fpCalib;
        private System.Windows.Forms.TableLayoutPanel tlpRightCenter;
        private System.Windows.Forms.Label lblTitleFPY;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.TableLayoutPanel tlpLeftTop;
        private System.Windows.Forms.Label lblTitleSysInfo;
        private System.Windows.Forms.TableLayoutPanel tlpCenterBottom;
        private System.Windows.Forms.Label lblSysMgr;
        private System.Windows.Forms.TableLayoutPanel tlpLeftBottom;
        private ScottPlot.FormsPlot fpFailedAnalysis;
        private ScottPlot.FormsPlot fpFailedCase;
        private System.Windows.Forms.Panel pnlRightBottom;
        private System.Windows.Forms.TableLayoutPanel tlpRightBottom;
        private System.Windows.Forms.ListView lvRightBottom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

