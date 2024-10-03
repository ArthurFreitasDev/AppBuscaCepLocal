using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBuscaCepLocal.Model
{
    public class Endereco
    {
        public int id_logradouro { get; set; }
        public int id_cidade { get; set; }
        public string tipo { get; set; }
        public string desceicao { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        public string descricao_sem_numero { get; set; }
        public string descricao_cidade { get; set; }
        public string descricao_cidade_ibge { get; set; }
        public object rows { get; set; }
        public int CEP {  get; set; }
        public string UF { get; set; }
    }
}
