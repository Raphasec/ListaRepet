public class Exercicio3{
    public void Questao(){
        int limite;

        Console.WriteLine("Digite um limite: ");
        limite = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i <= limite; i++){
            if(i < limite && i % 2 == 0){    
                Console.Write($"{i}, ");
            }else if(i == limite && i % 2 == 0){
                Console.Write(i);
            }
        }
    }
}