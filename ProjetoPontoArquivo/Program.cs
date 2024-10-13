using modelo;
using System.Collections;
using controle;

namespace visao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do Main");
            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            PlanoCartesianoController controller = new PlanoCartesianoController();
            ArrayList lista = new ArrayList();
            int op, cod_plano;

            do
            {
                op = Menu();
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o semiplano que deseja selecionar");
                        Console.WriteLine("1: direito;\r\n2: esquerdo;\r\n3: superior;\r\n4: inferiror;");
                        cod_plano = int.Parse(Console.ReadLine());
                        lista = controller.selecionarPontosPorSemiplano(cod_plano);
                        Console.WriteLine("Pontos Selecionados:\n");
                        foreach (PontoVO ponto in lista)
                        {
                            Console.WriteLine(ponto);
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        Console.WriteLine("Obrigado por utilizar o programa!");
                        break;
                    default:
                        Console.WriteLine("Código inválido!");
                        break;
                }
                Console.WriteLine("Digite Enter para continuar...");
                Console.ReadLine();
            } while (op != 10);

            // Lê imprime os objetos do tipo PontoVO
            /*lista = objetoPc1.obterTodos(1, true);
            Console.WriteLine("Imprime todos os pontos do arquivo");

            for (int i = 0; i < lista.Count; i++)
            {
                PontoVO objeto = (PontoVO) lista[i];
                Console.WriteLine(objeto);
            }

            // Lê imprime os pontos do semiplano ímpar
            PlanoCartesianoController objetoController = new PlanoCartesianoController();
            lista = objetoController.selecionarPontosSemiPlanoImpar();

            Console.WriteLine("Imprime todos os pontos do semi plano ímpar");

            for (int i = 0; i < lista.Count; i++)
            {
                PontoVO objeto = (PontoVO) lista[i];
                Console.WriteLine(objeto);
            }*/

            Console.WriteLine("Fim do Main");
        }
        
        static int Menu()
        {
            int op;
            Console.WriteLine("|-------- Console de Plano Cartesiano! --------|");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|    1 - Selecionar objetos por tipo de semiplano         |");
            Console.WriteLine("|    2 - Selecionar objetos dos semiplanos ímpares        |");
            Console.WriteLine("|    3 - Selecionar objetos dos semiplanos pares          |");
            Console.WriteLine("|    4 - Selecionar objetos por seu tipo de figura        |");
            Console.WriteLine("|    5 - Inserir objeto na lista                          |");
            Console.WriteLine("|    6 - Pesquisar objeto na lista                        |");
            Console.WriteLine("|    7 - Editar objeto na lista                           |");
            Console.WriteLine("|    8 - Excluir objeto na lista                          |");
            Console.WriteLine("|    9 - Visualizar objeto da lista                       |");
            Console.WriteLine("|    10 - Sair do programa                                |");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("|---------------------------------------------------------|");
            Console.Write("\nDigite a opção desejada: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
