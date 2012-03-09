using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Disney.iDash.LocalData;
using System.Data.Objects;

namespace Disney.iDash.LocalDataManager.Controls
{
    public partial class BrowserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler OnChanged;

        private LocalDataEntities _context = null;
        private BrowserController _browserController = new BrowserController();
        private bool _isDirty = false;

        #region Public methods
        //-----------------------------------------------------------------------------------------
        public BrowserControl()
        {
            InitializeComponent();
        }

        public BrowserController BrowserController
        {
            get { return _browserController; }
            set
            {
                _browserController = value;
                viewItems.OptionsBehavior.Editable = _browserController.AllowEdit;

                if (!_browserController.AllowEdit)
                    bindingNavigator.AddNewItem = null;
            }
        }

        public LocalDataEntities Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public object DataSource
        {
            get { return bindingSource.DataSource; }
            set { bindingSource.DataSource = value; }
        }

        public void RefreshGrid(object data = null)
        {
            try
            {
                if (_context == null)
                    _context = new LocalDataEntities(Session.LocalDataConnection);    

                var currentRow = viewItems.FocusedRowHandle;
                if (data == null)
                    bindingSource.DataSource = _browserController.GetData(_context);
                else
                    bindingSource.DataSource = data;

                _browserController.SetupColumns(viewItems);
                viewItems.BestFitColumns();
                viewItems.FocusedRowHandle = currentRow;

                IsDirty = false;
                btnDelete.Enabled = viewItems.GetFocusedRow() != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public bool Save()
        {
            var saved = false;
            try
            {
                if (_browserController.BeforeSave(_context))
                {
                    _context.DetectChanges();
                    _context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
                    RefreshGrid();
                    saved = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null)
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.InnerException.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saved;
        }

        public bool IsDirty
        {
            get { return _isDirty; }
            set 
            { 
                _isDirty = value;
                btnSave.Enabled = value;

                if (OnChanged != null)
                    OnChanged(this, null);
            }
        }

        public bool SaveButtonVisible
        {
            get { return btnSave.Visible; }
            set { btnSave.Visible = value;}
        }

        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private event handlers
        //-----------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var handles = viewItems.GetSelectedRows();
            for (int handle = handles.Length - 1; handle >= 0; handle--)
                _browserController.DeleteItem(viewItems.GetRow(handles[handle]));

            viewItems.DeleteSelectedRows();
        }

        private void viewItems_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            IsDirty = true;
        }

        private void viewItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void viewItems_RowCountChanged(object sender, EventArgs e)
        {
            IsDirty = true;
        }

        private void Browser_Shown(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void viewItems_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _browserController.EditItem(this, null);
        }

        private void btnDelete_EnabledChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = btnDelete.Enabled;
        }        
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private methods
        //-----------------------------------------------------------------------------------------
        private void Edit()
        {
            if (viewItems.SelectedRowsCount > 1)
            {
                List<object> selection = new List<object>();
                foreach (var rowHandle in viewItems.GetSelectedRows())
                    selection.Add(viewItems.GetRow(rowHandle));

                _browserController.EditMultiple(this, selection);
            }
            else
                _browserController.EditItem(this, viewItems.GetFocusedRow());
        }
        //-----------------------------------------------------------------------------------------
        #endregion
    }
}
