
using VkNet.Model;
using Application = System.Windows.Forms.Application;

namespace vk
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

            

            // Application.Run(new Form2());

            if (TokenWorker.LoadToken() != "nope")
            {
                VKAuth va = new VKAuth();

                dynamic api;//va.TokenAuth(TokenWorker.LoadToken());
                try
                {
                    va.TokenAuth(TokenWorker.LoadToken());
                    Application.Run(new Form2(va.TokenAuth(TokenWorker.LoadToken())));
                }
                catch
                {
                    Application.Run(new Form1());
                }

                






            }
            else {
                Application.Run(new Form1());
            }
        }

        
    }
}