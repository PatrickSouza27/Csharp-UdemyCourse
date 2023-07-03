namespace GetHashCodeEEquals
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Gmail { get; private set; }

        public Cliente(string nome, string gmail)
        {
            Nome = nome;
            Gmail = gmail;
        }

        public override bool Equals(object? obj)
        {
            if(obj is not Cliente)
            {
                return false;
            }
            Cliente? other = obj as Cliente;
            return Gmail.Equals(other?.Gmail);
        }

        public override int GetHashCode()
        {
            return Gmail.GetHashCode();
        }
    }
}
