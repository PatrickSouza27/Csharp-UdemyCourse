namespace ExercicioProposto
{
    public class ProcessContratos
    {
        private IContract _contract;


        public ProcessContratos(IContract contract)
        {
            _contract = contract;
        }

        public void ProcessContrato(Contract contrato, int month)
        {
            double valueBasic = contrato.TotalValue / month;
            for (int i = 1; i <= month; i++)
            {
                DateTime Date = contrato.Date.AddMonths(i);
                double UpdateValue = valueBasic + _contract.Interest(valueBasic, i);
                double ValueFinal = UpdateValue + _contract.ProcessPay(UpdateValue);
                contrato.AddInstallment(new Installment(Date, ValueFinal));
            }
        }
    }
}
