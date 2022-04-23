public class Exercicio12{
    public void Questao(){
        int sorteio = (new Random()).Next(1,11), tent, qtdTent = 0, acerto = 1;

        Console.WriteLine("Adivinhe o número entre 1 e 10");
        do{
            tent = Convert.ToInt32(Console.ReadLine());
            if(tent == sorteio){
                Console.WriteLine("\nMeus Parabéns, você ACERTOU!!!");
                acerto = 0;
            }else{
                Console.WriteLine("\nERROU!!! Tente novamente\n");
                qtdTent++;
            }
        }while(acerto != 0);
        Console.WriteLine($"Você acertou em {qtdTent} tentativas");
    }
}