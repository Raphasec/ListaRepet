public class Exercicio13{
    public void Questao(){
        int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
        do{
            num1 = (new Random()).Next(1,51); 
            num2 = (new Random()).Next(1,51); 
            num3 = (new Random()).Next(1,51);
            num4 = (new Random()).Next(1,51);
            num5 = (new Random()).Next(1,51); 
            num6 = (new Random()).Next(1,51);
        }while(num1 == num2 || num1 == num3 || num1 == num4 || num1 == num5 || num1 == num6 ||
        num2 == num3 || num2 == num4 || num2 == num5 || num2 == num6 ||
        num3 == num4 || num3 == num5 || num3 == num6 ||
        num4 == num5 || num4 == num6 ||
        num5 == num6);

        Console.WriteLine($"Os números da mega sena são: {num1} {num2} {num3} {num4} {num5} {num6}");
    }
}