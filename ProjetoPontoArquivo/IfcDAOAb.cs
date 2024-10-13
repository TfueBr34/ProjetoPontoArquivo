using System.Collections;
namespace modelo
{
	public interface IfcDAOAb
	{
		public abstract ArrayList obterTodos();
		public abstract ArrayList obterTodos(int tipoFigura);
		public abstract ArrayList inserir(PontoVO pontoVO);
		public abstract ArrayList pesquisar(PontoVO pontoVO);
		public abstract ArrayList alterar(PontoVO pontoVO);
		public abstract ArrayList excluir(PontoVO pontoVO);
	}
}