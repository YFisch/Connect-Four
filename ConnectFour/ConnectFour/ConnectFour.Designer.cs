namespace ConnectFour
{
    partial class ConnectFour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectFour));
            tblMain = new TableLayoutPanel();
            tblControl = new TableLayoutPanel();
            btnStart = new Button();
            opt2Player = new RadioButton();
            optPlayAgainstComputer = new RadioButton();
            lblStatus = new Label();
            tblGrid = new TableLayoutPanel();
            lblGrid1 = new Label();
            lblGrid2 = new Label();
            lblGrid3 = new Label();
            lblGrid4 = new Label();
            lblGrid5 = new Label();
            lblGrid6 = new Label();
            lblGrid7 = new Label();
            lblGrid8 = new Label();
            lblGrid9 = new Label();
            lblGrid10 = new Label();
            lblGrid11 = new Label();
            lblGrid12 = new Label();
            lblGrid13 = new Label();
            lblGrid14 = new Label();
            lblGrid15 = new Label();
            lblGrid16 = new Label();
            lblGrid17 = new Label();
            lblGrid18 = new Label();
            lblGrid19 = new Label();
            lblGrid20 = new Label();
            lblGrid21 = new Label();
            lblGrid22 = new Label();
            lblGrid23 = new Label();
            lblGrid24 = new Label();
            lblGrid25 = new Label();
            lblGrid26 = new Label();
            lblGrid27 = new Label();
            lblGrid28 = new Label();
            lblGrid29 = new Label();
            lblGrid30 = new Label();
            lblGrid31 = new Label();
            lblGrid32 = new Label();
            lblGrid33 = new Label();
            lblGrid34 = new Label();
            lblGrid35 = new Label();
            lblGrid36 = new Label();
            lblGrid37 = new Label();
            lblGrid38 = new Label();
            lblGrid39 = new Label();
            lblGrid40 = new Label();
            lblGrid41 = new Label();
            lblGrid42 = new Label();
            tblEnter = new TableLayoutPanel();
            btnEnter1 = new Button();
            btnEnter2 = new Button();
            btnEnter3 = new Button();
            btnEnter4 = new Button();
            btnEnter5 = new Button();
            btnEnter6 = new Button();
            btnEnter7 = new Button();
            tblMain.SuspendLayout();
            tblControl.SuspendLayout();
            tblGrid.SuspendLayout();
            tblEnter.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.Controls.Add(tblControl, 0, 0);
            tblMain.Controls.Add(tblGrid, 1, 2);
            tblMain.Controls.Add(tblEnter, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 4, 3, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tblMain.Size = new Size(929, 611);
            tblMain.TabIndex = 0;
            // 
            // tblControl
            // 
            tblControl.Anchor = AnchorStyles.None;
            tblControl.ColumnCount = 4;
            tblMain.SetColumnSpan(tblControl, 3);
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.Controls.Add(btnStart, 0, 0);
            tblControl.Controls.Add(opt2Player, 1, 0);
            tblControl.Controls.Add(optPlayAgainstComputer, 2, 0);
            tblControl.Controls.Add(lblStatus, 3, 0);
            tblControl.Location = new Point(11, 4);
            tblControl.Margin = new Padding(3, 4, 3, 4);
            tblControl.Name = "tblControl";
            tblControl.RowCount = 1;
            tblControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblControl.Size = new Size(907, 82);
            tblControl.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.AutoSize = true;
            btnStart.BackColor = Color.Black;
            btnStart.ForeColor = Color.RoyalBlue;
            btnStart.Location = new Point(20, 14);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(185, 53);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // opt2Player
            // 
            opt2Player.Anchor = AnchorStyles.None;
            opt2Player.AutoSize = true;
            opt2Player.Checked = true;
            opt2Player.ForeColor = Color.RoyalBlue;
            opt2Player.Location = new Point(299, 29);
            opt2Player.Name = "opt2Player";
            opt2Player.Size = new Size(79, 24);
            opt2Player.TabIndex = 1;
            opt2Player.TabStop = true;
            opt2Player.Text = "2 Player";
            opt2Player.UseVisualStyleBackColor = true;
            // 
            // optPlayAgainstComputer
            // 
            optPlayAgainstComputer.Anchor = AnchorStyles.None;
            optPlayAgainstComputer.AutoSize = true;
            optPlayAgainstComputer.ForeColor = Color.RoyalBlue;
            optPlayAgainstComputer.Location = new Point(463, 29);
            optPlayAgainstComputer.Name = "optPlayAgainstComputer";
            optPlayAgainstComputer.Size = new Size(203, 24);
            optPlayAgainstComputer.TabIndex = 2;
            optPlayAgainstComputer.Text = "Play Against the Computer";
            optPlayAgainstComputer.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Silver;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(681, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(223, 82);
            lblStatus.TabIndex = 3;
            // 
            // tblGrid
            // 
            tblGrid.BackColor = Color.RoyalBlue;
            tblGrid.BackgroundImageLayout = ImageLayout.Center;
            tblGrid.ColumnCount = 7;
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblGrid.Controls.Add(lblGrid1, 0, 0);
            tblGrid.Controls.Add(lblGrid2, 1, 0);
            tblGrid.Controls.Add(lblGrid3, 2, 0);
            tblGrid.Controls.Add(lblGrid4, 3, 0);
            tblGrid.Controls.Add(lblGrid5, 4, 0);
            tblGrid.Controls.Add(lblGrid6, 5, 0);
            tblGrid.Controls.Add(lblGrid7, 6, 0);
            tblGrid.Controls.Add(lblGrid8, 0, 1);
            tblGrid.Controls.Add(lblGrid9, 1, 1);
            tblGrid.Controls.Add(lblGrid10, 2, 1);
            tblGrid.Controls.Add(lblGrid11, 3, 1);
            tblGrid.Controls.Add(lblGrid12, 4, 1);
            tblGrid.Controls.Add(lblGrid13, 5, 1);
            tblGrid.Controls.Add(lblGrid14, 6, 1);
            tblGrid.Controls.Add(lblGrid15, 0, 2);
            tblGrid.Controls.Add(lblGrid16, 1, 2);
            tblGrid.Controls.Add(lblGrid17, 2, 2);
            tblGrid.Controls.Add(lblGrid18, 3, 2);
            tblGrid.Controls.Add(lblGrid19, 4, 2);
            tblGrid.Controls.Add(lblGrid20, 5, 2);
            tblGrid.Controls.Add(lblGrid21, 6, 2);
            tblGrid.Controls.Add(lblGrid22, 0, 3);
            tblGrid.Controls.Add(lblGrid23, 1, 3);
            tblGrid.Controls.Add(lblGrid24, 2, 3);
            tblGrid.Controls.Add(lblGrid25, 3, 3);
            tblGrid.Controls.Add(lblGrid26, 4, 3);
            tblGrid.Controls.Add(lblGrid27, 5, 3);
            tblGrid.Controls.Add(lblGrid28, 6, 3);
            tblGrid.Controls.Add(lblGrid29, 0, 4);
            tblGrid.Controls.Add(lblGrid30, 1, 4);
            tblGrid.Controls.Add(lblGrid31, 2, 4);
            tblGrid.Controls.Add(lblGrid32, 3, 4);
            tblGrid.Controls.Add(lblGrid33, 4, 4);
            tblGrid.Controls.Add(lblGrid34, 5, 4);
            tblGrid.Controls.Add(lblGrid35, 6, 4);
            tblGrid.Controls.Add(lblGrid36, 0, 5);
            tblGrid.Controls.Add(lblGrid37, 1, 5);
            tblGrid.Controls.Add(lblGrid38, 2, 5);
            tblGrid.Controls.Add(lblGrid39, 3, 5);
            tblGrid.Controls.Add(lblGrid40, 4, 5);
            tblGrid.Controls.Add(lblGrid41, 5, 5);
            tblGrid.Controls.Add(lblGrid42, 6, 5);
            tblGrid.Dock = DockStyle.Fill;
            tblGrid.Location = new Point(188, 185);
            tblGrid.Name = "tblGrid";
            tblGrid.RowCount = 6;
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblGrid.Size = new Size(551, 423);
            tblGrid.TabIndex = 1;
            // 
            // lblGrid1
            // 
            lblGrid1.Anchor = AnchorStyles.None;
            lblGrid1.BackColor = Color.White;
            lblGrid1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid1.Location = new Point(14, 10);
            lblGrid1.Name = "lblGrid1";
            lblGrid1.Size = new Size(50, 50);
            lblGrid1.TabIndex = 0;
            lblGrid1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid2
            // 
            lblGrid2.Anchor = AnchorStyles.None;
            lblGrid2.BackColor = Color.White;
            lblGrid2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid2.Location = new Point(92, 10);
            lblGrid2.Name = "lblGrid2";
            lblGrid2.Size = new Size(50, 50);
            lblGrid2.TabIndex = 1;
            lblGrid2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid3
            // 
            lblGrid3.Anchor = AnchorStyles.None;
            lblGrid3.BackColor = Color.White;
            lblGrid3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid3.Location = new Point(170, 10);
            lblGrid3.Name = "lblGrid3";
            lblGrid3.Size = new Size(50, 50);
            lblGrid3.TabIndex = 2;
            lblGrid3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid4
            // 
            lblGrid4.Anchor = AnchorStyles.None;
            lblGrid4.BackColor = Color.White;
            lblGrid4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid4.Location = new Point(248, 10);
            lblGrid4.Name = "lblGrid4";
            lblGrid4.Size = new Size(50, 50);
            lblGrid4.TabIndex = 3;
            lblGrid4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid5
            // 
            lblGrid5.Anchor = AnchorStyles.None;
            lblGrid5.BackColor = Color.White;
            lblGrid5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid5.Location = new Point(326, 10);
            lblGrid5.Name = "lblGrid5";
            lblGrid5.Size = new Size(50, 50);
            lblGrid5.TabIndex = 4;
            lblGrid5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid6
            // 
            lblGrid6.Anchor = AnchorStyles.None;
            lblGrid6.BackColor = Color.White;
            lblGrid6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid6.Location = new Point(404, 10);
            lblGrid6.Name = "lblGrid6";
            lblGrid6.Size = new Size(50, 50);
            lblGrid6.TabIndex = 5;
            lblGrid6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid7
            // 
            lblGrid7.Anchor = AnchorStyles.None;
            lblGrid7.BackColor = Color.White;
            lblGrid7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid7.Location = new Point(484, 10);
            lblGrid7.Name = "lblGrid7";
            lblGrid7.Size = new Size(50, 50);
            lblGrid7.TabIndex = 6;
            lblGrid7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid8
            // 
            lblGrid8.Anchor = AnchorStyles.None;
            lblGrid8.BackColor = Color.White;
            lblGrid8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid8.Location = new Point(14, 80);
            lblGrid8.Name = "lblGrid8";
            lblGrid8.Size = new Size(50, 50);
            lblGrid8.TabIndex = 7;
            lblGrid8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid9
            // 
            lblGrid9.Anchor = AnchorStyles.None;
            lblGrid9.BackColor = Color.White;
            lblGrid9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid9.Location = new Point(92, 80);
            lblGrid9.Name = "lblGrid9";
            lblGrid9.Size = new Size(50, 50);
            lblGrid9.TabIndex = 8;
            lblGrid9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid10
            // 
            lblGrid10.Anchor = AnchorStyles.None;
            lblGrid10.BackColor = Color.White;
            lblGrid10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid10.Location = new Point(170, 80);
            lblGrid10.Name = "lblGrid10";
            lblGrid10.Size = new Size(50, 50);
            lblGrid10.TabIndex = 9;
            lblGrid10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid11
            // 
            lblGrid11.Anchor = AnchorStyles.None;
            lblGrid11.BackColor = Color.White;
            lblGrid11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid11.Location = new Point(248, 80);
            lblGrid11.Name = "lblGrid11";
            lblGrid11.Size = new Size(50, 50);
            lblGrid11.TabIndex = 10;
            lblGrid11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid12
            // 
            lblGrid12.Anchor = AnchorStyles.None;
            lblGrid12.BackColor = Color.White;
            lblGrid12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid12.Location = new Point(326, 80);
            lblGrid12.Name = "lblGrid12";
            lblGrid12.Size = new Size(50, 50);
            lblGrid12.TabIndex = 11;
            lblGrid12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid13
            // 
            lblGrid13.Anchor = AnchorStyles.None;
            lblGrid13.BackColor = Color.White;
            lblGrid13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid13.Location = new Point(404, 80);
            lblGrid13.Name = "lblGrid13";
            lblGrid13.Size = new Size(50, 50);
            lblGrid13.TabIndex = 12;
            lblGrid13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid14
            // 
            lblGrid14.Anchor = AnchorStyles.None;
            lblGrid14.BackColor = Color.White;
            lblGrid14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid14.Location = new Point(484, 80);
            lblGrid14.Name = "lblGrid14";
            lblGrid14.Size = new Size(50, 50);
            lblGrid14.TabIndex = 13;
            lblGrid14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid15
            // 
            lblGrid15.Anchor = AnchorStyles.None;
            lblGrid15.BackColor = Color.White;
            lblGrid15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid15.Location = new Point(14, 150);
            lblGrid15.Name = "lblGrid15";
            lblGrid15.Size = new Size(50, 50);
            lblGrid15.TabIndex = 14;
            lblGrid15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid16
            // 
            lblGrid16.Anchor = AnchorStyles.None;
            lblGrid16.BackColor = Color.White;
            lblGrid16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid16.Location = new Point(92, 150);
            lblGrid16.Name = "lblGrid16";
            lblGrid16.Size = new Size(50, 50);
            lblGrid16.TabIndex = 15;
            lblGrid16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid17
            // 
            lblGrid17.Anchor = AnchorStyles.None;
            lblGrid17.BackColor = Color.White;
            lblGrid17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid17.Location = new Point(170, 150);
            lblGrid17.Name = "lblGrid17";
            lblGrid17.Size = new Size(50, 50);
            lblGrid17.TabIndex = 16;
            lblGrid17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid18
            // 
            lblGrid18.Anchor = AnchorStyles.None;
            lblGrid18.BackColor = Color.White;
            lblGrid18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid18.Location = new Point(248, 150);
            lblGrid18.Name = "lblGrid18";
            lblGrid18.Size = new Size(50, 50);
            lblGrid18.TabIndex = 17;
            lblGrid18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid19
            // 
            lblGrid19.Anchor = AnchorStyles.None;
            lblGrid19.BackColor = Color.White;
            lblGrid19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid19.Location = new Point(326, 150);
            lblGrid19.Name = "lblGrid19";
            lblGrid19.Size = new Size(50, 50);
            lblGrid19.TabIndex = 18;
            lblGrid19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid20
            // 
            lblGrid20.Anchor = AnchorStyles.None;
            lblGrid20.BackColor = Color.White;
            lblGrid20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid20.Location = new Point(404, 150);
            lblGrid20.Name = "lblGrid20";
            lblGrid20.Size = new Size(50, 50);
            lblGrid20.TabIndex = 19;
            lblGrid20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid21
            // 
            lblGrid21.Anchor = AnchorStyles.None;
            lblGrid21.BackColor = Color.White;
            lblGrid21.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid21.Location = new Point(484, 150);
            lblGrid21.Name = "lblGrid21";
            lblGrid21.Size = new Size(50, 50);
            lblGrid21.TabIndex = 20;
            lblGrid21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid22
            // 
            lblGrid22.Anchor = AnchorStyles.None;
            lblGrid22.BackColor = Color.White;
            lblGrid22.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid22.Location = new Point(14, 220);
            lblGrid22.Name = "lblGrid22";
            lblGrid22.Size = new Size(50, 50);
            lblGrid22.TabIndex = 21;
            lblGrid22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid23
            // 
            lblGrid23.Anchor = AnchorStyles.None;
            lblGrid23.BackColor = Color.White;
            lblGrid23.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid23.Location = new Point(92, 220);
            lblGrid23.Name = "lblGrid23";
            lblGrid23.Size = new Size(50, 50);
            lblGrid23.TabIndex = 22;
            lblGrid23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid24
            // 
            lblGrid24.Anchor = AnchorStyles.None;
            lblGrid24.BackColor = Color.White;
            lblGrid24.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid24.Location = new Point(170, 220);
            lblGrid24.Name = "lblGrid24";
            lblGrid24.Size = new Size(50, 50);
            lblGrid24.TabIndex = 23;
            lblGrid24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid25
            // 
            lblGrid25.Anchor = AnchorStyles.None;
            lblGrid25.BackColor = Color.White;
            lblGrid25.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid25.Location = new Point(248, 220);
            lblGrid25.Name = "lblGrid25";
            lblGrid25.Size = new Size(50, 50);
            lblGrid25.TabIndex = 24;
            lblGrid25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid26
            // 
            lblGrid26.Anchor = AnchorStyles.None;
            lblGrid26.BackColor = Color.White;
            lblGrid26.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid26.Location = new Point(326, 220);
            lblGrid26.Name = "lblGrid26";
            lblGrid26.Size = new Size(50, 50);
            lblGrid26.TabIndex = 25;
            lblGrid26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid27
            // 
            lblGrid27.Anchor = AnchorStyles.None;
            lblGrid27.BackColor = Color.White;
            lblGrid27.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid27.Location = new Point(404, 220);
            lblGrid27.Name = "lblGrid27";
            lblGrid27.Size = new Size(50, 50);
            lblGrid27.TabIndex = 26;
            lblGrid27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid28
            // 
            lblGrid28.Anchor = AnchorStyles.None;
            lblGrid28.BackColor = Color.White;
            lblGrid28.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid28.Location = new Point(484, 220);
            lblGrid28.Name = "lblGrid28";
            lblGrid28.Size = new Size(50, 50);
            lblGrid28.TabIndex = 27;
            lblGrid28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid29
            // 
            lblGrid29.Anchor = AnchorStyles.None;
            lblGrid29.BackColor = Color.White;
            lblGrid29.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid29.Location = new Point(14, 290);
            lblGrid29.Name = "lblGrid29";
            lblGrid29.Size = new Size(50, 50);
            lblGrid29.TabIndex = 28;
            lblGrid29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid30
            // 
            lblGrid30.Anchor = AnchorStyles.None;
            lblGrid30.BackColor = Color.White;
            lblGrid30.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid30.Location = new Point(92, 290);
            lblGrid30.Name = "lblGrid30";
            lblGrid30.Size = new Size(50, 50);
            lblGrid30.TabIndex = 29;
            lblGrid30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid31
            // 
            lblGrid31.Anchor = AnchorStyles.None;
            lblGrid31.BackColor = Color.White;
            lblGrid31.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid31.Location = new Point(170, 290);
            lblGrid31.Name = "lblGrid31";
            lblGrid31.Size = new Size(50, 50);
            lblGrid31.TabIndex = 30;
            lblGrid31.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid32
            // 
            lblGrid32.Anchor = AnchorStyles.None;
            lblGrid32.BackColor = Color.White;
            lblGrid32.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid32.Location = new Point(248, 290);
            lblGrid32.Name = "lblGrid32";
            lblGrid32.Size = new Size(50, 50);
            lblGrid32.TabIndex = 31;
            lblGrid32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid33
            // 
            lblGrid33.Anchor = AnchorStyles.None;
            lblGrid33.BackColor = Color.White;
            lblGrid33.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid33.Location = new Point(326, 290);
            lblGrid33.Name = "lblGrid33";
            lblGrid33.Size = new Size(50, 50);
            lblGrid33.TabIndex = 32;
            lblGrid33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid34
            // 
            lblGrid34.Anchor = AnchorStyles.None;
            lblGrid34.BackColor = Color.White;
            lblGrid34.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid34.Location = new Point(404, 290);
            lblGrid34.Name = "lblGrid34";
            lblGrid34.Size = new Size(50, 50);
            lblGrid34.TabIndex = 33;
            lblGrid34.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid35
            // 
            lblGrid35.Anchor = AnchorStyles.None;
            lblGrid35.BackColor = Color.White;
            lblGrid35.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid35.Location = new Point(484, 290);
            lblGrid35.Name = "lblGrid35";
            lblGrid35.Size = new Size(50, 50);
            lblGrid35.TabIndex = 34;
            lblGrid35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid36
            // 
            lblGrid36.Anchor = AnchorStyles.None;
            lblGrid36.BackColor = Color.White;
            lblGrid36.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid36.Location = new Point(14, 361);
            lblGrid36.Name = "lblGrid36";
            lblGrid36.Size = new Size(50, 50);
            lblGrid36.TabIndex = 35;
            lblGrid36.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid37
            // 
            lblGrid37.Anchor = AnchorStyles.None;
            lblGrid37.BackColor = Color.White;
            lblGrid37.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid37.Location = new Point(92, 361);
            lblGrid37.Name = "lblGrid37";
            lblGrid37.Size = new Size(50, 50);
            lblGrid37.TabIndex = 36;
            lblGrid37.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid38
            // 
            lblGrid38.Anchor = AnchorStyles.None;
            lblGrid38.BackColor = Color.White;
            lblGrid38.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid38.Location = new Point(170, 361);
            lblGrid38.Name = "lblGrid38";
            lblGrid38.Size = new Size(50, 50);
            lblGrid38.TabIndex = 37;
            lblGrid38.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid39
            // 
            lblGrid39.Anchor = AnchorStyles.None;
            lblGrid39.BackColor = Color.White;
            lblGrid39.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid39.Location = new Point(248, 361);
            lblGrid39.Name = "lblGrid39";
            lblGrid39.Size = new Size(50, 50);
            lblGrid39.TabIndex = 38;
            lblGrid39.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid40
            // 
            lblGrid40.Anchor = AnchorStyles.None;
            lblGrid40.BackColor = Color.White;
            lblGrid40.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid40.Location = new Point(326, 361);
            lblGrid40.Name = "lblGrid40";
            lblGrid40.Size = new Size(50, 50);
            lblGrid40.TabIndex = 39;
            lblGrid40.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid41
            // 
            lblGrid41.Anchor = AnchorStyles.None;
            lblGrid41.BackColor = Color.White;
            lblGrid41.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid41.Location = new Point(404, 361);
            lblGrid41.Name = "lblGrid41";
            lblGrid41.Size = new Size(50, 50);
            lblGrid41.TabIndex = 40;
            lblGrid41.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrid42
            // 
            lblGrid42.Anchor = AnchorStyles.None;
            lblGrid42.BackColor = Color.White;
            lblGrid42.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrid42.Location = new Point(484, 361);
            lblGrid42.Name = "lblGrid42";
            lblGrid42.Size = new Size(50, 50);
            lblGrid42.TabIndex = 41;
            lblGrid42.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblEnter
            // 
            tblEnter.ColumnCount = 7;
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.282649F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2826538F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2869387F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2869387F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2869387F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2869387F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2869387F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblEnter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblEnter.Controls.Add(btnEnter1, 0, 0);
            tblEnter.Controls.Add(btnEnter2, 1, 0);
            tblEnter.Controls.Add(btnEnter3, 2, 0);
            tblEnter.Controls.Add(btnEnter4, 3, 0);
            tblEnter.Controls.Add(btnEnter5, 4, 0);
            tblEnter.Controls.Add(btnEnter6, 5, 0);
            tblEnter.Controls.Add(btnEnter7, 6, 0);
            tblEnter.Dock = DockStyle.Fill;
            tblEnter.Location = new Point(188, 94);
            tblEnter.Name = "tblEnter";
            tblEnter.RowCount = 1;
            tblEnter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblEnter.Size = new Size(551, 85);
            tblEnter.TabIndex = 2;
            // 
            // btnEnter1
            // 
            btnEnter1.Anchor = AnchorStyles.None;
            btnEnter1.AutoSize = true;
            btnEnter1.BackColor = Color.Red;
            btnEnter1.Location = new Point(3, 13);
            btnEnter1.Name = "btnEnter1";
            btnEnter1.Size = new Size(72, 58);
            btnEnter1.TabIndex = 0;
            btnEnter1.Text = "Enter";
            btnEnter1.UseVisualStyleBackColor = false;
            // 
            // btnEnter2
            // 
            btnEnter2.Anchor = AnchorStyles.None;
            btnEnter2.AutoSize = true;
            btnEnter2.BackColor = Color.Red;
            btnEnter2.Location = new Point(81, 13);
            btnEnter2.Name = "btnEnter2";
            btnEnter2.Size = new Size(72, 58);
            btnEnter2.TabIndex = 1;
            btnEnter2.Text = "Enter";
            btnEnter2.UseVisualStyleBackColor = false;
            // 
            // btnEnter3
            // 
            btnEnter3.Anchor = AnchorStyles.None;
            btnEnter3.AutoSize = true;
            btnEnter3.BackColor = Color.Red;
            btnEnter3.Location = new Point(159, 13);
            btnEnter3.Name = "btnEnter3";
            btnEnter3.Size = new Size(72, 58);
            btnEnter3.TabIndex = 2;
            btnEnter3.Text = "Enter";
            btnEnter3.UseVisualStyleBackColor = false;
            // 
            // btnEnter4
            // 
            btnEnter4.Anchor = AnchorStyles.None;
            btnEnter4.AutoSize = true;
            btnEnter4.BackColor = Color.Red;
            btnEnter4.Location = new Point(237, 13);
            btnEnter4.Name = "btnEnter4";
            btnEnter4.Size = new Size(72, 58);
            btnEnter4.TabIndex = 3;
            btnEnter4.Text = "Enter";
            btnEnter4.UseVisualStyleBackColor = false;
            // 
            // btnEnter5
            // 
            btnEnter5.Anchor = AnchorStyles.None;
            btnEnter5.AutoSize = true;
            btnEnter5.BackColor = Color.Red;
            btnEnter5.Location = new Point(315, 13);
            btnEnter5.Name = "btnEnter5";
            btnEnter5.Size = new Size(72, 58);
            btnEnter5.TabIndex = 4;
            btnEnter5.Text = "Enter";
            btnEnter5.UseVisualStyleBackColor = false;
            // 
            // btnEnter6
            // 
            btnEnter6.Anchor = AnchorStyles.None;
            btnEnter6.AutoSize = true;
            btnEnter6.BackColor = Color.Red;
            btnEnter6.Location = new Point(393, 13);
            btnEnter6.Name = "btnEnter6";
            btnEnter6.Size = new Size(72, 58);
            btnEnter6.TabIndex = 5;
            btnEnter6.Text = "Enter";
            btnEnter6.UseVisualStyleBackColor = false;
            // 
            // btnEnter7
            // 
            btnEnter7.Anchor = AnchorStyles.None;
            btnEnter7.AutoSize = true;
            btnEnter7.BackColor = Color.Red;
            btnEnter7.Location = new Point(472, 13);
            btnEnter7.Name = "btnEnter7";
            btnEnter7.Size = new Size(75, 58);
            btnEnter7.TabIndex = 6;
            btnEnter7.Text = "Enter";
            btnEnter7.UseVisualStyleBackColor = false;
            // 
            // ConnectFour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 611);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConnectFour";
            Text = "Connect Four";
            WindowState = FormWindowState.Maximized;
            tblMain.ResumeLayout(false);
            tblControl.ResumeLayout(false);
            tblControl.PerformLayout();
            tblGrid.ResumeLayout(false);
            tblEnter.ResumeLayout(false);
            tblEnter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblControl;
        private Button btnStart;
        private RadioButton opt2Player;
        private RadioButton optPlayAgainstComputer;
        private TableLayoutPanel tblGrid;
        private Label lblGrid1;
        private Label lblGrid2;
        private Label lblGrid3;
        private Label lblGrid4;
        private Label lblGrid5;
        private Label lblGrid6;
        private Label lblGrid7;
        private Label lblGrid8;
        private Label lblGrid9;
        private Label lblGrid10;
        private Label lblGrid11;
        private Label lblGrid12;
        private Label lblGrid13;
        private Label lblGrid14;
        private Label lblGrid15;
        private Label lblGrid16;
        private Label lblGrid17;
        private Label lblGrid18;
        private Label lblGrid19;
        private Label lblGrid20;
        private Label lblGrid21;
        private Label lblGrid22;
        private Label lblGrid23;
        private Label lblGrid24;
        private Label lblGrid25;
        private Label lblGrid26;
        private Label lblGrid27;
        private Label lblGrid28;
        private Label lblGrid29;
        private Label lblGrid30;
        private Label lblGrid31;
        private Label lblGrid32;
        private Label lblGrid33;
        private Label lblGrid34;
        private Label lblGrid35;
        private Label lblGrid36;
        private Label lblGrid37;
        private Label lblGrid38;
        private Label lblGrid39;
        private Label lblGrid40;
        private Label lblGrid41;
        private Label lblGrid42;
        private TableLayoutPanel tblEnter;
        private Button btnEnter1;
        private Button btnEnter2;
        private Button btnEnter3;
        private Button btnEnter4;
        private Button btnEnter5;
        private Button btnEnter6;
        private Button btnEnter7;
        private Label lblStatus;
    }
}