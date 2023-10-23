namespace FlashFrenzy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }


        public class CardInfo
        {
            public string word { get; set; }
            public string definition { get; set; }
            int confidence { get; set; } //Ranges from 1 to 10 (1 being the least amount of knowledge).

            public CardInfo(string w, string d)
            {
                word = w;
                definition = d;
                confidence = 5; //Confidence defaults to 5. Will go up or down depending on user's knowledge level.
            }
        }
    }
}