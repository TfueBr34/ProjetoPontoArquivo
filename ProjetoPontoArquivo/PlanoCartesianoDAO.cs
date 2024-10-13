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
                    switch (int.Parse(itens[1]))
                    {
                        case 1:
                            pontoVO.Lado1 = double.Parse(itens[5]);
                            break;
                        case 2:
                            pontoVO.Lado1 = double.Parse(itens[5]);
                            pontoVO.Lado2 = double.Parse(itens[6]);
                            break;
                        case 3:
                            pontoVO.Lado1 = double.Parse(itens[5]);
                            pontoVO.Lado2 = double.Parse(itens[6]);
                            pontoVO.Lado3 = double.Parse(itens[7]);
                            break;
                    }
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
                if (int.Parse(itens[1]) == tipoFigura)
                {
                    try
                    {
                        pontoVO = new PontoVO(int.Parse(itens[0]), int.Parse(itens[1]), itens[2], double.Parse(itens[3]), double.Parse(itens[4]));
                        switch (tipoFigura)
                        {
                            case 1:
                                pontoVO.Lado1 = double.Parse(itens[5]);
                                break;
                            case 2:
                                pontoVO.Lado1 = double.Parse(itens[5]);
                                pontoVO.Lado2 = double.Parse(itens[6]);
                                break;
                            case 3:
                                pontoVO.Lado1 = double.Parse(itens[5]);
                                pontoVO.Lado2 = double.Parse(itens[6]);
                                pontoVO.Lado3 = double.Parse(itens[7]);
                                break;
                        }
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
        public ArrayList inserir(PontoVO pontoVO)
        {
            ArrayList pontos = obterTodos();
            pontos.Insert(pontoVO.Codigo-1, pontoVO);
            StreamWriter escritor = new StreamWriter("@registros.txt");
            escritor.WriteLine("n="+pontos.Count);
            escritor.WriteLine("NSU;tipoFigura;descricao;x;y;valor1;valor2;valor3");
            foreach (PontoVO ponto in pontos)
            {
                escritor.Write(ponto.Codigo.ToString() + ";" + ponto.TipoFigura.ToString() + ";" + ponto.Descricao.ToString() + ";" + ponto.X.ToString() + ";" + ponto.Y.ToString() + ";");
                switch (ponto.TipoFigura)
                {
                    case 1:
                        escritor.Write(ponto.Lado1+";;\n");
                        break;
                    case 2:
                        escritor.Write(ponto.Lado1 + ";" + ponto.Lado2 + ";\n");
                        break;
                    case 3:
                        escritor.Write(ponto.Lado1 + ";" + ponto.Lado2 + ";" + ponto.Lado3 + "\n");
                        break;
                }
            }
            return pontos;
        }
        public ArrayList pesquisar(PontoVO pontoVO)
        {
            ArrayList lista = obterTodos();
            foreach(PontoVO ponto in lista)
            {
                if (ponto.Equals(pontoVO))
                {
                    lista.Clear();
                    lista.Add(ponto);
                    return lista;
                }
            }
            return null;
        }
        public ArrayList alterar(PontoVO pontoVO)
        {
            ArrayList pontos = obterTodos();
            pontos.RemoveAt(pontoVO.Codigo-1);
            pontos = inserir(pontoVO);
            return pontos;
        }
        public ArrayList excluir(PontoVO pontoVO)
        {
            ArrayList pontos = obterTodos();
            pontos.RemoveAt(pontoVO.Codigo - 1);
            StreamWriter escritor = new StreamWriter("@registros.txt");
            escritor.WriteLine("n=" + pontos.Count);
            escritor.WriteLine("NSU;tipoFigura;descricao;x;y;valor1;valor2;valor3");
            foreach (PontoVO ponto in pontos)
            {
                escritor.Write(ponto.Codigo.ToString() + ";" + ponto.TipoFigura.ToString() + ";" + ponto.Descricao.ToString() + ";" + ponto.X.ToString() + ";" + ponto.Y.ToString() + ";");
                switch (ponto.TipoFigura)
                {
                    case 1:
                        escritor.Write(ponto.Lado1 + ";;\n");
                        break;
                    case 2:
                        escritor.Write(ponto.Lado1 + ";" + ponto.Lado2 + ";\n");
                        break;
                    case 3:
                        escritor.Write(ponto.Lado1 + ";" + ponto.Lado2 + ";" + ponto.Lado3 + "\n");
                        break;
                }
            }
            return pontos;
        }
    }
}
