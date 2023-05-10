namespace CSharp_PR_2
{
	public class Customer_Account
	{
		private string bank_name;
		private string customer_accountNo;
		private string customer_name;

		public Customer_Account(string name, string accountNo)
		{
			customer_accountNo = accountNo;
			customer_name = name;
		}

		public void PrintInfo()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("--------------------------------------------------------");
			Console.WriteLine();
			Console.WriteLine($"Customer name is {customer_name}");
			Console.WriteLine($"Customer account number is {customer_accountNo}");
			Console.WriteLine($"Customer bank name is {bank_name}");
			Console.WriteLine();
			Console.WriteLine("-------------------------------------------------------");
			Console.ResetColor();
		}

		public void SetBackName(string backName)
		{
			bank_name = backName;
		}

	}
}
