namespace WindowsFormsAppDinamick
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumUpDX = new System.Windows.Forms.NumericUpDown();
            this.NumUpDY = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.gombPanel = new System.Windows.Forms.Panel();
            this.mentesButton = new System.Windows.Forms.Button();
            this.beolvasasButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDY)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUpDX
            // 
            this.NumUpDX.Location = new System.Drawing.Point(23, 28);
            this.NumUpDX.Name = "NumUpDX";
            this.NumUpDX.Size = new System.Drawing.Size(58, 20);
            this.NumUpDX.TabIndex = 0;
            // 
            // NumUpDY
            // 
            this.NumUpDY.Location = new System.Drawing.Point(23, 65);
            this.NumUpDY.Name = "NumUpDY";
            this.NumUpDY.Size = new System.Drawing.Size(58, 20);
            this.NumUpDY.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gombPanel
            // 
            this.gombPanel.Location = new System.Drawing.Point(123, 28);
            this.gombPanel.Name = "gombPanel";
            this.gombPanel.Size = new System.Drawing.Size(665, 410);
            this.gombPanel.TabIndex = 3;
            // 
            // mentesButton
            // 
            this.mentesButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mentesButton.Cursor = System.Windows.Forms.Cursors.No;
            this.mentesButton.Location = new System.Drawing.Point(12, 141);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(75, 23);
            this.mentesButton.TabIndex = 4;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
            // 
            // beolvasasButt
            // 
            this.beolvasasButt.Location = new System.Drawing.Point(12, 180);
            this.beolvasasButt.Name = "beolvasasButt";
            this.beolvasasButt.Size = new System.Drawing.Size(75, 23);
            this.beolvasasButt.TabIndex = 5;
            this.beolvasasButt.Text = "Beolvasás";
            this.beolvasasButt.UseVisualStyleBackColor = true;
            this.beolvasasButt.Click += new System.EventHandler(this.beolvasasButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beolvasasButt);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.gombPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumUpDY);
            this.Controls.Add(this.NumUpDX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUpDX;
        private System.Windows.Forms.NumericUpDown NumUpDY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel gombPanel;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Button beolvasasButt;
    }
}

