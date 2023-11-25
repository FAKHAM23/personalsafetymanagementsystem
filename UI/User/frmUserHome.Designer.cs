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
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.rdoGreenTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoBlueTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoOrangeTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.cmbxLanguage = new MaterialSkin.Controls.MaterialComboBox();
            this.languageSupportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.swhTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtpPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.txtpEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtpLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtpFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtpPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbxbGender = new MaterialSkin.Controls.MaterialComboBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.safetyTipsTableAdapter = new WomanSafety.PersonalSafetyDatabaseDataSet2TableAdapters.SafetyTipsTableAdapter();
            this.languageSupportTableAdapter = new WomanSafety.PersonalSafetyDatabaseDataSet2TableAdapters.LanguageSupportTableAdapter();
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
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageSupportBindingSource)).BeginInit();
            this.materialCard7.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Controls.Add(this.tblHome);
            resources.ApplyResources(this.tabPageHome, "tabPageHome");
            this.tabPageHome.Name = "tabPageHome";
            // 
            // tblHome
            // 
            resources.ApplyResources(this.tblHome, "tblHome");
            this.tblHome.Controls.Add(this.btnUnsafe, 1, 1);
            this.tblHome.Controls.Add(this.materialLabel1, 0, 0);
            this.tblHome.Controls.Add(this.swhSendLocation, 1, 0);
            this.tblHome.Controls.Add(this.crdmap, 0, 1);
            this.tblHome.Name = "tblHome";
            // 
            // btnUnsafe
            // 
            resources.ApplyResources(this.btnUnsafe, "btnUnsafe");
            this.btnUnsafe.BackColor = System.Drawing.Color.Red;
            this.btnUnsafe.Name = "btnUnsafe";
            this.btnUnsafe.UseVisualStyleBackColor = false;
            this.btnUnsafe.Click += new System.EventHandler(this.btnUnsafe_Click);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.UseAccent = true;
            this.materialLabel1.UseMnemonic = false;
            // 
            // swhSendLocation
            // 
            resources.ApplyResources(this.swhSendLocation, "swhSendLocation");
            this.swhSendLocation.Checked = true;
            this.swhSendLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.swhSendLocation.Depth = 0;
            this.swhSendLocation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swhSendLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.swhSendLocation.Name = "swhSendLocation";
            this.swhSendLocation.Ripple = true;
            this.swhSendLocation.UseVisualStyleBackColor = true;
            this.swhSendLocation.CheckedChanged += new System.EventHandler(this.swhSendLocation_CheckedChanged);
            // 
            // crdmap
            // 
            this.crdmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crdmap.Controls.Add(this.gMapHome);
            this.crdmap.Depth = 0;
            resources.ApplyResources(this.crdmap, "crdmap");
            this.crdmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crdmap.MouseState = MaterialSkin.MouseState.HOVER;
            this.crdmap.Name = "crdmap";
            // 
            // gMapHome
            // 
            this.gMapHome.Bearing = 0F;
            this.gMapHome.CanDragMap = true;
            this.gMapHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.gMapHome, "gMapHome");
            this.gMapHome.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapHome.GrayScaleMode = false;
            this.gMapHome.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapHome.LevelsKeepInMemory = 5;
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
            this.gMapHome.Zoom = 0D;
            // 
            // tabPageRoute
            // 
            this.tabPageRoute.BackColor = System.Drawing.Color.White;
            this.tabPageRoute.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.tabPageRoute, "tabPageRoute");
            this.tabPageRoute.Name = "tabPageRoute";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialCard2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.UseAccent = true;
            this.materialLabel5.UseMnemonic = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.materialCard2, 2);
            this.materialCard2.Controls.Add(this.gMapRoute);
            this.materialCard2.Depth = 0;
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            // 
            // gMapRoute
            // 
            this.gMapRoute.Bearing = 0F;
            this.gMapRoute.CanDragMap = true;
            resources.ApplyResources(this.gMapRoute, "gMapRoute");
            this.gMapRoute.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapRoute.GrayScaleMode = false;
            this.gMapRoute.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapRoute.LevelsKeepInMemory = 5;
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
            this.gMapRoute.Zoom = 10D;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.materialTextBox1, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.materialTextBox2, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.btnLetsGo, 0, 5);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            resources.ApplyResources(this.materialTextBox1, "materialTextBox1");
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            resources.ApplyResources(this.materialTextBox2, "materialTextBox2");
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.UseTallSize = false;
            // 
            // btnLetsGo
            // 
            resources.ApplyResources(this.btnLetsGo, "btnLetsGo");
            this.btnLetsGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnLetsGo.Depth = 0;
            this.btnLetsGo.HighEmphasis = true;
            this.btnLetsGo.Icon = global::WomanSafety.Properties.Resources.icons8_forward_arrow_32;
            this.btnLetsGo.Image = global::WomanSafety.Properties.Resources.icons8_forward_arrow_32;
            this.btnLetsGo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLetsGo.Name = "btnLetsGo";
            this.btnLetsGo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLetsGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLetsGo.UseAccentColor = false;
            this.btnLetsGo.UseVisualStyleBackColor = true;
            this.btnLetsGo.Click += new System.EventHandler(this.btnLetsGo_Click);
            // 
            // tabPageReport
            // 
            this.tabPageReport.BackColor = System.Drawing.Color.White;
            this.tabPageReport.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.tabPageReport, "tabPageReport");
            this.tabPageReport.Name = "tabPageReport";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.dgvReport, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialCard6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnReport, 0, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            resources.ApplyResources(this.dgvReport, "dgvReport");
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.dgvReport, 4);
            // 
            // AttendanceEdit
            // 
            this.AttendanceEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.AttendanceEdit, "AttendanceEdit");
            this.AttendanceEdit.Image = ((System.Drawing.Image)(resources.GetObject("AttendanceEdit.Image")));
            this.AttendanceEdit.Name = "AttendanceEdit";
            this.AttendanceEdit.ReadOnly = true;
            // 
            // AttendanceDelete
            // 
            this.AttendanceDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.AttendanceDelete, "AttendanceDelete");
            this.AttendanceDelete.Image = ((System.Drawing.Image)(resources.GetObject("AttendanceDelete.Image")));
            this.AttendanceDelete.Name = "AttendanceDelete";
            this.AttendanceDelete.ReadOnly = true;
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.UseAccent = true;
            this.materialLabel2.UseMnemonic = false;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.txtUserReport);
            this.materialCard6.Depth = 0;
            resources.ApplyResources(this.materialCard6, "materialCard6");
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            // 
            // txtUserReport
            // 
            this.txtUserReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserReport.Depth = 0;
            resources.ApplyResources(this.txtUserReport, "txtUserReport");
            this.txtUserReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUserReport.Name = "txtUserReport";
            // 
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReport.Depth = 0;
            this.btnReport.HighEmphasis = true;
            this.btnReport.Icon = null;
            this.btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport.Name = "btnReport";
            this.btnReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReport.UseAccentColor = false;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tabPageContact
            // 
            this.tabPageContact.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.tabPageContact, "tabPageContact");
            this.tabPageContact.Name = "tabPageContact";
            this.tabPageContact.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.materialLabel6, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.UseAccent = true;
            this.materialLabel6.UseMnemonic = false;
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // tabPageSafety
            // 
            this.tabPageSafety.BackColor = System.Drawing.Color.White;
            this.tabPageSafety.Controls.Add(this.tableLayoutPanel6);
            resources.ApplyResources(this.tabPageSafety, "tabPageSafety");
            this.tabPageSafety.Name = "tabPageSafety";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.materialCard1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.materialCard5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dgvSafetyTips, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtSafetyTitle);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Depth = 0;
            resources.ApplyResources(this.materialCard1, "materialCard1");
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            // 
            // txtSafetyTitle
            // 
            this.txtSafetyTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSafetyTitle, "txtSafetyTitle");
            this.txtSafetyTitle.Name = "txtSafetyTitle";
            this.txtSafetyTitle.ReadOnly = true;
            // 
            // materialLabel8
            // 
            resources.ApplyResources(this.materialLabel8, "materialLabel8");
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.UseAccent = true;
            this.materialLabel8.UseMnemonic = false;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.txtSafetyTip);
            this.materialCard5.Depth = 0;
            resources.ApplyResources(this.materialCard5, "materialCard5");
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            // 
            // txtSafetyTip
            // 
            this.txtSafetyTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSafetyTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafetyTip.Depth = 0;
            resources.ApplyResources(this.txtSafetyTip, "txtSafetyTip");
            this.txtSafetyTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSafetyTip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSafetyTip.Name = "txtSafetyTip";
            this.txtSafetyTip.ReadOnly = true;
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
            resources.ApplyResources(this.dgvSafetyTips, "dgvSafetyTips");
            this.dgvSafetyTips.Name = "dgvSafetyTips";
            this.dgvSafetyTips.ReadOnly = true;
            this.dgvSafetyTips.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSafetyTips_CellClick);
            // 
            // tipIDDataGridViewTextBoxColumn
            // 
            this.tipIDDataGridViewTextBoxColumn.DataPropertyName = "TipID";
            resources.ApplyResources(this.tipIDDataGridViewTextBoxColumn, "tipIDDataGridViewTextBoxColumn");
            this.tipIDDataGridViewTextBoxColumn.Name = "tipIDDataGridViewTextBoxColumn";
            this.tipIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            resources.ApplyResources(this.Description, "Description");
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            resources.ApplyResources(this.createdAtDataGridViewTextBoxColumn, "createdAtDataGridViewTextBoxColumn");
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            resources.ApplyResources(this.updatedAtDataGridViewTextBoxColumn, "updatedAtDataGridViewTextBoxColumn");
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            resources.ApplyResources(this.userIDDataGridViewTextBoxColumn, "userIDDataGridViewTextBoxColumn");
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.View, "View");
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.Name = "View";
            this.View.ReadOnly = true;
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
            resources.ApplyResources(this.tabPageSetting, "tabPageSetting");
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.materialCard3, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.materialCard4, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.materialCard7, 0, 1);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.UseAccent = true;
            this.materialLabel3.UseMnemonic = false;
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
            resources.ApplyResources(this.materialCard3, "materialCard3");
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.tableLayoutPanel9.SetRowSpan(this.materialCard3, 2);
            // 
            // rdoGreenTheme
            // 
            resources.ApplyResources(this.rdoGreenTheme, "rdoGreenTheme");
            this.rdoGreenTheme.Depth = 0;
            this.rdoGreenTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoGreenTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoGreenTheme.Name = "rdoGreenTheme";
            this.rdoGreenTheme.Ripple = true;
            this.rdoGreenTheme.TabStop = true;
            this.rdoGreenTheme.UseVisualStyleBackColor = true;
            this.rdoGreenTheme.CheckedChanged += new System.EventHandler(this.rdoGreenTheme_CheckedChanged);
            // 
            // rdoBlueTheme
            // 
            resources.ApplyResources(this.rdoBlueTheme, "rdoBlueTheme");
            this.rdoBlueTheme.Checked = true;
            this.rdoBlueTheme.Depth = 0;
            this.rdoBlueTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoBlueTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoBlueTheme.Name = "rdoBlueTheme";
            this.rdoBlueTheme.Ripple = true;
            this.rdoBlueTheme.TabStop = true;
            this.rdoBlueTheme.UseVisualStyleBackColor = true;
            this.rdoBlueTheme.CheckedChanged += new System.EventHandler(this.rdoBlueTheme_CheckedChanged);
            // 
            // rdoOrangeTheme
            // 
            resources.ApplyResources(this.rdoOrangeTheme, "rdoOrangeTheme");
            this.rdoOrangeTheme.Depth = 0;
            this.rdoOrangeTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoOrangeTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoOrangeTheme.Name = "rdoOrangeTheme";
            this.rdoOrangeTheme.Ripple = true;
            this.rdoOrangeTheme.TabStop = true;
            this.rdoOrangeTheme.UseVisualStyleBackColor = true;
            this.rdoOrangeTheme.CheckedChanged += new System.EventHandler(this.rdoOrangeTheme_CheckedChanged);
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            // 
            // materialCard4
            // 
            resources.ApplyResources(this.materialCard4, "materialCard4");
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.cmbxLanguage);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            // 
            // cmbxLanguage
            // 
            this.cmbxLanguage.AutoResize = false;
            this.cmbxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxLanguage.DataSource = this.languageSupportBindingSource;
            this.cmbxLanguage.Depth = 0;
            this.cmbxLanguage.DisplayMember = "LanguageName";
            resources.ApplyResources(this.cmbxLanguage, "cmbxLanguage");
            this.cmbxLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbxLanguage.DropDownHeight = 118;
            this.cmbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLanguage.DropDownWidth = 121;
            this.cmbxLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbxLanguage.FormattingEnabled = true;
            this.cmbxLanguage.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbxLanguage.Name = "cmbxLanguage";
            this.cmbxLanguage.StartIndex = 0;
            this.cmbxLanguage.UseTallSize = false;
            this.cmbxLanguage.ValueMember = "LanguageID";
            this.cmbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbxLanguage_SelectedIndexChanged);
            // 
            // languageSupportBindingSource
            // 
            this.languageSupportBindingSource.DataMember = "LanguageSupport";
            this.languageSupportBindingSource.DataSource = this.personalSafetyDatabaseDataSet2;
            // 
            // materialCard7
            // 
            resources.ApplyResources(this.materialCard7, "materialCard7");
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.swhTheme);
            this.materialCard7.Controls.Add(this.materialLabel4);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            // 
            // swhTheme
            // 
            resources.ApplyResources(this.swhTheme, "swhTheme");
            this.swhTheme.Depth = 0;
            this.swhTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swhTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.swhTheme.Name = "swhTheme";
            this.swhTheme.Ripple = true;
            this.swhTheme.UseVisualStyleBackColor = true;
            this.swhTheme.CheckedChanged += new System.EventHandler(this.swhTheme_CheckedChanged);
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.tableLayoutPanel4);
            resources.ApplyResources(this.tabPageProfile, "tabPageProfile");
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.txtpPhone, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtpEmail, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtpLastName, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtpFirstName, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtpPassword, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtpUsername, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbxbGender, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.dateOfBirth, 1, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // txtpPhone
            // 
            this.txtpPhone.AnimateReadOnly = false;
            this.txtpPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpPhone.Depth = 0;
            resources.ApplyResources(this.txtpPhone, "txtpPhone");
            this.txtpPhone.LeadingIcon = null;
            this.txtpPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpPhone.Name = "txtpPhone";
            this.txtpPhone.TrailingIcon = null;
            this.txtpPhone.UseTallSize = false;
            // 
            // txtpEmail
            // 
            this.txtpEmail.AnimateReadOnly = false;
            this.txtpEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpEmail.Depth = 0;
            resources.ApplyResources(this.txtpEmail, "txtpEmail");
            this.txtpEmail.LeadingIcon = null;
            this.txtpEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpEmail.Name = "txtpEmail";
            this.txtpEmail.TrailingIcon = null;
            this.txtpEmail.UseTallSize = false;
            // 
            // txtpLastName
            // 
            this.txtpLastName.AnimateReadOnly = false;
            this.txtpLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpLastName.Depth = 0;
            resources.ApplyResources(this.txtpLastName, "txtpLastName");
            this.txtpLastName.LeadingIcon = null;
            this.txtpLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpLastName.Name = "txtpLastName";
            this.txtpLastName.TrailingIcon = null;
            this.txtpLastName.UseTallSize = false;
            // 
            // txtpFirstName
            // 
            this.txtpFirstName.AnimateReadOnly = false;
            this.txtpFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpFirstName.Depth = 0;
            resources.ApplyResources(this.txtpFirstName, "txtpFirstName");
            this.txtpFirstName.LeadingIcon = null;
            this.txtpFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpFirstName.Name = "txtpFirstName";
            this.txtpFirstName.TrailingIcon = null;
            this.txtpFirstName.UseTallSize = false;
            // 
            // txtpPassword
            // 
            this.txtpPassword.AnimateReadOnly = false;
            this.txtpPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpPassword.Depth = 0;
            resources.ApplyResources(this.txtpPassword, "txtpPassword");
            this.txtpPassword.LeadingIcon = null;
            this.txtpPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpPassword.Name = "txtpPassword";
            this.txtpPassword.TrailingIcon = null;
            this.txtpPassword.UseTallSize = false;
            // 
            // materialLabel9
            // 
            resources.ApplyResources(this.materialLabel9, "materialLabel9");
            this.materialLabel9.Depth = 0;
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.HighEmphasis = true;
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.UseAccent = true;
            this.materialLabel9.UseMnemonic = false;
            // 
            // txtpUsername
            // 
            this.txtpUsername.AnimateReadOnly = false;
            this.txtpUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpUsername.Depth = 0;
            resources.ApplyResources(this.txtpUsername, "txtpUsername");
            this.txtpUsername.LeadingIcon = null;
            this.txtpUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpUsername.Name = "txtpUsername";
            this.txtpUsername.TrailingIcon = null;
            this.txtpUsername.UseTallSize = false;
            // 
            // cmbxbGender
            // 
            this.cmbxbGender.AutoResize = false;
            this.cmbxbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxbGender.Depth = 0;
            resources.ApplyResources(this.cmbxbGender, "cmbxbGender");
            this.cmbxbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbxbGender.DropDownHeight = 118;
            this.cmbxbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxbGender.DropDownWidth = 121;
            this.cmbxbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbxbGender.FormattingEnabled = true;
            this.cmbxbGender.Items.AddRange(new object[] {
            resources.GetString("cmbxbGender.Items"),
            resources.GetString("cmbxbGender.Items1"),
            resources.GetString("cmbxbGender.Items2")});
            this.cmbxbGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbxbGender.Name = "cmbxbGender";
            this.cmbxbGender.StartIndex = 0;
            this.cmbxbGender.UseTallSize = false;
            // 
            // dateOfBirth
            // 
            resources.ApplyResources(this.dateOfBirth, "dateOfBirth");
            this.dateOfBirth.MaxDate = new System.DateTime(2023, 11, 26, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Value = new System.DateTime(2023, 11, 26, 0, 0, 0, 0);
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
            // languageSupportTableAdapter
            // 
            this.languageSupportTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "frmUserHome";
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
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.languageSupportBindingSource)).EndInit();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.tabPageProfile.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.BindingSource languageSupportBindingSource;
        private PersonalSafetyDatabaseDataSet2TableAdapters.LanguageSupportTableAdapter languageSupportTableAdapter;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialComboBox cmbxLanguage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialTextBox txtpPhone;
        private MaterialSkin.Controls.MaterialTextBox txtpEmail;
        private MaterialSkin.Controls.MaterialTextBox txtpLastName;
        private MaterialSkin.Controls.MaterialTextBox txtpFirstName;
        private MaterialSkin.Controls.MaterialTextBox txtpPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtpUsername;
        private MaterialSkin.Controls.MaterialComboBox cmbxbGender;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
    }
}