using System;
using System.Collections.Generic;

namespace TesteNumerosRomanos
{
    public class ConversorDeNumerosRomanos
    {
        private static Dictionary<string, int> tabela = new Dictionary<string, int>()
        {
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000},
        };


        public int Converte(string numeroEmRomano)
        {
            int acumulador = 0;
            int ultimoVizinhoDaDireita = 0;

            for (int i = numeroEmRomano.Length -1; i >= 0; i--)
            {
                // pega o inteirio referente ao simbolo atual
                int atual = tabela[numeroEmRomano[i].ToString()];

                // se o da direta for menor, o multiplicaremos por -1 para torna-lo negativo
                int multiplicador = 1;
                if (atual < ultimoVizinhoDaDireita)
                    multiplicador = -1;

                acumulador += atual * multiplicador;

                //atualiza o Vizinho da direita
                ultimoVizinhoDaDireita = atual;

            }

            return acumulador;

        }
    }
}