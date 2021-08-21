using System;
using System.Windows.Forms;

namespace Teclado
{

    public partial class FrasesProntas : Form
    {
        public FrasesProntas()
        {
            InitializeComponent();
        }
        // Pega o texto e joga no memo
        private void KeySender_Click(object sender, EventArgs e)
        {
            this.textArea2.Text += ((Control)sender).Text + " ";
        }
        // Timer MENU
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Loop do Tab no menu
            if (this.ActiveControl.Name == "btnEmocoes")
            {
                btnDor.Focus();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }
        //Btn Retorna Loop
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            pnPrincipal.Enabled = true;
            btnDor.Focus();
            pnDor.Enabled = false;
            pnLigar.Enabled = false;
            pnFome.Enabled = false;
            pnSede.Enabled = false;
            pnSentir.Enabled = false;
            pnEmocoes.Enabled = false;
        }
        //Btn Retornar Teclado
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Btn Desfazer Ação
        private void btnDesfazer_Click(object sender, EventArgs e)
        {

        }
        //btnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textArea2.Clear();
            pnPrincipal.Enabled = true;
            pnDor.Enabled = false;
            pnLigar.Enabled = false;
            pnFome.Enabled = false;
            pnSede.Enabled = false;
            pnSentir.Enabled = false;
            pnEmocoes.Enabled = false;
        }
        //Btn DOR
        private void btnDor_Click(object sender, EventArgs e)
        {
            //Envia Texto para textArea2
            this.textArea2.Text += ((Control)sender).Text + " ";
            //Desativa o Loop
            timerFrases.Enabled = false;
            //habilita painel Dor
            pnDor.Enabled = true;
            //desativa painel Principal
            pnPrincipal.Enabled = false;
            //foca no botão Cabeca
            btnCabeca.Focus();
        }
        //Timer DORES
        private void timerDor_Tick(object sender, EventArgs e)
        {
            {
                //Loop do Tab no menu
                if (this.ActiveControl.Name == "btnFechar")
                {
                    btnCabeca.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        //Btn Ligar
        private void btnLigar_Click(object sender, EventArgs e)
        {
            this.textArea2.Text += ((Control)sender).Text + " ";
            //Desativa o Loop
            timerFrases.Enabled = false;
            pnLigar.Enabled = true;
            pnPrincipal.Enabled = false;
            btnReponsavel.Focus();
        }
        //Timer Ligar
        private void timerLigar_Tick(object sender, EventArgs e)
        {
            {
                //Loop do Tab no menu
                if (this.ActiveControl.Name == "btnFechar")
                {
                    btnReponsavel.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        //Btn Fome
        private void btnFome_Click(object sender, EventArgs e)
        {
            this.textArea2.Text += ((Control)sender).Text + " ";
            //Desativa o Loop
            timerFrases.Enabled = false;
            pnFome.Enabled = true;
            pnPrincipal.Enabled = false;
            btnFrutas.Focus();
        }
        //Timer Fome
        private void timerFome_Tick(object sender, EventArgs e)
        {
            {
                //Loop do Tab no menu
                if (this.ActiveControl.Name == "btnFechar")
                {
                    btnFrutas.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        //btn Sede
        private void btnSede_Click(object sender, EventArgs e)
        {
            this.textArea2.Text += ((Control)sender).Text + " ";
            //Desativa o Loop
            timerFrases.Enabled = false;
            pnSede.Enabled = true;
            pnPrincipal.Enabled = false;
            btnAgua.Focus();
        }
        //Timer Sede
        private void timerSede_Tick(object sender, EventArgs e)
        {
            {
                //Loop do Tab no menu
                if (this.ActiveControl.Name == "btnFechar")
                {
                    btnAgua.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        //btn Sentir
        private void btnSentir_Click(object sender, EventArgs e)
        {
            this.textArea2.Text += ((Control)sender).Text + " ";
            timerFrases.Enabled = false;
            pnSentir.Enabled = true;
            pnPrincipal.Enabled = false;
            btnCalor.Focus();
        }
        //Timer Sentir
        private void timerSentir_Tick(object sender, EventArgs e)
        {
            {
                //Loop do Tab no menu
                if (this.ActiveControl.Name == "btnFechar")
                {
                    btnCalor.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        //btn Emocoes
        private void btnEmocoes_Click(object sender, EventArgs e)
        {
            this.textArea2.Text += ((Control)sender).Text + " ";
            timerFrases.Enabled = false;
            pnEmocoes.Enabled = true;
            pnPrincipal.Enabled = false;
            btnFeliz.Focus();
        }
        //Timer Emocoes
        private void timerEmocoes_Tick(object sender, EventArgs e)
        {
            {
                //Loop do Tab no menu
                if (this.ActiveControl.Name == "btnFechar")
                {
                    btnEmocoes.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
    }
}
