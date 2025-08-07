using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebViewSys
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string url = "https://google.com";
            bool hideTitlebar = false;
            bool kiosk = false;
            string iconPath = null;
            string windowTitle = "WebViewSys";
            Size? customSize = null;

            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i].ToLower();

                if (arg == "--notitlebar") hideTitlebar = true;
                else if (arg == "--kiosk") kiosk = true;
                else if (arg == "--title" && i + 1 < args.Length) windowTitle = args[++i];
                else if (arg == "--size" && i + 1 < args.Length)
                {
                    string[] dims = args[++i].Split('x');
                    if (dims.Length == 2 &&
                        int.TryParse(dims[0], out int width) &&
                        int.TryParse(dims[1], out int height))
                    {
                        customSize = new Size(width, height);
                    }
                }
                else if (arg.EndsWith(".ico") && System.IO.File.Exists(args[i])) iconPath = args[i];
                else if (Uri.IsWellFormedUriString(args[i], UriKind.Absolute)) url = args[i];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(url, hideTitlebar, kiosk, iconPath, windowTitle, customSize));
        }
    }
}
