using _152120181039_HW2.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _152120181039_HW2.Forms
{
    public partial class GameOverForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string infoAtTheEndOfGame = Request.QueryString["isGameDoneSuccessfully"];
            string askedWord = Request.QueryString["askedWord"];
            if (infoAtTheEndOfGame == "true")
            {
                lblInfoAtTheEndOfGame.Text = Constant.GameDoneSuccessfully;
            }
            if (infoAtTheEndOfGame == "false")
            {
                lblInfoAtTheEndOfGame.Text = Constant.GameDoneNotSuccessfully + askedWord.ToUpper();
            }
        }

        protected void btnPlayAgain_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Constant.GameFormUrl);
        }

        protected void btnHomePage_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(Constant.HomeUrl);
        }
    }
}