using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teste
{
    public partial class Form1 : Form
    {
        Font smallFont = new Font("Arial", 24, FontStyle.Bold);
        Font MediumFont = new Font("Arial", 26, FontStyle.Bold | FontStyle.Underline);

        public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public static void abre_pg_curso()
        {
           
            Application.Run(new cursos_pg());
        }
        public static void abre_lab()
        {

            Application.Run(new lab());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_pg_curso));
            t.Start();
            this.Close();
          

            
        }

      


        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = MediumFont;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = smallFont;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = MediumFont;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = smallFont;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(abre_lab));
            t.Start();
            this.Close();
        }

    

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12 && e.Control && e.Shift)
            {
                LoginADM tela_login_ADM = new LoginADM();
                tela_login_ADM.ShowDialog();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
