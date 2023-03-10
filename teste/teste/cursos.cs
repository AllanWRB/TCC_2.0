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
    public partial class cursos : Form
    {
        Font SuperMiniFont = new Font("Arial", 8, FontStyle.Bold);
        Font MiniFont = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
        Font SmallFont = new Font("Arial", 24, FontStyle.Bold);
        Font MediumFont = new Font("Arial", 26, FontStyle.Bold | FontStyle.Underline);
        public cursos()
        {
            InitializeComponent();
        }
        public static void abre_home()
        {

            Application.Run(new Form1());
        }

        public static void abre_pg_cursos()
        {

            Application.Run(new cursos_pg());
        }
        private void label1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_home));
            t.Start();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_home));
            t.Start();
            this.Close();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.Font = MiniFont;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = SuperMiniFont;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_pg_cursos));
            t.Start();
            this.Close();
        }
    }
}
