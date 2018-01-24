namespace CalendarServici
{
    partial class AdaugaVacanta
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
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.lb_dataStart = new System.Windows.Forms.Label();
            this.lb_dataEnd = new System.Windows.Forms.Label();
            this.rb_zi = new System.Windows.Forms.RadioButton();
            this.rb_perioada = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_adauga_vacanta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(12, 24);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 0;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(12, 72);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 1;
            // 
            // lb_dataStart
            // 
            this.lb_dataStart.AutoSize = true;
            this.lb_dataStart.Location = new System.Drawing.Point(9, 8);
            this.lb_dataStart.Name = "lb_dataStart";
            this.lb_dataStart.Size = new System.Drawing.Size(32, 13);
            this.lb_dataStart.TabIndex = 2;
            this.lb_dataStart.Text = "De la";
            // 
            // lb_dataEnd
            // 
            this.lb_dataEnd.AutoSize = true;
            this.lb_dataEnd.Location = new System.Drawing.Point(9, 56);
            this.lb_dataEnd.Name = "lb_dataEnd";
            this.lb_dataEnd.Size = new System.Drawing.Size(43, 13);
            this.lb_dataEnd.TabIndex = 3;
            this.lb_dataEnd.Text = "Pana la";
            // 
            // rb_zi
            // 
            this.rb_zi.AutoSize = true;
            this.rb_zi.Location = new System.Drawing.Point(233, 28);
            this.rb_zi.Name = "rb_zi";
            this.rb_zi.Size = new System.Drawing.Size(34, 17);
            this.rb_zi.TabIndex = 4;
            this.rb_zi.Text = "Zi";
            this.rb_zi.UseVisualStyleBackColor = true;
            this.rb_zi.CheckedChanged += new System.EventHandler(this.rb_zi_CheckedChanged);
            // 
            // rb_perioada
            // 
            this.rb_perioada.AutoSize = true;
            this.rb_perioada.Checked = true;
            this.rb_perioada.Location = new System.Drawing.Point(233, 48);
            this.rb_perioada.Name = "rb_perioada";
            this.rb_perioada.Size = new System.Drawing.Size(67, 17);
            this.rb_perioada.TabIndex = 5;
            this.rb_perioada.TabStop = true;
            this.rb_perioada.Text = "Perioada";
            this.rb_perioada.UseVisualStyleBackColor = true;
            this.rb_perioada.CheckedChanged += new System.EventHandler(this.rb_perioada_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip vacanta";
            // 
            // bt_adauga_vacanta
            // 
            this.bt_adauga_vacanta.Location = new System.Drawing.Point(233, 73);
            this.bt_adauga_vacanta.Name = "bt_adauga_vacanta";
            this.bt_adauga_vacanta.Size = new System.Drawing.Size(88, 30);
            this.bt_adauga_vacanta.TabIndex = 2;
            this.bt_adauga_vacanta.Text = "Adauga";
            this.bt_adauga_vacanta.UseVisualStyleBackColor = true;
            this.bt_adauga_vacanta.Click += new System.EventHandler(this.bt_adauga_vacanta_Click);
            // 
            // AdaugaVacanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 106);
            this.Controls.Add(this.bt_adauga_vacanta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_perioada);
            this.Controls.Add(this.rb_zi);
            this.Controls.Add(this.lb_dataEnd);
            this.Controls.Add(this.lb_dataStart);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdaugaVacanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adauga Vacanta";
            this.Load += new System.EventHandler(this.AdaugaVacanta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label lb_dataStart;
        private System.Windows.Forms.Label lb_dataEnd;
        private System.Windows.Forms.RadioButton rb_zi;
        private System.Windows.Forms.RadioButton rb_perioada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_adauga_vacanta;
    }
}