public class Exercicio9{
    public void Questao(){
        double valor, valornovo, juros;
        int  meses;

        Console.WriteLine("Digite o valor monetário, em R$: ");
        valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros mensal, em %: ");
        juros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de meses: ");
        meses = Convert.ToInt32(Console.ReadLine());

        valornovo = valor;

        for(int i = 1; i <= meses; i++){
            valornovo = valornovo + (valornovo * (juros / 100));
        }

        Console.WriteLine($"O valor antigo era: {valor}");
        Console.WriteLine($"O valor novo é: {valornovo:F2}");
        Console.WriteLine($"O rendimento foi de: {valornovo - valor:F2}");
    }
}