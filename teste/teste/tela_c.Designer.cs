namespace teste
{
    partial class tela_c
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_req = new System.Windows.Forms.Label();
            this.lbl_requisitos = new System.Windows.Forms.Label();
            this.lbl_op_trabalho = new System.Windows.Forms.Label();
            this.lbl_aprender = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_tp_curso = new System.Windows.Forms.Label();
            this.lbl_modalidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(78, 45);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(33, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "nome";
            // 
            // lbl_req
            // 
            this.lbl_req.AutoSize = true;
            this.lbl_req.Location = new System.Drawing.Point(79, 442);
            this.lbl_req.Name = "lbl_req";
            this.lbl_req.Size = new System.Drawing.Size(51, 13);
            this.lbl_req.TabIndex = 1;
            this.lbl_req.Text = "requisitos";
            // 
            // lbl_requisitos
            // 
            this.lbl_requisitos.AutoSize = true;
            this.lbl_requisitos.Location = new System.Drawing.Point(78, 96);
            this.lbl_requisitos.Name = "lbl_requisitos";
            this.lbl_requisitos.Size = new System.Drawing.Size(49, 13);
            this.lbl_requisitos.TabIndex = 2;
            this.lbl_requisitos.Text = "profissao";
            // 
            // lbl_op_trabalho
            // 
            this.lbl_op_trabalho.AutoSize = true;
            this.lbl_op_trabalho.Location = new System.Drawing.Point(78, 143);
            this.lbl_op_trabalho.Name = "lbl_op_trabalho";
            this.lbl_op_trabalho.Size = new System.Drawing.Size(125, 13);
            this.lbl_op_trabalho.TabIndex = 3;
            this.lbl_op_trabalho.Text = "oportunidade de trabalho";
            // 
            // lbl_aprender
            // 
            this.lbl_aprender.AutoSize = true;
            this.lbl_aprender.Location = new System.Drawing.Point(78, 192);
            this.lbl_aprender.Name = "lbl_aprender";
            this.lbl_aprender.Size = new System.Drawing.Size(105, 13);
            this.lbl_aprender.TabIndex = 4;
            this.lbl_aprender.Text = "Materias Lecionadas";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(78, 235);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(34, 13);
            this.lbl_preco.TabIndex = 5;
            this.lbl_preco.Text = "preço";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(78, 272);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(69, 13);
            this.lbl_hora.TabIndex = 6;
            this.lbl_hora.Text = "carga horaria";
            // 
            // lbl_tp_curso
            // 
            this.lbl_tp_curso.AutoSize = true;
            this.lbl_tp_curso.Location = new System.Drawing.Point(79, 324);
            this.lbl_tp_curso.Name = "lbl_tp_curso";
            this.lbl_tp_curso.Size = new System.Drawing.Size(58, 13);
            this.lbl_tp_curso.TabIndex = 7;
            this.lbl_tp_curso.Text = "Tipo Curso";
            // 
            // lbl_modalidade
            // 
            this.lbl_modalidade.AutoSize = true;
            this.lbl_modalidade.Location = new System.Drawing.Point(78, 371);
            this.lbl_modalidade.Name = "lbl_modalidade";
            this.lbl_modalidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_modalidade.TabIndex = 8;
            this.lbl_modalidade.Text = "Modalidade";
            // 
            // tela_c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.lbl_modalidade);
            this.Controls.Add(this.lbl_tp_curso);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_aprender);
            this.Controls.Add(this.lbl_op_trabalho);
            this.Controls.Add(this.lbl_requisitos);
            this.Controls.Add(this.lbl_req);
            this.Controls.Add(this.lbl_nome);
            this.Name = "tela_c";
            this.Text = "tela_c";
            this.Load += new System.EventHandler(this.tela_c_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_req;
        private System.Windows.Forms.Label lbl_requisitos;
        private System.Windows.Forms.Label lbl_op_trabalho;
        private System.Windows.Forms.Label lbl_aprender;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_tp_curso;
        private System.Windows.Forms.Label lbl_modalidade;
    }
}