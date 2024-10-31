using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace BFY_TriCorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBTN_Click(object sender, EventArgs e)  //save button write info to files
        {
            DateTime CurDate = DateTime.Now;  //current date
            //path to write files
            string LogPath = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\Brew for You\\BFY TriCorder\\";
            Directory.CreateDirectory(LogPath);  //create LogPath directory if needed
            StreamWriter Temp = File.AppendText(LogPath + "Temperature.csv");  //append to temperature file
            Temp.Write(CurDate.ToShortDateString() + ",");  //write in csv format, date first
            Temp.Write(MorningNUD.Value.ToString() + ",");  //morning temp
            Temp.Write(AfternoonNUD.Value.ToString() + ",CM");  //afternoon temp, and initials
            Temp.WriteLine();  //blank line
            Temp.Flush();
            Temp.Close();  //close stream

            StreamWriter Depo = File.AppendText(LogPath + "Deposit.csv");  //deposit file
            Depo.Write(CurDate.ToShortDateString() + ",CM,");  //date, ititals
            Depo.Write(AmountNUD.Value.ToString());  //amount
            Depo.WriteLine();  //blank line
            Depo.Flush();
            Depo.Close();  //close file
            Application.Exit();  //exit app
        }

        private void ReadBTN_Click(object sender, EventArgs e)  //speak data 
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();  //new speech synth
            DateTime CurDate = DateTime.Now;  //get current date
            synth.Rate = 3;  //speech rate medium
            synth.SpeakAsync("Today is " + CurDate.Date.ToLongDateString());  //read date
            synth.SpeakAsync("Morning Temperature:  " + MorningNUD.Value.ToString() + " degrees.");  //morning temp
            synth.SpeakAsync("Afternoon Temperature:  " + AfternoonNUD.Value.ToString() + " degrees.");  //afternoon temp
            synth.SpeakAsync("Deposit Amount:  $" + AmountNUD.Value.ToString());  //deposit amount
        }
    }  //end class
}  //end namesace