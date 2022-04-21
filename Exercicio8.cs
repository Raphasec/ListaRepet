public class Exercicio8{
    public void Questao(){
        int num, cont = 0;
        
        Console.WriteLine("Digite um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        for(int i = num; i > 0; i--){
            if(num % i == 0){
                cont++;
            }
        }
        if(cont == 2){
            Console.WriteLine($"O número {num} é primo");
        }else{
            Console.WriteLine($"O número {num} não é primo");
        }
    }
}