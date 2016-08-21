using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class TesteDoAvaliador
    {
        static void Main(String[] args)
        {
            // 1a parte: Cenario
            Usuario joao = new Usuario("João");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Mária");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 250.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));

            // 2a parte: Acao
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            // 3a parte: validacao
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Console.WriteLine(maiorEsperado == leiloeiro.MaiorLance);
            Console.WriteLine(menorEsperado == leiloeiro.MenorLance);

            Console.ReadKey();
        }
    }
}
