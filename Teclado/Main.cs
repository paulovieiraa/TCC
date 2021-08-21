using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teclado
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }        
        //Btn Calibrar Equipamento
        private void button1_Click(object sender, EventArgs e)
        {
            Calibrar b = new Calibrar();
            b.ShowDialog();
        }
        //Btn Iniciar ("Chama tela do Teclado")
        private void button3_Click(object sender, EventArgs e)
        {
            FormTecladoVirtual t = new FormTecladoVirtual();
            t.ShowDialog();
        }
        //Btn Sobre 
        private void button4_Click(object sender, EventArgs e)
        {
            Sobre s = new Sobre();
            s.ShowDialog();
        }
        //Btn Fechar
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Loop do Tab no menu, sendo que se tab = btn fechar .: Volta para btnMain
            if (this.ActiveControl.Name == "button2")
            {
                button1.Focus();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
