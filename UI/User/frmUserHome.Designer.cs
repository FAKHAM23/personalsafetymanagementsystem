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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tblHome = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.swhSendLocation = new MaterialSkin.Controls.MaterialSwitch();
            this.roundedButton1 = new WomanSafety.UI.RoundedButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tabPageRoute = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddStudent = new MaterialSkin.Controls.MaterialButton();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.switchStd = new MaterialSkin.Controls.MaterialSwitch();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.AttendanceEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.AttendanceDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpick = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddAttendance = new MaterialSkin.Controls.MaterialButton();
            this.btnAttdReport = new MaterialSkin.Controls.MaterialButton();
            this.tabPageContact = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCLO = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddCLO = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.dgvCLO = new System.Windows.Forms.DataGridView();
            this.EditCLO = new System.Windows.Forms.DataGridViewImageColumn();
            this.ViewCLO = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCLO = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.lblCloCount2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageSafety = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.btnAddRubric = new MaterialSkin.Controls.MaterialButton();
            this.txtRubricDetaills = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbCLOs = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvRubric = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditRubirc = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteRubric = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tblHome.SuspendLayout();
            this.tabPageRoute.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tabPageReport.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.tabPageContact.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLO)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.tabPageSafety.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubric)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageHome);
            this.materialTabControl1.Controls.Add(this.tabPageRoute);
            this.materialTabControl1.Controls.Add(this.tabPageReport);
            this.materialTabControl1.Controls.Add(this.tabPageContact);
            this.materialTabControl1.Controls.Add(this.tabPageSafety);
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
            this.tabPageHome.Click += new System.EventHandler(this.tabPageHome_Click);
            // 
            // tblHome
            // 
            this.tblHome.ColumnCount = 2;
            this.tblHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.33293F));
            this.tblHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.66707F));
            this.tblHome.Controls.Add(this.roundedButton1, 1, 1);
            this.tblHome.Controls.Add(this.materialLabel1, 0, 0);
            this.tblHome.Controls.Add(this.swhSendLocation, 1, 0);
            this.tblHome.Controls.Add(this.materialCard1, 0, 1);
            this.tblHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHome.Location = new System.Drawing.Point(3, 3);
            this.tblHome.Name = "tblHome";
            this.tblHome.RowCount = 2;
            this.tblHome.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblHome.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblHome.Size = new System.Drawing.Size(829, 412);
            this.tblHome.TabIndex = 1;
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
            this.swhSendLocation.Location = new System.Drawing.Point(467, 0);
            this.swhSendLocation.Margin = new System.Windows.Forms.Padding(0);
            this.swhSendLocation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swhSendLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.swhSendLocation.Name = "swhSendLocation";
            this.swhSendLocation.Ripple = true;
            this.swhSendLocation.Size = new System.Drawing.Size(160, 37);
            this.swhSendLocation.TabIndex = 7;
            this.swhSendLocation.Text = "Send Location";
            this.swhSendLocation.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.Red;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.Location = new System.Drawing.Point(555, 133);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(185, 186);
            this.roundedButton1.TabIndex = 8;
            this.roundedButton1.Text = "Feeling Unsafe Click Here!";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 55);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(439, 343);
            this.materialCard1.TabIndex = 9;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
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
            this.tableLayoutPanel1.Controls.Add(this.btnAddStudent, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvStudent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.switchStd, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.05389F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.94611F));
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
            this.materialLabel5.Size = new System.Drawing.Size(96, 29);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Students";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel5.UseAccent = true;
            this.materialLabel5.UseMnemonic = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddStudent.Depth = 0;
            this.btnAddStudent.HighEmphasis = true;
            this.btnAddStudent.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Icon")));
            this.btnAddStudent.ImageKey = "icons8-plus-32.png";
            this.btnAddStudent.Location = new System.Drawing.Point(678, 6);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddStudent.Size = new System.Drawing.Size(147, 36);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStudent.UseAccentColor = true;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToOrderColumns = true;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvStudent, 3);
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.Color.Gray;
            this.dgvStudent.Location = new System.Drawing.Point(13, 107);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(13);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.Size = new System.Drawing.Size(803, 292);
            this.dgvStudent.TabIndex = 3;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 31;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 44;
            // 
            // switchStd
            // 
            this.switchStd.AutoSize = true;
            this.switchStd.Checked = true;
            this.switchStd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchStd.Depth = 0;
            this.switchStd.Location = new System.Drawing.Point(174, 0);
            this.switchStd.Margin = new System.Windows.Forms.Padding(0);
            this.switchStd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchStd.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchStd.Name = "switchStd";
            this.switchStd.Ripple = true;
            this.switchStd.Size = new System.Drawing.Size(137, 37);
            this.switchStd.TabIndex = 5;
            this.switchStd.Text = "Active Only";
            this.switchStd.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Controls.Add(this.dgvAttendance, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpick, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddAttendance, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAttdReport, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.23221F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.43446F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(829, 412);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToOrderColumns = true;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceEdit,
            this.AttendanceDelete});
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(301, 3);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.dgvAttendance, 4);
            this.dgvAttendance.Size = new System.Drawing.Size(525, 406);
            this.dgvAttendance.TabIndex = 9;
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
            // dtpick
            // 
            this.dtpick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpick.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpick.Location = new System.Drawing.Point(3, 126);
            this.dtpick.Name = "dtpick";
            this.dtpick.Size = new System.Drawing.Size(181, 26);
            this.dtpick.TabIndex = 8;
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
            this.materialLabel2.Size = new System.Drawing.Size(125, 29);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Attendance";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel2.UseAccent = true;
            this.materialLabel2.UseMnemonic = false;
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAttendance.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddAttendance.Depth = 0;
            this.btnAddAttendance.HighEmphasis = true;
            this.btnAddAttendance.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddAttendance.Icon")));
            this.btnAddAttendance.Location = new System.Drawing.Point(4, 181);
            this.btnAddAttendance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAttendance.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddAttendance.Size = new System.Drawing.Size(180, 36);
            this.btnAddAttendance.TabIndex = 6;
            this.btnAddAttendance.Text = "New Attendance";
            this.btnAddAttendance.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddAttendance.UseAccentColor = false;
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            // 
            // btnAttdReport
            // 
            this.btnAttdReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttdReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAttdReport.Depth = 0;
            this.btnAttdReport.HighEmphasis = true;
            this.btnAttdReport.Icon = null;
            this.btnAttdReport.Location = new System.Drawing.Point(4, 375);
            this.btnAttdReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAttdReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttdReport.Name = "btnAttdReport";
            this.btnAttdReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAttdReport.Size = new System.Drawing.Size(107, 31);
            this.btnAttdReport.TabIndex = 10;
            this.btnAttdReport.Text = "PDF Report";
            this.btnAttdReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttdReport.UseAccentColor = false;
            this.btnAttdReport.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel3.Controls.Add(this.materialCard3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvCLO, 0, 2);
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
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel3.SetColumnSpan(this.materialCard3, 2);
            this.materialCard3.Controls.Add(this.tableLayoutPanel4);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(258, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(563, 74);
            this.materialCard3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.97222F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02778F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.Controls.Add(this.txtCLO, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddCLO, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(535, 46);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtCLO
            // 
            this.txtCLO.AnimateReadOnly = false;
            this.txtCLO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCLO.Depth = 0;
            this.txtCLO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCLO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCLO.Hint = "CLO Name";
            this.txtCLO.LeadingIcon = null;
            this.txtCLO.Location = new System.Drawing.Point(3, 3);
            this.txtCLO.MaxLength = 50;
            this.txtCLO.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCLO.Multiline = false;
            this.txtCLO.Name = "txtCLO";
            this.txtCLO.Size = new System.Drawing.Size(247, 50);
            this.txtCLO.TabIndex = 1;
            this.txtCLO.Text = "";
            this.txtCLO.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtCLO.TrailingIcon")));
            // 
            // btnAddCLO
            // 
            this.btnAddCLO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCLO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCLO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCLO.Depth = 0;
            this.btnAddCLO.HighEmphasis = true;
            this.btnAddCLO.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddCLO.Icon")));
            this.btnAddCLO.Location = new System.Drawing.Point(302, 6);
            this.btnAddCLO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCLO.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCLO.Name = "btnAddCLO";
            this.btnAddCLO.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCLO.Size = new System.Drawing.Size(78, 34);
            this.btnAddCLO.TabIndex = 0;
            this.btnAddCLO.Text = "Add";
            this.btnAddCLO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCLO.UseAccentColor = false;
            this.btnAddCLO.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.Location = new System.Drawing.Point(426, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(105, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvCLO
            // 
            this.dgvCLO.AllowUserToAddRows = false;
            this.dgvCLO.AllowUserToOrderColumns = true;
            this.dgvCLO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCLO.BackgroundColor = System.Drawing.Color.White;
            this.dgvCLO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCLO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvCLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditCLO,
            this.ViewCLO,
            this.DeleteCLO});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvCLO, 3);
            this.dgvCLO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCLO.Location = new System.Drawing.Point(30, 165);
            this.dgvCLO.Margin = new System.Windows.Forms.Padding(30, 0, 30, 20);
            this.dgvCLO.Name = "dgvCLO";
            this.dgvCLO.ReadOnly = true;
            this.tableLayoutPanel3.SetRowSpan(this.dgvCLO, 3);
            this.dgvCLO.Size = new System.Drawing.Size(775, 233);
            this.dgvCLO.TabIndex = 8;
            // 
            // EditCLO
            // 
            this.EditCLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditCLO.HeaderText = "Edit";
            this.EditCLO.Image = ((System.Drawing.Image)(resources.GetObject("EditCLO.Image")));
            this.EditCLO.Name = "EditCLO";
            this.EditCLO.ReadOnly = true;
            this.EditCLO.Width = 31;
            // 
            // ViewCLO
            // 
            this.ViewCLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ViewCLO.HeaderText = "View";
            this.ViewCLO.Image = ((System.Drawing.Image)(resources.GetObject("ViewCLO.Image")));
            this.ViewCLO.Name = "ViewCLO";
            this.ViewCLO.ReadOnly = true;
            this.ViewCLO.Width = 36;
            // 
            // DeleteCLO
            // 
            this.DeleteCLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteCLO.HeaderText = "Delete";
            this.DeleteCLO.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCLO.Image")));
            this.DeleteCLO.Name = "DeleteCLO";
            this.DeleteCLO.ReadOnly = true;
            this.DeleteCLO.Width = 44;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.materialLabel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.materialCard4, 0, 1);
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
            this.materialLabel6.Size = new System.Drawing.Size(59, 29);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "CLOs";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel6.UseAccent = true;
            this.materialLabel6.UseMnemonic = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.lblCloCount2);
            this.materialCard4.Depth = 0;
            this.materialCard4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 61);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(210, 35);
            this.materialCard4.TabIndex = 8;
            // 
            // lblCloCount2
            // 
            this.lblCloCount2.AutoSize = true;
            this.lblCloCount2.Depth = 0;
            this.lblCloCount2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCloCount2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblCloCount2.HighEmphasis = true;
            this.lblCloCount2.Location = new System.Drawing.Point(17, 9);
            this.lblCloCount2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCloCount2.Name = "lblCloCount2";
            this.lblCloCount2.Size = new System.Drawing.Size(83, 17);
            this.lblCloCount2.TabIndex = 0;
            this.lblCloCount2.Text = "Total 3 CLOs";
            this.lblCloCount2.UseAccent = true;
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
            this.tableLayoutPanel6.Controls.Add(this.materialLabel8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.materialCard5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dgvRubric, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(835, 418);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.Location = new System.Drawing.Point(5, 0);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(81, 29);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Rubrics";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel8.UseAccent = true;
            this.materialLabel8.UseMnemonic = false;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btnAddRubric);
            this.materialCard5.Controls.Add(this.txtRubricDetaills);
            this.materialCard5.Controls.Add(this.cbCLOs);
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
            // btnAddRubric
            // 
            this.btnAddRubric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRubric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddRubric.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddRubric.Depth = 0;
            this.btnAddRubric.HighEmphasis = true;
            this.btnAddRubric.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddRubric.Icon")));
            this.btnAddRubric.Location = new System.Drawing.Point(386, 84);
            this.btnAddRubric.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddRubric.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddRubric.Size = new System.Drawing.Size(133, 36);
            this.btnAddRubric.TabIndex = 2;
            this.btnAddRubric.Text = "Add Rubric";
            this.btnAddRubric.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddRubric.UseAccentColor = false;
            this.btnAddRubric.UseVisualStyleBackColor = true;
            // 
            // txtRubricDetaills
            // 
            this.txtRubricDetaills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRubricDetaills.AnimateReadOnly = false;
            this.txtRubricDetaills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRubricDetaills.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRubricDetaills.Depth = 0;
            this.txtRubricDetaills.ErrorMessage = "Error";
            this.txtRubricDetaills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRubricDetaills.HideSelection = true;
            this.txtRubricDetaills.Hint = "Rubric Details";
            this.txtRubricDetaills.LeadingIcon = null;
            this.txtRubricDetaills.Location = new System.Drawing.Point(17, 72);
            this.txtRubricDetaills.MaxLength = 32767;
            this.txtRubricDetaills.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRubricDetaills.Name = "txtRubricDetaills";
            this.txtRubricDetaills.PasswordChar = '\0';
            this.txtRubricDetaills.PrefixSuffixText = null;
            this.txtRubricDetaills.ReadOnly = false;
            this.txtRubricDetaills.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRubricDetaills.SelectedText = "";
            this.txtRubricDetaills.SelectionLength = 0;
            this.txtRubricDetaills.SelectionStart = 0;
            this.txtRubricDetaills.ShortcutsEnabled = true;
            this.txtRubricDetaills.Size = new System.Drawing.Size(346, 48);
            this.txtRubricDetaills.TabIndex = 1;
            this.txtRubricDetaills.TabStop = false;
            this.txtRubricDetaills.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRubricDetaills.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtRubricDetaills.TrailingIcon")));
            this.txtRubricDetaills.UseSystemPasswordChar = false;
            // 
            // cbCLOs
            // 
            this.cbCLOs.AutoResize = false;
            this.cbCLOs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCLOs.Depth = 0;
            this.cbCLOs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCLOs.DropDownHeight = 174;
            this.cbCLOs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCLOs.DropDownWidth = 121;
            this.cbCLOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCLOs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCLOs.FormattingEnabled = true;
            this.cbCLOs.Hint = "CLOs";
            this.cbCLOs.IntegralHeight = false;
            this.cbCLOs.ItemHeight = 43;
            this.cbCLOs.Location = new System.Drawing.Point(17, 17);
            this.cbCLOs.MaxDropDownItems = 4;
            this.cbCLOs.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCLOs.Name = "cbCLOs";
            this.cbCLOs.Size = new System.Drawing.Size(121, 49);
            this.cbCLOs.StartIndex = 0;
            this.cbCLOs.TabIndex = 0;
            // 
            // dgvRubric
            // 
            this.dgvRubric.AllowUserToAddRows = false;
            this.dgvRubric.AllowUserToOrderColumns = true;
            this.dgvRubric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRubric.BackgroundColor = System.Drawing.Color.White;
            this.dgvRubric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRubric.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvRubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.EditRubirc,
            this.DeleteRubric});
            this.tableLayoutPanel6.SetColumnSpan(this.dgvRubric, 2);
            this.dgvRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRubric.Location = new System.Drawing.Point(3, 161);
            this.dgvRubric.Name = "dgvRubric";
            this.dgvRubric.ReadOnly = true;
            this.dgvRubric.Size = new System.Drawing.Size(829, 254);
            this.dgvRubric.TabIndex = 1;
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
            // EditRubirc
            // 
            this.EditRubirc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditRubirc.HeaderText = "Edit";
            this.EditRubirc.Image = ((System.Drawing.Image)(resources.GetObject("EditRubirc.Image")));
            this.EditRubirc.Name = "EditRubirc";
            this.EditRubirc.ReadOnly = true;
            this.EditRubirc.Width = 31;
            // 
            // DeleteRubric
            // 
            this.DeleteRubric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteRubric.HeaderText = "Delete";
            this.DeleteRubric.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRubric.Image")));
            this.DeleteRubric.Name = "DeleteRubric";
            this.DeleteRubric.ReadOnly = true;
            this.DeleteRubric.Width = 44;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.ImageKey = "icons8-admin-settings-male-32.png";
            this.tabPageProfile.Location = new System.Drawing.Point(4, 39);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Size = new System.Drawing.Size(835, 418);
            this.tabPageProfile.TabIndex = 5;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
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
            this.tabPageRoute.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tabPageReport.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.tabPageContact.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLO)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.tabPageSafety.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageRoute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnAddStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private MaterialSkin.Controls.MaterialSwitch switchStd;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewImageColumn AttendanceEdit;
        private System.Windows.Forms.DataGridViewImageColumn AttendanceDelete;
        private System.Windows.Forms.DateTimePicker dtpick;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnAddAttendance;
        private MaterialSkin.Controls.MaterialButton btnAttdReport;
        private System.Windows.Forms.TabPage tabPageContact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialTextBox txtCLO;
        private MaterialSkin.Controls.MaterialButton btnAddCLO;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.DataGridView dgvCLO;
        private System.Windows.Forms.DataGridViewImageColumn EditCLO;
        private System.Windows.Forms.DataGridViewImageColumn ViewCLO;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCLO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel lblCloCount2;
        private System.Windows.Forms.TabPage tabPageSafety;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton btnAddRubric;
        private MaterialSkin.Controls.MaterialTextBox2 txtRubricDetaills;
        private MaterialSkin.Controls.MaterialComboBox cbCLOs;
        private System.Windows.Forms.DataGridView dgvRubric;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn EditRubirc;
        private System.Windows.Forms.DataGridViewImageColumn DeleteRubric;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tblHome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch swhSendLocation;
        private RoundedButton roundedButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}