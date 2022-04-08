namespace LG.Nayckerson.Desenvolvimento
{
    public class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public EnumRelacionamento Relacionamento { get; set; }
        public string FoneRelacionamento => string.Format("{0}({1})", Telefone, Relacionamento.ToString());
    }
}