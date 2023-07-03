namespace CompararProduto
{
    class ServiceCalc
    {
        public T Max<T>(List<T> listProduto) where T : IComparable
        {
            if(listProduto.Count == 0)
            {
                throw new ArgumentException("Lista Vazia! Adicione um Produto valido");
            }

            T Maior = listProduto[0];
            for(int i = 1; i < listProduto.Count; i++)
            {
                if (listProduto[i].CompareTo(Maior) > 0)
                {
                    Maior = listProduto[i];
                }
            }
            return Maior;
        }
    }
}
