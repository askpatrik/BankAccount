namespace BankAccount
{
     class Program
    {
        static void Main(string[] args)
        {
            var patriksKonto = new BankAccount("Patrik", 5000);
            var kevinsKonto = new BankAccount("Kevin", 7500);

            patriksKonto.MakeTransfer(500, patriksKonto);
            
        }
    }
}