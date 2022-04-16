public class Exercicio2{
    public void Questao(){
        for(int i = 0; i <= 100; i++){
            if(i < 100 && i % 2 == 0){    
                Console.Write($"{i}, ");
            }else if(i == 100 && i % 2 == 0){
                Console.WriteLine(i);
            }
        }
    }
}