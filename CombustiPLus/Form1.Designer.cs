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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPlaca = new TextBox();
            cmbCombustible = new ComboBox();
            nudGalones = new NumericUpDown();
            btnDespachar = new Button();
            cmbPago = new ComboBox();
            btnCotizar = new Button();
            groupBox2 = new GroupBox();
            lstDetalle = new ListBox();
            groupBox3 = new GroupBox();
            btnPorCombustible = new Button();
            lstDespachos = new ListBox();
            lblResumen = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(cmbCombustible);
            groupBox1.Controls.Add(nudGalones);
            groupBox1.Controls.Add(btnDespachar);
            groupBox1.Controls.Add(cmbPago);
            groupBox1.Controls.Add(btnCotizar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo despacho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 156);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 17;
            label4.Text = "Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 116);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 16;
            label3.Text = "Galones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 15;
            label2.Text = "Combustible";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 36);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 14;
            label1.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(130, 32);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 27);
            txtPlaca.TabIndex = 8;
            // 
            // cmbCombustible
            // 
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Location = new Point(130, 72);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(151, 28);
            cmbCombustible.TabIndex = 9;
            // 
            // nudGalones
            // 
            nudGalones.Location = new Point(130, 112);
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(150, 27);
            nudGalones.TabIndex = 11;
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(220, 210);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(94, 29);
            btnDespachar.TabIndex = 13;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(130, 152);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(151, 28);
            cmbPago.TabIndex = 10;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(15, 210);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(94, 29);
            btnCotizar.TabIndex = 12;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDetalle);
            groupBox2.Location = new Point(12, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 190);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // lstDetalle
            // 
            lstDetalle.Dock = DockStyle.Fill;
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(3, 23);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(434, 164);
            lstDetalle.TabIndex = 15;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPorCombustible);
            groupBox3.Controls.Add(lstDespachos);
            groupBox3.Location = new Point(470, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(500, 420);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Despachos del dia";
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.Location = new Point(10, 365);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(220, 35);
            btnPorCombustible.TabIndex = 14;
            btnPorCombustible.Text = "Galon x Combustible";
            btnPorCombustible.UseVisualStyleBackColor = true;
            btnPorCombustible.Click += btnPorCombustible_Click;
            // 
            // lstDespachos
            // 
            lstDespachos.FormattingEnabled = true;
            lstDespachos.Location = new Point(10, 25);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(480, 324);
            lstDespachos.TabIndex = 16;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(470, 445);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(65, 20);
            lblResumen.TabIndex = 7;
            lblResumen.Text = "resumen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 706);
            Controls.Add(lblResumen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "CombustiPlus - Estación Bávaro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblResumen;
        private TextBox txtPlaca;
        private ComboBox cmbCombustible;
        private ComboBox cmbPago;
        private NumericUpDown nudGalones;
        private Button btnCotizar;
        private Button btnDespachar;
        private Button btnPorCombustible;
        private ListBox lstDetalle;
        private ListBox lstDespachos;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}
