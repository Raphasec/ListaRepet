public class Exercicio5{
    public void Questao(){
        double num, repet = 0;
        Console.Clear();
        do{
            Console.WriteLine("Digite um número de 1 a 10: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            if(num >= 1 && num <= 10){
                for(int i = 0; i <= 10; i++){
                    Console.WriteLine(num * i);
                }
            }else{
                Console.WriteLine("Erro!!! Tente novamente pressionando qualquer tecla");
                Console.ReadKey();
                repet = 1;
            }
        }while(repet != 0);
    }
}