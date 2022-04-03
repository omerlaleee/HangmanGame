using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _152120181039_HW2.Constants
{
    public static class Constant
    {
        // URLs
        public static string HomeUrl = "Home.aspx";
        public static string GameFormUrl = "GameForm.aspx";
        public static string SettingsFormUrl = "SettingsForm.aspx";

        // Global Variables
        public static int counter = 0;

        // Errors
        public static string BothFieldsNeedToBeFilledError = "Kelime eklemek için iki alanı da doldurmanız gerekir!";
        public static string ChooseADataToDeleteError = "Kelime silmek için soldaki listeden bir kelime seçiniz!";
        public static string SameWordError = "Aynı kelimeyi bir daha ekleyemezsiniz!";
        
        // Informations
        public static string WrongGuessCount = "Yanlış Tahmin Sayısı : ";

        // Database Connection String
        public static string ConnectionString = @"Server=OMER;Database=HW2;Trusted_Connection=True";

    }
}