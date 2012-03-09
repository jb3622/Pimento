using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using Disney.iDash.LocalData;
using DevExpress.XtraGrid.Columns;
using Disney.iDash.LocalDataManager.Controls;
using System.Data.Objects;

namespace Disney.iDash.LocalDataManager
{
    public class BrowserController
    {
        public string Caption { get; set; }
        public bool AllowEdit { get; set; }

        public BrowserController()
        {
            Caption = "CHANGE THE CAPTION";
            AllowEdit = true;
        }

        public virtual object GetData(LocalDataEntities context)
        {
            return null;
        }

        public virtual void SetupColumns(GridView view)
        {
        }

        public virtual void DeleteItem(object row)
        {
        }

        public virtual void EditMultiple(BrowserControl browser, List<object> selection)
        {
        }

        public virtual void EditItem(BrowserControl browser, object row)
        {
        }

        public virtual bool BeforeSave(LocalDataEntities context)
        {
            return true;
        }

    }

    public class ApplicationBrowserInfo : BrowserController
    {
        public ApplicationBrowserInfo()
        {
            AllowEdit = false;
            Caption = "Applications";
        }

        public override object GetData(LocalDataEntities context)
        {
            context.Refresh(RefreshMode.StoreWins, context.eApplications);
            var qry = from a in context.eApplications
                      orderby a.ApplicationName
                      select a;

            return qry.AsEnumerable();
        }

        public override bool BeforeSave(LocalDataEntities context)
        {
            var result = true;

            foreach (var app in context.eApplications)
                if (app.EntityState == System.Data.EntityState.Deleted)
                {
                    foreach (var option in context.eMenuOptions)
                        if (option.ApplicationId == app.Id)
                            context.DeleteObject(option);                       

                    foreach (var option in app.vMenuOptions)
                    {
                        foreach (var user in option.vUsers)
                            context.DeleteObject(user);
                        context.DeleteObject(option);
                    }
                    foreach (var user in app.vUsers)
                    {
                        foreach (var option in user.vMenuOptions)
                            context.DeleteObject(option);
                        context.DeleteObject(user);
                    }
                    context.DeleteObject(app);
                }
            return result;
        }

        public override void SetupColumns(GridView view)
        {
            base.SetupColumns(view);
            foreach (GridColumn col in view.Columns)
                switch (col.FieldName)
                {
                    case "Id":
                        col.OptionsColumn.AllowEdit = false;
                        break;

                    case "vMenuOptions":
                        col.Visible = false;
                        col.OptionsColumn.ShowInCustomizationForm = false;
                        break;

                    case "vUsers":
                        col.Visible = false;
                        col.OptionsColumn.ShowInCustomizationForm = false;
                        break;
                }
        }

        public override void EditItem(BrowserControl browser, object row)
        {
            var frm = new Forms.ApplicationDetailsForm();
            frm.ShowForm(browser, row);
        }

        public override void DeleteItem(object row)
        {
            if (row != null)
            {
                var item = (eApplication)row;
                item.vMenuOptions.Clear();
                item.vMenuOptions.Clear();
                item.vUsers.Clear();
            }
        }
    }

    public class EnvironmentBrowserInfo : BrowserController
    {
        public EnvironmentBrowserInfo()
        {
            Caption = "Environments";
        }

        public override object GetData(LocalDataEntities context)
        {
            context.Refresh(RefreshMode.StoreWins, context.eEnvironments);
            var qry = from e in context.eEnvironments
                      orderby e.EnvironmentName
                      select e;

            return qry.AsQueryable();
        }

        public override void SetupColumns(GridView view)
        {
            base.SetupColumns(view);
            foreach (var fieldName in new string[] { "Id", "vUsers" })
            {
                var col = view.Columns.ColumnByFieldName(fieldName);
                if (col != null)
                {
                    col.Visible = false;
                    col.OptionsColumn.ShowInCustomizationForm = false;
                }
            }
        }
    }

    public class UserBrowserInfo : BrowserController
    {
        public UserBrowserInfo()
        {
            Caption = "Users";
            AllowEdit = false;
        }

        public override object GetData(LocalDataEntities context)
        {
            context.Refresh(RefreshMode.StoreWins, context.eUsers);

            var qry = from u in context.eUsers
                      orderby u.Firstname, u.Lastname
                      select u;

            return qry.AsEnumerable();
        }

        public override void SetupColumns(GridView view)
        {
            base.SetupColumns(view);           

            foreach (GridColumn col in view.Columns)
                switch (col.FieldName)
                {
                    case "Id":
                        col.Caption = "Id";
                        col.Visible = false;
                        col.OptionsColumn.ShowInCustomizationForm = false;
                        col.VisibleIndex=0;
                        break;

                    case "Active":
                        col.VisibleIndex=1;
                        break;

                    case "NetworkId":
                        col.VisibleIndex=2;
                        break;

                    case "Fullname":
                        col.VisibleIndex=3;
                        break;

                    case "DisplayName":
                        col.VisibleIndex=4;
                        break;

                    case "Firstname":
                        col.VisibleIndex=5;
                        break;

                    case "Lastname":
                        col.VisibleIndex=6;
                        break;

                    case "eMail":
                        col.VisibleIndex=7;
                        break;

                    case "Department":
                        col.VisibleIndex=8;
                        break;

                    case "Team":
                        col.VisibleIndex=9;
                        break;

                    case "ApplicationCount":
                        col.Caption = "Applications";
                        col.VisibleIndex=10;
                        break;

                    case "EnvironmentCount":
                        col.Caption = "Environments";
                        col.VisibleIndex=11;
                        break;

                    case "MenuOptionCount":
                        col.Caption = "Restricted Menus";
                        col.VisibleIndex=12;
                        break;

                    case "vApplications":
                    case "vEnvironments":
                    case "vMenuOptions":
                        col.Visible = false;
                        col.OptionsColumn.ShowInCustomizationForm = false;
                        break;

                }           

        }

        public override void EditMultiple(BrowserControl browser, List<object> selection)
        {
            var frm = new Forms.UserPermissionsForm();
            frm.ShowForm(browser, selection);
        }

        public override void EditItem(BrowserControl browser, object row)
        {
            var frm = new Forms.UserDetailsForm();
            frm.ShowForm(browser, row);
        }

        public override void DeleteItem(object row)
        {
            if (row != null)
            {
                var item = (eUser)row;
                item.vMenuOptions.Clear();
                item.vApplications.Clear();
                item.vEnvironments.Clear();
            }
            
        }
    }

    public class MenuOptionBrowserInfo : BrowserController
    {
        public MenuOptionBrowserInfo()
        {
            Caption = "Menu Options";          
        }
        
        public override void SetupColumns(GridView view)
        {
            base.SetupColumns(view);
            foreach (var fieldName in new string[] { "Id", "ApplicationId", "vApplication", "vUsers" })
            {
                var col = view.Columns.ColumnByFieldName(fieldName);
                if (col != null)
                {
                    col.Visible = false;
                    col.OptionsColumn.ShowInCustomizationForm = false;
                }
            }
        }
    }
}
