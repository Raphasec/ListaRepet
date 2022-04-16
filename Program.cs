using System;

namespace ListaRepet // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, repet = 0;
            string resp, fl;

            do{
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Lista Estruturas de Repetição");
                Console.WriteLine("-------------------------------");
            
                Console.WriteLine("\nEscolha um exercício(1-15): ");
                op = Convert.ToInt32(Console.ReadLine());

                switch(op){
                    //Exercícios
                    case 1:
                        Exercicio1 ex1 = new Exercicio1();
                        Console.Clear();
                        ex1.Questao();
                        break;
                    case 2:
                        Exercicio2 ex2 = new Exercicio2();
                        Console.Clear();
                        ex2.Questao();
                        break;
                    case 3:
                        Exercicio3 ex3 = new Exercicio3();
                        Console.Clear();
                        ex3.Questao();
                        break;
                    case 4:
                        Exercicio4 ex4 = new Exercicio4();
                        Console.Clear();
                        ex4.Questao();
                        break;
                    case 5:
                        Exercicio5 ex5 = new Exercicio5();
                        Console.Clear();
                        ex5.Questao();
                        break;
                    case 6:
                        Exercicio6 ex6 = new Exercicio6();
                        Console.Clear();
                        ex6.Questao();
                        break;
                    case 7:
                    //Não Finalizado
                        Exercicio7 ex7 = new Exercicio7();
                        Console.Clear();
                        ex7.Questao();
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    default:
                        Console.WriteLine("Erro, tente novamente pressionando qualquer tecla!");
                        repet = 1;
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("\nDeseja tentar novamente?[S/N]");
                resp = Console.ReadLine();
                fl = resp.Substring(0, 1);
                resp = fl.ToUpper();

                if(resp == "S"){
                    repet = 1;
                }else{
                    repet = 0;
                }

            }while(repet != 0);
        }
    }
}