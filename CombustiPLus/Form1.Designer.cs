namespace CombustiPLus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblResumen = new Label();
            txtPlaca = new TextBox();
            cmbCombustible = new ComboBox();
            cmbPago = new ComboBox();
            nudGalones = new NumericUpDown();
            btnCotizar = new Button();
            btnDespachar = new Button();
            btnGxC = new Button();
            lstDetalle = new ListBox();
            lstDespachos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(547, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo despacho";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(547, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(547, 501);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Despacho del dia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 157);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 157);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Combustible";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 157);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Galones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 199);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 6;
            label4.Text = "Pagos";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(191, 199);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(0, 20);
            lblResumen.TabIndex = 7;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(91, 275);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 27);
            txtPlaca.TabIndex = 8;
            txtPlaca.Text = "placa";
            // 
            // cmbCombustible
            // 
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Location = new Point(95, 340);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(151, 28);
            cmbCombustible.TabIndex = 9;
            cmbCombustible.Text = "combustible";
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(94, 428);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(151, 28);
            cmbPago.TabIndex = 10;
            cmbPago.Text = "Pago";
            // 
            // nudGalones
            // 
            nudGalones.Location = new Point(91, 487);
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(150, 27);
            nudGalones.TabIndex = 11;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(0, 0);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(94, 29);
            btnCotizar.TabIndex = 12;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(49, 77);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(94, 29);
            btnDespachar.TabIndex = 13;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            // 
            // btnGxC
            // 
            btnGxC.Location = new Point(161, 29);
            btnGxC.Name = "btnGxC";
            btnGxC.Size = new Size(188, 29);
            btnGxC.TabIndex = 14;
            btnGxC.Text = "Galon x Combustible";
            btnGxC.UseVisualStyleBackColor = true;
            // 
            // lstDetalle
            // 
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(81, 582);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(150, 104);
            lstDetalle.TabIndex = 15;
            // 
            // lstDespachos
            // 
            lstDespachos.FormattingEnabled = true;
            lstDespachos.Location = new Point(311, 582);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(150, 104);
            lstDespachos.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 717);
            Controls.Add(lstDespachos);
            Controls.Add(lstDetalle);
            Controls.Add(btnGxC);
            Controls.Add(btnDespachar);
            Controls.Add(btnCotizar);
            Controls.Add(nudGalones);
            Controls.Add(cmbPago);
            Controls.Add(cmbCombustible);
            Controls.Add(txtPlaca);
            Controls.Add(lblResumen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "CombustiPlus - Estación Bávaro";
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblResumen;
        private TextBox txtPlaca;
        private ComboBox cmbCombustible;
        private ComboBox cmbPago;
        private NumericUpDown nudGalones;
        private Button btnCotizar;
        private Button btnDespachar;
        private Button btnGxC;
        private ListBox lstDetalle;
        private ListBox lstDespachos;
    }
}
