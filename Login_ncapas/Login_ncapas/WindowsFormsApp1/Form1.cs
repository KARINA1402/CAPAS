using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ClassLibrary_E.Class1 obje = new ClassLibrary_E.Class1();
        ClassLibrary_N.Class1 objn = new ClassLibrary_N.Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.usu1 = txtusuario.Text;
            obje.pas1 = txtpassword.Text;
            dt = objn.N_login(obje);

            if (dt.Rows.Count > 0)
            {
                obje.usu1 = dt.Rows[0][0].ToString();
                obje.pas1 = dt.Rows[0][1].ToString();
                MessageBox.Show("Bienvenido " + obje.usu1, "Mensaje");

                //this.Hide();

                Principal pri = new Principal();
                pri.Show();
                txtusuario.Text = "";
                txtpassword.Text = "";
            }
            else 
            {
                MessageBox.Show("Error","Mensaje");
            }
                
        }
    }
}
