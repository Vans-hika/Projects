// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;
using System.IO;
interface i1
{
    //void save();
   

}
abstract class Account:i1
{
    public virtual void save(int x)
    {
        int[] values = new int[x];
        //Stack<int[]> stack = new Stack<int[]>();
        int Totalamt = values.Sum();


    }
    public virtual void current(int x)
    {
        // stack.Pop();
    }
}
class CurrentAccount : Account
{
    int amount = 1000;
    public override void current(int Amount)
    {
        if(Amount>amount && Amount <= 0)
        {
            Console.WriteLine("Please add a valid Amount");
        }
        else
        {
            amount -= Amount;
            Console.WriteLine("$ {Amount} is transfer to you");
        }
    }
}
class SavingAccount : Account
{
  
    public override void save(int Amount)
    {    int[] values = new int[Amount];
        Stack<int[]> final = new Stack<int[]>();
        final.Push(values);
        if (values[values.Length-1] < 0)
        {
            Console.WriteLine("Please add valid amount");

        }
        else
        {
            Amount += Amount;
            Console.WriteLine("Total balance in your account is" + Amount);
        } 
            
        
    }
}
class Transactions
{
    public void Transaction(int Amount)
    {
        int[] amt = new int[5];

        for (int i = 0; i <= 5; i++)
        {
            amt = new int[Amount];
        }
        int Totalamt = amt.Sum();
        if (Totalamt > 50000)
        {
            Console.WriteLine("You cannot do transactions more than 50000 or more than 5 times");
        }
    }
}
class ATM:Account
{
    Stack<int> stack1 = new Stack<int>();
    public override void save(int x)
    {
        base.save(x);
        int[] values = new int[x];
        Console.WriteLine("Now total amount is"+ values.Sum());
    }
    public override void current(int x)
    {
        base.current(x);
        int[] values = new int[x];
        int TotalAmount = values.Sum();

        Console.WriteLine(" Your left balance"+(TotalAmount-x));

    }
}
class InputOutputHandler
{
  public void Input()
  {
        Console.Write("Please choose the right option");
        Console.WriteLine(" Saving"+" " +"Current");
        Console.WriteLine("Add Money" + " " + "Withdraw Money");
  }
    public void Output()
    {
        Console.WriteLine("Thankyou for coming");
    }
}
interface i2
{
     void available()
    {

    }
}
class AccountManager :i2
{
    void i2.available()
        
    {
              
        if (File.Exists("oops.txt"))
        {
            FileStream fs = new FileStream("oops.txt", FileMode.Open, FileAccess.Write);
            StreamWriter swr = new StreamWriter(fs);
        }
        else
        {
            Console.WriteLine("Not Exists");
            FileStream fs = new FileStream("oops.txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
        }



    }
}
class Program
{
    public static void Main(string[] args)
    {
         
         Console.WriteLine("Hii, How may I help you");
        InputOutputHandler obj = new InputOutputHandler();
        SavingAccount obj1 = new SavingAccount();
        CurrentAccount obj2 = new CurrentAccount();
        ATM obj3 = new ATM();
        i2 obj4 = new AccountManager();
       
        obj.Input();
        string input = Console.ReadLine();
        if (input=="Saving")
        {
            Console.WriteLine("Enter the amount you want to save");
            int Amount =Convert.ToInt32( Console.ReadLine());
            obj1.save(Amount);
        }
        else if (input == "Current")
        {
            Console.WriteLine("Enter the amount you want to withdraw");
            int Amount = Convert.ToInt32(Console.ReadLine());
            obj2.current(Amount);
            obj4.available();
        }
        else if (input == "Add Money")
        {
            Console.WriteLine("Enter the amount you want to add");
            int Amount = Convert.ToInt32(Console.ReadLine());
            obj3.save(Amount);
        }
        else if (input == "Withdraw Money")
        {
            Console.WriteLine("Enter the amount you want to add");
            int Amount = Convert.ToInt32(Console.ReadLine());
            obj3.current(Amount);

        }
        else
        {

            obj.Output();
        }

        



    }
}