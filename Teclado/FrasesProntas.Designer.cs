namespace Teclado
{
    partial class FrasesProntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrasesProntas));
            this.btnFechar = new System.Windows.Forms.Button();
            this.timerFrases = new System.Windows.Forms.Timer(this.components);
            this.btnvoltar = new System.Windows.Forms.Button();
            this.textArea2 = new System.Windows.Forms.TextBox();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.btnSentir = new System.Windows.Forms.Button();
            this.btnEmocoes = new System.Windows.Forms.Button();
            this.btnSede = new System.Windows.Forms.Button();
            this.btnFome = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDor = new System.Windows.Forms.Button();
            this.pnDor = new System.Windows.Forms.Panel();
            this.btnPe = new System.Windows.Forms.Button();
            this.btnPernas = new System.Windows.Forms.Button();
            this.btnBarriga = new System.Windows.Forms.Button();
            this.btnCostas = new System.Windows.Forms.Button();
            this.btnTorax = new System.Windows.Forms.Button();
            this.btnPescoco = new System.Windows.Forms.Button();
            this.btnCabeca = new System.Windows.Forms.Button();
            this.pnLigar = new System.Windows.Forms.Panel();
            this.btnBombeiro = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.btnReponsavel = new System.Windows.Forms.Button();
            this.btnPolicia = new System.Windows.Forms.Button();
            this.pnFome = new System.Windows.Forms.Panel();
            this.btnLanche = new System.Windows.Forms.Button();
            this.btnAlmoco = new System.Windows.Forms.Button();
            this.btnFrutas = new System.Windows.Forms.Button();
            this.pnSede = new System.Windows.Forms.Panel();
            this.btnRefrigerante = new System.Windows.Forms.Button();
            this.btnSuco = new System.Windows.Forms.Button();
            this.btnAgua = new System.Windows.Forms.Button();
            this.pnEmocoes = new System.Windows.Forms.Panel();
            this.btnCansado = new System.Windows.Forms.Button();
            this.btnAlegre = new System.Windows.Forms.Button();
            this.btnIrritado = new System.Windows.Forms.Button();
            this.btnBravo = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.btnFeliz = new System.Windows.Forms.Button();
            this.pnSentir = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalor = new System.Windows.Forms.Button();
            this.btnFrio = new System.Windows.Forms.Button();
            this.pnRetorna = new System.Windows.Forms.Panel();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.timerDor = new System.Windows.Forms.Timer(this.components);
            this.timerFome = new System.Windows.Forms.Timer(this.components);
            this.timerLigar = new System.Windows.Forms.Timer(this.components);
            this.timerSede = new System.Windows.Forms.Timer(this.components);
            this.timerSentir = new System.Windows.Forms.Timer(this.components);
            this.timerEmocoes = new System.Windows.Forms.Timer(this.components);
            this.pnPrincipal.SuspendLayout();
            this.pnDor.SuspendLayout();
            this.pnLigar.SuspendLayout();
            this.pnFome.SuspendLayout();
            this.pnSede.SuspendLayout();
            this.pnEmocoes.SuspendLayout();
            this.pnSentir.SuspendLayout();
            this.pnRetorna.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(429, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(130, 39);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "RETORNAR TECLADO";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // timerFrases
            // 
            this.timerFrases.Interval = 4000;
            this.timerFrases.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(293, 0);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(130, 39);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "RETORNAR LOOP";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // textArea2
            // 
            this.textArea2.Location = new System.Drawing.Point(104, 239);
            this.textArea2.Multiline = true;
            this.textArea2.Name = "textArea2";
            this.textArea2.Size = new System.Drawing.Size(380, 122);
            this.textArea2.TabIndex = 35;
            this.textArea2.TabStop = false;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.btnSentir);
            this.pnPrincipal.Controls.Add(this.btnEmocoes);
            this.pnPrincipal.Controls.Add(this.btnSede);
            this.pnPrincipal.Controls.Add(this.btnFome);
            this.pnPrincipal.Controls.Add(this.btnLigar);
            this.pnPrincipal.Controls.Add(this.btnDor);
            this.pnPrincipal.Location = new System.Drawing.Point(8, 4);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(574, 46);
            this.pnPrincipal.TabIndex = 36;
            this.pnPrincipal.TabStop = true;
            // 
            // btnSentir
            // 
            this.btnSentir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSentir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSentir.Location = new System.Drawing.Point(386, 4);
            this.btnSentir.Name = "btnSentir";
            this.btnSentir.Size = new System.Drawing.Size(87, 39);
            this.btnSentir.TabIndex = 4;
            this.btnSentir.Text = "SENTIR";
            this.btnSentir.UseVisualStyleBackColor = true;
            this.btnSentir.Click += new System.EventHandler(this.btnSentir_Click);
            // 
            // btnEmocoes
            // 
            this.btnEmocoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmocoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmocoes.Location = new System.Drawing.Point(481, 4);
            this.btnEmocoes.Name = "btnEmocoes";
            this.btnEmocoes.Size = new System.Drawing.Size(87, 39);
            this.btnEmocoes.TabIndex = 5;
            this.btnEmocoes.Text = "EMOÇÕES";
            this.btnEmocoes.UseVisualStyleBackColor = true;
            this.btnEmocoes.Click += new System.EventHandler(this.btnEmocoes_Click);
            // 
            // btnSede
            // 
            this.btnSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSede.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSede.Location = new System.Drawing.Point(291, 4);
            this.btnSede.Name = "btnSede";
            this.btnSede.Size = new System.Drawing.Size(87, 39);
            this.btnSede.TabIndex = 3;
            this.btnSede.Text = "SEDE";
            this.btnSede.UseVisualStyleBackColor = true;
            this.btnSede.Click += new System.EventHandler(this.btnSede_Click);
            // 
            // btnFome
            // 
            this.btnFome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFome.Location = new System.Drawing.Point(196, 4);
            this.btnFome.Name = "btnFome";
            this.btnFome.Size = new System.Drawing.Size(87, 39);
            this.btnFome.TabIndex = 2;
            this.btnFome.Text = "FOME";
            this.btnFome.UseVisualStyleBackColor = true;
            this.btnFome.Click += new System.EventHandler(this.btnFome_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLigar.Location = new System.Drawing.Point(101, 4);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(87, 39);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDor
            // 
            this.btnDor.BackColor = System.Drawing.SystemColors.Control;
            this.btnDor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDor.Location = new System.Drawing.Point(6, 4);
            this.btnDor.Name = "btnDor";
            this.btnDor.Size = new System.Drawing.Size(87, 39);
            this.btnDor.TabIndex = 0;
            this.btnDor.Text = "DOR";
            this.btnDor.UseVisualStyleBackColor = true;
            this.btnDor.Click += new System.EventHandler(this.btnDor_Click);
            // 
            // pnDor
            // 
            this.pnDor.Controls.Add(this.btnPe);
            this.pnDor.Controls.Add(this.btnPernas);
            this.pnDor.Controls.Add(this.btnBarriga);
            this.pnDor.Controls.Add(this.btnCostas);
            this.pnDor.Controls.Add(this.btnTorax);
            this.pnDor.Controls.Add(this.btnPescoco);
            this.pnDor.Controls.Add(this.btnCabeca);
            this.pnDor.Enabled = false;
            this.pnDor.Location = new System.Drawing.Point(8, 49);
            this.pnDor.Name = "pnDor";
            this.pnDor.Size = new System.Drawing.Size(93, 320);
            this.pnDor.TabIndex = 37;
            this.pnDor.TabStop = true;
            // 
            // btnPe
            // 
            this.btnPe.Location = new System.Drawing.Point(3, 276);
            this.btnPe.Name = "btnPe";
            this.btnPe.Size = new System.Drawing.Size(87, 39);
            this.btnPe.TabIndex = 6;
            this.btnPe.Text = "Pé";
            this.btnPe.UseVisualStyleBackColor = true;
            this.btnPe.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnPernas
            // 
            this.btnPernas.Location = new System.Drawing.Point(3, 231);
            this.btnPernas.Name = "btnPernas";
            this.btnPernas.Size = new System.Drawing.Size(87, 39);
            this.btnPernas.TabIndex = 5;
            this.btnPernas.Text = "Pernas";
            this.btnPernas.UseVisualStyleBackColor = true;
            this.btnPernas.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnBarriga
            // 
            this.btnBarriga.Location = new System.Drawing.Point(3, 186);
            this.btnBarriga.Name = "btnBarriga";
            this.btnBarriga.Size = new System.Drawing.Size(87, 39);
            this.btnBarriga.TabIndex = 4;
            this.btnBarriga.Text = "Barriga";
            this.btnBarriga.UseVisualStyleBackColor = true;
            this.btnBarriga.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnCostas
            // 
            this.btnCostas.Location = new System.Drawing.Point(3, 141);
            this.btnCostas.Name = "btnCostas";
            this.btnCostas.Size = new System.Drawing.Size(87, 39);
            this.btnCostas.TabIndex = 3;
            this.btnCostas.Text = "Costas";
            this.btnCostas.UseVisualStyleBackColor = true;
            this.btnCostas.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnTorax
            // 
            this.btnTorax.Location = new System.Drawing.Point(3, 96);
            this.btnTorax.Name = "btnTorax";
            this.btnTorax.Size = new System.Drawing.Size(87, 39);
            this.btnTorax.TabIndex = 2;
            this.btnTorax.Text = "Torax";
            this.btnTorax.UseVisualStyleBackColor = true;
            this.btnTorax.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnPescoco
            // 
            this.btnPescoco.Location = new System.Drawing.Point(3, 51);
            this.btnPescoco.Name = "btnPescoco";
            this.btnPescoco.Size = new System.Drawing.Size(87, 39);
            this.btnPescoco.TabIndex = 1;
            this.btnPescoco.Text = "Pescoço";
            this.btnPescoco.UseVisualStyleBackColor = true;
            this.btnPescoco.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnCabeca
            // 
            this.btnCabeca.Location = new System.Drawing.Point(3, 6);
            this.btnCabeca.Name = "btnCabeca";
            this.btnCabeca.Size = new System.Drawing.Size(87, 39);
            this.btnCabeca.TabIndex = 0;
            this.btnCabeca.Text = "Cabeça";
            this.btnCabeca.UseVisualStyleBackColor = true;
            this.btnCabeca.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // pnLigar
            // 
            this.pnLigar.Controls.Add(this.btnBombeiro);
            this.pnLigar.Controls.Add(this.btnHospital);
            this.pnLigar.Controls.Add(this.btnReponsavel);
            this.pnLigar.Controls.Add(this.btnPolicia);
            this.pnLigar.Enabled = false;
            this.pnLigar.Location = new System.Drawing.Point(107, 49);
            this.pnLigar.Name = "pnLigar";
            this.pnLigar.Size = new System.Drawing.Size(88, 187);
            this.pnLigar.TabIndex = 38;
            this.pnLigar.TabStop = true;
            // 
            // btnBombeiro
            // 
            this.btnBombeiro.Location = new System.Drawing.Point(1, 141);
            this.btnBombeiro.Name = "btnBombeiro";
            this.btnBombeiro.Size = new System.Drawing.Size(87, 39);
            this.btnBombeiro.TabIndex = 3;
            this.btnBombeiro.Text = "Bombeiro";
            this.btnBombeiro.UseVisualStyleBackColor = true;
            this.btnBombeiro.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnHospital
            // 
            this.btnHospital.Location = new System.Drawing.Point(1, 96);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(87, 39);
            this.btnHospital.TabIndex = 2;
            this.btnHospital.Text = "Hospital";
            this.btnHospital.UseVisualStyleBackColor = true;
            this.btnHospital.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnReponsavel
            // 
            this.btnReponsavel.Location = new System.Drawing.Point(1, 6);
            this.btnReponsavel.Name = "btnReponsavel";
            this.btnReponsavel.Size = new System.Drawing.Size(87, 39);
            this.btnReponsavel.TabIndex = 0;
            this.btnReponsavel.Text = "Responsavel";
            this.btnReponsavel.UseVisualStyleBackColor = true;
            this.btnReponsavel.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnPolicia
            // 
            this.btnPolicia.Location = new System.Drawing.Point(1, 51);
            this.btnPolicia.Name = "btnPolicia";
            this.btnPolicia.Size = new System.Drawing.Size(87, 39);
            this.btnPolicia.TabIndex = 1;
            this.btnPolicia.Text = "Policia";
            this.btnPolicia.UseVisualStyleBackColor = true;
            this.btnPolicia.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // pnFome
            // 
            this.pnFome.Controls.Add(this.btnLanche);
            this.pnFome.Controls.Add(this.btnAlmoco);
            this.pnFome.Controls.Add(this.btnFrutas);
            this.pnFome.Enabled = false;
            this.pnFome.Location = new System.Drawing.Point(202, 49);
            this.pnFome.Name = "pnFome";
            this.pnFome.Size = new System.Drawing.Size(89, 184);
            this.pnFome.TabIndex = 39;
            this.pnFome.TabStop = true;
            // 
            // btnLanche
            // 
            this.btnLanche.Location = new System.Drawing.Point(-1, 98);
            this.btnLanche.Name = "btnLanche";
            this.btnLanche.Size = new System.Drawing.Size(87, 39);
            this.btnLanche.TabIndex = 2;
            this.btnLanche.Text = "Lanche";
            this.btnLanche.UseVisualStyleBackColor = true;
            this.btnLanche.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnAlmoco
            // 
            this.btnAlmoco.Location = new System.Drawing.Point(-1, 53);
            this.btnAlmoco.Name = "btnAlmoco";
            this.btnAlmoco.Size = new System.Drawing.Size(87, 39);
            this.btnAlmoco.TabIndex = 1;
            this.btnAlmoco.Text = "Almoço";
            this.btnAlmoco.UseVisualStyleBackColor = true;
            this.btnAlmoco.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnFrutas
            // 
            this.btnFrutas.Location = new System.Drawing.Point(-1, 8);
            this.btnFrutas.Name = "btnFrutas";
            this.btnFrutas.Size = new System.Drawing.Size(87, 39);
            this.btnFrutas.TabIndex = 0;
            this.btnFrutas.Text = "Frutas";
            this.btnFrutas.UseVisualStyleBackColor = true;
            this.btnFrutas.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // pnSede
            // 
            this.pnSede.Controls.Add(this.btnRefrigerante);
            this.pnSede.Controls.Add(this.btnSuco);
            this.pnSede.Controls.Add(this.btnAgua);
            this.pnSede.Enabled = false;
            this.pnSede.Location = new System.Drawing.Point(294, 49);
            this.pnSede.Name = "pnSede";
            this.pnSede.Size = new System.Drawing.Size(89, 185);
            this.pnSede.TabIndex = 40;
            this.pnSede.TabStop = true;
            // 
            // btnRefrigerante
            // 
            this.btnRefrigerante.Location = new System.Drawing.Point(2, 98);
            this.btnRefrigerante.Name = "btnRefrigerante";
            this.btnRefrigerante.Size = new System.Drawing.Size(87, 39);
            this.btnRefrigerante.TabIndex = 2;
            this.btnRefrigerante.Text = "Refrigerante";
            this.btnRefrigerante.UseVisualStyleBackColor = true;
            this.btnRefrigerante.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnSuco
            // 
            this.btnSuco.Location = new System.Drawing.Point(2, 53);
            this.btnSuco.Name = "btnSuco";
            this.btnSuco.Size = new System.Drawing.Size(87, 39);
            this.btnSuco.TabIndex = 1;
            this.btnSuco.Text = "Suco";
            this.btnSuco.UseVisualStyleBackColor = true;
            this.btnSuco.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnAgua
            // 
            this.btnAgua.Location = new System.Drawing.Point(2, 8);
            this.btnAgua.Name = "btnAgua";
            this.btnAgua.Size = new System.Drawing.Size(87, 39);
            this.btnAgua.TabIndex = 0;
            this.btnAgua.Text = "Agua";
            this.btnAgua.UseVisualStyleBackColor = true;
            this.btnAgua.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // pnEmocoes
            // 
            this.pnEmocoes.Controls.Add(this.btnCansado);
            this.pnEmocoes.Controls.Add(this.btnAlegre);
            this.pnEmocoes.Controls.Add(this.btnIrritado);
            this.pnEmocoes.Controls.Add(this.btnBravo);
            this.pnEmocoes.Controls.Add(this.btnTriste);
            this.pnEmocoes.Controls.Add(this.btnFeliz);
            this.pnEmocoes.Enabled = false;
            this.pnEmocoes.Location = new System.Drawing.Point(487, 49);
            this.pnEmocoes.Name = "pnEmocoes";
            this.pnEmocoes.Size = new System.Drawing.Size(98, 282);
            this.pnEmocoes.TabIndex = 41;
            this.pnEmocoes.TabStop = true;
            // 
            // btnCansado
            // 
            this.btnCansado.Location = new System.Drawing.Point(2, 233);
            this.btnCansado.Name = "btnCansado";
            this.btnCansado.Size = new System.Drawing.Size(87, 39);
            this.btnCansado.TabIndex = 5;
            this.btnCansado.Text = "Cansado";
            this.btnCansado.UseVisualStyleBackColor = true;
            this.btnCansado.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnAlegre
            // 
            this.btnAlegre.Location = new System.Drawing.Point(2, 53);
            this.btnAlegre.Name = "btnAlegre";
            this.btnAlegre.Size = new System.Drawing.Size(87, 39);
            this.btnAlegre.TabIndex = 1;
            this.btnAlegre.Text = "Alegre";
            this.btnAlegre.UseVisualStyleBackColor = true;
            this.btnAlegre.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnIrritado
            // 
            this.btnIrritado.Location = new System.Drawing.Point(2, 188);
            this.btnIrritado.Name = "btnIrritado";
            this.btnIrritado.Size = new System.Drawing.Size(87, 39);
            this.btnIrritado.TabIndex = 4;
            this.btnIrritado.Text = "Irritado";
            this.btnIrritado.UseVisualStyleBackColor = true;
            this.btnIrritado.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnBravo
            // 
            this.btnBravo.Location = new System.Drawing.Point(2, 143);
            this.btnBravo.Name = "btnBravo";
            this.btnBravo.Size = new System.Drawing.Size(87, 39);
            this.btnBravo.TabIndex = 3;
            this.btnBravo.Text = "Bravo";
            this.btnBravo.UseVisualStyleBackColor = true;
            this.btnBravo.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnTriste
            // 
            this.btnTriste.Location = new System.Drawing.Point(2, 98);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(87, 39);
            this.btnTriste.TabIndex = 2;
            this.btnTriste.Text = "Triste";
            this.btnTriste.UseVisualStyleBackColor = true;
            this.btnTriste.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnFeliz
            // 
            this.btnFeliz.Location = new System.Drawing.Point(2, 8);
            this.btnFeliz.Name = "btnFeliz";
            this.btnFeliz.Size = new System.Drawing.Size(87, 39);
            this.btnFeliz.TabIndex = 0;
            this.btnFeliz.Text = "Feliz";
            this.btnFeliz.UseVisualStyleBackColor = true;
            this.btnFeliz.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // pnSentir
            // 
            this.pnSentir.Controls.Add(this.button1);
            this.pnSentir.Controls.Add(this.btnCalor);
            this.pnSentir.Controls.Add(this.btnFrio);
            this.pnSentir.Enabled = false;
            this.pnSentir.Location = new System.Drawing.Point(392, 49);
            this.pnSentir.Name = "pnSentir";
            this.pnSentir.Size = new System.Drawing.Size(89, 184);
            this.pnSentir.TabIndex = 42;
            this.pnSentir.TabStop = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Medo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnCalor
            // 
            this.btnCalor.Location = new System.Drawing.Point(2, 8);
            this.btnCalor.Name = "btnCalor";
            this.btnCalor.Size = new System.Drawing.Size(87, 39);
            this.btnCalor.TabIndex = 0;
            this.btnCalor.Text = "Calor";
            this.btnCalor.UseVisualStyleBackColor = true;
            this.btnCalor.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // btnFrio
            // 
            this.btnFrio.Location = new System.Drawing.Point(2, 53);
            this.btnFrio.Name = "btnFrio";
            this.btnFrio.Size = new System.Drawing.Size(87, 39);
            this.btnFrio.TabIndex = 1;
            this.btnFrio.Text = "Frio";
            this.btnFrio.UseVisualStyleBackColor = true;
            this.btnFrio.Click += new System.EventHandler(this.KeySender_Click);
            // 
            // pnRetorna
            // 
            this.pnRetorna.Controls.Add(this.btnDesfazer);
            this.pnRetorna.Controls.Add(this.btnLimpar);
            this.pnRetorna.Controls.Add(this.btnvoltar);
            this.pnRetorna.Controls.Add(this.btnFechar);
            this.pnRetorna.Location = new System.Drawing.Point(8, 370);
            this.pnRetorna.Name = "pnRetorna";
            this.pnRetorna.Size = new System.Drawing.Size(568, 47);
            this.pnRetorna.TabIndex = 43;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Location = new System.Drawing.Point(157, 0);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(130, 39);
            this.btnDesfazer.TabIndex = 9;
            this.btnDesfazer.Text = "DESFAZER AÇÃO";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 39);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR FRASES";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // timerDor
            // 
            this.timerDor.Interval = 4000;
            this.timerDor.Tick += new System.EventHandler(this.timerDor_Tick);
            // 
            // timerFome
            // 
            this.timerFome.Interval = 4000;
            this.timerFome.Tick += new System.EventHandler(this.timerFome_Tick);
            // 
            // timerLigar
            // 
            this.timerLigar.Interval = 4000;
            this.timerLigar.Tick += new System.EventHandler(this.timerLigar_Tick);
            // 
            // timerSede
            // 
            this.timerSede.Interval = 4000;
            this.timerSede.Tick += new System.EventHandler(this.timerSede_Tick);
            // 
            // timerSentir
            // 
            this.timerSentir.Interval = 4000;
            this.timerSentir.Tick += new System.EventHandler(this.timerSentir_Tick);
            // 
            // timerEmocoes
            // 
            this.timerEmocoes.Interval = 4000;
            this.timerEmocoes.Tick += new System.EventHandler(this.timerEmocoes_Tick);
            // 
            // FrasesProntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 421);
            this.Controls.Add(this.pnRetorna);
            this.Controls.Add(this.pnEmocoes);
            this.Controls.Add(this.pnFome);
            this.Controls.Add(this.pnLigar);
            this.Controls.Add(this.pnDor);
            this.Controls.Add(this.textArea2);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pnSede);
            this.Controls.Add(this.pnSentir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrasesProntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frases Prontas";
            this.pnPrincipal.ResumeLayout(false);
            this.pnDor.ResumeLayout(false);
            this.pnLigar.ResumeLayout(false);
            this.pnFome.ResumeLayout(false);
            this.pnSede.ResumeLayout(false);
            this.pnEmocoes.ResumeLayout(false);
            this.pnSentir.ResumeLayout(false);
            this.pnRetorna.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Timer timerFrases;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox textArea2;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Button btnSentir;
        private System.Windows.Forms.Button btnEmocoes;
        private System.Windows.Forms.Button btnSede;
        private System.Windows.Forms.Button btnFome;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDor;
        private System.Windows.Forms.Panel pnDor;
        private System.Windows.Forms.Button btnPe;
        private System.Windows.Forms.Button btnPernas;
        private System.Windows.Forms.Button btnBarriga;
        private System.Windows.Forms.Button btnCostas;
        private System.Windows.Forms.Button btnTorax;
        private System.Windows.Forms.Button btnPescoco;
        private System.Windows.Forms.Button btnCabeca;
        private System.Windows.Forms.Panel pnLigar;
        private System.Windows.Forms.Button btnBombeiro;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Button btnReponsavel;
        private System.Windows.Forms.Button btnPolicia;
        private System.Windows.Forms.Panel pnFome;
        private System.Windows.Forms.Button btnLanche;
        private System.Windows.Forms.Button btnAlmoco;
        private System.Windows.Forms.Button btnFrutas;
        private System.Windows.Forms.Panel pnSede;
        private System.Windows.Forms.Button btnRefrigerante;
        private System.Windows.Forms.Button btnSuco;
        private System.Windows.Forms.Button btnAgua;
        private System.Windows.Forms.Panel pnEmocoes;
        private System.Windows.Forms.Button btnCansado;
        private System.Windows.Forms.Button btnAlegre;
        private System.Windows.Forms.Button btnIrritado;
        private System.Windows.Forms.Button btnBravo;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnFeliz;
        private System.Windows.Forms.Panel pnSentir;
        private System.Windows.Forms.Button btnCalor;
        private System.Windows.Forms.Button btnFrio;
        private System.Windows.Forms.Panel pnRetorna;
        private System.Windows.Forms.Timer timerDor;
        private System.Windows.Forms.Timer timerFome;
        private System.Windows.Forms.Timer timerLigar;
        private System.Windows.Forms.Timer timerSede;
        private System.Windows.Forms.Timer timerSentir;
        private System.Windows.Forms.Timer timerEmocoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDesfazer;
    }
}