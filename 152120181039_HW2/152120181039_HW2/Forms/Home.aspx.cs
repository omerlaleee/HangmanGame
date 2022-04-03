using _152120181039_HW2.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _152120181039_HW2.Forms
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStartGame_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.GameFormUrl);
        }

        protected void btnSettings_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.SettingsFormUrl);
        }
    }
}