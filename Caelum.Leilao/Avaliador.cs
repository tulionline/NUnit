﻿using System;

namespace Caelum.Leilao
{
    class Avaliador
    {
        private double maiorDeTodos = Double.MinValue;
        private double menorDeTodos = Double.MaxValue;

        public void Avalia(Leilao leilao)
        {
            foreach (var lance in leilao.Lances)
            {
                if (lance.Valor > maiorDeTodos)
                {
                    maiorDeTodos = lance.Valor;
                }
                else if (lance.Valor < menorDeTodos)
                {
                    menorDeTodos = lance.Valor;
                }
            }
        }

        public double MaiorLance
        {
            get { return this.maiorDeTodos; }
        }

        public double MenorLance
        {
            get { return this.menorDeTodos; }
        }
    }
}