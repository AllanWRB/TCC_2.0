namespace teste
{
    partial class EdicaoADM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Deslogar = new System.Windows.Forms.Button();
            this.btn_AlterarUS = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carga_horaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 63);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENAI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btn_Deslogar);
            this.panel2.Controls.Add(this.btn_AlterarUS);
            this.panel2.Controls.Add(this.btn_Excluir);
            this.panel2.Controls.Add(this.btn_Editar);
            this.panel2.Controls.Add(this.btn_Cadastrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 498);
            this.panel2.TabIndex = 6;
            // 
            // btn_Deslogar
            // 
            this.btn_Deslogar.FlatAppearance.BorderSize = 0;
            this.btn_Deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_Deslogar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Deslogar.Location = new System.Drawing.Point(19, 411);
            this.btn_Deslogar.Name = "btn_Deslogar";
            this.btn_Deslogar.Size = new System.Drawing.Size(140, 66);
            this.btn_Deslogar.TabIndex = 4;
            this.btn_Deslogar.Text = "Deslogar";
            this.btn_Deslogar.UseVisualStyleBackColor = true;
            this.btn_Deslogar.Click += new System.EventHandler(this.btn_Deslogar_Click);
            // 
            // btn_AlterarUS
            // 
            this.btn_AlterarUS.FlatAppearance.BorderSize = 0;
            this.btn_AlterarUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlterarUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_AlterarUS.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AlterarUS.Location = new System.Drawing.Point(19, 315);
            this.btn_AlterarUS.Name = "btn_AlterarUS";
            this.btn_AlterarUS.Size = new System.Drawing.Size(140, 66);
            this.btn_AlterarUS.TabIndex = 3;
            this.btn_AlterarUS.Text = "Alterar Usuario/Senha";
            this.btn_AlterarUS.UseVisualStyleBackColor = true;
            this.btn_AlterarUS.Click += new System.EventHandler(this.btn_AlterarUS_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Excluir.Location = new System.Drawing.Point(19, 219);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(140, 66);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Curso";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Editar.Location = new System.Drawing.Point(19, 123);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(140, 66);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar Cursos";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_Cadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Cadastrar.Location = new System.Drawing.Point(19, 27);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(140, 66);
            this.btn_Cadastrar.TabIndex = 0;
            this.btn_Cadastrar.Text = "Cadastrar Cursos";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_curso,
            this.nome_curso,
            this.preco,
            this.carga_horaria});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(200, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 498);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_curso
            // 
            this.id_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "id_curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.Width = 72;
            // 
            // nome_curso
            // 
            this.nome_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_curso.DataPropertyName = "nome_curso";
            this.nome_curso.HeaderText = "nome do curso";
            this.nome_curso.Name = "nome_curso";
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "preco";
            this.preco.Name = "preco";
            // 
            // carga_horaria
            // 
            this.carga_horaria.DataPropertyName = "carga_horaria";
            this.carga_horaria.HeaderText = "Carga Horaria";
            this.carga_horaria.Name = "carga_horaria";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(130, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Excluir Curso";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EdicaoADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Name = "EdicaoADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdicaoADM";
            this.Load += new System.EventHandler(this.EdicaoADM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Deslogar;
        private System.Windows.Forms.Button btn_AlterarUS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn carga_horaria;
    }
}