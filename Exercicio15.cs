//Faça um programa que leia um valor inteiro maior do que zero e mostre todos os números primos
//menores do que o valor lido.

public class Exercicio15{
    public void Questao(){
        int num, cont;

        Console.Clear();
        Console.WriteLine("Digite um número maior do que 0");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Os números primos menores que {num} são: \n");
        if(num > 0){
            for(int i = num; i >= 2; i--){
                cont = 0;
                for(int j = 1; j <= i; j++){
                    if(i % j == 0){
                        cont++;
                    }
                }
                 if(num == 2){
                        Console.WriteLine("2");
                    }
                if(cont == 2 && i != num){
                    Console.Write(i + " ");
                }
            }
        }else{
            Console.WriteLine("Inválido!!!");
        }
    }
}