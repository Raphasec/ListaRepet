 public class Exe10
    {
        public void Questao()
        {
            int num, i = 0; 
            double soma = 0;

            Console.Clear();
            do{
                Console.WriteLine("Digite um número");
                num = Convert.ToInt32(Console.ReadLine());
                if(num != -1){
                    i++;
                    soma = soma + num;
                }
            }while(num != -1);
            if(num == -1){
                Console.WriteLine($"A soma dos números é {soma}");
                Console.WriteLine($"A média dos números é {soma/i:F2}. Para finalizar o programa pressione qualquer tecla");
                Console.ReadKey();
                Console.WriteLine("Finalizando o programa...");
            }
        }
    }