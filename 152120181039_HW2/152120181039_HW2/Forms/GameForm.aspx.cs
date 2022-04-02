using _152120181039_HW2.Constants;
using _152120181039_HW2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _152120181039_HW2.Forms
{
    public partial class GameForm : System.Web.UI.Page
    {
        DatabaseManager databaseManager = new DatabaseManager(new DatabaseConnection());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, databaseManager.IdsOfWords().Count);
                int randomIdNumber = databaseManager.IdsOfWords()[randomNumber];
                string randomWord = databaseManager.FindWordById(randomIdNumber);
                foreach (var item in databaseManager.IdsOfWords())
                {
                    lblAllIds.Text += item.ToString() + "\n\n";
                }
                lblWordCount.Text = "Total Word : " + databaseManager.IdsOfWords().Count.ToString();
                lblIdOfRandomWord.Text = randomIdNumber.ToString();
                lblRandomWord.Text = randomWord;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(Messages.HomeUrl);
        }
    }
}