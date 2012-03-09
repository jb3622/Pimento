namespace Disney.iDash.LocalDataManager
{
    partial class UserEditor
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
            this.grpUserDetails = new DevExpress.XtraEditors.GroupControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.txtNetworkID = new DevExpress.XtraEditors.TextEdit();
            this.lblNetworkID = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lstApplications = new Disney.iDash.Shared.Controls.ListMover();
            this.lstMenuOptions = new Disney.iDash.Shared.Controls.ListEditor();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpApplications = new DevExpress.XtraTab.XtraTabPage();
            this.tpEnvironments = new DevExpress.XtraTab.XtraTabPage();
            this.lstEnvironments = new Disney.iDash.Shared.Controls.ListMover();
            this.tpMenuOptions = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lstApplicationTabs = new DevExpress.XtraEditors.ListBoxControl();
            this.lblApps = new DevExpress.XtraEditors.LabelControl();
            this.lblDisabledOptions = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).BeginInit();
            this.ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUserDetails)).BeginInit();
            this.grpUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetworkID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpApplications.SuspendLayout();
            this.tpEnvironments.SuspendLayout();
            this.tpMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstApplicationTabs)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.Controls.Add(this.xtraTabControl1);
            this.ClientPanel.Controls.Add(this.btnCancel);
            this.ClientPanel.Controls.Add(this.btnSave);
            this.ClientPanel.Controls.Add(this.btnClose);
            this.ClientPanel.Controls.Add(this.grpUserDetails);
            this.ClientPanel.Size = new System.Drawing.Size(663, 444);
            this.ClientPanel.TabIndex = 0;
            // 
            // BoxStyles
            // 
            this.BoxStyles.Appearance.BackColor = System.Drawing.Color.White;
            this.BoxStyles.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BoxStyles.Appearance.Options.UseBackColor = true;
            this.BoxStyles.Appearance.Options.UseFont = true;
            this.BoxStyles.Appearance.Options.UseForeColor = true;
            this.BoxStyles.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceDisabled.ForeColor = System.Drawing.Color.Silver;
            this.BoxStyles.AppearanceDisabled.Options.UseBackColor = true;
            this.BoxStyles.AppearanceDisabled.Options.UseFont = true;
            this.BoxStyles.AppearanceDisabled.Options.UseForeColor = true;
            this.BoxStyles.AppearanceDropDown.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxStyles.AppearanceDropDown.ForeColor = System.Drawing.Color.Black;
            this.BoxStyles.AppearanceDropDown.Options.UseBackColor = true;
            this.BoxStyles.AppearanceDropDown.Options.UseFont = true;
            this.BoxStyles.AppearanceDropDown.Options.UseForeColor = true;
            this.BoxStyles.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceDropDownHeader.ForeColor = System.Drawing.Color.Blue;
            this.BoxStyles.AppearanceDropDownHeader.Options.UseBackColor = true;
            this.BoxStyles.AppearanceDropDownHeader.Options.UseFont = true;
            this.BoxStyles.AppearanceDropDownHeader.Options.UseForeColor = true;
            this.BoxStyles.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.BoxStyles.AppearanceFocused.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.BoxStyles.AppearanceFocused.Options.UseBackColor = true;
            this.BoxStyles.AppearanceFocused.Options.UseFont = true;
            this.BoxStyles.AppearanceFocused.Options.UseForeColor = true;
            this.BoxStyles.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceReadOnly.ForeColor = System.Drawing.Color.Red;
            this.BoxStyles.AppearanceReadOnly.Options.UseBackColor = true;
            this.BoxStyles.AppearanceReadOnly.Options.UseFont = true;
            this.BoxStyles.AppearanceReadOnly.Options.UseForeColor = true;
            // 
            // grpUserDetails
            // 
            this.grpUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserDetails.AppearanceCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.grpUserDetails.AppearanceCaption.Options.UseFont = true;
            this.grpUserDetails.Controls.Add(this.chkActive);
            this.grpUserDetails.Controls.Add(this.txtEmail);
            this.grpUserDetails.Controls.Add(this.lblEmail);
            this.grpUserDetails.Controls.Add(this.txtLastName);
            this.grpUserDetails.Controls.Add(this.lblLastName);
            this.grpUserDetails.Controls.Add(this.txtFirstName);
            this.grpUserDetails.Controls.Add(this.lblFirstName);
            this.grpUserDetails.Controls.Add(this.txtNetworkID);
            this.grpUserDetails.Controls.Add(this.lblNetworkID);
            this.grpUserDetails.Location = new System.Drawing.Point(12, 13);
            this.grpUserDetails.Name = "grpUserDetails";
            this.grpUserDetails.Size = new System.Drawing.Size(639, 168);
            this.grpUserDetails.TabIndex = 5;
            this.grpUserDetails.Text = "User Details";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(138, 138);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "Active?";
            this.chkActive.Size = new System.Drawing.Size(75, 19);
            this.chkActive.TabIndex = 13;
            this.chkActive.EditValueChanged += new System.EventHandler(this.chkActive_EditValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.MaxLength = 128;
            this.txtEmail.Size = new System.Drawing.Size(453, 20);
            this.txtEmail.StyleController = this.BoxStyles;
            this.txtEmail.TabIndex = 12;
            this.txtEmail.EditValueChanged += new System.EventHandler(this.txtEmail_EditValueChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(14, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(24, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(138, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Properties.Appearance.Options.UseBackColor = true;
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Properties.MaxLength = 100;
            this.txtLastName.Size = new System.Drawing.Size(453, 20);
            this.txtLastName.StyleController = this.BoxStyles;
            this.txtLastName.TabIndex = 10;
            this.txtLastName.EditValueChanged += new System.EventHandler(this.txtLastName_EditValueChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(14, 88);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(50, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(138, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.txtFirstName.Properties.Appearance.Options.UseFont = true;
            this.txtFirstName.Properties.MaxLength = 100;
            this.txtFirstName.Size = new System.Drawing.Size(453, 20);
            this.txtFirstName.StyleController = this.BoxStyles;
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.EditValueChanged += new System.EventHandler(this.txtFirstName_EditValueChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(14, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(51, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // txtNetworkID
            // 
            this.txtNetworkID.Location = new System.Drawing.Point(138, 33);
            this.txtNetworkID.Name = "txtNetworkID";
            this.txtNetworkID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNetworkID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNetworkID.Properties.Appearance.Options.UseBackColor = true;
            this.txtNetworkID.Properties.Appearance.Options.UseFont = true;
            this.txtNetworkID.Properties.MaxLength = 100;
            this.txtNetworkID.Size = new System.Drawing.Size(453, 20);
            this.txtNetworkID.StyleController = this.BoxStyles;
            this.txtNetworkID.TabIndex = 6;
            this.txtNetworkID.EditValueChanged += new System.EventHandler(this.txtNetworkID_EditValueChanged);
            // 
            // lblNetworkID
            // 
            this.lblNetworkID.Location = new System.Drawing.Point(14, 36);
            this.lblNetworkID.Name = "lblNetworkID";
            this.lblNetworkID.Size = new System.Drawing.Size(54, 13);
            this.lblNetworkID.TabIndex = 1;
            this.lblNetworkID.Text = "Network ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(588, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstApplications
            // 
            this.lstApplications.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lstApplications.Appearance.Options.UseFont = true;
            this.lstApplications.AvailableDataSource = null;
            this.lstApplications.AvailableDisplayMember = "";
            this.lstApplications.AvailablePrompt = "Unassigned";
            this.lstApplications.AvailableValueMember = "";
            this.lstApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstApplications.Location = new System.Drawing.Point(0, 0);
            this.lstApplications.Margin = new System.Windows.Forms.Padding(0);
            this.lstApplications.Name = "lstApplications";
            this.lstApplications.ReadOnly = false;
            this.lstApplications.SelectedDataSource = null;
            this.lstApplications.SelectedDisplayMember = "";
            this.lstApplications.SelectedPrompt = "Assigned";
            this.lstApplications.SelectedValueMember = "";
            this.lstApplications.Size = new System.Drawing.Size(637, 189);
            this.lstApplications.TabIndex = 1;
            // 
            // lstMenuOptions
            // 
            this.lstMenuOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMenuOptions.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lstMenuOptions.Appearance.Options.UseFont = true;
            this.lstMenuOptions.DataSource = null;
            this.lstMenuOptions.DisplayMember = "";
            this.lstMenuOptions.Location = new System.Drawing.Point(2, 23);
            this.lstMenuOptions.Margin = new System.Windows.Forms.Padding(0);
            this.lstMenuOptions.Name = "lstMenuOptions";
            this.lstMenuOptions.Size = new System.Drawing.Size(306, 163);
            this.lstMenuOptions.StyleControler = null;
            this.lstMenuOptions.TabIndex = 1;
            this.lstMenuOptions.ValueMember = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(450, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(519, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 187);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpApplications;
            this.xtraTabControl1.Size = new System.Drawing.Size(643, 218);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpApplications,
            this.tpEnvironments,
            this.tpMenuOptions});
            // 
            // tpApplications
            // 
            this.tpApplications.Controls.Add(this.lstApplications);
            this.tpApplications.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tpApplications.Name = "tpApplications";
            this.tpApplications.Size = new System.Drawing.Size(637, 189);
            this.tpApplications.Text = "Applications";
            // 
            // tpEnvironments
            // 
            this.tpEnvironments.Controls.Add(this.lstEnvironments);
            this.tpEnvironments.Name = "tpEnvironments";
            this.tpEnvironments.Size = new System.Drawing.Size(637, 189);
            this.tpEnvironments.Text = "Environments";
            // 
            // lstEnvironments
            // 
            this.lstEnvironments.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lstEnvironments.Appearance.Options.UseFont = true;
            this.lstEnvironments.AvailableDataSource = null;
            this.lstEnvironments.AvailableDisplayMember = "";
            this.lstEnvironments.AvailablePrompt = "Unassigned";
            this.lstEnvironments.AvailableValueMember = "";
            this.lstEnvironments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEnvironments.Location = new System.Drawing.Point(0, 0);
            this.lstEnvironments.Margin = new System.Windows.Forms.Padding(0);
            this.lstEnvironments.Name = "lstEnvironments";
            this.lstEnvironments.ReadOnly = false;
            this.lstEnvironments.SelectedDataSource = null;
            this.lstEnvironments.SelectedDisplayMember = "";
            this.lstEnvironments.SelectedPrompt = "Assigned";
            this.lstEnvironments.SelectedValueMember = "";
            this.lstEnvironments.Size = new System.Drawing.Size(637, 189);
            this.lstEnvironments.TabIndex = 2;
            // 
            // tpMenuOptions
            // 
            this.tpMenuOptions.Controls.Add(this.splitContainerControl1);
            this.tpMenuOptions.Name = "tpMenuOptions";
            this.tpMenuOptions.Size = new System.Drawing.Size(637, 189);
            this.tpMenuOptions.Text = "Menu Options";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lstApplicationTabs);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblApps);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.lblDisabledOptions);
            this.splitContainerControl1.Panel2.Controls.Add(this.lstMenuOptions);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(637, 189);
            this.splitContainerControl1.SplitterPosition = 321;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            this.splitContainerControl1.Resize += new System.EventHandler(this.splitContainerControl1_Resize);
            // 
            // lstApplicationTabs
            // 
            this.lstApplicationTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstApplicationTabs.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstApplicationTabs.Appearance.Options.UseFont = true;
            this.lstApplicationTabs.Location = new System.Drawing.Point(4, 23);
            this.lstApplicationTabs.Margin = new System.Windows.Forms.Padding(0);
            this.lstApplicationTabs.Name = "lstApplicationTabs";
            this.lstApplicationTabs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstApplicationTabs.Size = new System.Drawing.Size(315, 159);
            this.lstApplicationTabs.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstApplicationTabs.TabIndex = 1;
            this.lstApplicationTabs.SelectedIndexChanged += new System.EventHandler(this.lstApplicationTabs_SelectedIndexChanged);
            // 
            // lblApps
            // 
            this.lblApps.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApps.Location = new System.Drawing.Point(7, 6);
            this.lblApps.Name = "lblApps";
            this.lblApps.Size = new System.Drawing.Size(162, 14);
            this.lblApps.TabIndex = 0;
            this.lblApps.Text = "Authorised Application / Tabs";
            // 
            // lblDisabledOptions
            // 
            this.lblDisabledOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisabledOptions.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDisabledOptions.Location = new System.Drawing.Point(212, 6);
            this.lblDisabledOptions.Name = "lblDisabledOptions";
            this.lblDisabledOptions.Size = new System.Drawing.Size(93, 14);
            this.lblDisabledOptions.TabIndex = 0;
            this.lblDisabledOptions.Text = "Disabled Options";
            // 
            // UserMaintenance
            // 
            this.AcceptButton = this.btnSearch;
            this.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(663, 502);
            this.Name = "UserMaintenance";
            this.Text = "User Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).EndInit();
            this.ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUserDetails)).EndInit();
            this.grpUserDetails.ResumeLayout(false);
            this.grpUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetworkID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpApplications.ResumeLayout(false);
            this.tpEnvironments.ResumeLayout(false);
            this.tpMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstApplicationTabs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpUserDetails;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private Shared.Controls.ListMover lstApplications;
        private Shared.Controls.ListEditor lstMenuOptions;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtNetworkID;
        private DevExpress.XtraEditors.LabelControl lblNetworkID;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpApplications;
        private DevExpress.XtraTab.XtraTabPage tpEnvironments;
        private DevExpress.XtraTab.XtraTabPage tpMenuOptions;
        private Shared.Controls.ListMover lstEnvironments;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LabelControl lblLastName;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ListBoxControl lstApplicationTabs;
        private DevExpress.XtraEditors.LabelControl lblApps;
        private DevExpress.XtraEditors.LabelControl lblDisabledOptions;
    }
}
