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
    public partial class cursos_pg : Form
    {
        public cursos_pg()
        {
            InitializeComponent();
        }
        public static void abre_home()
        {

            Application.Run(new Form1());
        }

        public static void abre_cursos()
        {

            Application.Run(new cursos());
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

        private void label12_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_cursos));
            t.Start();
            this.Close();
        }
    }
    /*private void cursos_Load(object sender, EventArgs e)
    {
        MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
        Conexao.Open();//abre conexao
        string query = "select nome_curso from tb_curso where id_curso=1";//nome da consulta
        MySqlCommand comando = new MySqlCommand(query, Conexao);//comando sql para montar

        MySqlDataReader registro = comando.ExecuteReader();//ler os dados da consulta




        while (registro.Read())//ler 1 registro

            label3.Text = Convert.ToString(registro["nome_curso"]) + "\n";//pega o registro e monstra no label


        Conexao.Close();
    }*/
}
