using System;
using System.Windows.Forms;

namespace FlashFrenzy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            // Create an instance of the main form (Home in your case)
            Home mainForm = new Home();

            // Handle the FormClosing event of the main form to ensure the application exits gracefully
            mainForm.FormClosing += (sender, e) =>
            {
                // Check if the form is closing by user action (X button)
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    // Prevent the default form closing behavior (closing the form)
                    e.Cancel = true;

                    // Perform any cleanup or save operations if needed

                    // Exit the application
                    Application.Exit();
                }
            };

            // Start the application by showing the main form
            Application.Run(mainForm);
        }
    }
}
