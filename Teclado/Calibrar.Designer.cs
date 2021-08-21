namespace Teclado
{
    partial class Calibrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibrar));
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumeroAmostras = new System.Windows.Forms.TextBox();
            this.btnInicarGrafico = new System.Windows.Forms.Button();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerGrafico = new System.Windows.Forms.Timer(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPararGrafico = new System.Windows.Forms.Button();
            this.cb_Impressoras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(596, 459);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 37);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Retornar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Amostras";
            // 
            // textNumeroAmostras
            // 
            this.textNumeroAmostras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroAmostras.Location = new System.Drawing.Point(427, 23);
            this.textNumeroAmostras.Name = "textNumeroAmostras";
            this.textNumeroAmostras.Size = new System.Drawing.Size(62, 23);
            this.textNumeroAmostras.TabIndex = 3;
            // 
            // btnInicarGrafico
            // 
            this.btnInicarGrafico.Location = new System.Drawing.Point(271, 75);
            this.btnInicarGrafico.Name = "btnInicarGrafico";
            this.btnInicarGrafico.Size = new System.Drawing.Size(86, 37);
            this.btnInicarGrafico.TabIndex = 4;
            this.btnInicarGrafico.Text = "Iniciar Gráfico";
            this.btnInicarGrafico.UseVisualStyleBackColor = true;
            this.btnInicarGrafico.Click += new System.EventHandler(this.btnInicarGrafico_Click);
            // 
            // chtGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Pulso Muscular";
            this.chtGrafico.Legends.Add(legend1);
            this.chtGrafico.Location = new System.Drawing.Point(29, 124);
            this.chtGrafico.Name = "chtGrafico";
            this.chtGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Musculo";
            series1.YValuesPerPoint = 4;
            this.chtGrafico.Series.Add(series1);
            this.chtGrafico.Size = new System.Drawing.Size(561, 358);
            this.chtGrafico.TabIndex = 7;
            this.chtGrafico.Text = "chart1";
            // 
            // timerCOM
            // 
            this.timerCOM.Enabled = true;
            this.timerCOM.Interval = 3000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Controlador";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(140, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 26);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "BaudRate:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 26);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Porta de Conexão: ";
            // 
            // timerGrafico
            // 
            this.timerGrafico.Interval = 1000;
            this.timerGrafico.Tick += new System.EventHandler(this.timerGrafico_Tick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(596, 124);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 37);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir\r\n";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(596, 189);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 37);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar em PDF";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPararGrafico
            // 
            this.btnPararGrafico.Location = new System.Drawing.Point(387, 75);
            this.btnPararGrafico.Name = "btnPararGrafico";
            this.btnPararGrafico.Size = new System.Drawing.Size(86, 37);
            this.btnPararGrafico.TabIndex = 9;
            this.btnPararGrafico.Text = "Para Gráfico";
            this.btnPararGrafico.UseVisualStyleBackColor = true;
            this.btnPararGrafico.Click += new System.EventHandler(this.btnPararGrafico_Click);
            // 
            // cb_Impressoras
            // 
            this.cb_Impressoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Impressoras.FormattingEnabled = true;
            this.cb_Impressoras.Location = new System.Drawing.Point(507, 84);
            this.cb_Impressoras.Name = "cb_Impressoras";
            this.cb_Impressoras.Size = new System.Drawing.Size(175, 21);
            this.cb_Impressoras.TabIndex = 10;
            // 
            // Calibrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 508);
            this.Controls.Add(this.cb_Impressoras);
            this.Controls.Add(this.btnPararGrafico);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chtGrafico);
            this.Controls.Add(this.btnInicarGrafico);
            this.Controls.Add(this.textNumeroAmostras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calibrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calibrar Equipamento";
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumeroAmostras;
        private System.Windows.Forms.Button btnInicarGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerGrafico;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPararGrafico;
        private System.Windows.Forms.ComboBox cb_Impressoras;
    }
}