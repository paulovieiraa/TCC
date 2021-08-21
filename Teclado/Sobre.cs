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
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }
        //Btn Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
