using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace teste
{
    public partial class cursos_pg : Form
    {
        int id_cursod;
        conexao con = new conexao();
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

        private void label12_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_cursos));
            t.Start();
            this.Close();
        }
        public static void Abre_tela_c(int id_curso)
        {

            tela_c cursos_exibidos = new tela_c(id_curso);
            cursos_exibidos.ShowDialog();

        }

        private void cursos_pg_Load(object sender, EventArgs e)
        {
            busca(box_nome.Text, box_preco.Text, box_duracao.Text, box_tp.Text, box_modalidade.Text);
        }

        private void cursosClick(object sender, EventArgs e, int id_curso)
        {

            Abre_tela_c(id_curso);



        }

        public void espaco(Label label,int pos)
        {
            label.Location = new Point(label.Location.X, (label.Location.Y + pos));
            label.Refresh();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            busca(box_nome.Text,box_preco.Text,box_duracao.Text,box_tp.Text,box_modalidade.Text);
        }
        private void busca(string nome_curso,string preco,string duracao,string tipo_curso,string modalidade)
        {
            string query;
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            if (nome_curso.ToString() != null)
            {
                query = "select tb_curso.id_curso,tb_curso.nome_curso,tb_curso.preco,tb_tipo_curso.tipo_curso from tb_curso inner join tb_tipo_curso on tb_tipo_curso.id_tipo_curso=tb_curso.id_tipo_curso where tb_curso.nome_curso like '%" + nome_curso.ToString() + "%'";//nome da consulta
                painel_r.Update();
            }
            else
            {
                query = "select tb_curso.id_curso,tb_curso.nome_curso,tb_curso.preco,tb_tipo_curso.tipo_curso from tb_curso inner join tb_tipo_curso on tb_tipo_curso.id_tipo_curso=tb_curso.id_tipo_curso ";//nome da consulta

            
            MySqlCommand comando = new MySqlCommand(query, Conexao);//comando sql para montar

            MySqlDataReader registro = comando.ExecuteReader();//ler os dados da consulta




                while (registro.Read())//ler 1 registro
                {


                    Panel cursos = new Panel()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        AutoSize = true,
                    };
                    Label lbl_cursod = new Label()
                    {

                    };

                    Label Lnome_curso = new Label()

                    {
                        AutoSize = true

                    };
                    Label Lpreco = new Label()

                    {
                        AutoSize = true,


                    };
                    Label Ltipo_curso = new Label()

                    {
                        AutoSize = true

                    };

                    Button curso_pg = new Button()

                    {
                        AutoSize = true

                    };
                    id_cursod = Convert.ToInt32(registro.GetInt32("id_curso"));
                    lbl_cursod.Text = id_cursod.ToString();
                    Lnome_curso.Text = registro.GetString("nome_curso");

                    cursos.Click += new EventHandler((sender1, e1) => cursosClick(sender1, e1, Convert.ToInt32(lbl_cursod.Text)));

                    //cursos.Click += Abre_tela_c();







                    Lpreco.Text = Convert.ToString(registro.GetDecimal("preco"));
                    Ltipo_curso.Text = registro.GetString("tipo_curso");
                    cursos.Controls.Add(Lnome_curso);

                    espaco(Lpreco, 25);
                    //preco.Location = new Point((int)preco.Location.X, (int)(preco.Location.Y - 50));

                    cursos.Controls.Add(Lpreco);

                    cursos.Controls.Add(Ltipo_curso);
                    espaco(Ltipo_curso, 50);
                    painel_r.Controls.Add(cursos);
                }

            }



            Conexao.Close();
        }
    }
    }

