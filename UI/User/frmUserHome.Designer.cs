namespace WomanSafety.UI
{
    partial class frmUserHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserHome));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tblHome = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnsafe = new WomanSafety.UI.RoundedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.swhSendLocation = new MaterialSkin.Controls.MaterialSwitch();
            this.crdmap = new MaterialSkin.Controls.MaterialCard();
            this.gMapHome = new GMap.NET.WindowsForms.GMapControl();
            this.tabPageRoute = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.gMapRoute = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLetsGo = new MaterialSkin.Controls.MaterialButton();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.AttendanceEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.AttendanceDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.txtUserReport = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnReport = new MaterialSkin.Controls.MaterialButton();
            this.tabPageContact = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageSafety = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtSafetyTitle = new System.Windows.Forms.RichTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.txtSafetyTip = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dgvSafetyTips = new System.Windows.Forms.DataGridView();
            this.tipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.safetyTipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalSafetyDatabaseDataSet2 = new WomanSafety.PersonalSafetyDatabaseDataSet2();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.swhTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.rdoGreenTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoBlueTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoOrangeTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.safetyTipsTableAdapter = new WomanSafety.PersonalSafetyDatabaseDataSet2TableAdapters.SafetyTipsTableAdapter();
            this.materialTabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tblHome.SuspendLayout();
            this.crdmap.SuspendLayout();
            this.tabPageRoute.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.materialCard6.SuspendLayout();
            this.tabPageContact.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPageSafety.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSafetyTips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetyTipsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalSafetyDatabaseDataSet2)).BeginInit();
            this.tabPageSetting.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageHome);
            this.materialTabControl1.Controls.Add(this.tabPageRoute);
            this.materialTabControl1.Controls.Add(this.tabPageReport);
            this.materialTabControl1.Controls.Add(this.tabPageContact);
            this.materialTabControl1.Controls.Add(this.tabPageSafety);
            this.materialTabControl1.Controls.Add(this.tabPageSetting);
            this.materialTabControl1.Controls.Add(this.tabPageProfile);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(843, 461);
            this.materialTabControl1.TabIndex = 3;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Controls.Add(this.tblHome);
            this.tabPageHome.ImageKey = "icons8-home-page-32.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 39);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(835, 418);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            // 
            // tblHome
            // 
            this.tblHome.ColumnCount = 2;
            this.tblHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.8275F));
            this.tblHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.1725F));
            this.tblHome.Controls.Add(this.btnUnsafe, 1, 1);
            this.tblHome.Controls.Add(this.materialLabel1, 0, 0);
            this.tblHome.Controls.Add(this.swhSendLocation, 1, 0);
            this.tblHome.Controls.Add(this.crdmap, 0, 1);
            this.tblHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHome.Location = new System.Drawing.Point(3, 3);
            this.tblHome.Name = "tblHome";
            this.tblHome.RowCount = 2;
            this.tblHome.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblHome.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblHome.Size = new System.Drawing.Size(829, 412);
            this.tblHome.TabIndex = 1;
            // 
            // btnUnsafe
            // 
            this.btnUnsafe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnsafe.BackColor = System.Drawing.Color.Red;
            this.btnUnsafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnsafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsafe.Location = new System.Drawing.Point(598, 133);
            this.btnUnsafe.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnsafe.Name = "btnUnsafe";
            this.btnUnsafe.Size = new System.Drawing.Size(185, 186);
            this.btnUnsafe.TabIndex = 8;
            this.btnUnsafe.Text = "Feeling Unsafe Click Here!";
            this.btnUnsafe.UseVisualStyleBackColor = false;
            this.btnUnsafe.Click += new System.EventHandler(this.btnUnsafe_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(5, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(222, 41);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Woman Safety";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.UseAccent = true;
            this.materialLabel1.UseMnemonic = false;
            // 
            // swhSendLocation
            // 
            this.swhSendLocation.AutoSize = true;
            this.swhSendLocation.Checked = true;
            this.swhSendLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.swhSendLocation.Depth = 0;
            this.swhSendLocation.Location = new System.Drawing.Point(553, 0);
            this.swhSendLocation.Margin = new System.Windows.Forms.Padding(0);
            this.swhSendLocation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swhSendLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.swhSendLocation.Name = "swhSendLocation";
            this.swhSendLocation.Ripple = true;
            this.swhSendLocation.Size = new System.Drawing.Size(160, 37);
            this.swhSendLocation.TabIndex = 7;
            this.swhSendLocation.Text = "Send Location";
            this.swhSendLocation.UseVisualStyleBackColor = true;
            this.swhSendLocation.CheckedChanged += new System.EventHandler(this.swhSendLocation_CheckedChanged);
            // 
            // crdmap
            // 
            this.crdmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crdmap.Controls.Add(this.gMapHome);
            this.crdmap.Depth = 0;
            this.crdmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crdmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crdmap.Location = new System.Drawing.Point(14, 55);
            this.crdmap.Margin = new System.Windows.Forms.Padding(14);
            this.crdmap.MouseState = MaterialSkin.MouseState.HOVER;
            this.crdmap.Name = "crdmap";
            this.crdmap.Padding = new System.Windows.Forms.Padding(14);
            this.crdmap.Size = new System.Drawing.Size(525, 343);
            this.crdmap.TabIndex = 9;
            // 
            // gMapHome
            // 
            this.gMapHome.Bearing = 0F;
            this.gMapHome.CanDragMap = true;
            this.gMapHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gMapHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapHome.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapHome.GrayScaleMode = false;
            this.gMapHome.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapHome.LevelsKeepInMemory = 5;
            this.gMapHome.Location = new System.Drawing.Point(14, 14);
            this.gMapHome.MarkersEnabled = true;
            this.gMapHome.MaxZoom = 20;
            this.gMapHome.MinZoom = 2;
            this.gMapHome.MouseWheelZoomEnabled = true;
            this.gMapHome.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapHome.Name = "gMapHome";
            this.gMapHome.NegativeMode = false;
            this.gMapHome.PolygonsEnabled = true;
            this.gMapHome.RetryLoadTile = 0;
            this.gMapHome.RoutesEnabled = true;
            this.gMapHome.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapHome.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapHome.ShowTileGridLines = false;
            this.gMapHome.Size = new System.Drawing.Size(497, 315);
            this.gMapHome.TabIndex = 0;
            this.gMapHome.Zoom = 0D;
            // 
            // tabPageRoute
            // 
            this.tabPageRoute.BackColor = System.Drawing.Color.White;
            this.tabPageRoute.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRoute.ImageKey = "icons8-route-32.png";
            this.tabPageRoute.Location = new System.Drawing.Point(4, 39);
            this.tabPageRoute.Name = "tabPageRoute";
            this.tabPageRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoute.Size = new System.Drawing.Size(835, 418);
            this.tabPageRoute.TabIndex = 1;
            this.tabPageRoute.Text = "Safe Route";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02564F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.38462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialCard2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.07767F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(5, 0);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 29);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Safe Route";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel5.UseAccent = true;
            this.materialLabel5.UseMnemonic = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.materialCard2, 2);
            this.materialCard2.Controls.Add(this.gMapRoute);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(5, 49);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(541, 358);
            this.materialCard2.TabIndex = 6;
            // 
            // gMapRoute
            // 
            this.gMapRoute.Bearing = 0F;
            this.gMapRoute.CanDragMap = true;
            this.gMapRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapRoute.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapRoute.GrayScaleMode = false;
            this.gMapRoute.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapRoute.LevelsKeepInMemory = 5;
            this.gMapRoute.Location = new System.Drawing.Point(14, 14);
            this.gMapRoute.Margin = new System.Windows.Forms.Padding(2);
            this.gMapRoute.MarkersEnabled = true;
            this.gMapRoute.MaxZoom = 20;
            this.gMapRoute.MinZoom = 2;
            this.gMapRoute.MouseWheelZoomEnabled = true;
            this.gMapRoute.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapRoute.Name = "gMapRoute";
            this.gMapRoute.NegativeMode = false;
            this.gMapRoute.PolygonsEnabled = true;
            this.gMapRoute.RetryLoadTile = 0;
            this.gMapRoute.RoutesEnabled = true;
            this.gMapRoute.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapRoute.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapRoute.ShowTileGridLines = false;
            this.gMapRoute.Size = new System.Drawing.Size(513, 330);
            this.gMapRoute.TabIndex = 7;
            this.gMapRoute.Zoom = 10D;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.materialTextBox1, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.materialTextBox2, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.btnLetsGo, 0, 5);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(554, 47);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 7;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(272, 362);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "From:";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(3, 60);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(266, 36);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "To:";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(3, 159);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(266, 36);
            this.materialTextBox2.TabIndex = 1;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.UseTallSize = false;
            // 
            // btnLetsGo
            // 
            this.btnLetsGo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLetsGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLetsGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnLetsGo.Depth = 0;
            this.btnLetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetsGo.HighEmphasis = true;
            this.btnLetsGo.Icon = global::WomanSafety.Properties.Resources.icons8_forward_arrow_32;
            this.btnLetsGo.Image = global::WomanSafety.Properties.Resources.icons8_forward_arrow_32;
            this.btnLetsGo.Location = new System.Drawing.Point(81, 261);
            this.btnLetsGo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLetsGo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLetsGo.Name = "btnLetsGo";
            this.btnLetsGo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLetsGo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLetsGo.Size = new System.Drawing.Size(110, 36);
            this.btnLetsGo.TabIndex = 3;
            this.btnLetsGo.Text = "Let\'s Go";
            this.btnLetsGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLetsGo.UseAccentColor = false;
            this.btnLetsGo.UseVisualStyleBackColor = true;
            this.btnLetsGo.Click += new System.EventHandler(this.btnLetsGo_Click);
            // 
            // tabPageReport
            // 
            this.tabPageReport.BackColor = System.Drawing.Color.White;
            this.tabPageReport.Controls.Add(this.tableLayoutPanel2);
            this.tabPageReport.ImageKey = "icons8-attendance-32.png";
            this.tabPageReport.Location = new System.Drawing.Point(4, 39);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(835, 418);
            this.tabPageReport.TabIndex = 2;
            this.tabPageReport.Text = "Report";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.02564F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.97436F));
            this.tableLayoutPanel2.Controls.Add(this.dgvReport, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialCard6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnReport, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(829, 412);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToOrderColumns = true;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceEdit,
            this.AttendanceDelete});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(301, 3);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.dgvReport, 4);
            this.dgvReport.Size = new System.Drawing.Size(525, 406);
            this.dgvReport.TabIndex = 9;
            // 
            // AttendanceEdit
            // 
            this.AttendanceEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttendanceEdit.HeaderText = "Edit";
            this.AttendanceEdit.Image = ((System.Drawing.Image)(resources.GetObject("AttendanceEdit.Image")));
            this.AttendanceEdit.Name = "AttendanceEdit";
            this.AttendanceEdit.ReadOnly = true;
            this.AttendanceEdit.Width = 31;
            // 
            // AttendanceDelete
            // 
            this.AttendanceDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttendanceDelete.HeaderText = "Delete";
            this.AttendanceDelete.Image = ((System.Drawing.Image)(resources.GetObject("AttendanceDelete.Image")));
            this.AttendanceDelete.Name = "AttendanceDelete";
            this.AttendanceDelete.ReadOnly = true;
            this.AttendanceDelete.Width = 44;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(5, 0);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 29);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Report";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel2.UseAccent = true;
            this.materialLabel2.UseMnemonic = false;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.txtUserReport);
            this.materialCard6.Depth = 0;
            this.materialCard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 43);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(270, 157);
            this.materialCard6.TabIndex = 12;
            // 
            // txtUserReport
            // 
            this.txtUserReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserReport.Depth = 0;
            this.txtUserReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserReport.Location = new System.Drawing.Point(14, 14);
            this.txtUserReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUserReport.Name = "txtUserReport";
            this.txtUserReport.Size = new System.Drawing.Size(242, 129);
            this.txtUserReport.TabIndex = 11;
            this.txtUserReport.Text = "";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReport.Depth = 0;
            this.btnReport.HighEmphasis = true;
            this.btnReport.Icon = null;
            this.btnReport.Location = new System.Drawing.Point(76, 220);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport.Name = "btnReport";
            this.btnReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReport.Size = new System.Drawing.Size(146, 36);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report Incident";
            this.btnReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReport.UseAccentColor = false;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tabPageContact
            // 
            this.tabPageContact.Controls.Add(this.tableLayoutPanel3);
            this.tabPageContact.ImageKey = "icons8-contacts1-32.png";
            this.tabPageContact.Location = new System.Drawing.Point(4, 39);
            this.tabPageContact.Name = "tabPageContact";
            this.tabPageContact.Size = new System.Drawing.Size(835, 418);
            this.tabPageContact.TabIndex = 3;
            this.tabPageContact.Text = "Contact";
            this.tabPageContact.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.26209F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.15013F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.52941F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.176471F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(835, 418);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.materialLabel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.18518F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.81481F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(238, 134);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(5, 0);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(98, 29);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "Contacts";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel6.UseAccent = true;
            this.materialLabel6.UseMnemonic = false;
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // tabPageSafety
            // 
            this.tabPageSafety.BackColor = System.Drawing.Color.White;
            this.tabPageSafety.Controls.Add(this.tableLayoutPanel6);
            this.tabPageSafety.ImageKey = "icons8-safety-32.png";
            this.tabPageSafety.Location = new System.Drawing.Point(4, 39);
            this.tabPageSafety.Name = "tabPageSafety";
            this.tabPageSafety.Size = new System.Drawing.Size(835, 418);
            this.tabPageSafety.TabIndex = 4;
            this.tabPageSafety.Text = "Safety Tips";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.24427F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.75572F));
            this.tableLayoutPanel6.Controls.Add(this.materialCard1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.materialCard5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dgvSafetyTips, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(835, 418);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtSafetyTitle);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(9, 9);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(9);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(217, 140);
            this.materialCard1.TabIndex = 1;
            // 
            // txtSafetyTitle
            // 
            this.txtSafetyTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafetyTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSafetyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSafetyTitle.Location = new System.Drawing.Point(14, 43);
            this.txtSafetyTitle.Margin = new System.Windows.Forms.Padding(10);
            this.txtSafetyTitle.Name = "txtSafetyTitle";
            this.txtSafetyTitle.ReadOnly = true;
            this.txtSafetyTitle.Size = new System.Drawing.Size(189, 83);
            this.txtSafetyTitle.TabIndex = 9;
            this.txtSafetyTitle.Text = "No Safety Tip Selected";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.Location = new System.Drawing.Point(14, 14);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(119, 29);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Safety Tips";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel8.UseAccent = true;
            this.materialLabel8.UseMnemonic = false;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.txtSafetyTip);
            this.materialCard5.Depth = 0;
            this.materialCard5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(249, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(572, 128);
            this.materialCard5.TabIndex = 0;
            // 
            // txtSafetyTip
            // 
            this.txtSafetyTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSafetyTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafetyTip.Depth = 0;
            this.txtSafetyTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSafetyTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtSafetyTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSafetyTip.Location = new System.Drawing.Point(14, 14);
            this.txtSafetyTip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSafetyTip.Name = "txtSafetyTip";
            this.txtSafetyTip.ReadOnly = true;
            this.txtSafetyTip.Size = new System.Drawing.Size(544, 100);
            this.txtSafetyTip.TabIndex = 0;
            this.txtSafetyTip.Text = "No Safety Tip Selected";
            // 
            // dgvSafetyTips
            // 
            this.dgvSafetyTips.AllowUserToAddRows = false;
            this.dgvSafetyTips.AllowUserToDeleteRows = false;
            this.dgvSafetyTips.AllowUserToOrderColumns = true;
            this.dgvSafetyTips.AutoGenerateColumns = false;
            this.dgvSafetyTips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSafetyTips.BackgroundColor = System.Drawing.Color.White;
            this.dgvSafetyTips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSafetyTips.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvSafetyTips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSafetyTips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipIDDataGridViewTextBoxColumn,
            this.Title,
            this.Description,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.View});
            this.tableLayoutPanel6.SetColumnSpan(this.dgvSafetyTips, 2);
            this.dgvSafetyTips.DataSource = this.safetyTipsBindingSource;
            this.dgvSafetyTips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSafetyTips.Location = new System.Drawing.Point(3, 161);
            this.dgvSafetyTips.Name = "dgvSafetyTips";
            this.dgvSafetyTips.ReadOnly = true;
            this.dgvSafetyTips.Size = new System.Drawing.Size(829, 254);
            this.dgvSafetyTips.TabIndex = 1;
            this.dgvSafetyTips.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSafetyTips_CellClick);
            // 
            // tipIDDataGridViewTextBoxColumn
            // 
            this.tipIDDataGridViewTextBoxColumn.DataPropertyName = "TipID";
            this.tipIDDataGridViewTextBoxColumn.HeaderText = "TipID";
            this.tipIDDataGridViewTextBoxColumn.Name = "tipIDDataGridViewTextBoxColumn";
            this.tipIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.View.HeaderText = "View";
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 36;
            // 
            // safetyTipsBindingSource
            // 
            this.safetyTipsBindingSource.DataMember = "SafetyTips";
            this.safetyTipsBindingSource.DataSource = this.personalSafetyDatabaseDataSet2;
            // 
            // personalSafetyDatabaseDataSet2
            // 
            this.personalSafetyDatabaseDataSet2.DataSetName = "PersonalSafetyDatabaseDataSet2";
            this.personalSafetyDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.tableLayoutPanel9);
            this.tabPageSetting.ImageKey = "icons8-gear-32.png";
            this.tabPageSetting.Location = new System.Drawing.Point(4, 39);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Size = new System.Drawing.Size(835, 418);
            this.tabPageSetting.TabIndex = 6;
            this.tabPageSetting.Text = "Setting";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.materialCard7, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.materialCard3, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(835, 418);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(5, 0);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 29);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Setting";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel3.UseAccent = true;
            this.materialLabel3.UseMnemonic = false;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.swhTheme);
            this.materialCard7.Controls.Add(this.materialLabel4);
            this.materialCard7.Depth = 0;
            this.materialCard7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(14, 43);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(272, 65);
            this.materialCard7.TabIndex = 12;
            // 
            // swhTheme
            // 
            this.swhTheme.AutoSize = true;
            this.swhTheme.Depth = 0;
            this.swhTheme.Location = new System.Drawing.Point(122, 14);
            this.swhTheme.Margin = new System.Windows.Forms.Padding(0);
            this.swhTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swhTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.swhTheme.Name = "swhTheme";
            this.swhTheme.Ripple = true;
            this.swhTheme.Size = new System.Drawing.Size(94, 37);
            this.swhTheme.TabIndex = 1;
            this.swhTheme.Text = "Light";
            this.swhTheme.UseVisualStyleBackColor = true;
            this.swhTheme.CheckedChanged += new System.EventHandler(this.swhTheme_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(36, 23);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Theme: ";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.rdoGreenTheme);
            this.materialCard3.Controls.Add(this.rdoBlueTheme);
            this.materialCard3.Controls.Add(this.rdoOrangeTheme);
            this.materialCard3.Controls.Add(this.materialLabel7);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(314, 43);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.tableLayoutPanel9.SetRowSpan(this.materialCard3, 2);
            this.materialCard3.Size = new System.Drawing.Size(299, 174);
            this.materialCard3.TabIndex = 13;
            // 
            // rdoGreenTheme
            // 
            this.rdoGreenTheme.AutoSize = true;
            this.rdoGreenTheme.Depth = 0;
            this.rdoGreenTheme.Location = new System.Drawing.Point(125, 72);
            this.rdoGreenTheme.Margin = new System.Windows.Forms.Padding(0);
            this.rdoGreenTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoGreenTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoGreenTheme.Name = "rdoGreenTheme";
            this.rdoGreenTheme.Ripple = true;
            this.rdoGreenTheme.Size = new System.Drawing.Size(76, 37);
            this.rdoGreenTheme.TabIndex = 4;
            this.rdoGreenTheme.TabStop = true;
            this.rdoGreenTheme.Text = "Green";
            this.rdoGreenTheme.UseVisualStyleBackColor = true;
            this.rdoGreenTheme.CheckedChanged += new System.EventHandler(this.rdoGreenTheme_CheckedChanged);
            // 
            // rdoBlueTheme
            // 
            this.rdoBlueTheme.AutoSize = true;
            this.rdoBlueTheme.Checked = true;
            this.rdoBlueTheme.Depth = 0;
            this.rdoBlueTheme.Location = new System.Drawing.Point(125, 109);
            this.rdoBlueTheme.Margin = new System.Windows.Forms.Padding(0);
            this.rdoBlueTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoBlueTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoBlueTheme.Name = "rdoBlueTheme";
            this.rdoBlueTheme.Ripple = true;
            this.rdoBlueTheme.Size = new System.Drawing.Size(66, 37);
            this.rdoBlueTheme.TabIndex = 3;
            this.rdoBlueTheme.TabStop = true;
            this.rdoBlueTheme.Text = "Blue";
            this.rdoBlueTheme.UseVisualStyleBackColor = true;
            this.rdoBlueTheme.CheckedChanged += new System.EventHandler(this.rdoBlueTheme_CheckedChanged);
            // 
            // rdoOrangeTheme
            // 
            this.rdoOrangeTheme.AutoSize = true;
            this.rdoOrangeTheme.Depth = 0;
            this.rdoOrangeTheme.Location = new System.Drawing.Point(125, 35);
            this.rdoOrangeTheme.Margin = new System.Windows.Forms.Padding(0);
            this.rdoOrangeTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoOrangeTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoOrangeTheme.Name = "rdoOrangeTheme";
            this.rdoOrangeTheme.Ripple = true;
            this.rdoOrangeTheme.Size = new System.Drawing.Size(86, 37);
            this.rdoOrangeTheme.TabIndex = 2;
            this.rdoOrangeTheme.TabStop = true;
            this.rdoOrangeTheme.Text = "Orange";
            this.rdoOrangeTheme.UseVisualStyleBackColor = true;
            this.rdoOrangeTheme.CheckedChanged += new System.EventHandler(this.rdoOrangeTheme_CheckedChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 45);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(107, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "Color Scheme: ";
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.tableLayoutPanel8);
            this.tabPageProfile.ImageKey = "icons8-admin-settings-male-32.png";
            this.tabPageProfile.Location = new System.Drawing.Point(4, 39);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Size = new System.Drawing.Size(835, 418);
            this.tabPageProfile.TabIndex = 5;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(835, 418);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-attendance-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-home-page-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-menu-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-open-book-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-pass-fail-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-plus-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-settings.gif");
            this.imageList1.Images.SetKeyName(7, "icons8-user-account-32.png");
            this.imageList1.Images.SetKeyName(8, "icons8-attendance-32.png");
            this.imageList1.Images.SetKeyName(9, "icons8-active-directory-32.png");
            this.imageList1.Images.SetKeyName(10, "icons8-delete-32.png");
            this.imageList1.Images.SetKeyName(11, "icons8-edit-32.png");
            this.imageList1.Images.SetKeyName(12, "icons8-edit-property-32.png");
            this.imageList1.Images.SetKeyName(13, "icons8-no-connection-32.png");
            this.imageList1.Images.SetKeyName(14, "icons8-scorecard-32.png");
            this.imageList1.Images.SetKeyName(15, "icons8-certificate-32.png");
            this.imageList1.Images.SetKeyName(16, "icons8-admin-settings-male-32.png");
            this.imageList1.Images.SetKeyName(17, "icons8-contacts-32.png");
            this.imageList1.Images.SetKeyName(18, "icons8-route-32.png");
            this.imageList1.Images.SetKeyName(19, "icons8-tips-32.png");
            this.imageList1.Images.SetKeyName(20, "icons8-safety-32.png");
            this.imageList1.Images.SetKeyName(21, "icons8-contacts1-32.png");
            this.imageList1.Images.SetKeyName(22, "icons8-setting-32 (1).png");
            this.imageList1.Images.SetKeyName(23, "icons8-gear-32.png");
            // 
            // safetyTipsTableAdapter
            // 
            this.safetyTipsTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 528);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserHome";
            this.Text = "User Home";
            this.Load += new System.EventHandler(this.frmUserHome_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tblHome.ResumeLayout(false);
            this.tblHome.PerformLayout();
            this.crdmap.ResumeLayout(false);
            this.tabPageRoute.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.materialCard6.ResumeLayout(false);
            this.tabPageContact.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPageSafety.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSafetyTips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetyTipsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalSafetyDatabaseDataSet2)).EndInit();
            this.tabPageSetting.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tabPageProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageRoute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewImageColumn AttendanceEdit;
        private System.Windows.Forms.DataGridViewImageColumn AttendanceDelete;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnReport;
        private System.Windows.Forms.TabPage tabPageContact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage tabPageSafety;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private System.Windows.Forms.DataGridView dgvSafetyTips;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tblHome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch swhSendLocation;
        private RoundedButton btnUnsafe;
        private MaterialSkin.Controls.MaterialCard crdmap;
        private GMap.NET.WindowsForms.GMapControl gMapHome;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.RichTextBox txtSafetyTitle;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtSafetyTip;
        private PersonalSafetyDatabaseDataSet2 personalSafetyDatabaseDataSet2;
        private System.Windows.Forms.BindingSource safetyTipsBindingSource;
        private PersonalSafetyDatabaseDataSet2TableAdapters.SafetyTipsTableAdapter safetyTipsTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private GMap.NET.WindowsForms.GMapControl gMapRoute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton btnLetsGo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TabPage tabPageSetting;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtUserReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialSwitch swhTheme;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton rdoGreenTheme;
        private MaterialSkin.Controls.MaterialRadioButton rdoBlueTheme;
        private MaterialSkin.Controls.MaterialRadioButton rdoOrangeTheme;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}