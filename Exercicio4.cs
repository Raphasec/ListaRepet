public class Exercicio4{
    public void Questao(){
        int num;

        Console.WriteLine("Digite um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i <= 100; i++){
            if(i % num == 0 && i < 100){    
                Console.Write($"{i}, ");
            }else if(i % num == 0 && i == 100){
                Console.WriteLine(i);
            }
        }
    }
}
