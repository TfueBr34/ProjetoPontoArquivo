using modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
            ArrayList lista = null;
            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            lista = dao.obterTodos(1, true);

            ArrayList pontosSelecionados = new ArrayList();
            for (int i = 0; i < lista.size(); i++)
            {
                PontoVO objeto = lista.get(i);

                switch (codigo)
                {
                    case 1: // Direito
                        if (objeto.getX() > 0)
                        {
                            pontosSelecionados.Add(objeto);
                        }
                        break;
                    case 2: // Esquerdo
                        if (objeto.getX() < 0)
                        {
                            pontosSelecionados.Add(objeto);
                        }
                        break;
                    case 3: //Superior
                        if (objeto.getX() > 0)
                        {
                            pontosSelecionados.Add(objeto);
                        }
                        break;
                    case 4: //Inferior
                        if (objeto.getY() < 0)
                        {
                            pontosSelecionados.Add(objeto);
                        }
                        break;
                    default:
                        Console.WriteLine("Código Inválido");
                        break;
                }
            }
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
            ArrayList lista = null;

            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            lista = dao.obterTodos(1, true);

            ArrayList pontosSemiPlanoPar = new ArrayList();

            for(int i = 0; i < lista.Count; i++)
            {
                PontoVO objeto = (PontoVO)lista[i];

                double resultado = objeto.X * objeto.Y;
                if(resultado < 0)
                {
                    pontosSemiPlanoPar.Add(objeto);
                }
            }
            return pontosSemiPlanoPar;

        }
        public ArrayList selecionarPontos(int tipoFigura)
        {
            ArrayList lista = null;

            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            lista = dao.obterTodos(tipoFigura);

            return lista;
        }
    }
}
