namespace teste
{
    partial class CadastrarCurso
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
            this.lbl_cadastrar = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_requisitos = new System.Windows.Forms.Label();
            this.lbl_profissao = new System.Windows.Forms.Label();
            this.lbl_op_trabalho = new System.Windows.Forms.Label();
            this.lbl_aprender = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_tipo_curso = new System.Windows.Forms.Label();
            this.lbl_modalidade = new System.Windows.Forms.Label();
            this.box_tp = new System.Windows.Forms.ComboBox();
            this.box_modalidade = new System.Windows.Forms.ComboBox();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.box_requisitos = new System.Windows.Forms.TextBox();
            this.box_preco = new System.Windows.Forms.TextBox();
            this.box_carga_horaria = new System.Windows.Forms.TextBox();
            this.box_profissao = new System.Windows.Forms.TextBox();
            this.box_op = new System.Windows.Forms.TextBox();
            this.box_oq_aprender = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_cadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 63);
            this.panel1.TabIndex = 7;
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
            // lbl_cadastrar
            // 
            this.lbl_cadastrar.AutoSize = true;
            this.lbl_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lbl_cadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cadastrar.Location = new System.Drawing.Point(395, 12);
            this.lbl_cadastrar.Name = "lbl_cadastrar";
            this.lbl_cadastrar.Size = new System.Drawing.Size(197, 29);
            this.lbl_cadastrar.TabIndex = 8;
            this.lbl_cadastrar.Text = "Cadastrar Curso";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(106, 108);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(80, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome do Curso";
            // 
            // lbl_requisitos
            // 
            this.lbl_requisitos.AutoSize = true;
            this.lbl_requisitos.Location = new System.Drawing.Point(106, 163);
            this.lbl_requisitos.Name = "lbl_requisitos";
            this.lbl_requisitos.Size = new System.Drawing.Size(56, 13);
            this.lbl_requisitos.TabIndex = 10;
            this.lbl_requisitos.Text = "Requisitos";
            // 
            // lbl_profissao
            // 
            this.lbl_profissao.AutoSize = true;
            this.lbl_profissao.Location = new System.Drawing.Point(107, 332);
            this.lbl_profissao.Name = "lbl_profissao";
            this.lbl_profissao.Size = new System.Drawing.Size(50, 13);
            this.lbl_profissao.TabIndex = 11;
            this.lbl_profissao.Text = "Profissao";
            // 
            // lbl_op_trabalho
            // 
            this.lbl_op_trabalho.AutoSize = true;
            this.lbl_op_trabalho.Location = new System.Drawing.Point(586, 101);
            this.lbl_op_trabalho.Name = "lbl_op_trabalho";
            this.lbl_op_trabalho.Size = new System.Drawing.Size(136, 13);
            this.lbl_op_trabalho.TabIndex = 12;
            this.lbl_op_trabalho.Text = "Oportunidades de Trabalho";
            // 
            // lbl_aprender
            // 
            this.lbl_aprender.AutoSize = true;
            this.lbl_aprender.Location = new System.Drawing.Point(624, 329);
            this.lbl_aprender.Name = "lbl_aprender";
            this.lbl_aprender.Size = new System.Drawing.Size(98, 13);
            this.lbl_aprender.TabIndex = 13;
            this.lbl_aprender.Text = "O que vai aprender";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(107, 531);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(35, 13);
            this.lbl_preco.TabIndex = 14;
            this.lbl_preco.Text = "Preço";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(106, 586);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(72, 13);
            this.lbl_hora.TabIndex = 15;
            this.lbl_hora.Text = "Carga Horaria";
            // 
            // lbl_tipo_curso
            // 
            this.lbl_tipo_curso.AutoSize = true;
            this.lbl_tipo_curso.Location = new System.Drawing.Point(660, 532);
            this.lbl_tipo_curso.Name = "lbl_tipo_curso";
            this.lbl_tipo_curso.Size = new System.Drawing.Size(72, 13);
            this.lbl_tipo_curso.TabIndex = 16;
            this.lbl_tipo_curso.Text = "Tipo do curso";
            // 
            // lbl_modalidade
            // 
            this.lbl_modalidade.AutoSize = true;
            this.lbl_modalidade.Location = new System.Drawing.Point(670, 584);
            this.lbl_modalidade.Name = "lbl_modalidade";
            this.lbl_modalidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_modalidade.TabIndex = 17;
            this.lbl_modalidade.Text = "Modalidade";
            // 
            // box_tp
            // 
            this.box_tp.FormattingEnabled = true;
            this.box_tp.Location = new System.Drawing.Point(751, 524);
            this.box_tp.Name = "box_tp";
            this.box_tp.Size = new System.Drawing.Size(198, 21);
            this.box_tp.TabIndex = 18;
            // 
            // box_modalidade
            // 
            this.box_modalidade.FormattingEnabled = true;
            this.box_modalidade.Location = new System.Drawing.Point(751, 576);
            this.box_modalidade.Name = "box_modalidade";
            this.box_modalidade.Size = new System.Drawing.Size(198, 21);
            this.box_modalidade.TabIndex = 19;
            // 
            // box_nome
            // 
            this.box_nome.Location = new System.Drawing.Point(227, 101);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(198, 20);
            this.box_nome.TabIndex = 20;
            // 
            // box_requisitos
            // 
            this.box_requisitos.Location = new System.Drawing.Point(227, 156);
            this.box_requisitos.Name = "box_requisitos";
            this.box_requisitos.Size = new System.Drawing.Size(198, 20);
            this.box_requisitos.TabIndex = 21;
            // 
            // box_preco
            // 
            this.box_preco.Location = new System.Drawing.Point(227, 524);
            this.box_preco.Name = "box_preco";
            this.box_preco.Size = new System.Drawing.Size(198, 20);
            this.box_preco.TabIndex = 22;
            // 
            // box_carga_horaria
            // 
            this.box_carga_horaria.Location = new System.Drawing.Point(227, 579);
            this.box_carga_horaria.Name = "box_carga_horaria";
            this.box_carga_horaria.Size = new System.Drawing.Size(198, 20);
            this.box_carga_horaria.TabIndex = 23;
            // 
            // box_profissao
            // 
            this.box_profissao.Location = new System.Drawing.Point(227, 329);
            this.box_profissao.Multiline = true;
            this.box_profissao.Name = "box_profissao";
            this.box_profissao.Size = new System.Drawing.Size(198, 142);
            this.box_profissao.TabIndex = 24;
            // 
            // box_op
            // 
            this.box_op.Location = new System.Drawing.Point(751, 101);
            this.box_op.Multiline = true;
            this.box_op.Name = "box_op";
            this.box_op.Size = new System.Drawing.Size(198, 142);
            this.box_op.TabIndex = 25;
            // 
            // box_oq_aprender
            // 
            this.box_oq_aprender.Location = new System.Drawing.Point(751, 329);
            this.box_oq_aprender.Multiline = true;
            this.box_oq_aprender.Name = "box_oq_aprender";
            this.box_oq_aprender.Size = new System.Drawing.Size(198, 142);
            this.box_oq_aprender.TabIndex = 26;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(517, 634);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 27;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // CadastrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.box_oq_aprender);
            this.Controls.Add(this.box_op);
            this.Controls.Add(this.box_profissao);
            this.Controls.Add(this.box_carga_horaria);
            this.Controls.Add(this.box_preco);
            this.Controls.Add(this.box_requisitos);
            this.Controls.Add(this.box_nome);
            this.Controls.Add(this.box_modalidade);
            this.Controls.Add(this.box_tp);
            this.Controls.Add(this.lbl_modalidade);
            this.Controls.Add(this.lbl_tipo_curso);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_aprender);
            this.Controls.Add(this.lbl_op_trabalho);
            this.Controls.Add(this.lbl_profissao);
            this.Controls.Add(this.lbl_requisitos);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.panel1);
            this.Name = "CadastrarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCurso";
            this.Load += new System.EventHandler(this.CadastrarCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cadastrar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_requisitos;
        private System.Windows.Forms.Label lbl_profissao;
        private System.Windows.Forms.Label lbl_op_trabalho;
        private System.Windows.Forms.Label lbl_aprender;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_tipo_curso;
        private System.Windows.Forms.Label lbl_modalidade;
        private System.Windows.Forms.ComboBox box_tp;
        private System.Windows.Forms.ComboBox box_modalidade;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.TextBox box_requisitos;
        private System.Windows.Forms.TextBox box_preco;
        private System.Windows.Forms.TextBox box_carga_horaria;
        private System.Windows.Forms.TextBox box_profissao;
        private System.Windows.Forms.TextBox box_op;
        private System.Windows.Forms.TextBox box_oq_aprender;
        private System.Windows.Forms.Button btn_enviar;
    }
}