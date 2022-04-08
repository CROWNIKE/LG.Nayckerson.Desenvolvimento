using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LG.Nayckerson.Desenvolvimento
{
    
    public class ListaDeContato : IList<Contato>
    {
        private IList<Contato> _contatos;

        public ListaDeContato()
        {
            _contatos = new List<Contato>();
        }

        public static implicit operator ListaDeContato(List<Contato> contatos)
        {
            return new ListaDeContato { contatos };
        }

        public Contato this[int index]
        {
            get { return _contatos[index]; }
            set { if (PodeAdicionar(value)) _contatos[index] = value; }
        }

        public int Count
        {
            get { return _contatos.Count; }
        }

        public bool IsReadOnly => false;

        public void Add(Contato item)
        {
            if (PodeAdicionar(item)) _contatos.Add(item);
        }

        public void Clear()
        {
            _contatos.Clear();
        }

        public bool Contains(Contato item)
        {
            return _contatos.Contains(item);
        }

        public void CopyTo(Contato[] array, int arrayIndex)
        {
            _contatos.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Contato> GetEnumerator()
        {
            return _contatos.GetEnumerator();
        }

        public int IndexOf(Contato item)
        {
            return _contatos.IndexOf(item);
        }

        public void Insert(int index, Contato item)
        {
            if (PodeAdicionar(item)) _contatos.Insert(index, item);
        }

        public bool Remove(Contato item)
        {
            return _contatos.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _contatos.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _contatos.GetEnumerator();
        }

        private bool PodeAdicionar(Contato item)
        {
            return _contatos.All(contato => contato.FoneRelacionamento != item.FoneRelacionamento);
        }

        private void Add(List<Contato> item)
        {
            foreach (var contato in item) _contatos.Add(contato);
        }
    }
}
