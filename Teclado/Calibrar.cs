using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
namespace Teclado
{
    public partial class Calibrar : Form
    {
        public Calibrar()
        {
            InitializeComponent();
            //ativa timer 
            timerCOM.Enabled = true;
            //cria estilo de grafico
            chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            //Carrega lista de Impressoras Disponiveis
            CarregarListaDeImpressoras();
        }
        //Variaveis
        int valor,media,tamanho,x=0; //valor = dado recebido hardware;
        int porcentagem = 1, porcentagem2;

        public object Helper { get; private set; }

        //btn Imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using (var printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.PrinterSettings.PrinterName = cb_Impressoras.SelectedItem.ToString();
                printDocument.Print();
            }
        }
        //Void Carregar Impressoras
        public void CarregarListaDeImpressoras()
        {
            cb_Impressoras.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cb_Impressoras.Items.Add(printer);
            }
        }
        //Metodo Imprimir
        public void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var printDocument = sender as System.Drawing.Printing.PrintDocument;
            if (printDocument != null)
            {
                using (var font = new System.Drawing.Font("Times New Roman", 14))
                using (var brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString(
                        "Dados do Calibrador"+"\n\n"+
                        "Porta de Conexao:" + " " +comboBox1.Text+"\n"+
                        "BaudRate:" + " " +comboBox2.Text+"\n\n"+
                        "Dados da Amostra"+"\n"+
                        "Numero de Amostras:"+" "+textNumeroAmostras.Text + "\n"+
                        "Grafico" +"\n" + chtGrafico,
                        font,
                        brush,
                        new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }
        //btn Salvar para PDF
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // cria uma instância de iTextSharp.text.Document
            Document documentoPDF_Teclado = new Document();

            // cria um Writer para o documento
            //Interbet //c = new PdfPCell(new Phrase(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " GMT", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14)));
            PdfWriter.GetInstance(documentoPDF_Teclado, new
              FileStream("Calibrar_Teclado_PDF.pdf", FileMode.Create));

            // abre o documento
            documentoPDF_Teclado.Open();

            // adiciona conteúdo
            documentoPDF_Teclado.Add(new Paragraph("Dados do Calibrador" + "\n\n" +
                        "Porta de Conexao:" + " " + comboBox1.Text + "\n" +
                        "BaudRate:" + " " + comboBox2.Text + "\n\n" +
                        "Dados da Amostra" + "\n" +
                        "Numero de Amostras:" + " " + textNumeroAmostras.Text + "\n" +
                        "Grafico"));

            var chartimage = new MemoryStream();
            chtGrafico.SaveImage(chartimage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            documentoPDF_Teclado.Add(Chart_image);

            // fecha o documento
            documentoPDF_Teclado.Close();

            MessageBox.Show("Documento PDF criado com sucesso.");
        }
        //btn Para Grafico
        private void btnPararGrafico_Click(object sender, EventArgs e)
        {
            timerGrafico.Stop();
        }
        //btn Iniciar Grafico
        private void btnInicarGrafico_Click(object sender, EventArgs e)
        {
            timerGrafico.Start();
        }

        //Btn Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //CONEXAO COM ARDUINO
        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou
            i = 0;
            quantDiferente = false;
            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }
            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;//retorna
            }
            //limpa comboBox
            comboBox1.Items.Clear();
            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista na COM
            comboBox1.SelectedIndex = 0;
        }


        //Grafico Dinamico [ Em tempo real]
        private void timerGrafico_Tick(object sender, EventArgs e)
        {
            //verifica valores recebido no grafico, em função ao eixo X
            if(chtGrafico.Series[0].Points.Count > 10)
            {
                //remover o primeiro ponto
                chtGrafico.Series[0].Points.RemoveAt(0);
                chtGrafico.Update();
            }
            //adiciona valores
            //new Random().NextDouble()
            chtGrafico.Series[0].Points.AddXY(x++, new Random().NextDouble());
            chtGrafico.BeginInit();
        }
    }
}
