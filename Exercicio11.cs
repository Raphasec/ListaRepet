public class Exercicio11{
    public void Questao(){
        string voto;
        int numA = 0, numB = 0, numC = 0, numD = 0;
        
        Console.WriteLine("Votação!!!!");
        do{
            Console.WriteLine("\n Candidato A\n Candidato B\n Candidato C\n Candidato D\n");
            voto = Console.ReadLine();
            switch (voto){
                case "A":
                    numA++;
                    break;
                case "B":
                    numB++;
                    break;
                case "C":
                    numC++;
                    break;
                case "D":
                    numD++;
                    break;
                default:
                    Console.WriteLine("Finalizando votação...");
                    break; 
            }
        }while(voto != "S");
        if(numA > numB && numA > numC && numA > numD){
            Console.WriteLine($"O vencedor é: A" );
        }else if(numB > numA && numB > numC && numB > numD){
            Console.WriteLine($"O vencedor é: B" );
        }else if(numC > numB && numC > numA && numC > numD){
            Console.WriteLine($"O vencedor é: C" );
        }else if(numD > numB && numD > numC && numD > numA){
            Console.WriteLine($"O vencedor é: D" );
        }
    }
}