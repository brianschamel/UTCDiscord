namespace DiscordUTC
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.CopyUTC = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datePicker.Location = new System.Drawing.Point(12, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            // 
            // CopyUTC
            // 
            this.CopyUTC.Location = new System.Drawing.Point(5, 64);
            this.CopyUTC.Name = "CopyUTC";
            this.CopyUTC.Size = new System.Drawing.Size(200, 50);
            this.CopyUTC.TabIndex = 1;
            this.CopyUTC.Text = "Copy UTC Data";
            this.CopyUTC.UseVisualStyleBackColor = true;
            this.CopyUTC.Click += new System.EventHandler(this.CopyUTC_Click);
            // 
            // dateTimePicker1
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePicker.Location = new System.Drawing.Point(12, 38);
            this.timePicker.Name = "dateTimePicker1";
            this.timePicker.Size = new System.Drawing.Size(200, 20);
            this.timePicker.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 126);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.CopyUTC);
            this.Controls.Add(this.datePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button CopyUTC;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}

