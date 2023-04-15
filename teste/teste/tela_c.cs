using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class tela_c : Form
    {
        Font SuperMiniFont = new Font("Arial", 8, FontStyle.Bold);
        Font MiniFont = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
        Font SmallFont = new Font("Arial", 24, FontStyle.Bold);
        Font MediumFont = new Font("Arial", 26, FontStyle.Bold | FontStyle.Underline);

        int _id_curso; 
        conexao con = new conexao();
        public tela_c(int id_curso)
        {
           _id_curso = id_curso;
            InitializeComponent();
        }
        public static void abre_home()
        {

            Application.Run(new Form1());
        }

        public static void abre_cursos()
        {

            Application.Run(new cursos_pg());
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_home));
            t.Start();
            this.Close();
        }


        private void tela_c_Load(object sender, EventArgs e)
        {
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string query = "select id_curso,nome_curso,requisitos,profissao,op_trabalho,q_vai_aprender,preco,carga_horaria,tb_tipo_curso.tipo_curso, tb_modalidade.modalidade from tb_curso inner join tb_tipo_curso on tb_tipo_curso.id_tipo_curso=tb_curso.id_tipo_curso inner join tb_modalidade on tb_modalidade.id_modalidade=tb_curso.id_modalidade where id_curso="+_id_curso;//nome da consulta
            MySqlCommand comando = new MySqlCommand(query, Conexao);//comando sql para montar
            MySqlDataReader registro = comando.ExecuteReader();//ler os dados da consulta
            registro.Read();
            lbl_NomeMenu.Text = registro.GetString("nome_curso");
            lbl_nome.Text = registro.GetString("nome_curso");
            lbl_req.Text = registro.GetString("requisitos");
            lbl_prof.Text = registro.GetString("profissao");
            lbl_op_trabalho.Text = registro.GetString("op_trabalho");
            lbl_aprender.Text = registro.GetString("q_vai_aprender");
            lbl_preco.Text += registro.GetString("preco");
            lbl_hora.Text += registro.GetString("carga_horaria");
            lbl_tp_curso.Text = registro.GetString("tipo_curso");
            lbl_modalidade.Text = registro.GetString("modalidade");
            registro.Close();
            Conexao.Close();

        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Point[] myArray =
        // {
        //    new Point(20,100),
        //    new Point(40,100),
        //    new Point(20,250),
        //    new Point(40,250),
           
        // };
        //    GraphicsPath Forma = new GraphicsPath();
            
        //    Forma.AddClosedCurve(myArray,.3f);
        //    panel2.Region=new   Region( Forma);
        //}
        private void label12_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_cursos));
            t.Start();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_home));
            t.Start();
            this.Close();
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = MiniFont;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = SuperMiniFont;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            label12.Font = MiniFont;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.Font = SuperMiniFont;
        }
    }
}
