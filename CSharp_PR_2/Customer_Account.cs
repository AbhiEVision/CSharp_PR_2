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

		// this method first make color green after that they will print the details of user like their name, account no. and bank name.
		public void PrintInfo()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("================ Customer bank details ================");
			Console.WriteLine();
			Console.WriteLine($"Customer name is {customer_name}");
			Console.WriteLine($"Customer account number is {customer_accountNo}");
			Console.WriteLine($"Customer bank name is {bank_name}");
			Console.WriteLine();
			Console.WriteLine("=======================================================\n");
			Console.ResetColor();
		}

		public void SetBackName(string backName)
		{
			bank_name = backName;
		}

	}
}
