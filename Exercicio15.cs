public class Exercicio15{
    public void Questao(){
        int num, cont = 0;

        Console.WriteLine("Digite um número maior do que 0");
        num = Convert.ToInt32(Console.ReadLine());

        if(num > 0){
            for(int i = num; i < num; i--){
            if(num % i == 0){
                cont++;
            }
            if(cont == 2){
                Console.WriteLine(i);
            }
        }
        }else{
            Console.WriteLine("Inválido!!!");
        }
    }
}