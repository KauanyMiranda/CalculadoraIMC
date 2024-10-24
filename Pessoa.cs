
public class Pessoa
{
    public string nome;
    public int cpf;
    public int idade;
    public string sexo;
    public double peso;
    public double altura;
    public double valorIMC;

    public void CalcularIMC(double peso, double altura)
    {
        valorIMC = peso / (altura * altura);

        if (valorIMC <= 18.5)
        {
            Console.WriteLine($"Valor IMC = {valorIMC.ToString("F2")} MAGREZA");
        }
        if (valorIMC >= 18.5 & valorIMC <= 24.9)
        {
            Console.WriteLine($"Valor IMC = {valorIMC.ToString("F2")} NORMAL");
        }
        if (valorIMC >= 25.0 & valorIMC <= 29.9)
        {
            Console.WriteLine($"Valor IMC = {valorIMC.ToString("F2")} SOBREPESO GRAU I");
        }
        if (valorIMC >= 30.0 & valorIMC <= 39.9)
        {
            Console.WriteLine($"Valor IMC = {valorIMC.ToString("F2")} OBESIDADE GRAU II");
        }
        if (valorIMC >= 40.00)
        {
            Console.WriteLine($"Valor IMC = {valorIMC.ToString("F2")} OBESIDADE GRAU III");
        }


    }
}
