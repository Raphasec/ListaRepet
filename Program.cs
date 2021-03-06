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
                        Exercicio7 ex7 = new Exercicio7();
                        Console.Clear();
                        ex7.Questao();
                        break;
                    case 8:
                        Exercicio8 ex8 = new Exercicio8();
                        Console.Clear();
                        ex8.Questao();
                        break;
                    case 9:
                        Exercicio9 ex9 = new Exercicio9();
                        Console.Clear();
                        ex9.Questao();
                        break;
                    case 10:
                        Exe10 ex10 = new Exe10();
                        Console.Clear();
                        ex10.Questao();
                        break;
                    case 11:
                        Exercicio11 ex11 = new Exercicio11();
                        Console.Clear();
                        ex11.Questao();
                        break;
                    case 12:
                        Exercicio12 ex12 = new Exercicio12();
                        Console.Clear();
                        ex12.Questao();
                        break;
                    case 13:
                        Exercicio13 ex13 = new Exercicio13();
                        Console.Clear();
                        ex13.Questao();
                        break;
                    case 14:
                        Exercicio14 ex14 = new Exercicio14();
                        Console.Clear();
                        ex14.Questao();
                        break;
                    case 15:
                        Exercicio15 ex15 = new Exercicio15();
                        Console.Clear();
                        ex15.Questao();
                        break;
                    default:
                        Console.WriteLine("\nErro!!! Número de questão inválido");
                        repet = 1;
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