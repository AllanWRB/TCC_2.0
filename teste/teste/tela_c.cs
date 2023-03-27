using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class tela_c : Form
    {
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
    }
}
