﻿namespace Automat_Konsol
{
    /// <summary>
    /// A wallet class the holds the users money in a list
    /// Has a user and a list of coins
    /// 
    /// </summary>
    public class Wallet
    {
        public string user;

        public List<Money> money;


        public Wallet(string user, List<Money> money)
        {
            this.user = user;
            this.money = money;
        }
        /// <summary>
        /// Pay method, takes in a cost then finds the highest denomination in the wallet that you can pay with then removes as many as possible to pay the cost
        /// </summary>
        /// <param name="cost"></param>
        public void Pay(int cost, Wallet wallet)
        {
            for (int i = money.Count - 1; i >= 0; i--)
            {
                if (cost < 0)
                {
                    ReturnChange(wallet);
                    break;
                }
                if (cost == 0) break;

                if (money[i].Count > 0 && money[i].Denomination <= cost)
                {
                    int nbrOf = money[i].Count < cost / money[i].Denomination ? money[i].Count : cost / money[i].Denomination;
                    money[i].Count -= nbrOf;
                    cost -= nbrOf * money[i].Denomination;
                }
            }
            //find closest money over is better
            if (cost > 0)
            {

            }
            // remove the money from the pile
        }
        /// <summary>
        /// Adds the funds to the vending machine
        /// </summary>
        /// <param name="funds"></param>
        public void AddFunds(Wallet wallet)
        {
            Wallet tempVend = this;
            Wallet tempUser = wallet;
            bool valid = true;
            string[] inserted;
            int amount;
            //add the specific coins
            do
            {
                Console.WriteLine("Hur mycket önskar du sätta in? skriv per valör serparera med komma, " +
                "\nvalörerna är enkrona, femkrona, tiokrona, tjugolapp, femtiolapp och hundralapp, ex 5 enkronor och 5 tior: 5,0,5 ");
                inserted = Console.ReadLine().Split(',');
                amount = 0;
                if (VaildInput(inserted, wallet))
                {
                    for (int i = 0; i < inserted.Length; i++)
                    {
                        if (int.TryParse(inserted[i], out amount) && amount <= wallet.money[i].Count)
                        {
                            this.money[i].Count += amount;
                            wallet.money[i].Count -= amount;
                        }

                    }
                }
                else
                {
                    Program.ShowInvalidInput();
                    Program.ShowPressAnyKey();
                    valid = false;
                }
                Console.Clear();
            } while (valid = false);



        }
        /// <summary>
        /// returns change to the user
        /// </summary>
        /// <param name="change"></param>
        public void ReturnChange(Wallet wallet)
        {
            string returned = this.ToString(); 
            for (int i = 0; i < wallet.money.Count; i++)
            {
                wallet.money[i].Count += this.money[i].Count;
                this.money[i].Count -= this.money[i].Count;
            }
            Console.WriteLine($"Returnerar: {returned}");            
        }

        /// <summary>
        /// gets the total balance in the wallet
        /// </summary>
        /// <returns>the sum of the wallets content</returns>
        public int getBalance()
        {
            int sum = 0;
            foreach (var item in money)
            {
                sum += item.Count * item.Denomination;
            }
            return sum;
        }
        /// <summary>
        /// Converts the money list to string
        /// </summary>
        /// <returns>return the string depicting the money list</returns>
        public override string ToString()
        {
            return $"{this.money[0].Count} enkronor, {this.money[1].Count} femkronor, {this.money[2].Count} tiokronor," +
                $" {this.money[3].Count} tjugolappar, {this.money[4].Count} femtiolappar, {this.money[5].Count} hundra lappar";
        }
        /// <summary>
        /// checks that the input is vaild and the funds are available
        /// </summary>
        /// <param name="inserted"></param>
        /// <param name="wallet"></param>
        /// <returns>true if its valid and false if not</returns>
        public bool VaildInput(string[] inserted, Wallet wallet)
        {
            int count = 0;
            int amount;
            for (int i = 0; i < inserted.Length; i++)
            {
                if (int.TryParse(inserted[i], out amount) && amount <= wallet.money[i].Count)
                {
                    count++;
                }
                else if (int.TryParse(inserted[i], out amount) && amount > wallet.money[i].Count)
                {
                    Console.WriteLine($"Inte tillräckligt av {i + 1}:e valören i plånboken" +
                        "\nInsättnignen nullifieras");
                }
            }
            return (count == inserted.Length) ? true : false;
        }
    }

}
