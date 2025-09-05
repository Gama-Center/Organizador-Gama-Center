// DENTRO DE Services/DadosService.cs
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Organizador_Gama_Center.Services // O namespace agora inclui a pasta!
{
    public class DadosService
    {

        // Este método privado ajuda a não repetir código
        private List<string> CarregarListaDeArquivo(string nomeArquivo, List<string> listaPadrao)
        {
            List<string> lista;
            if (File.Exists(nomeArquivo))
            {
                lista = File.ReadAllLines(nomeArquivo).ToList();
            }
            else
            {
                lista = new List<string>(listaPadrao);
            }

            return lista;
        }

        // Cada método agora tem uma única responsabilidade e RETORNA a lista
        public List<string> CarregarTipos()
        {
            return CarregarListaDeArquivo("tipos.txt", new List<string> { "TREINAMENTO", "DOCUMENTOS TECNICOS" });
        }

        public List<string> CarregarEmpresas()
        {
            return CarregarListaDeArquivo("empresas.txt", new List<string> { "GAMA", "LG", "CLIENTE X" });
        }

        public List<string> CarregarColaboradores()
        {
            return CarregarListaDeArquivo("colaboradores.txt", new List<string> { "ALICE", "BRUNO", "CARLA", "DANIEL" });
        }

        public List<string> CarregarMeses()
        {
            return new List<string> { "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" };
        }
    }
}