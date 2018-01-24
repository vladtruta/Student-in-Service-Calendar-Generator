namespace CalendarServici
{
    partial class ListaVacante
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
            this.dgv_vacante = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bt_adauga = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vacante)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vacante
            // 
            this.dgv_vacante.AllowUserToAddRows = false;
            this.dgv_vacante.AllowUserToDeleteRows = false;
            this.dgv_vacante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vacante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vacante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tip,
            this.dataStart,
            this.dataFinal,
            this.elimina});
            this.dgv_vacante.Location = new System.Drawing.Point(12, 12);
            this.dgv_vacante.Name = "dgv_vacante";
            this.dgv_vacante.Size = new System.Drawing.Size(413, 182);
            this.dgv_vacante.TabIndex = 0;
            this.dgv_vacante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vacante_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tip
            // 
            this.tip.HeaderText = "Tip";
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            // 
            // dataStart
            // 
            this.dataStart.HeaderText = "Data Start";
            this.dataStart.Name = "dataStart";
            this.dataStart.ReadOnly = true;
            // 
            // dataFinal
            // 
            this.dataFinal.HeaderText = "DataFinal";
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ReadOnly = true;
            // 
            // elimina
            // 
            this.elimina.HeaderText = "Elimina";
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            this.elimina.Text = "Elimina";
            this.elimina.UseColumnTextForButtonValue = true;
            // 
            // bt_adauga
            // 
            this.bt_adauga.Location = new System.Drawing.Point(72, 201);
            this.bt_adauga.Name = "bt_adauga";
            this.bt_adauga.Size = new System.Drawing.Size(98, 34);
            this.bt_adauga.TabIndex = 1;
            this.bt_adauga.Text = "Adauga Vacanta";
            this.bt_adauga.UseVisualStyleBackColor = true;
            this.bt_adauga.Click += new System.EventHandler(this.bt_adauga_Click_1);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(257, 201);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(98, 34);
            this.bt_clear.TabIndex = 2;
            this.bt_clear.Text = "Sterge Tot";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // ListaVacante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 240);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_adauga);
            this.Controls.Add(this.dgv_vacante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaVacante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vacante";
            this.Load += new System.EventHandler(this.Vacante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vacante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vacante;
        private System.Windows.Forms.Button bt_adauga;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinal;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
    }
}