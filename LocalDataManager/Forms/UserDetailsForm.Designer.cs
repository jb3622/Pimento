namespace Disney.iDash.LocalDataManager.Forms
{
    partial class UserDetailsForm
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
            this.grpMainDetails = new DevExpress.XtraEditors.GroupControl();
            this.txtLastname = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtNetworkId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtFirstname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listApplications = new Disney.iDash.Shared.Controls.ListMover();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.listEnvironments = new Disney.iDash.Shared.Controls.ListMover();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpApplications = new DevExpress.XtraTab.XtraTabPage();
            this.tpEnvironments = new DevExpress.XtraTab.XtraTabPage();
            this.tpMenuOptions = new DevExpress.XtraTab.XtraTabPage();
            this.listMenuOptions = new Disney.iDash.Shared.Controls.ListMover();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboApplications = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartment = new DevExpress.XtraEditors.TextEdit();
            this.txtTeam = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMainDetails)).BeginInit();
            this.grpMainDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetworkId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpApplications.SuspendLayout();
            this.tpEnvironments.SuspendLayout();
            this.tpMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboApplications.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMainDetails
            // 
            this.grpMainDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMainDetails.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpMainDetails.AppearanceCaption.Options.UseFont = true;
            this.grpMainDetails.Controls.Add(this.txtTeam);
            this.grpMainDetails.Controls.Add(this.txtDepartment);
            this.grpMainDetails.Controls.Add(this.labelControl6);
            this.grpMainDetails.Controls.Add(this.labelControl7);
            this.grpMainDetails.Controls.Add(this.txtLastname);
            this.grpMainDetails.Controls.Add(this.txtEmail);
            this.grpMainDetails.Controls.Add(this.txtNetworkId);
            this.grpMainDetails.Controls.Add(this.labelControl4);
            this.grpMainDetails.Controls.Add(this.labelControl3);
            this.grpMainDetails.Controls.Add(this.labelControl2);
            this.grpMainDetails.Controls.Add(this.chkActive);
            this.grpMainDetails.Controls.Add(this.txtFirstname);
            this.grpMainDetails.Controls.Add(this.labelControl1);
            this.grpMainDetails.Location = new System.Drawing.Point(12, 12);
            this.grpMainDetails.Name = "grpMainDetails";
            this.grpMainDetails.Size = new System.Drawing.Size(547, 134);
            this.grpMainDetails.TabIndex = 0;
            this.grpMainDetails.Text = "Main Details";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(280, 52);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtLastname.Properties.Appearance.Options.UseFont = true;
            this.txtLastname.Size = new System.Drawing.Size(190, 20);
            this.txtLastname.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Size = new System.Drawing.Size(262, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNetworkId
            // 
            this.txtNetworkId.Location = new System.Drawing.Point(12, 52);
            this.txtNetworkId.Name = "txtNetworkId";
            this.txtNetworkId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNetworkId.Properties.Appearance.Options.UseFont = true;
            this.txtNetworkId.Size = new System.Drawing.Size(100, 20);
            this.txtNetworkId.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "eMail";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(280, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Lastname";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(119, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Firstname";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(476, 52);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(55, 19);
            this.chkActive.TabIndex = 6;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(118, 52);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFirstname.Properties.Appearance.Options.UseFont = true;
            this.txtFirstname.Size = new System.Drawing.Size(156, 20);
            this.txtFirstname.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Network Id";
            // 
            // listApplications
            // 
            this.listApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listApplications.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.listApplications.Appearance.Options.UseFont = true;
            this.listApplications.AvailableDataSource = null;
            this.listApplications.AvailableDisplayMember = "";
            this.listApplications.AvailablePrompt = "Available";
            this.listApplications.AvailableValueMember = "";
            this.listApplications.Location = new System.Drawing.Point(10, 10);
            this.listApplications.Margin = new System.Windows.Forms.Padding(0);
            this.listApplications.Name = "listApplications";
            this.listApplications.ReadOnly = false;
            this.listApplications.SelectedDataSource = null;
            this.listApplications.SelectedDisplayMember = "";
            this.listApplications.SelectedPrompt = "Selected";
            this.listApplications.SelectedValueMember = "";
            this.listApplications.Size = new System.Drawing.Size(526, 321);
            this.listApplications.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(409, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(490, 556);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listEnvironments
            // 
            this.listEnvironments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEnvironments.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.listEnvironments.Appearance.Options.UseFont = true;
            this.listEnvironments.AvailableDataSource = null;
            this.listEnvironments.AvailableDisplayMember = "";
            this.listEnvironments.AvailablePrompt = "Available";
            this.listEnvironments.AvailableValueMember = "";
            this.listEnvironments.Location = new System.Drawing.Point(10, 10);
            this.listEnvironments.Margin = new System.Windows.Forms.Padding(0);
            this.listEnvironments.Name = "listEnvironments";
            this.listEnvironments.ReadOnly = false;
            this.listEnvironments.SelectedDataSource = null;
            this.listEnvironments.SelectedDisplayMember = "";
            this.listEnvironments.SelectedPrompt = "Selected";
            this.listEnvironments.SelectedValueMember = "";
            this.listEnvironments.Size = new System.Drawing.Size(526, 350);
            this.listEnvironments.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 171);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpApplications;
            this.xtraTabControl1.Size = new System.Drawing.Size(552, 372);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpApplications,
            this.tpEnvironments,
            this.tpMenuOptions});
            // 
            // tpApplications
            // 
            this.tpApplications.Controls.Add(this.listApplications);
            this.tpApplications.Name = "tpApplications";
            this.tpApplications.Size = new System.Drawing.Size(550, 350);
            this.tpApplications.Text = "Applications";
            // 
            // tpEnvironments
            // 
            this.tpEnvironments.Controls.Add(this.listEnvironments);
            this.tpEnvironments.Name = "tpEnvironments";
            this.tpEnvironments.Size = new System.Drawing.Size(550, 379);
            this.tpEnvironments.Text = "Environments";
            // 
            // tpMenuOptions
            // 
            this.tpMenuOptions.Controls.Add(this.listMenuOptions);
            this.tpMenuOptions.Controls.Add(this.labelControl5);
            this.tpMenuOptions.Controls.Add(this.cboApplications);
            this.tpMenuOptions.Name = "tpMenuOptions";
            this.tpMenuOptions.Size = new System.Drawing.Size(550, 350);
            this.tpMenuOptions.Text = "Restricted Menu Options";
            // 
            // listMenuOptions
            // 
            this.listMenuOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMenuOptions.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.listMenuOptions.Appearance.Options.UseFont = true;
            this.listMenuOptions.AvailableDataSource = null;
            this.listMenuOptions.AvailableDisplayMember = "";
            this.listMenuOptions.AvailablePrompt = "Available";
            this.listMenuOptions.AvailableValueMember = "";
            this.listMenuOptions.Location = new System.Drawing.Point(10, 43);
            this.listMenuOptions.Margin = new System.Windows.Forms.Padding(0);
            this.listMenuOptions.Name = "listMenuOptions";
            this.listMenuOptions.ReadOnly = false;
            this.listMenuOptions.SelectedDataSource = null;
            this.listMenuOptions.SelectedDisplayMember = "";
            this.listMenuOptions.SelectedPrompt = "Selected";
            this.listMenuOptions.SelectedValueMember = "";
            this.listMenuOptions.Size = new System.Drawing.Size(526, 292);
            this.listMenuOptions.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Application";
            // 
            // cboApplications
            // 
            this.cboApplications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboApplications.Location = new System.Drawing.Point(69, 10);
            this.cboApplications.Name = "cboApplications";
            this.cboApplications.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cboApplications.Properties.Appearance.Options.UseFont = true;
            this.cboApplications.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboApplications.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ApplicationName", "Application")});
            this.cboApplications.Properties.DisplayMember = "ApplicationName";
            this.cboApplications.Properties.NullText = "";
            this.cboApplications.Properties.ShowFooter = false;
            this.cboApplications.Properties.ShowHeader = false;
            this.cboApplications.Properties.ShowLines = false;
            this.cboApplications.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboApplications.Properties.ValueMember = "Id";
            this.cboApplications.Size = new System.Drawing.Size(467, 20);
            this.cboApplications.TabIndex = 2;
            this.cboApplications.EditValueChanged += new System.EventHandler(this.cboApplications_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(440, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Team";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(279, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(279, 100);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDepartment.Properties.Appearance.Options.UseFont = true;
            this.txtDepartment.Size = new System.Drawing.Size(156, 20);
            this.txtDepartment.TabIndex = 10;
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(440, 100);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTeam.Properties.Appearance.Options.UseFont = true;
            this.txtTeam.Size = new System.Drawing.Size(102, 20);
            this.txtTeam.TabIndex = 12;
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 591);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpMainDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDetailsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDetailsForm_FormClosed);
            this.Shown += new System.EventHandler(this.UserDetailsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpMainDetails)).EndInit();
            this.grpMainDetails.ResumeLayout(false);
            this.grpMainDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetworkId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpApplications.ResumeLayout(false);
            this.tpEnvironments.ResumeLayout(false);
            this.tpMenuOptions.ResumeLayout(false);
            this.tpMenuOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboApplications.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMainDetails;
        private Shared.Controls.ListMover listApplications;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private Shared.Controls.ListMover listEnvironments;
        private DevExpress.XtraEditors.TextEdit txtLastname;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtNetworkId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.TextEdit txtFirstname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpApplications;
        private DevExpress.XtraTab.XtraTabPage tpEnvironments;
        private DevExpress.XtraTab.XtraTabPage tpMenuOptions;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cboApplications;
        private Shared.Controls.ListMover listMenuOptions;
        private DevExpress.XtraEditors.TextEdit txtTeam;
        private DevExpress.XtraEditors.TextEdit txtDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}