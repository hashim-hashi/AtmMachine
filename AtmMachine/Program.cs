
using System;


public class cardHolder
{
    String cardNum;
    int pin;
    String FirstName;
    String LastName;
    double balance;
    public cardHolder(String cardNum, int pin, String FirstName, String LastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.balance = balance;
    }

    public string getNum()
    {
        return cardNum;
    }
    public int getpin()
    {
        return pin;
    }
    public string getFirstName()
    {
        return FirstName;
    }
    public string getLastName()
    {
        return LastName;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(string newFirstName)
    {
        FirstName = newFirstName;
    }
    public void setLastName(string newLastName)
    {
        LastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from below..");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");

        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for deposit. you balance is" + currentUser.getBalance());
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money withdrawing?");
            double withdrawal = Double.Parse(Console.ReadLine());
            // check withdraw amount is greater than balance
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you");
            }

        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance:" + currentUser.getBalance());
        }
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("2313141", 6612, "fad", "sgw", 1234));
        cardHolders.Add(new cardHolder("2313124", 1612, "yyad", "sgwew", 1323));
        cardHolders.Add(new cardHolder("2313143", 1312, "fadd", "sgwfsd", 1223));
        cardHolders.Add(new cardHolder("2313123", 1412, "fadew", "gsfsgw", 1523));

        //prompt user
        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("please insert card");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not working");
                }
            }
            catch
            {
                Console.WriteLine("Not working");
            }
        }

        Console.WriteLine("Please enetr pin");
        int userPin = 0;

        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getpin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not working");
                }
            }
            catch
            {
                Console.WriteLine("Not working");
            }
        }
        Console.WriteLine("Welcome " + currentUser.getFirstName());
        int option = 0;
        printOptions();
        do
        {
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error");
            }
            if (option == 1)
            {
                deposit(currentUser);
            }
            else if (option == 2)
            {
                withdraw(currentUser);
            }
            else if (option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;
            }

        }
        while (option != 4);
        Console.WriteLine("Thank you");

    }
}
