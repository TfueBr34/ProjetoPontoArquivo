﻿using modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle
{
    public class PlanoCartesianoController
    {
        /**
         * Selecionar os pontos por semiplano que pode ser:
         * 1: direito;
         * 2: esquerdo;
         * 3: superior;
         * 4: inferiror;
         */
        public ArrayList selecionarPontosPorSemiplano(int codigo)
        {

            return null;
        }

        /* Selecionar os pontos por semiplano que pode ser:
        * 1: direito;
        * 2: esquerdo;
        * 3: superior;
        * 4: inferiror;
        */
        public ArrayList selecionarPontosSemiPlanoImpar()
        {
            ArrayList lista = null;
            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            lista = dao.obterTodos(1, true);

            ArrayList pontosSemiPlanoImpar = new ArrayList();

            for (int i = 0; i < lista.Count; i++)
            {
                PontoVO objeto = (PontoVO) lista[i];

                double resultado = objeto.X * objeto.Y;
                if (resultado > 0)
                {
                    pontosSemiPlanoImpar.Add(objeto);
                }
            }
            return pontosSemiPlanoImpar;
        }

        public ArrayList selecionarPontosSemiPlanoPar()
        {
            return null;
        }
        public ArrayList selecionarPontos(int tipoFigura)
        {
            return null;
        }
    }
}
