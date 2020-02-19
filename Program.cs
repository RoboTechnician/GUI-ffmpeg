using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GUIffmpeg
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var proc = Process.Start(@"C:\Users\HOME\ffmpeg\bin\ffmpeg.exe", "-ss 4:58.5 -i \"F:\\Harukana Receive\\[HorribleSubs] Harukana Receive - 01 [1080p].mkv\" -t 6.5 -c:v vp9 -b:v 4M -pass 1 -c:a libopus -f webm NUL");
            //proc.Exited += (s, e) => Process.Start(@"C:\Users\HOME\ffmpeg\bin\ffmpeg.exe", "-ss 4:58.5 -i \"F:\\Harukana Receive\\[HorribleSubs] Harukana Receive - 01 [1080p].mkv\" -t 6.5 -c:v vp9 -b:v 4M -pass 2 -c:a libopus output1.webm");
            //while (!proc.HasExited) { }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
