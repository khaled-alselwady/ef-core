namespace SetupEFCoreModel
{
    internal class Program
    {
        static void _RetrieveAllData()
        {
            using (AppDBContext context = new AppDBContext())
            {
                foreach (Wallet wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }
            }
        }

        static void _Find(int Id)
        {
            using (AppDBContext context = new AppDBContext())
            {
                Wallet? wallet = context.Wallets.FirstOrDefault(wallet => wallet.Id == Id);

                if (wallet is not null)
                {
                    Console.WriteLine(wallet);
                }
            }
        }

        static void _Add()
        {
            using (AppDBContext context = new AppDBContext())
            {
                Wallet wallet = new Wallet
                {
                    Holder = "Salah",
                    Balance = 1200m
                };

                context.Wallets.Add(wallet);
                context.SaveChanges();
            }
        }

        static void _Update()
        {
            using (AppDBContext context = new AppDBContext())
            {
                Wallet wallet = context.Wallets.Single(wallet => wallet.Id == 3);

                wallet.Balance += 1000m;

                context.SaveChanges();
            }
        }

        static void _Delete(int Id)
        {
            using (AppDBContext context = new AppDBContext())
            {
                Wallet wallet = context.Wallets.Single(wallet => wallet.Id == Id);

                context.Wallets.Remove(wallet);

                context.SaveChanges();
            }
        }

        static void _RetrieveDataWithFilter()
        {
            using (AppDBContext context = new AppDBContext())
            {
                var result = context.Wallets.Where(wallet => wallet.Balance > 8000);

                foreach (Wallet wallet in result)
                {
                    Console.WriteLine(wallet);
                }
            }
        }

        static void _ApplyTransaction()
        {
            using (AppDBContext context = new AppDBContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    // Transfer $500 from wallet id = 5 to wallet id = 6

                    Wallet fromWallet = context.Wallets.Single(wallet => wallet.Id == 5);
                    Wallet toWallet = context.Wallets.Single(wallet => wallet.Id == 6);

                    decimal amountToTransfer = 500m;

                    fromWallet.Balance -= amountToTransfer;
                    context.SaveChanges();

                    toWallet.Balance += amountToTransfer;
                    context.SaveChanges();

                    transaction.Commit();
                }
            }
        }

        static void Main(string[] args)
        {
            //_RetrieveAllData();

            //_Find(Id: 2);

            //_Add();

            //_Update();

            //_Delete(Id: 11);

            //_RetrieveDataWithFilter();

            //_ApplyTransaction();

            Console.ReadKey();
        }
    }
}
