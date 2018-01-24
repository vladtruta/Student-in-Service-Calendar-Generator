namespace CalendarServici
{
    partial class AdaugarePereche
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
            this.bt_adauga = new System.Windows.Forms.Button();
            this.tb_nume1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_prenume1 = new System.Windows.Forms.TextBox();
            this.rb_1per = new System.Windows.Forms.RadioButton();
            this.rb_2per = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_prenume2 = new System.Windows.Forms.Label();
            this.lb_nume2 = new System.Windows.Forms.Label();
            this.tb_prenume2 = new System.Windows.Forms.TextBox();
            this.tb_nume2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_adauga
            // 
            this.bt_adauga.Location = new System.Drawing.Point(183, 118);
            this.bt_adauga.Name = "bt_adauga";
            this.bt_adauga.Size = new System.Drawing.Size(136, 39);
            this.bt_adauga.TabIndex = 10;
            this.bt_adauga.Text = "Adauga";
            this.bt_adauga.UseVisualStyleBackColor = true;
            this.bt_adauga.Click += new System.EventHandler(this.bt_adauga_Click);
            // 
            // tb_nume1
            // 
            this.tb_nume1.Location = new System.Drawing.Point(51, 53);
            this.tb_nume1.Name = "tb_nume1";
            this.tb_nume1.Size = new System.Drawing.Size(190, 20);
            this.tb_nume1.TabIndex = 6;
            this.tb_nume1.Enter += new System.EventHandler(this.tb_nume1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prenume";
            // 
            // tb_prenume1
            // 
            this.tb_prenume1.Location = new System.Drawing.Point(302, 53);
            this.tb_prenume1.Name = "tb_prenume1";
            this.tb_prenume1.Size = new System.Drawing.Size(190, 20);
            this.tb_prenume1.TabIndex = 7;
            this.tb_prenume1.Enter += new System.EventHandler(this.tb_nume1_Enter);
            // 
            // rb_1per
            // 
            this.rb_1per.AutoSize = true;
            this.rb_1per.Checked = true;
            this.rb_1per.Location = new System.Drawing.Point(12, 29);
            this.rb_1per.Name = "rb_1per";
            this.rb_1per.Size = new System.Drawing.Size(54, 17);
            this.rb_1per.TabIndex = 12;
            this.rb_1per.TabStop = true;
            this.rb_1per.Text = "1 elev";
            this.rb_1per.UseVisualStyleBackColor = true;
            this.rb_1per.CheckedChanged += new System.EventHandler(this.rb_1per_CheckedChanged);
            // 
            // rb_2per
            // 
            this.rb_2per.AutoSize = true;
            this.rb_2per.Location = new System.Drawing.Point(72, 29);
            this.rb_2per.Name = "rb_2per";
            this.rb_2per.Size = new System.Drawing.Size(56, 17);
            this.rb_2per.TabIndex = 13;
            this.rb_2per.Text = "2 elevi";
            this.rb_2per.UseVisualStyleBackColor = true;
            this.rb_2per.CheckedChanged += new System.EventHandler(this.rb_2per_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pereche de:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_prenume2
            // 
            this.lb_prenume2.AutoSize = true;
            this.lb_prenume2.Location = new System.Drawing.Point(246, 86);
            this.lb_prenume2.Name = "lb_prenume2";
            this.lb_prenume2.Size = new System.Drawing.Size(49, 13);
            this.lb_prenume2.TabIndex = 16;
            this.lb_prenume2.Text = "Prenume";
            // 
            // lb_nume2
            // 
            this.lb_nume2.AutoSize = true;
            this.lb_nume2.Location = new System.Drawing.Point(9, 86);
            this.lb_nume2.Name = "lb_nume2";
            this.lb_nume2.Size = new System.Drawing.Size(35, 13);
            this.lb_nume2.TabIndex = 15;
            this.lb_nume2.Text = "Nume";
            // 
            // tb_prenume2
            // 
            this.tb_prenume2.Location = new System.Drawing.Point(302, 83);
            this.tb_prenume2.Name = "tb_prenume2";
            this.tb_prenume2.Size = new System.Drawing.Size(190, 20);
            this.tb_prenume2.TabIndex = 9;
            this.tb_prenume2.Enter += new System.EventHandler(this.tb_nume1_Enter);
            // 
            // tb_nume2
            // 
            this.tb_nume2.Location = new System.Drawing.Point(51, 83);
            this.tb_nume2.Name = "tb_nume2";
            this.tb_nume2.Size = new System.Drawing.Size(190, 20);
            this.tb_nume2.TabIndex = 8;
            this.tb_nume2.Enter += new System.EventHandler(this.tb_nume1_Enter);
            // 
            // AdaugarePereche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 166);
            this.Controls.Add(this.lb_prenume2);
            this.Controls.Add(this.lb_nume2);
            this.Controls.Add(this.tb_prenume2);
            this.Controls.Add(this.tb_nume2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_2per);
            this.Controls.Add(this.rb_1per);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_prenume1);
            this.Controls.Add(this.tb_nume1);
            this.Controls.Add(this.bt_adauga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdaugarePereche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adaugare Pereche";
            this.Load += new System.EventHandler(this.AdaugarePereche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_adauga;
        private System.Windows.Forms.TextBox tb_nume1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_prenume1;
        private System.Windows.Forms.RadioButton rb_1per;
        private System.Windows.Forms.RadioButton rb_2per;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_prenume2;
        private System.Windows.Forms.Label lb_nume2;
        private System.Windows.Forms.TextBox tb_prenume2;
        private System.Windows.Forms.TextBox tb_nume2;
    }
}