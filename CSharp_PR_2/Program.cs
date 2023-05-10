using CSharp_PR_2;

Customer_Account abhi_patel = new("Abhi Patel", "8532 5858 7412");
abhi_patel.SetBackName("Federal Bank");

Customer_Account parthiv_hirani = new("Parthiv Hirani", "7436 8912 6525");
parthiv_hirani.SetBackName("SBI");

abhi_patel.PrintInfo();
parthiv_hirani.PrintInfo();