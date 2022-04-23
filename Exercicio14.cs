public class Exercicio14{
    public void Questao(){
        int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
        int tentA1, tentA2, tentA3, tentA4, tentA5, tentA6;
        int tentB1, tentB2, tentB3, tentB4, tentB5, tentB6, acerto = 0;
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

        Console.WriteLine("Tente adivinhar os números da mega sena!!!");
        do{ 
            Console.WriteLine("Digite o número 1");
            tentA1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 2");
            tentA2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 3");
            tentA3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 4");
            tentA4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 5");
            tentA5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 6");
            tentA6 = Convert.ToInt32(Console.ReadLine());
            
            if(tentA1 == num1 && tentA2 == num2 && tentA3 == num3 && tentA4 == num4 && tentA5 == num5 && tentA6 == num6){
                Console.WriteLine("O vencedor é A!!!");
                acerto = 1;
            }else{
                Console.WriteLine("\nB, Digite o número 1");
                tentB1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B, Digite o número 2");
                tentB2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B, Digite o número 3");
                tentB3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B, Digite o número 4");
                tentB4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B, Digite o número 5");
                tentB5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B, Digite o número 6");
                tentB6 = Convert.ToInt32(Console.ReadLine());
                
                if(tentB1 == num1 && tentB2 == num2 && tentB3 == num3 && tentB4 == num4 && tentB5 == num5 && tentB6 == num6){
                    Console.WriteLine("O vencedor é B!!!");
                    acerto = 1;
                }
            }
        }while(acerto != 1);
    }
}