namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido = false;

        //validando as propriedades
        public int Mes
        {
            get
            {
                return this.mes;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }

        //criando getters and setters
        public int getMes()
        {
            return this.mes;
        }

        public void setMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public void ApresentaMes()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine($"Mês: {this.mes}");
            }
            else
            {

                System.Console.WriteLine("Mês Válido");
            }
        }
    }
}