using _152120181039_HW2.Constants;
using _152120181039_HW2.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _152120181039_HW2.Forms
{
    public partial class SettingsForm : System.Web.UI.Page
    {
        DatabaseManager databaseManager = new DatabaseManager(new DatabaseConnection());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)    // we want to get this function fire just one time
            {
                refreshListBox();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.HomeUrl);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxAddedWord.Text == "" || txtBoxHintOfAddedWord.Text == "")
            {
                lblErrorMessage.Text = Constant.BothFieldsNeedToBeFilledError;
            }
            else
            {
                lblErrorMessage.Text = "";
                databaseManager.Add(txtBoxAddedWord.Text.ToLower(), txtBoxHintOfAddedWord.Text, lblErrorMessage);
                refreshListBox();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            if (lstBoxWords.SelectedItem != null)
            {
                databaseManager.Delete(lstBoxWords.SelectedItem.Text);
                refreshListBox();
            }
            else
            {
                lblErrorMessage.Text = Constant.ChooseADataToDeleteError;
            }
        }

        public void refreshListBox()
        {
            lstBoxWords.Items.Clear();
            foreach (var item in databaseManager.GetAll())
            {
                lstBoxWords.Items.Add(item);
            }
            txtBoxAddedWord.Text = "";
            txtBoxHintOfAddedWord.Text = "";
        }
    }
}