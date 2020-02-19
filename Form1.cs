using System;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUIffmpeg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                inputLabel.Text = inputDialog.FileName;
            }
        }

        public void StartEncoding()
        {
            //var common = "-ss " + ss.ToString("0.00", CultureInfo.InvariantCulture) + " -i \"" + inFile + "\" -t " + t.ToString("0.00", CultureInfo.InvariantCulture) + " -c:v vp9 -b:v " + mBitrate.ToString("0.00", CultureInfo.InvariantCulture) + "M ";
            var common = "-ss " + startTime.Text + " -i \"" + inputDialog.FileName + "\" -t " +
                duration.Text + " -c:v vp9 -b:v " + videoBitrate.Text + "K " + (scaleCheck.Checked ? "-s " + scale.Text + " " : "");
            if (passCheck.Checked)
            {
                var pass1 = common + "-pass 1 -c:a libvorbis -f webm NUL";
                var pass2 = common + "-pass 2 -c:a libvorbis -b:a " + audioBitrate.Text +"K \"" + folderDialog.SelectedPath + "\\" + "output.webm\"";
                var proc = Process.Start(@"C:\Users\HOME\ffmpeg\bin\ffmpeg.exe", pass1);
                while (!proc.HasExited) { }
                Process.Start(@"C:\Users\HOME\ffmpeg\bin\ffmpeg.exe", pass2);
            }
            else
                Process.Start(
                    @"C:\Users\HOME\ffmpeg\bin\ffmpeg.exe",
                    common + "-c:a libvorbis -b:a " + audioBitrate.Text + "K \"" + folderDialog.SelectedPath + "\\" + "output.webm\"");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(inputDialog.FileName) && Directory.Exists(folderDialog.SelectedPath))
            {
                //ss = ((float)int.Parse(sMs.Text) / 1000) + int.Parse(sS.Text) + (int.Parse(sM.Text) * 60) + (int.Parse(startTime.Text) * 60);
                //t = ((float)int.Parse(eMs.Text) / 1000) + int.Parse(eS.Text) + (int.Parse(eM.Text) * 60) + (int.Parse(endTime.Text) * 60) - ss;
                //mBitrate = (float.Parse(size.Text) / t) * 8;
                //inFile = inputDialog.FileName;
                //outFolder = folderDialog.SelectedPath;
                new Thread(StartEncoding).Start();
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                outputLabel.Text = folderDialog.SelectedPath;
            }
        }

        private void ScaleCheckedChanged(object sender, EventArgs e)
        {
            scale.ReadOnly = !scaleCheck.Checked;
        }
    }
}
