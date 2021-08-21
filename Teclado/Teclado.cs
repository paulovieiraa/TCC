using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Web;

namespace Teclado
{
    public partial class FormTecladoVirtual : Form
    {

        public FormTecladoVirtual()
        {
            InitializeComponent();
        }

        // ********* MENU *********

        //Valida FORM p/ Timer
        private void FormTecladoVirtual_Shown(object sender, EventArgs e)
        {
            timerMenu.Enabled = true;
        }
        //Timer ativo Menu 
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            //Loop do Tab no menu, sendo que se tab = btn fechar .: Volta para btnMain
            if (this.ActiveControl.Name == "btnFechar")
            {
                btnMain.Focus();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }
        //Btn Menu1
        private void btnMain_Click(object sender, EventArgs e)
        {
            timerMenu.Enabled = false;
            //Inicia outro Form
            Main m = new Main();
            m.ShowDialog();
        }
        //Btn Frases Prontas
        private void btnFrases_Click_1(object sender, EventArgs e)
        {
            //Desativar TAB
            timerMenu.Enabled = false;
            //Inicia outro Form
            FrasesProntas f = new FrasesProntas();
            f.ShowDialog();
        }
        //Btn Iniciar Varredura Alfabeto >> 
        private void btnVarrerTeclado_Click(object sender, EventArgs e)
        {
            pnLetras.Enabled = true;
            pnComum.Enabled = true;
            pnNumeros.Enabled = false;
            //desativa timer do Menu
            timerMenu.Enabled = false;
            //desativa timer do Menu3
            timerMenu3.Enabled = false;
            //Focar botão A
            btnA.Focus();
            //Inicia varredura em Menu2
            timerMenu2.Enabled = true;
        }
        //Btn Iniciar Varredura Numeros >> 
        private void button14_Click(object sender, EventArgs e)
        {
            pnLetras.Enabled = false;
            pnComum.Enabled = true;
            pnNumeros.Enabled = true;
            //desativa timer do Menu
            timerMenu.Enabled = false;
            //desativa time do Menu2
            timerMenu2.Enabled = false;
            //Focar botão 0
            btnZero.Focus();
            //Inicia varredura em Menu3
            timerMenu3.Enabled = true;
        }
        //Aumentar Tempo
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            timerMenu.Interval += 1000;
            timerMenu2.Interval = timerMenu.Interval;
            timerMenu3.Interval = timerMenu.Interval;
            //Modificando o Timer da Label em segundos
            label1.Text = "Tempo: " + (timerMenu.Interval / 1000).ToString() + "s";
        }
        //Diminuir Tempo
        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (timerMenu.Interval >= 4000)
            {
                timerMenu.Interval -= 1000;
                timerMenu2.Interval = timerMenu.Interval;
                timerMenu3.Interval = timerMenu.Interval;
                //Modificando o Timer da Label em segundos
                label1.Text = "Tempo: " + (timerMenu.Interval / 1000).ToString() + "s";
            }
        }
        //Salvar em PDF
        private void btnImprimirTexto_Click(object sender, EventArgs e)
        {
            // cria uma instância de iTextSharp.text.Document
            Document documentoPDF_Teclado = new Document();

            // cria um Writer para o documento
            PdfWriter.GetInstance(documentoPDF_Teclado, new
              FileStream("Texto_Teclado_PDF.pdf", FileMode.Create));

            // abre o documento
            documentoPDF_Teclado.Open();

            // adiciona conteúdo
            documentoPDF_Teclado.Add(new Paragraph("Texto" + "\n\n" + txtArea.Text));

            // fecha o documento
            documentoPDF_Teclado.Close();

            MessageBox.Show("Documento PDF criado com sucesso.");
        }
        //Btn Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        // ********* SUB MENU2 *********

        //Timer ativo Menu2 
        private void timerMenu2_Tick(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "btnvolta")
            {
                //Inicia no Botão A
                btnA.Focus();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }
        //BUTTON >> to >> TEXTBOX
        private void KeySender_Click(object sender, EventArgs e) //BTN A
        {
            this.txtArea.Text += ((Control)sender).Text;
        }
        //Btn Pergunta
        private void btnpergunta_Click(object sender, EventArgs e)
        {
            this.txtArea.Text += "?";
        }
        //Btn Exclamação 
        private void button13_Click(object sender, EventArgs e)
        {
            this.txtArea.Text += "!";
        }
        //Btn Virgula
        private void button18_Click(object sender, EventArgs e)
        {
            this.txtArea.Text += ",";
        }
        //Btn Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
        }

        // ********* SUB MENU3 *********

        //Timer ativo Menu3
        private void timerMenu3_Tick(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "btnvolta")
            {
                // Seta foco no botão zero
                btnZero.Focus();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        //Btn Ponto
        private void button19_Click(object sender, EventArgs e)
        {
            this.txtArea.Text += ".";
        }
        //btnvoltar2
        private void btnvoltar2_Click(object sender, EventArgs e)
        {
            //desativa time do Menu 2
            timerMenu2.Enabled = false;
            //desativa time do Menu 3
            timerMenu3.Enabled = false;
            //Inicia no botão Main
            btnMain.Focus();
            //Ativa o Menu 
            timerMenu.Enabled = true;
        }




        // *************************** VALIDO PARA 2 MENUS *******
        //Btn Enter
        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.txtArea.Text += "\r\n";
        }
        //Btn Espaço
        private void btnEspaco_Click(object sender, EventArgs e)
        {
            this.txtArea.Text += " ";
        }
        //Btn BackSpace
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtArea.Text != "")
            {
                this.txtArea.Text = this.txtArea.Text.Remove(this.txtArea.Text.Length - 1, 1);
            }
            else { //não fazer nada
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {

            //Inicia no botão Main
            btnMain.Focus();
            //Ativa o Menu 
            timerMenu.Enabled = true;
            //desativa painel comum
            pnComum.Enabled = false;

            if (timerMenu2.Enabled == true)
            {

                btnMain.Enabled = false;
                pnLetras.Enabled = false;
                //desativa o Menu 2
                timerMenu2.Enabled = false;
                btnA.Focus();

            }
            else if (timerMenu3.Enabled == true)
            {
                btnMain.Enabled = false;
                pnNumeros.Enabled = false;
                //desativa o Menu 3
                timerMenu3.Enabled = false;
            }
        }
    }
}
