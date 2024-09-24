using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace modelo
{
    public class PlanoCartesianoDAO
    {
        public ArrayList obterTodos()
        {
            ArrayList pontos = new ArrayList();
            string linha = "";
            string[] itens = null;
            PontoVO pontoVO = null;

            StreamReader leitor = new StreamReader(@"registros.txt");
            while (!leitor.EndOfStream)
            {
                linha = leitor.ReadLine();
                itens = linha.Split(";");
                try
                {
                    pontoVO = new PontoVO(int.Parse(itens[0]), int.Parse(itens[1]), itens[2], double.Parse(itens[3]), double.Parse(itens[4]));
                    pontos.Add(pontoVO);
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao criar objeto do ponto. Mensagem: {0}", e);
                }
            }
            return pontos;
        }

        public ArrayList obterTodos(int tipoFigura)
        {
            ArrayList pontos = new ArrayList();
            string linha = "";
            string[] itens = null;
            PontoVO pontoVO = null;

            StreamReader leitor = new StreamReader(@"registros.txt");
            while (!leitor.EndOfStream)
            {
                linha = leitor.ReadLine();
                itens = linha.Split(";");
                if (itens[1] = tipoFigura)
                {
                    try
                    {
                        pontoVO = new PontoVO(int.Parse(itens[0]), int.Parse(itens[1]), itens[2], double.Parse(itens[3]), double.Parse(itens[4]));
                        pontos.Add(pontoVO);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erro ao criar objeto do ponto. Mensagem: {0}", e);
                    }
                }
            }
            return pontos;
        }
    }
}
