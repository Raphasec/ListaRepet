public class Exercicio7{
    public void Questao(){
        double notas, repet = 0, media = 0, i = 0;

        do{
            Console.Clear();
            do{
                Console.WriteLine("Digite uma nota de 0 a 100");
                notas = Convert.ToDouble(Console.ReadLine());
                if(notas >= 0 && notas <=100){
                    i++;
                    media = (media + notas);
                }
            }while(notas >= 0 && notas <= 100);
            if(notas > 100){   
                    Console.WriteLine("Erro!!! Para tentar novamente pressione qualquer tecla!");
                    Console.ReadKey();
                    repet = 1;
                }else if(notas < 0){
                    Console.WriteLine($"A média das notas é {media/i}. Para finalizar o programa pressione qualquer tecla");
                    Console.ReadKey();
                    Console.WriteLine("Finalizando o programa...");
                }
        }while (repet != 0);
    }
}