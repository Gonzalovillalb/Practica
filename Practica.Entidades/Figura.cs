namespace Practica.Entidades
{
    public class Figura : ICloneable
    {
        private double Radio;
        private Borde borde;

        public Borde Borde
        {
            get { return borde; }
            set { borde = value; }
        }

        private Relleno relleno;

        public Relleno Relleno
        {
            get { return relleno; }
            set { relleno = value; }
        }

        public Figura(double Radio, Borde borde, Relleno color)
        {

            this.Radio = Radio;
            Borde = borde;
            Relleno = color;
        }

        public Figura()
        {
        }

        public double GetRadio() => Radio;
        public double GetArea() =>4 * (Math.PI) * Math.Pow(Radio, 2);
        public double GetVolumen() =>4 * (Math.PI) * Math.Pow(Radio, 3);
        public void SetRadio(int medida)
        {
            if (medida > 0)
            {
                Radio = medida;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
