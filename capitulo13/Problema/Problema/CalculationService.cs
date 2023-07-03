namespace Problema
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
           if(list.Count == 0)
            {
                throw new ArgumentException("the list Can not be empty!");
            }
            T Max = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(Max) > 0)
                {
                    Max = list[i];
                }
            }
            return Max;
        }
    }
}
