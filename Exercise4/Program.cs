namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Daniela";
            double salariofixo = 0, totalvendas = 0, percentualvendas = 0, salariofinal = 0;

            salariofixo = 3000;
            totalvendas = 2000;
            percentualvendas = (percentualvendas / 100) * 15;
            salariofinal = salariofixo + percentualvendas;

            Console.WriteLine("Nome do funcionário: " + nome);
            Console.WriteLine("Salário fixo: " + salariofixo);
            Console.WriteLine("Salário final: "+ salariofinal);    
        }
    }
}