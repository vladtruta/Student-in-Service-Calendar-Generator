namespace CalendarServici
{
    partial class SeteazaPerioada
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
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_finish = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_adauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(86, 12);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 0;
            // 
            // dtp_finish
            // 
            this.dtp_finish.Location = new System.Drawing.Point(86, 44);
            this.dtp_finish.Name = "dtp_finish";
            this.dtp_finish.Size = new System.Drawing.Size(200, 20);
            this.dtp_finish.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data inceput";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data sfarsit";
            // 
            // bt_adauga
            // 
            this.bt_adauga.Location = new System.Drawing.Point(103, 81);
            this.bt_adauga.Name = "bt_adauga";
            this.bt_adauga.Size = new System.Drawing.Size(96, 32);
            this.bt_adauga.TabIndex = 4;
            this.bt_adauga.Text = "Adauga";
            this.bt_adauga.UseVisualStyleBackColor = true;
            this.bt_adauga.Click += new System.EventHandler(this.bt_adauga_Click);
            // 
            // SeteazaPerioada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 125);
            this.Controls.Add(this.bt_adauga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_finish);
            this.Controls.Add(this.dtp_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeteazaPerioada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perioada";
            this.Load += new System.EventHandler(this.AnScolar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_adauga;
    }
}