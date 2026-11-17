using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CombustiPLus
{
    public partial class Form1 : Form
    {

        private readonly List<Despacho> despachos = new List<Despacho>();
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        public Form1()
        {
            InitializeComponent();

            cmbCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombustible.Items.AddRange(new object[] { "Premium", "Regular",
                "Gasoil" });
            cmbPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbCombustible.SelectedIndex = 0;
            cmbPago.SelectedIndex = 0;

            nudGalones.DecimalPlaces = 1;
            nudGalones.Increment = 0.5m;
            nudGalones.Minimum = 0;
            nudGalones.Maximum = 1000;

            lstDespachos.Font = new Font("Consolas", 10);
            lstDetalle.Font = new Font("Consolas", 10);
            lblResumen.Text = "";

        }

        private static string Dinero(decimal v)
        {
            return "RD$ " + v.ToString("N2", Inv);
        }
        private bool Validar()
        {
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres.", "Dato Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("La cantidad de galones deben ser mas que 0.", "Dato Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;


        }
    }
}
