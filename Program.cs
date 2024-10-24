
public class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        pessoa.nome = "Kauany";
        pessoa.cpf = 05555;
        pessoa.idade = 20;
        pessoa.sexo = "Fem";


        Console.Write("Digite o peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        pessoa.CalcularIMC(peso, altura);
    }
}