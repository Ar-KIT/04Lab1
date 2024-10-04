namespace BasicThread
{
    partial class FrmBasicThread
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
            this.lblThreadStatus = new System.Windows.Forms.Label();
            this.btnRunThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThreadStatus
            // 
            this.lblThreadStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblThreadStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadStatus.Location = new System.Drawing.Point(21, 30);
            this.lblThreadStatus.Name = "lblThreadStatus";
            this.lblThreadStatus.Size = new System.Drawing.Size(355, 40);
            this.lblThreadStatus.TabIndex = 0;
            this.lblThreadStatus.Text = "- Before starting thread -";
            this.lblThreadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRunThread
            // 
            this.btnRunThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunThread.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRunThread.Location = new System.Drawing.Point(132, 120);
            this.btnRunThread.Name = "btnRunThread";
            this.btnRunThread.Size = new System.Drawing.Size(135, 45);
            this.btnRunThread.TabIndex = 1;
            this.btnRunThread.Text = "Run";
            this.btnRunThread.UseVisualStyleBackColor = true;
            this.btnRunThread.Click += new System.EventHandler(this.btnRunThread_Click);
            // 
            // FrmBasicThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 199);
            this.Controls.Add(this.btnRunThread);
            this.Controls.Add(this.lblThreadStatus);
            this.Name = "FrmBasicThread";
            this.Text = "BasicThread";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThreadStatus;
        private System.Windows.Forms.Button btnRunThread;
    }
}

