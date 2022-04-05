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
            if (!IsPostBack)    // we want to get this function fire just one time
            {
                Random random = new Random();
                int randomNumber = random.Next(0, databaseManager.IdsOfWords().Count);
                int randomIdNumber = databaseManager.IdsOfWords()[randomNumber];
                string randomWord = databaseManager.FindWordById(randomIdNumber);   //**
                string hintOfRandomWord = databaseManager.FindHintById(randomIdNumber); //**
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == ' ')
                    {
                        lblPredictDisplayer.Text += "- ";
                    }
                    else
                    {
                        lblPredictDisplayer.Text += "_ ";
                    }
                }
                lblRandomWord.Text = randomWord;
                lblHintOfRandomWord.Text = "Hint : " + hintOfRandomWord;
            }
        }

        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Constant.counter = 0;
            Response.Redirect(Constant.HomeUrl);
        }

        public string PlaceCharsInPredictDisplayer(string randomWord, string predictDisplayer, Button button)
        {
            bool selectedCharIsTrue = false;
            char[] ch = predictDisplayer.ToCharArray();
            for (int i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i] == char.Parse(button.Text.ToLower()))
                {
                    selectedCharIsTrue = true;
                    ch[2 * i] = char.Parse(button.Text.ToLower());
                }
            }
            if (selectedCharIsTrue == false)
            {
                Constant.counter++;
            }
            predictDisplayer = new string(ch);
            button.Enabled = false;
            SituationOfTheMan(Constant.counter);
            if (IsGameDone(predictDisplayer))
            {
                Response.Redirect(Constant.GameOverFormUrl + "?isGameDoneSuccessfully=true");
            }
            return predictDisplayer.ToUpper();
        }

        public bool IsGameDone(string predictDisplayer)
        {
            for (int i = 0; i < predictDisplayer.Length; i++)
            {
                if (predictDisplayer[i] == '_')
                {
                    return false;
                }
            }
            return true;
        }

        public void SituationOfTheMan(int wrongGuessCounter)
        {
            if (wrongGuessCounter == 1)
            {
                img0.Visible = false;
                img1.Visible = true;
            }
            else if (wrongGuessCounter == 2)
            {
                img1.Visible = false;
                img2.Visible = true;
            }
            else if (wrongGuessCounter == 3)
            {
                img2.Visible = false;
                img3.Visible = true;
            }
            else if (wrongGuessCounter == 4)
            {
                img3.Visible = false;
                img4.Visible = true;
            }
            else if (wrongGuessCounter == 5)
            {
                img4.Visible = false;
                img5.Visible = true;
            }
            else if (wrongGuessCounter == 6)
            {
                img5.Visible = false;
                img6.Visible = true;
            }
            else if (wrongGuessCounter == 7)
            {
                img6.Visible = false;
                img7.Visible = true;
            }
            else if (wrongGuessCounter == 8)
            {
                img7.Visible = false;
                img8.Visible = true;
            }
            else if (wrongGuessCounter == 9)
            {
                img8.Visible = false;
                img9.Visible = true;
                Constant.counter = 0;
                Response.Redirect(Constant.GameOverFormUrl + "?isGameDoneSuccessfully=false" + "&askedWord=" + lblRandomWord.Text);
            }
        }

        protected void timer_Tick(object sender, EventArgs e)
        {
            string randomWord = lblRandomWord.Text;
            int timer = Convert.ToInt32(lblTimer.Text);
            timer += 1;
            lblTimer.Text = timer.ToString();
            if (timer == 30)
            {
                Response.Redirect(Constant.GameOverFormUrl + "?isGameDoneSuccessfully=false" + "&askedWord=" + randomWord);
            }
        }

        protected void btnA_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnA);
        }

        protected void btnB_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnB);
        }
        protected void btnC_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnC);
        }

        protected void btnÇ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnÇ);
        }

        protected void btnD_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnD);
        }

        protected void btnE_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnE);
        }

        protected void btnF_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnF);
        }

        protected void btnG_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnG);
        }

        protected void btnĞ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnĞ);
        }

        protected void btnH_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnH);
        }

        protected void btnI_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnI);
        }

        protected void btnİ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnİ);
        }

        protected void btnJ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnJ);
        }

        protected void btnK_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnK);
        }

        protected void btnL_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnL);
        }

        protected void btnM_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnM);
        }

        protected void btnN_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnN);
        }

        protected void btnO_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnO);
        }

        protected void btnÖ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnÖ);
        }

        protected void btnP_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnP);
        }

        protected void btnR_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnR);
        }

        protected void btnS_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnS);
        }

        protected void btnŞ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnŞ);
        }

        protected void btnT_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnT);
        }

        protected void btnU_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnU);
        }

        protected void btnÜ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnÜ);
        }

        protected void btnV_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnV);
        }

        protected void btnY_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnY);
        }

        protected void btnZ_Click(object sender, EventArgs e)
        {
            lblPredictDisplayer.Text = PlaceCharsInPredictDisplayer(lblRandomWord.Text, lblPredictDisplayer.Text, btnZ);
        }
    }
}