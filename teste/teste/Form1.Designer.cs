﻿using System.Windows.Forms;

namespace teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelArredondado2 = new teste.PanelArredondado();
            this.panelArredondado1 = new teste.PanelArredondado();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelArredondado1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(94, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 550);
            this.panel2.TabIndex = 2;

            // 
            // panel3
            // 

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cursos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panelArredondado2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(620, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 550);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Laboratórios";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 63);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(168, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Home";
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
            // panelArredondado2
            // 
            this.panelArredondado2.BackColor = System.Drawing.Color.White;
            this.panelArredondado2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelArredondado2.BackgroundImage")));
            this.panelArredondado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelArredondado2.BorderRadius = 30;
            this.panelArredondado2.ForeColor = System.Drawing.Color.Black;
            this.panelArredondado2.GradientAngle = 0F;
            this.panelArredondado2.GradientBottomColor = System.Drawing.Color.Transparent;
            this.panelArredondado2.GradientTopColor = System.Drawing.Color.Transparent;
            this.panelArredondado2.Location = new System.Drawing.Point(12, 93);
            this.panelArredondado2.Name = "panelArredondado2";
            this.panelArredondado2.Size = new System.Drawing.Size(323, 440);
            this.panelArredondado2.TabIndex = 6;
            // 
            // panelArredondado1
            // 
            this.panelArredondado1.BackColor = System.Drawing.Color.White;
            this.panelArredondado1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelArredondado1.BackgroundImage")));
            this.panelArredondado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelArredondado1.BorderRadius = 30;
            this.panelArredondado1.ForeColor = System.Drawing.Color.Black;
            this.panelArredondado1.GradientAngle = 0F;
            this.panelArredondado1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.panelArredondado1.GradientTopColor = System.Drawing.Color.Transparent;
            this.panelArredondado1.Location = new System.Drawing.Point(12, 93);
            this.panelArredondado1.Name = "panelArredondado1";
            this.panelArredondado1.Size = new System.Drawing.Size(323, 440);
            this.panelArredondado1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";

            this.Load += new System.EventHandler(this.Form1_Load);

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private PanelArredondado panelArredondado2;
        private PanelArredondado panelArredondado1;
    }
}

