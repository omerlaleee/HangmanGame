using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _152120181039_HW2.Constants
{
    public static class Constant
    {
        // Database Connection String
        public static string ConnectionString = @"Server=OMER;Database=HW2;Trusted_Connection=True";

        // URLs
        public static string HomeUrl = "Home.aspx";
        public static string GameFormUrl = "GameForm.aspx";
        public static string SettingsFormUrl = "SettingsForm.aspx";
        public static string GameOverFormUrl = "GameOverForm.aspx";

        // Global Variables
        public static int counter = 0;
        public static int timer = 0;

        // Errors
        public static string BothFieldsNeedToBeFilledError = "You have to fill both textboxes to add new word!";
        public static string ChooseADataToDeleteError = "Please select a word from the list to delete it!";
        public static string SameWordError = "The word that you wanted to add is already exist in the database!";

        // Informations
        public static string WrongGuessCount = "Wrong Guess Count : ";
        public static string GameDoneSuccessfully = "CONGRATULATIONS! YOU GUESSED THE WORD CORRECTLY...";
        public static string GameDoneNotSuccessfully = "GAME OVER!!! THE WORD WAS : ";
        public static string TimeIsOver = "TIME IS UP! THE WORD WAS : ";

        // Database Query Strings
        public static string GetAllFromDB = "Select * from Words";
        public static string InsertDataToDB = "INSERT INTO Words (Word, Hint) Values (@wordName, @hintName)";
        public static string RemoveDataFromDB = "Delete from Words where Word = '";


    }
}