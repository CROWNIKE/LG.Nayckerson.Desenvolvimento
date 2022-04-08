using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.Nayckerson.Desenvolvimento
{
    public class Cliente
    {
        private ListaDeContato _contatos;

        public Cliente()
        {
            Contatos = new ListaDeContato();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeNascimento { get; set; }

        /// <summary>
        /// Retorna contatos ordenado.
        /// </summary>
        public ListaDeContato Contatos
        {
            get { return _contatos.OrderBy(x => x.Codigo).ToList(); }
            set { _contatos = value; }
        }
    }
}
