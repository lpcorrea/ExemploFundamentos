namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public double Forca { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e {Forca} de força!");
        }

        public void AumentaForca()
        {
            this.Forca *= 1.05;
        }

        public void DiminuiForca()
        {
            this.Forca /= 1.05;
        }
    }
}