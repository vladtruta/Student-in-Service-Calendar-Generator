namespace CalendarServici
{
    partial class Meniu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.lb_elevi = new System.Windows.Forms.ListBox();
            this.meniuElevi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_adauga_elev = new System.Windows.Forms.Button();
            this.tb_elev1 = new System.Windows.Forms.TextBox();
            this.tb_elev2 = new System.Windows.Forms.TextBox();
            this.bt_adauga1 = new System.Windows.Forms.Button();
            this.bt_adauga2 = new System.Windows.Forms.Button();
            this.bt_confirma = new System.Windows.Forms.Button();
            this.bt_inc_fisier_elevi = new System.Windows.Forms.Button();
            this.bt_sterge_toti_elevi = new System.Windows.Forms.Button();
            this.bt_sterge1 = new System.Windows.Forms.Button();
            this.bt_sterge2 = new System.Windows.Forms.Button();
            this.bt_sterge12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_perechi = new System.Windows.Forms.ListBox();
            this.meniuPerechi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_sterge_toti_perechi = new System.Windows.Forms.Button();
            this.bt_inc_fisier_perechi = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_adauga_pereche = new System.Windows.Forms.Button();
            this.bt_seteaza_vacante = new System.Windows.Forms.Button();
            this.bt_generare = new System.Windows.Forms.Button();
            this.cb_gen_automat = new System.Windows.Forms.CheckBox();
            this.panel_perechi = new System.Windows.Forms.Panel();
            this.bt_an_scolar = new System.Windows.Forms.Button();
            this.bt_cresc_elevi = new System.Windows.Forms.Button();
            this.bt_desc_elevi = new System.Windows.Forms.Button();
            this.el_dubl_elevi = new System.Windows.Forms.Button();
            this.rb_pereche1 = new System.Windows.Forms.RadioButton();
            this.rb_pereche2 = new System.Windows.Forms.RadioButton();
            this.bt_moveDown = new System.Windows.Forms.Button();
            this.bt_moveUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rb_nume_complet = new System.Windows.Forms.RadioButton();
            this.rb_nume_fam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuElevi.SuspendLayout();
            this.meniuPerechi.SuspendLayout();
            this.panel_perechi.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_elevi
            // 
            this.lb_elevi.ContextMenuStrip = this.meniuElevi;
            this.lb_elevi.FormattingEnabled = true;
            this.lb_elevi.HorizontalScrollbar = true;
            this.lb_elevi.Location = new System.Drawing.Point(11, 120);
            this.lb_elevi.Name = "lb_elevi";
            this.lb_elevi.Size = new System.Drawing.Size(242, 329);
            this.lb_elevi.TabIndex = 0;
            this.lb_elevi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_elevi_MouseDown);
            this.lb_elevi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb_elevi_MouseUp);
            // 
            // meniuElevi
            // 
            this.meniuElevi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.meniuElevi.Name = "meniuEditDelete";
            this.meniuElevi.Size = new System.Drawing.Size(118, 48);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.sterge_elevi_toolstrip_Click);
            // 
            // bt_adauga_elev
            // 
            this.bt_adauga_elev.Location = new System.Drawing.Point(11, 86);
            this.bt_adauga_elev.Name = "bt_adauga_elev";
            this.bt_adauga_elev.Size = new System.Drawing.Size(75, 28);
            this.bt_adauga_elev.TabIndex = 1;
            this.bt_adauga_elev.Text = "Adauga";
            this.bt_adauga_elev.UseVisualStyleBackColor = true;
            this.bt_adauga_elev.Click += new System.EventHandler(this.bt_adauga_elev_Click);
            // 
            // tb_elev1
            // 
            this.tb_elev1.Location = new System.Drawing.Point(45, 20);
            this.tb_elev1.Name = "tb_elev1";
            this.tb_elev1.ReadOnly = true;
            this.tb_elev1.Size = new System.Drawing.Size(179, 20);
            this.tb_elev1.TabIndex = 2;
            // 
            // tb_elev2
            // 
            this.tb_elev2.Location = new System.Drawing.Point(45, 98);
            this.tb_elev2.Name = "tb_elev2";
            this.tb_elev2.ReadOnly = true;
            this.tb_elev2.Size = new System.Drawing.Size(179, 20);
            this.tb_elev2.TabIndex = 3;
            // 
            // bt_adauga1
            // 
            this.bt_adauga1.Location = new System.Drawing.Point(1, 14);
            this.bt_adauga1.Name = "bt_adauga1";
            this.bt_adauga1.Size = new System.Drawing.Size(38, 31);
            this.bt_adauga1.TabIndex = 4;
            this.bt_adauga1.Text = ">";
            this.bt_adauga1.UseVisualStyleBackColor = true;
            this.bt_adauga1.Click += new System.EventHandler(this.bt_adauga1_Click);
            // 
            // bt_adauga2
            // 
            this.bt_adauga2.Location = new System.Drawing.Point(1, 92);
            this.bt_adauga2.Name = "bt_adauga2";
            this.bt_adauga2.Size = new System.Drawing.Size(38, 31);
            this.bt_adauga2.TabIndex = 5;
            this.bt_adauga2.Text = ">";
            this.bt_adauga2.UseVisualStyleBackColor = true;
            this.bt_adauga2.Click += new System.EventHandler(this.bt_adauga2_Click);
            // 
            // bt_confirma
            // 
            this.bt_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirma.Location = new System.Drawing.Point(415, 336);
            this.bt_confirma.Name = "bt_confirma";
            this.bt_confirma.Size = new System.Drawing.Size(156, 70);
            this.bt_confirma.TabIndex = 6;
            this.bt_confirma.Text = "Confirma";
            this.bt_confirma.UseVisualStyleBackColor = true;
            this.bt_confirma.Click += new System.EventHandler(this.bt_confirma_Click);
            // 
            // bt_inc_fisier_elevi
            // 
            this.bt_inc_fisier_elevi.Location = new System.Drawing.Point(11, 455);
            this.bt_inc_fisier_elevi.Name = "bt_inc_fisier_elevi";
            this.bt_inc_fisier_elevi.Size = new System.Drawing.Size(92, 36);
            this.bt_inc_fisier_elevi.TabIndex = 7;
            this.bt_inc_fisier_elevi.Text = "Incarca fisier elevi";
            this.bt_inc_fisier_elevi.UseVisualStyleBackColor = true;
            this.bt_inc_fisier_elevi.Click += new System.EventHandler(this.bt_inc_fisier_elevi_Click);
            // 
            // bt_sterge_toti_elevi
            // 
            this.bt_sterge_toti_elevi.Location = new System.Drawing.Point(177, 86);
            this.bt_sterge_toti_elevi.Name = "bt_sterge_toti_elevi";
            this.bt_sterge_toti_elevi.Size = new System.Drawing.Size(76, 28);
            this.bt_sterge_toti_elevi.TabIndex = 8;
            this.bt_sterge_toti_elevi.Text = "Sterge  Tot";
            this.bt_sterge_toti_elevi.UseVisualStyleBackColor = true;
            this.bt_sterge_toti_elevi.Click += new System.EventHandler(this.bt_sterge_toti_elevi_Click);
            // 
            // bt_sterge1
            // 
            this.bt_sterge1.Location = new System.Drawing.Point(230, 14);
            this.bt_sterge1.Name = "bt_sterge1";
            this.bt_sterge1.Size = new System.Drawing.Size(38, 31);
            this.bt_sterge1.TabIndex = 11;
            this.bt_sterge1.Text = "X";
            this.bt_sterge1.UseVisualStyleBackColor = true;
            this.bt_sterge1.Click += new System.EventHandler(this.bt_sterge1_Click);
            // 
            // bt_sterge2
            // 
            this.bt_sterge2.Location = new System.Drawing.Point(230, 92);
            this.bt_sterge2.Name = "bt_sterge2";
            this.bt_sterge2.Size = new System.Drawing.Size(38, 31);
            this.bt_sterge2.TabIndex = 12;
            this.bt_sterge2.Text = "X";
            this.bt_sterge2.UseVisualStyleBackColor = true;
            this.bt_sterge2.Click += new System.EventHandler(this.bt_sterge2_Click);
            // 
            // bt_sterge12
            // 
            this.bt_sterge12.Location = new System.Drawing.Point(274, 14);
            this.bt_sterge12.Name = "bt_sterge12";
            this.bt_sterge12.Size = new System.Drawing.Size(39, 109);
            this.bt_sterge12.TabIndex = 13;
            this.bt_sterge12.Text = "X";
            this.bt_sterge12.UseVisualStyleBackColor = true;
            this.bt_sterge12.Click += new System.EventHandler(this.bt_sterge12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Perechi";
            // 
            // lb_perechi
            // 
            this.lb_perechi.ContextMenuStrip = this.meniuPerechi;
            this.lb_perechi.FormattingEnabled = true;
            this.lb_perechi.HorizontalScrollbar = true;
            this.lb_perechi.Location = new System.Drawing.Point(577, 120);
            this.lb_perechi.Name = "lb_perechi";
            this.lb_perechi.Size = new System.Drawing.Size(244, 329);
            this.lb_perechi.TabIndex = 19;
            this.lb_perechi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_perechi_MouseDown);
            this.lb_perechi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb_perechi_MouseUp);
            // 
            // meniuPerechi
            // 
            this.meniuPerechi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem1});
            this.meniuPerechi.Name = "meniuPerechi";
            this.meniuPerechi.Size = new System.Drawing.Size(108, 26);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.stergeToolStripMenuItem1.Text = "Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.sterge_perechi_toolstrip_Click);
            // 
            // bt_sterge_toti_perechi
            // 
            this.bt_sterge_toti_perechi.Location = new System.Drawing.Point(745, 86);
            this.bt_sterge_toti_perechi.Name = "bt_sterge_toti_perechi";
            this.bt_sterge_toti_perechi.Size = new System.Drawing.Size(76, 28);
            this.bt_sterge_toti_perechi.TabIndex = 21;
            this.bt_sterge_toti_perechi.Text = "Sterge  Tot";
            this.bt_sterge_toti_perechi.UseVisualStyleBackColor = true;
            this.bt_sterge_toti_perechi.Click += new System.EventHandler(this.bt_sterge_toti_perechi_Click);
            // 
            // bt_inc_fisier_perechi
            // 
            this.bt_inc_fisier_perechi.Location = new System.Drawing.Point(577, 455);
            this.bt_inc_fisier_perechi.Name = "bt_inc_fisier_perechi";
            this.bt_inc_fisier_perechi.Size = new System.Drawing.Size(92, 36);
            this.bt_inc_fisier_perechi.TabIndex = 22;
            this.bt_inc_fisier_perechi.Text = "Incarca fisier perechi";
            this.bt_inc_fisier_perechi.UseVisualStyleBackColor = true;
            this.bt_inc_fisier_perechi.Click += new System.EventHandler(this.bt_inc_fisier_perechi_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(102, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Elevi";
            // 
            // bt_adauga_pereche
            // 
            this.bt_adauga_pereche.Location = new System.Drawing.Point(577, 86);
            this.bt_adauga_pereche.Name = "bt_adauga_pereche";
            this.bt_adauga_pereche.Size = new System.Drawing.Size(75, 28);
            this.bt_adauga_pereche.TabIndex = 25;
            this.bt_adauga_pereche.Text = "Adauga";
            this.bt_adauga_pereche.UseVisualStyleBackColor = true;
            this.bt_adauga_pereche.Click += new System.EventHandler(this.bt_adauga_pereche_Click);
            // 
            // bt_seteaza_vacante
            // 
            this.bt_seteaza_vacante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_seteaza_vacante.Location = new System.Drawing.Point(315, 112);
            this.bt_seteaza_vacante.Name = "bt_seteaza_vacante";
            this.bt_seteaza_vacante.Size = new System.Drawing.Size(193, 33);
            this.bt_seteaza_vacante.TabIndex = 26;
            this.bt_seteaza_vacante.Text = "Seteaza Vacantele";
            this.bt_seteaza_vacante.UseVisualStyleBackColor = true;
            this.bt_seteaza_vacante.Click += new System.EventHandler(this.bt_seteaza_vacante_Click);
            // 
            // bt_generare
            // 
            this.bt_generare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_generare.Location = new System.Drawing.Point(259, 423);
            this.bt_generare.Name = "bt_generare";
            this.bt_generare.Size = new System.Drawing.Size(312, 36);
            this.bt_generare.TabIndex = 27;
            this.bt_generare.Text = "GENERARE";
            this.bt_generare.UseVisualStyleBackColor = true;
            this.bt_generare.Click += new System.EventHandler(this.bt_generare_Click);
            // 
            // cb_gen_automat
            // 
            this.cb_gen_automat.AutoSize = true;
            this.cb_gen_automat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gen_automat.Location = new System.Drawing.Point(324, 162);
            this.cb_gen_automat.Name = "cb_gen_automat";
            this.cb_gen_automat.Size = new System.Drawing.Size(170, 24);
            this.cb_gen_automat.TabIndex = 28;
            this.cb_gen_automat.Text = "Generare Automata";
            this.cb_gen_automat.UseVisualStyleBackColor = true;
            this.cb_gen_automat.CheckedChanged += new System.EventHandler(this.cb_gen_automat_CheckedChanged);
            // 
            // panel_perechi
            // 
            this.panel_perechi.Controls.Add(this.bt_sterge2);
            this.panel_perechi.Controls.Add(this.bt_sterge1);
            this.panel_perechi.Controls.Add(this.bt_adauga2);
            this.panel_perechi.Controls.Add(this.bt_adauga1);
            this.panel_perechi.Controls.Add(this.tb_elev2);
            this.panel_perechi.Controls.Add(this.tb_elev1);
            this.panel_perechi.Controls.Add(this.bt_sterge12);
            this.panel_perechi.Location = new System.Drawing.Point(259, 192);
            this.panel_perechi.Name = "panel_perechi";
            this.panel_perechi.Size = new System.Drawing.Size(312, 133);
            this.panel_perechi.TabIndex = 29;
            // 
            // bt_an_scolar
            // 
            this.bt_an_scolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_an_scolar.Location = new System.Drawing.Point(315, 60);
            this.bt_an_scolar.Name = "bt_an_scolar";
            this.bt_an_scolar.Size = new System.Drawing.Size(193, 33);
            this.bt_an_scolar.TabIndex = 30;
            this.bt_an_scolar.Text = "Seteaza Perioada";
            this.bt_an_scolar.UseVisualStyleBackColor = true;
            this.bt_an_scolar.Click += new System.EventHandler(this.bt_an_scolar_Click);
            // 
            // bt_cresc_elevi
            // 
            this.bt_cresc_elevi.Location = new System.Drawing.Point(106, 94);
            this.bt_cresc_elevi.Name = "bt_cresc_elevi";
            this.bt_cresc_elevi.Size = new System.Drawing.Size(46, 20);
            this.bt_cresc_elevi.TabIndex = 31;
            this.bt_cresc_elevi.Text = "Cresc.";
            this.bt_cresc_elevi.UseVisualStyleBackColor = true;
            this.bt_cresc_elevi.Click += new System.EventHandler(this.bt_cresc_elevi_Click);
            // 
            // bt_desc_elevi
            // 
            this.bt_desc_elevi.Location = new System.Drawing.Point(106, 73);
            this.bt_desc_elevi.Name = "bt_desc_elevi";
            this.bt_desc_elevi.Size = new System.Drawing.Size(46, 20);
            this.bt_desc_elevi.TabIndex = 32;
            this.bt_desc_elevi.Text = "Desc.";
            this.bt_desc_elevi.UseVisualStyleBackColor = true;
            this.bt_desc_elevi.Click += new System.EventHandler(this.bt_desc_elevi_Click);
            // 
            // el_dubl_elevi
            // 
            this.el_dubl_elevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.el_dubl_elevi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.el_dubl_elevi.Location = new System.Drawing.Point(177, 38);
            this.el_dubl_elevi.Name = "el_dubl_elevi";
            this.el_dubl_elevi.Size = new System.Drawing.Size(75, 44);
            this.el_dubl_elevi.TabIndex = 33;
            this.el_dubl_elevi.Text = "Elimina Dubluri";
            this.el_dubl_elevi.UseVisualStyleBackColor = true;
            this.el_dubl_elevi.Click += new System.EventHandler(this.el_dubl_elevi_Click);
            // 
            // rb_pereche1
            // 
            this.rb_pereche1.AutoSize = true;
            this.rb_pereche1.Location = new System.Drawing.Point(24, 19);
            this.rb_pereche1.Name = "rb_pereche1";
            this.rb_pereche1.Size = new System.Drawing.Size(85, 17);
            this.rb_pereche1.TabIndex = 35;
            this.rb_pereche1.Text = "Perechi de 1";
            this.rb_pereche1.UseVisualStyleBackColor = true;
            // 
            // rb_pereche2
            // 
            this.rb_pereche2.AutoSize = true;
            this.rb_pereche2.Checked = true;
            this.rb_pereche2.Location = new System.Drawing.Point(24, 42);
            this.rb_pereche2.Name = "rb_pereche2";
            this.rb_pereche2.Size = new System.Drawing.Size(85, 17);
            this.rb_pereche2.TabIndex = 36;
            this.rb_pereche2.TabStop = true;
            this.rb_pereche2.Text = "Perechi de 2";
            this.rb_pereche2.UseVisualStyleBackColor = true;
            // 
            // bt_moveDown
            // 
            this.bt_moveDown.Location = new System.Drawing.Point(658, 94);
            this.bt_moveDown.Name = "bt_moveDown";
            this.bt_moveDown.Size = new System.Drawing.Size(81, 20);
            this.bt_moveDown.TabIndex = 37;
            this.bt_moveDown.Text = "▼";
            this.bt_moveDown.UseVisualStyleBackColor = true;
            this.bt_moveDown.Click += new System.EventHandler(this.bt_moveDown_Click);
            // 
            // bt_moveUp
            // 
            this.bt_moveUp.Location = new System.Drawing.Point(658, 73);
            this.bt_moveUp.Name = "bt_moveUp";
            this.bt_moveUp.Size = new System.Drawing.Size(81, 20);
            this.bt_moveUp.TabIndex = 38;
            this.bt_moveUp.Text = "▲";
            this.bt_moveUp.UseVisualStyleBackColor = true;
            this.bt_moveUp.Click += new System.EventHandler(this.bt_moveUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "(se va tine cont exact de aceasta ordine)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rb_nume_complet
            // 
            this.rb_nume_complet.AutoSize = true;
            this.rb_nume_complet.Checked = true;
            this.rb_nume_complet.Location = new System.Drawing.Point(304, 465);
            this.rb_nume_complet.Name = "rb_nume_complet";
            this.rb_nume_complet.Size = new System.Drawing.Size(100, 17);
            this.rb_nume_complet.TabIndex = 43;
            this.rb_nume_complet.TabStop = true;
            this.rb_nume_complet.Text = "Nume Complete";
            this.rb_nume_complet.UseVisualStyleBackColor = true;
            // 
            // rb_nume_fam
            // 
            this.rb_nume_fam.AutoSize = true;
            this.rb_nume_fam.Location = new System.Drawing.Point(428, 465);
            this.rb_nume_fam.Name = "rb_nume_fam";
            this.rb_nume_fam.Size = new System.Drawing.Size(114, 17);
            this.rb_nume_fam.TabIndex = 44;
            this.rb_nume_fam.Text = "Doar Nume Familie";
            this.rb_nume_fam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_pereche1);
            this.groupBox1.Controls.Add(this.rb_pereche2);
            this.groupBox1.Location = new System.Drawing.Point(260, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 75);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perechi";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(675, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 36);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nume complete sau doar de familie, cu virgula intre ele!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(109, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nume complete sau doar de familie, cu spatiu intre ele.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rb_nume_fam);
            this.Controls.Add(this.rb_nume_complet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_moveUp);
            this.Controls.Add(this.bt_moveDown);
            this.Controls.Add(this.el_dubl_elevi);
            this.Controls.Add(this.bt_desc_elevi);
            this.Controls.Add(this.bt_cresc_elevi);
            this.Controls.Add(this.bt_an_scolar);
            this.Controls.Add(this.cb_gen_automat);
            this.Controls.Add(this.bt_confirma);
            this.Controls.Add(this.panel_perechi);
            this.Controls.Add(this.bt_generare);
            this.Controls.Add(this.bt_seteaza_vacante);
            this.Controls.Add(this.bt_adauga_pereche);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bt_inc_fisier_perechi);
            this.Controls.Add(this.bt_sterge_toti_perechi);
            this.Controls.Add(this.lb_perechi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_sterge_toti_elevi);
            this.Controls.Add(this.bt_inc_fisier_elevi);
            this.Controls.Add(this.bt_adauga_elev);
            this.Controls.Add(this.lb_elevi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator Elevi Serviciu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Meniu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.meniuElevi.ResumeLayout(false);
            this.meniuPerechi.ResumeLayout(false);
            this.panel_perechi.ResumeLayout(false);
            this.panel_perechi.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_elevi;
        private System.Windows.Forms.Button bt_adauga_elev;
        private System.Windows.Forms.TextBox tb_elev1;
        private System.Windows.Forms.TextBox tb_elev2;
        private System.Windows.Forms.Button bt_adauga1;
        private System.Windows.Forms.Button bt_adauga2;
        private System.Windows.Forms.Button bt_confirma;
        private System.Windows.Forms.Button bt_inc_fisier_elevi;
        private System.Windows.Forms.Button bt_sterge_toti_elevi;
        private System.Windows.Forms.Button bt_sterge1;
        private System.Windows.Forms.Button bt_sterge2;
        private System.Windows.Forms.Button bt_sterge12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_perechi;
        private System.Windows.Forms.Button bt_sterge_toti_perechi;
        private System.Windows.Forms.Button bt_inc_fisier_perechi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_adauga_pereche;
        private System.Windows.Forms.Button bt_seteaza_vacante;
        private System.Windows.Forms.Button bt_generare;
        private System.Windows.Forms.CheckBox cb_gen_automat;
        private System.Windows.Forms.Panel panel_perechi;
        private System.Windows.Forms.Button bt_an_scolar;
        private System.Windows.Forms.Button bt_cresc_elevi;
        private System.Windows.Forms.Button bt_desc_elevi;
        private System.Windows.Forms.Button el_dubl_elevi;
        private System.Windows.Forms.RadioButton rb_pereche1;
        private System.Windows.Forms.RadioButton rb_pereche2;
        private System.Windows.Forms.Button bt_moveDown;
        private System.Windows.Forms.Button bt_moveUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip meniuElevi;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip meniuPerechi;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rb_nume_complet;
        private System.Windows.Forms.RadioButton rb_nume_fam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
    }
}

