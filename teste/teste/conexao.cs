using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security;

namespace teste
{
    class conexao
    {





        static private string servidor = "localhost";
        static private string bancodedados = "tcc";
        static private string usuario = "root";
        static private string senha = "";

        static private string StrCon = "server=" + servidor + ";database=" + bancodedados + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection getconexao()
        {
            MySqlConnection conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                getconexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result;
        }
        public void desconectar()
        {
            getconexao().Close();
        }
        public DataTable GetCurso_Nome(int a)
        {
            MySqlConnection conexao = getconexao();
            string SQL = "select nome_curso from tb_curso where id_curso=" + a;
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_curso = new DataTable();
            dados.Fill(tb_curso);
            return tb_curso;
        }

        public DataTable Getcursos(int a)
        {
            MySqlConnection conexao = getconexao();
            string SQL = "select id_curso,nome_curso,requisitos,descricao,localizacao,preco,carga_horaria,tb_tipo_curso.tipo_curso,tb_modalidade.modalidade,tb_turno.tipo_turno from tb_curso inner join tb_tipo_curso on tb_curso.id_tipo_curso=tb_tipo_curso.id_tipo_curso inner join tb_modalidade on tb_curso.id_modalidade=tb_modalidade.id_modalidade inner join tb_turno on tb_curso.id_turno=tb_turno.id_turno where tb_tipo_curso.id_tipo_curso=" + a;
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_curso = new DataTable();
            dados.Fill(tb_curso);
            return tb_curso;
        }

    }
}