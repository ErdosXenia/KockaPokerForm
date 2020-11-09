namespace KockaPokerForm
{
    partial class frmKezdo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKezdo));
            this.btnHarom = new System.Windows.Forms.Button();
            this.btnOt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHarom
            // 
            this.btnHarom.Location = new System.Drawing.Point(53, 153);
            this.btnHarom.Name = "btnHarom";
            this.btnHarom.Size = new System.Drawing.Size(75, 32);
            this.btnHarom.TabIndex = 0;
            this.btnHarom.Text = "3";
            this.btnHarom.UseVisualStyleBackColor = true;
            this.btnHarom.Click += new System.EventHandler(this.btnHarom_Click);
            // 
            // btnOt
            // 
            this.btnOt.Location = new System.Drawing.Point(243, 153);
            this.btnOt.Name = "btnOt";
            this.btnOt.Size = new System.Drawing.Size(75, 32);
            this.btnOt.TabIndex = 1;
            this.btnOt.Text = "5";
            this.btnOt.UseVisualStyleBackColor = true;
            this.btnOt.Click += new System.EventHandler(this.btnOt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Választható körök száma:";
            // 
            // frmKezdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOt);
            this.Controls.Add(this.btnHarom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKezdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezdő Képernyő";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKezdo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHarom;
        private System.Windows.Forms.Button btnOt;
        private System.Windows.Forms.Label label1;
    }
}