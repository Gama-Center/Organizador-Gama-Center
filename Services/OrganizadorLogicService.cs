using System;
using System.Collections.Generic;

namespace Organizador_Gama_Center.Services
{
    public class OrganizadorLogicService
    {
        // O dicionário de regras agora mora aqui. É 'readonly' porque só será definido no início.
        private readonly Dictionary<string, List<string>> _subtiposPorTipo;

        // O construtor é o lugar perfeito para inicializar as regras
        public OrganizadorLogicService()
        {
            _subtiposPorTipo = new Dictionary<string, List<string>>();
            InicializarDependencias();
        }

        // Este método agora é privado, pois é um detalhe interno da classe
        private void InicializarDependencias()
        {
            _subtiposPorTipo.Clear();
            _subtiposPorTipo.Add("TREINAMENTO", new List<string> {"PDFS", "PROVA", "RAC", "VIDEOS" });
            _subtiposPorTipo.Add("DOCUMENTOS TECNICOS", new List<string>());

            //Criando lista de NRS automaticas
            var listaNrs = new List<string>();
            for (int i = 1; i <= 39; i++)
            {
                listaNrs.Add("NR " + i);
            }


            // 3. Adicionamos a nova regra: o TIPO "CERTIFICADOS" tem como subtipos a lista de NRs
            _subtiposPorTipo.Add("CERTIFICADOS", listaNrs);
        }

        // Método público para o Chef pedir a lista de subtipos
        public List<string> ObterSubtiposPorTipo(string tipo)
        {
            if (tipo != null && _subtiposPorTipo.ContainsKey(tipo))
            {
                return _subtiposPorTipo[tipo];
            }
            return new List<string>(); // Sempre retorna uma lista, mesmo que vazia
        }

        // O método de abreviar agora é privado, uma ferramenta interna
        private string Abreviar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return "";
            switch (texto.ToUpper())
            {
                case "BOLETO": return "BOLETO";
                case "CERTIFICADO": return "CERTIF";
                default:
                    return texto.Substring(0, Math.Min(6, texto.Length)).ToUpper();
            }
        }

        // O método público que o Chef usará para pedir o nome do arquivo
        public string GerarNomeSugerido(string tipo, string subtipo, string empresa, string colaborador, string mes)
        {
            var partesDoNome = new List<string>();
            string dataAtual = DateTime.Now.ToString("dd-MM-yyyy");

            if (!string.IsNullOrWhiteSpace(tipo)) partesDoNome.Add(Abreviar(tipo));
            if (!string.IsNullOrWhiteSpace(subtipo)) partesDoNome.Add(Abreviar(subtipo));
            if (!string.IsNullOrWhiteSpace(colaborador)) partesDoNome.Add(colaborador.ToUpper());
            if (!string.IsNullOrWhiteSpace(empresa)) partesDoNome.Add(empresa.ToUpper());
            if (!string.IsNullOrWhiteSpace(mes)) partesDoNome.Add(mes.ToUpper());
            partesDoNome.Add(dataAtual);

            return string.Join(" - ", partesDoNome);
        }
    }
}