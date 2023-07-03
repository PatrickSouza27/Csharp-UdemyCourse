using Compos.Entities.Enums;
using System.Collections.Generic;

namespace Compos.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
     
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {

        }
        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContrato(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract s in Contracts)
            {
                if(s.Date.Year == year && s.Date.Month == month)
                {
                    sum += s.TotValue();
                }
            }
            return sum;
        }
    }
}



