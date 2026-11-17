using System.Globalization;

namespace CombustiPlus
{
    public class Despacho
    {
        public int Numero {  get; set; }
        public string Placa { get; set; }
        public string Combustible { get; set; }
        public decimal Galones { get; set; }    
        public string Pago {  get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "#{0:00} {1} {2,-7} {3:0.0} gal {4,-8} RD$ {5,9:N2}",
                Numero, Placa, Combustible, Galones, Pago, Total);

        }
    }
}