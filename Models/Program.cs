using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_csharp_catalogo_de_jogos.Models
{
class Program
{
    static void Main()
    {
      int quantidadeJogos = int.Parse(Console.ReadLine());


      string[] nomesJogos = new string[quantidadeJogos];
       

      for (int i = 0; i < quantidadeJogos; i++)
      {

      nomesJogos[i] = Console.ReadLine();

      }


      ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {

      nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
      string listaNomes = string.Join(", ", nomes);
      Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {listaNomes} ao catalogo.");
    }
    
}
}