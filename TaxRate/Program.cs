namespace MyFirstProject.day1.examples
{
	class TaxRate
	{
		static void Main()
		{
			// Calculate the tax to be paid by a person earning 45000
			// Salary less than or equal to 8350 %10
			// Salary greater than 8350 to 33950 (including) %15
			// Salary greater than 33950 %25
			Console.Write("Please enter your salary: ");
			string salaryStr = Console.ReadLine();
			int salary = int.Parse(salaryStr);
			double lowTaxRate, medTaxRate, highTaxRate, totalTax;
			if (salary > 8350 && salary <= 33950)
			{
				lowTaxRate = 8350 * 0.10;
				medTaxRate = (salary - 8350) * 0.15;
				highTaxRate = 0;
			}
			else if (salary > 33950)
			{
				lowTaxRate = 8350 * 0.10;
				medTaxRate = (33950 - 8350) * 0.15;
				highTaxRate = (salary - 33950) * 0.25;
			}
			else {
				lowTaxRate = salary * 0.10;
				medTaxRate = 0;
				highTaxRate = 0;
			}
			totalTax = (double)System.Math.Round(lowTaxRate + medTaxRate + highTaxRate, 2);
			string totalTaxStr = totalTax.ToString();
			totalTaxStr = String.Format("{0:0.00}", totalTaxStr);
			Console.WriteLine($"The total tax is ${totalTaxStr}.");
		}
	}
}
