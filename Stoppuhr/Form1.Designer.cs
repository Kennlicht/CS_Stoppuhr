namespace Stoppuhr
{
   partial class mainForm
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
         this.startButton = new System.Windows.Forms.Button();
         this.stoppButton = new System.Windows.Forms.Button();
         this.resetButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // startButton
         // 
         this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.startButton.Location = new System.Drawing.Point(16, 144);
         this.startButton.Name = "startButton";
         this.startButton.Size = new System.Drawing.Size(75, 23);
         this.startButton.TabIndex = 0;
         this.startButton.Text = "Start";
         this.startButton.UseVisualStyleBackColor = true;
         this.startButton.Click += new System.EventHandler(this.startButton_Click);
         // 
         // stoppButton
         // 
         this.stoppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.stoppButton.Enabled = false;
         this.stoppButton.Location = new System.Drawing.Point(113, 144);
         this.stoppButton.Name = "stoppButton";
         this.stoppButton.Size = new System.Drawing.Size(75, 23);
         this.stoppButton.TabIndex = 1;
         this.stoppButton.Text = "Stop";
         this.stoppButton.UseVisualStyleBackColor = true;
         this.stoppButton.Click += new System.EventHandler(this.stopButton_Click);
         // 
         // resetButton
         // 
         this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.resetButton.Enabled = false;
         this.resetButton.Location = new System.Drawing.Point(208, 144);
         this.resetButton.Name = "resetButton";
         this.resetButton.Size = new System.Drawing.Size(75, 23);
         this.resetButton.TabIndex = 2;
         this.resetButton.Text = "Reset";
         this.resetButton.UseVisualStyleBackColor = true;
         this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(13, 26);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(274, 51);
         this.label1.TabIndex = 3;
         this.label1.Text = "00:00:00,000";
         // 
         // progressBar1
         // 
         this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.progressBar1.Location = new System.Drawing.Point(15, 101);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(270, 23);
         this.progressBar1.TabIndex = 4;
         // 
         // timer1
         // 
         this.timer1.Interval = 50;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // mainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(300, 185);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.resetButton);
         this.Controls.Add(this.stoppButton);
         this.Controls.Add(this.startButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "mainForm";
         this.Text = "Stoppuhr";
         this.Load += new System.EventHandler(this.mainForm_Load);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_Closed);
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_Closing);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button startButton;
      private System.Windows.Forms.Button stoppButton;
      private System.Windows.Forms.Button resetButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.Timer timer1;
   }
}

