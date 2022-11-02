﻿namespace MESWinForms
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
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeftBottom = new System.Windows.Forms.TableLayoutPanel();
            this.fpFailedCaseTop = new ScottPlot.FormsPlot();
            this.fpFailedCaseBottom = new ScottPlot.FormsPlot();
            this.tlpLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeftTopContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeftTopLeftSide = new System.Windows.Forms.TableLayoutPanel();
            this.fpCenterLeftBottom = new ScottPlot.FormsPlot();
            this.fpCenterLeftTop = new ScottPlot.FormsPlot();
            this.tlpLeftTopRightSide = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWorkspaceValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMgrSysValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConnectionDev = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSysInfo = new System.Windows.Forms.Label();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightCenter = new System.Windows.Forms.Panel();
            this.tlpRightCenter = new System.Windows.Forms.TableLayoutPanel();
            this.fpFPY = new ScottPlot.FormsPlot();
            this.tlpRightTop = new System.Windows.Forms.TableLayoutPanel();
            this.fpCalib = new ScottPlot.FormsPlot();
            this.lblRightTop = new System.Windows.Forms.Label();
            this.pnlRightBottom = new System.Windows.Forms.Panel();
            this.tlpRightBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lvRightBottom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lvCenterDevices = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSystemInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.fpCenterBottom = new ScottPlot.FormsPlot();
            this.tlpMain.SuspendLayout();
            this.tlpCenter.SuspendLayout();
            this.pnlCenterBottom.SuspendLayout();
            this.tlpCenterBottom.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.tlpLeftBottom.SuspendLayout();
            this.tlpLeftTop.SuspendLayout();
            this.tlpLeftTopContent.SuspendLayout();
            this.tlpLeftTopLeftSide.SuspendLayout();
            this.tlpLeftTopRightSide.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.pnlRightCenter.SuspendLayout();
            this.tlpRightCenter.SuspendLayout();
            this.tlpRightTop.SuspendLayout();
            this.pnlRightBottom.SuspendLayout();
            this.tlpRightBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
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
            this.tlpMain.Controls.Add(this.label5, 1, 0);
            this.tlpMain.Controls.Add(this.lblDateTime, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69861F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.30139F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1716, 1146);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpCenter
            // 
            this.tlpCenter.BackgroundImage = global::MESWinForms.Properties.Resources.bg;
            this.tlpCenter.ColumnCount = 1;
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenter.Controls.Add(this.pnlCenterBottom, 0, 1);
            this.tlpCenter.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenter.Location = new System.Drawing.Point(499, 134);
            this.tlpCenter.Name = "tlpCenter";
            this.tlpCenter.RowCount = 2;
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCenter.Size = new System.Drawing.Size(742, 988);
            this.tlpCenter.TabIndex = 0;
            // 
            // pnlCenterBottom
            // 
            this.pnlCenterBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlCenterBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCenterBottom.Controls.Add(this.tlpCenterBottom);
            this.pnlCenterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterBottom.Location = new System.Drawing.Point(3, 694);
            this.pnlCenterBottom.Name = "pnlCenterBottom";
            this.pnlCenterBottom.Size = new System.Drawing.Size(736, 291);
            this.pnlCenterBottom.TabIndex = 7;
            // 
            // tlpCenterBottom
            // 
            this.tlpCenterBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpCenterBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpCenterBottom.ColumnCount = 3;
            this.tlpCenterBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpCenterBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpCenterBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpCenterBottom.Controls.Add(this.lvCenterDevices, 1, 2);
            this.tlpCenterBottom.Controls.Add(this.lblSystemInfo, 1, 1);
            this.tlpCenterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenterBottom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlpCenterBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpCenterBottom.Name = "tlpCenterBottom";
            this.tlpCenterBottom.RowCount = 4;
            this.tlpCenterBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpCenterBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenterBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tlpCenterBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpCenterBottom.Size = new System.Drawing.Size(736, 291);
            this.tlpCenterBottom.TabIndex = 8;
            // 
            // tlpLeft
            // 
            this.tlpLeft.BackgroundImage = global::MESWinForms.Properties.Resources.bg;
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Controls.Add(this.tlpLeftBottom, 0, 1);
            this.tlpLeft.Controls.Add(this.tlpLeftTop, 0, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 134);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Size = new System.Drawing.Size(490, 988);
            this.tlpLeft.TabIndex = 1;
            // 
            // tlpLeftBottom
            // 
            this.tlpLeftBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box3;
            this.tlpLeftBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpLeftBottom.ColumnCount = 3;
            this.tlpLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpLeftBottom.Controls.Add(this.fpFailedCaseTop, 1, 1);
            this.tlpLeftBottom.Controls.Add(this.fpFailedCaseBottom, 1, 2);
            this.tlpLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftBottom.Location = new System.Drawing.Point(3, 497);
            this.tlpLeftBottom.Name = "tlpLeftBottom";
            this.tlpLeftBottom.RowCount = 4;
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.454341F));
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.94334F));
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.94334F));
            this.tlpLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.658964F));
            this.tlpLeftBottom.Size = new System.Drawing.Size(484, 488);
            this.tlpLeftBottom.TabIndex = 8;
            // 
            // fpFailedCaseTop
            // 
            this.fpFailedCaseTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpFailedCaseTop.Location = new System.Drawing.Point(21, 41);
            this.fpFailedCaseTop.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.fpFailedCaseTop.Name = "fpFailedCaseTop";
            this.fpFailedCaseTop.Size = new System.Drawing.Size(440, 204);
            this.fpFailedCaseTop.TabIndex = 0;
            // 
            // fpFailedCaseBottom
            // 
            this.fpFailedCaseBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpFailedCaseBottom.Location = new System.Drawing.Point(21, 255);
            this.fpFailedCaseBottom.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.fpFailedCaseBottom.Name = "fpFailedCaseBottom";
            this.fpFailedCaseBottom.Size = new System.Drawing.Size(440, 204);
            this.fpFailedCaseBottom.TabIndex = 1;
            // 
            // tlpLeftTop
            // 
            this.tlpLeftTop.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpLeftTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpLeftTop.ColumnCount = 3;
            this.tlpLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tlpLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpLeftTop.Controls.Add(this.tlpLeftTopContent, 1, 2);
            this.tlpLeftTop.Controls.Add(this.lblSysInfo, 1, 1);
            this.tlpLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftTop.Location = new System.Drawing.Point(3, 3);
            this.tlpLeftTop.Name = "tlpLeftTop";
            this.tlpLeftTop.RowCount = 4;
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tlpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpLeftTop.Size = new System.Drawing.Size(484, 488);
            this.tlpLeftTop.TabIndex = 9;
            // 
            // tlpLeftTopContent
            // 
            this.tlpLeftTopContent.ColumnCount = 2;
            this.tlpLeftTopContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpLeftTopContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpLeftTopContent.Controls.Add(this.tlpLeftTopLeftSide, 1, 0);
            this.tlpLeftTopContent.Controls.Add(this.tlpLeftTopRightSide, 0, 0);
            this.tlpLeftTopContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftTopContent.Location = new System.Drawing.Point(22, 90);
            this.tlpLeftTopContent.Name = "tlpLeftTopContent";
            this.tlpLeftTopContent.RowCount = 1;
            this.tlpLeftTopContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftTopContent.Size = new System.Drawing.Size(444, 369);
            this.tlpLeftTopContent.TabIndex = 0;
            // 
            // tlpLeftTopLeftSide
            // 
            this.tlpLeftTopLeftSide.ColumnCount = 1;
            this.tlpLeftTopLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftTopLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeftTopLeftSide.Controls.Add(this.fpCenterLeftBottom, 0, 1);
            this.tlpLeftTopLeftSide.Controls.Add(this.fpCenterLeftTop, 0, 0);
            this.tlpLeftTopLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftTopLeftSide.Location = new System.Drawing.Point(180, 3);
            this.tlpLeftTopLeftSide.Name = "tlpLeftTopLeftSide";
            this.tlpLeftTopLeftSide.RowCount = 2;
            this.tlpLeftTopLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftTopLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftTopLeftSide.Size = new System.Drawing.Size(261, 363);
            this.tlpLeftTopLeftSide.TabIndex = 0;
            // 
            // fpCenterLeftBottom
            // 
            this.fpCenterLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCenterLeftBottom.Location = new System.Drawing.Point(7, 186);
            this.fpCenterLeftBottom.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.fpCenterLeftBottom.Name = "fpCenterLeftBottom";
            this.fpCenterLeftBottom.Size = new System.Drawing.Size(247, 172);
            this.fpCenterLeftBottom.TabIndex = 6;
            // 
            // fpCenterLeftTop
            // 
            this.fpCenterLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCenterLeftTop.Location = new System.Drawing.Point(7, 5);
            this.fpCenterLeftTop.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.fpCenterLeftTop.Name = "fpCenterLeftTop";
            this.fpCenterLeftTop.Size = new System.Drawing.Size(247, 171);
            this.fpCenterLeftTop.TabIndex = 0;
            // 
            // tlpLeftTopRightSide
            // 
            this.tlpLeftTopRightSide.ColumnCount = 2;
            this.tlpLeftTopRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftTopRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeftTopRightSide.Controls.Add(this.label7, 0, 5);
            this.tlpLeftTopRightSide.Controls.Add(this.lblTemperature, 1, 4);
            this.tlpLeftTopRightSide.Controls.Add(this.label1, 0, 0);
            this.tlpLeftTopRightSide.Controls.Add(this.lblUserValue, 1, 0);
            this.tlpLeftTopRightSide.Controls.Add(this.label2, 0, 1);
            this.tlpLeftTopRightSide.Controls.Add(this.lblWorkspaceValue, 1, 1);
            this.tlpLeftTopRightSide.Controls.Add(this.label3, 0, 2);
            this.tlpLeftTopRightSide.Controls.Add(this.lblMgrSysValue, 1, 2);
            this.tlpLeftTopRightSide.Controls.Add(this.label4, 0, 3);
            this.tlpLeftTopRightSide.Controls.Add(this.lblConnectionDev, 1, 3);
            this.tlpLeftTopRightSide.Controls.Add(this.label6, 0, 4);
            this.tlpLeftTopRightSide.Controls.Add(this.label8, 1, 5);
            this.tlpLeftTopRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftTopRightSide.Location = new System.Drawing.Point(3, 3);
            this.tlpLeftTopRightSide.Name = "tlpLeftTopRightSide";
            this.tlpLeftTopRightSide.RowCount = 6;
            this.tlpLeftTopRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLeftTopRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLeftTopRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLeftTopRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLeftTopRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLeftTopRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLeftTopRightSide.Size = new System.Drawing.Size(171, 363);
            this.tlpLeftTopRightSide.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(3, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 63);
            this.label7.TabIndex = 11;
            this.label7.Text = "湿度:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTemperature.Location = new System.Drawing.Point(88, 240);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(80, 60);
            this.lblTemperature.TabIndex = 10;
            this.lblTemperature.Text = "23";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色:";
            // 
            // lblUserValue
            // 
            this.lblUserValue.AutoSize = true;
            this.lblUserValue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserValue.ForeColor = System.Drawing.SystemColors.Info;
            this.lblUserValue.Location = new System.Drawing.Point(88, 0);
            this.lblUserValue.Name = "lblUserValue";
            this.lblUserValue.Size = new System.Drawing.Size(80, 60);
            this.lblUserValue.TabIndex = 1;
            this.lblUserValue.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "工作区：";
            // 
            // lblWorkspaceValue
            // 
            this.lblWorkspaceValue.AutoSize = true;
            this.lblWorkspaceValue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkspaceValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkspaceValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWorkspaceValue.ForeColor = System.Drawing.SystemColors.Info;
            this.lblWorkspaceValue.Location = new System.Drawing.Point(88, 60);
            this.lblWorkspaceValue.Name = "lblWorkspaceValue";
            this.lblWorkspaceValue.Size = new System.Drawing.Size(80, 60);
            this.lblWorkspaceValue.TabIndex = 3;
            this.lblWorkspaceValue.Text = "Default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "管理系统：";
            // 
            // lblMgrSysValue
            // 
            this.lblMgrSysValue.AutoSize = true;
            this.lblMgrSysValue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMgrSysValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMgrSysValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMgrSysValue.ForeColor = System.Drawing.SystemColors.Info;
            this.lblMgrSysValue.Location = new System.Drawing.Point(88, 120);
            this.lblMgrSysValue.Name = "lblMgrSysValue";
            this.lblMgrSysValue.Size = new System.Drawing.Size(80, 60);
            this.lblMgrSysValue.TabIndex = 5;
            this.lblMgrSysValue.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 60);
            this.label4.TabIndex = 6;
            this.label4.Text = "连接设备:";
            // 
            // lblConnectionDev
            // 
            this.lblConnectionDev.AutoSize = true;
            this.lblConnectionDev.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConnectionDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConnectionDev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblConnectionDev.ForeColor = System.Drawing.SystemColors.Info;
            this.lblConnectionDev.Location = new System.Drawing.Point(88, 180);
            this.lblConnectionDev.Name = "lblConnectionDev";
            this.lblConnectionDev.Size = new System.Drawing.Size(80, 60);
            this.lblConnectionDev.TabIndex = 7;
            this.lblConnectionDev.Text = "45";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(3, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 60);
            this.label6.TabIndex = 8;
            this.label6.Text = "温度:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(88, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 63);
            this.label8.TabIndex = 12;
            this.label8.Text = "12.5";
            // 
            // lblSysInfo
            // 
            this.lblSysInfo.AutoSize = true;
            this.lblSysInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSysInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSysInfo.Location = new System.Drawing.Point(22, 39);
            this.lblSysInfo.Name = "lblSysInfo";
            this.lblSysInfo.Size = new System.Drawing.Size(444, 48);
            this.lblSysInfo.TabIndex = 1;
            this.lblSysInfo.Text = "系统管理";
            this.lblSysInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.tlpRight.Location = new System.Drawing.Point(1247, 134);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpRight.Size = new System.Drawing.Size(466, 988);
            this.tlpRight.TabIndex = 2;
            // 
            // pnlRightCenter
            // 
            this.pnlRightCenter.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlRightCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRightCenter.Controls.Add(this.tlpRightCenter);
            this.pnlRightCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCenter.Location = new System.Drawing.Point(3, 332);
            this.pnlRightCenter.Name = "pnlRightCenter";
            this.pnlRightCenter.Size = new System.Drawing.Size(460, 323);
            this.pnlRightCenter.TabIndex = 5;
            // 
            // tlpRightCenter
            // 
            this.tlpRightCenter.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpRightCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRightCenter.ColumnCount = 1;
            this.tlpRightCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightCenter.Controls.Add(this.fpFPY, 0, 1);
            this.tlpRightCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightCenter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlpRightCenter.Location = new System.Drawing.Point(0, 0);
            this.tlpRightCenter.Name = "tlpRightCenter";
            this.tlpRightCenter.RowCount = 2;
            this.tlpRightCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpRightCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpRightCenter.Size = new System.Drawing.Size(460, 323);
            this.tlpRightCenter.TabIndex = 8;
            // 
            // fpFPY
            // 
            this.fpFPY.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fpFPY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpFPY.Location = new System.Drawing.Point(30, 24);
            this.fpFPY.Margin = new System.Windows.Forms.Padding(30, 5, 30, 30);
            this.fpFPY.Name = "fpFPY";
            this.fpFPY.Size = new System.Drawing.Size(400, 269);
            this.fpFPY.TabIndex = 1;
            // 
            // tlpRightTop
            // 
            this.tlpRightTop.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpRightTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRightTop.ColumnCount = 3;
            this.tlpRightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpRightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpRightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpRightTop.Controls.Add(this.fpCalib, 1, 2);
            this.tlpRightTop.Controls.Add(this.lblRightTop, 1, 1);
            this.tlpRightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightTop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlpRightTop.Location = new System.Drawing.Point(3, 3);
            this.tlpRightTop.Name = "tlpRightTop";
            this.tlpRightTop.RowCount = 3;
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpRightTop.Size = new System.Drawing.Size(460, 323);
            this.tlpRightTop.TabIndex = 7;
            // 
            // fpCalib
            // 
            this.fpCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCalib.Location = new System.Drawing.Point(43, 84);
            this.fpCalib.Margin = new System.Windows.Forms.Padding(30, 5, 30, 30);
            this.fpCalib.Name = "fpCalib";
            this.fpCalib.Size = new System.Drawing.Size(372, 209);
            this.fpCalib.TabIndex = 1;
            // 
            // lblRightTop
            // 
            this.lblRightTop.AutoSize = true;
            this.lblRightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRightTop.ForeColor = System.Drawing.SystemColors.Info;
            this.lblRightTop.Location = new System.Drawing.Point(16, 25);
            this.lblRightTop.Name = "lblRightTop";
            this.lblRightTop.Size = new System.Drawing.Size(426, 54);
            this.lblRightTop.TabIndex = 2;
            this.lblRightTop.Text = "校准管理";
            this.lblRightTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRightBottom
            // 
            this.pnlRightBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.pnlRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRightBottom.Controls.Add(this.tlpRightBottom);
            this.pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightBottom.Location = new System.Drawing.Point(3, 661);
            this.pnlRightBottom.Name = "pnlRightBottom";
            this.pnlRightBottom.Size = new System.Drawing.Size(460, 324);
            this.pnlRightBottom.TabIndex = 8;
            // 
            // tlpRightBottom
            // 
            this.tlpRightBottom.BackgroundImage = global::MESWinForms.Properties.Resources.box2;
            this.tlpRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRightBottom.ColumnCount = 3;
            this.tlpRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tlpRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpRightBottom.Controls.Add(this.lvRightBottom, 1, 2);
            this.tlpRightBottom.Controls.Add(this.label9, 1, 1);
            this.tlpRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpRightBottom.Name = "tlpRightBottom";
            this.tlpRightBottom.RowCount = 4;
            this.tlpRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tlpRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpRightBottom.Size = new System.Drawing.Size(460, 324);
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
            this.lvRightBottom.Location = new System.Drawing.Point(16, 60);
            this.lvRightBottom.Name = "lvRightBottom";
            this.lvRightBottom.Size = new System.Drawing.Size(426, 243);
            this.lvRightBottom.TabIndex = 1;
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
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "报警";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(16, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(426, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "报警系统";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(1247, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(466, 125);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(499, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(742, 131);
            this.label5.TabIndex = 4;
            this.label5.Text = "NI数字化转型智能展示系统";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDateTime.Location = new System.Drawing.Point(3, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(490, 131);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvCenterDevices
            // 
            this.lvCenterDevices.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lvCenterDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lvCenterDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCenterDevices.ForeColor = System.Drawing.SystemColors.Info;
            this.lvCenterDevices.HideSelection = false;
            this.lvCenterDevices.Location = new System.Drawing.Point(25, 60);
            this.lvCenterDevices.Name = "lvCenterDevices";
            this.lvCenterDevices.Size = new System.Drawing.Size(685, 215);
            this.lvCenterDevices.TabIndex = 7;
            this.lvCenterDevices.UseCompatibleStateImageBehavior = false;
            this.lvCenterDevices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "设备名称";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "序列号";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 106;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "厂商";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 96;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "模型";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 132;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "总线型号";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "硬件版本";
            // 
            // lblSystemInfo
            // 
            this.lblSystemInfo.AutoSize = true;
            this.lblSystemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSystemInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSystemInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSystemInfo.Location = new System.Drawing.Point(25, 20);
            this.lblSystemInfo.Name = "lblSystemInfo";
            this.lblSystemInfo.Size = new System.Drawing.Size(685, 37);
            this.lblSystemInfo.TabIndex = 8;
            this.lblSystemInfo.Text = "硬件系统";
            this.lblSystemInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::MESWinForms.Properties.Resources.box3;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5163F));
            this.tableLayoutPanel1.Controls.Add(this.fpCenterBottom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbCamera, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 685);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pbCamera
            // 
            this.pbCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCamera.Location = new System.Drawing.Point(61, 79);
            this.pbCamera.Margin = new System.Windows.Forms.Padding(46, 59, 36, 0);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(872, 377);
            this.pbCamera.TabIndex = 10;
            this.pbCamera.TabStop = false;
            // 
            // fpCenterBottom
            // 
            this.fpCenterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCenterBottom.Location = new System.Drawing.Point(45, 347);
            this.fpCenterBottom.Margin = new System.Windows.Forms.Padding(45, 5, 45, 35);
            this.fpCenterBottom.Name = "fpCenterBottom";
            this.fpCenterBottom.Size = new System.Drawing.Size(646, 303);
            this.fpCenterBottom.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1716, 1146);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpCenter.ResumeLayout(false);
            this.pnlCenterBottom.ResumeLayout(false);
            this.tlpCenterBottom.ResumeLayout(false);
            this.tlpCenterBottom.PerformLayout();
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeftBottom.ResumeLayout(false);
            this.tlpLeftTop.ResumeLayout(false);
            this.tlpLeftTop.PerformLayout();
            this.tlpLeftTopContent.ResumeLayout(false);
            this.tlpLeftTopLeftSide.ResumeLayout(false);
            this.tlpLeftTopRightSide.ResumeLayout(false);
            this.tlpLeftTopRightSide.PerformLayout();
            this.tlpRight.ResumeLayout(false);
            this.pnlRightCenter.ResumeLayout(false);
            this.tlpRightCenter.ResumeLayout(false);
            this.tlpRightTop.ResumeLayout(false);
            this.tlpRightTop.PerformLayout();
            this.pnlRightBottom.ResumeLayout(false);
            this.tlpRightBottom.ResumeLayout(false);
            this.tlpRightBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpCenter;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlCenterBottom;
        private System.Windows.Forms.Panel pnlRightCenter;
        private System.Windows.Forms.TableLayoutPanel tlpRightTop;
        private System.Windows.Forms.TableLayoutPanel tlpCenterBottom;
        private System.Windows.Forms.Panel pnlRightBottom;
        private System.Windows.Forms.TableLayoutPanel tlpRightBottom;
        private System.Windows.Forms.TableLayoutPanel tlpLeftBottom;
        private ScottPlot.FormsPlot fpFailedCaseTop;
        private ScottPlot.FormsPlot fpFailedCaseBottom;
        private System.Windows.Forms.TableLayoutPanel tlpLeftTop;
        private System.Windows.Forms.TableLayoutPanel tlpLeftTopContent;
        private System.Windows.Forms.TableLayoutPanel tlpLeftTopLeftSide;
        private System.Windows.Forms.Label lblSysInfo;
        private System.Windows.Forms.TableLayoutPanel tlpLeftTopRightSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWorkspaceValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMgrSysValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConnectionDev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TableLayoutPanel tlpRightCenter;
        private ScottPlot.FormsPlot fpFPY;
        private ScottPlot.FormsPlot fpCalib;
        private System.Windows.Forms.Label lblRightTop;
        private ScottPlot.FormsPlot fpCenterLeftTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTemperature;
        private ScottPlot.FormsPlot fpCenterLeftBottom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvRightBottom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvCenterDevices;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Label lblSystemInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbCamera;
        private ScottPlot.FormsPlot fpCenterBottom;
    }
}

