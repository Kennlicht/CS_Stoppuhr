using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Stoppuhr
{
   public partial class mainForm : Form
   {
      //bool Running = false;
      Stopwatch stopwatch = new Stopwatch();

      public mainForm()
      {
         InitializeComponent();
      }

      private void mainForm_Load(object sender, EventArgs e)
      {
         // Worker-Thread initialisieren und starten...
      }

      private void mainForm_Closing(object sender, FormClosingEventArgs e)
      {
         // Worker-Thread beenden...
      }

      private void mainForm_Closed(object sender, FormClosedEventArgs e)
      {
         // Worker-Thread beenden...
      }

      private void startButton_Click(object sender, EventArgs e)
      {
         startButton.Enabled = false;
         stoppButton.Enabled = true;
         stoppButton.Focus();
         
         stopwatch.Start();
         timer1.Start();
         //Running = true;

         UpdateDisplay();
      }

      private void stopButton_Click(object sender, EventArgs e)
      {
         startButton.Enabled = true;
         stoppButton.Enabled = false;
         resetButton.Enabled = true;
         resetButton.Focus();
         
         stopwatch.Stop();
         timer1.Stop();
         //Running = false;

         UpdateDisplay();
      }

      private void resetButton_Click(object sender, EventArgs e)
      {
         startButton.Enabled = true;
         stoppButton.Enabled = false;
         resetButton.Enabled = false;
         startButton.Focus();

         stopwatch.Reset();
         UpdateDisplay();
      }

      void UpdateDisplay()
      {
         double elapsed = stopwatch.ElapsedMilliseconds;

         int Hours = TimeSpan.FromMilliseconds(elapsed).Hours;
         int Minutes = TimeSpan.FromMilliseconds(elapsed).Minutes;
         int Seconds = TimeSpan.FromMilliseconds(elapsed).Seconds;
         int Millis = TimeSpan.FromMilliseconds(elapsed).Milliseconds;

         label1.Text = Hours.ToString("0#")
                     + ":" + Minutes.ToString("0#")
                     + ":" + Seconds.ToString("0#")
                     + "," + Millis.ToString("0##");

         double percent = (elapsed / 60000) * 100;
         progressBar1.Value = (int)percent % 100;
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         UpdateDisplay();
      }


   }
}
