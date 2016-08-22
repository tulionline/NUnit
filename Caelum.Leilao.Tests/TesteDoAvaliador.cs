using NUnit.Framework;

namespace Caelum.Leilao
{
    [TestFixture]
    public class TesteDoAvaliador
    {
        [Test]
        public void Main()
        {
            // 1a parte: Cenario
            Usuario joao = new Usuario("João");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Mária");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));
            leilao.Propoe(new Lance(maria, 250.0));

            // 2a parte: Acao
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            // 3a parte: validacao
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance);
        }
    }
}