namespace CalendarServici
{
    partial class EditElev
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_prenume = new System.Windows.Forms.TextBox();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.bt_actualiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prenume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume";
            // 
            // tb_prenume
            // 
            this.tb_prenume.Location = new System.Drawing.Point(71, 70);
            this.tb_prenume.Name = "tb_prenume";
            this.tb_prenume.Size = new System.Drawing.Size(190, 20);
            this.tb_prenume.TabIndex = 6;
            this.tb_prenume.Enter += new System.EventHandler(this.tb_nume_Enter);
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(71, 30);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(190, 20);
            this.tb_nume.TabIndex = 5;
            this.tb_nume.Enter += new System.EventHandler(this.tb_nume_Enter);
            // 
            // bt_actualiz
            // 
            this.bt_actualiz.Location = new System.Drawing.Point(77, 112);
            this.bt_actualiz.Name = "bt_actualiz";
            this.bt_actualiz.Size = new System.Drawing.Size(136, 39);
            this.bt_actualiz.TabIndex = 8;
            this.bt_actualiz.Text = "Actualizeaza";
            this.bt_actualiz.UseVisualStyleBackColor = true;
            this.bt_actualiz.Click += new System.EventHandler(this.bt_actualiz_Click);
            // 
            // EditElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_prenume);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.bt_actualiz);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditElev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editare Elev";
            this.Load += new System.EventHandler(this.EditElev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_prenume;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.Button bt_actualiz;
    }
}