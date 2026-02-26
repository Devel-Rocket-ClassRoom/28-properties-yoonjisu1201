using System;

// README.md를 읽고 아래에 코드를 작성하세요.
BankAccount account = new BankAccount("123-456", "홍길동", 0);
Console.WriteLine("--- 50000원 입금 ---");
account.Deposit(50000);
Console.WriteLine("--- 20000원 출금 ---");
account.Withdraw(20000);
Console.WriteLine("--- 100000원 출금 시도 ---");
account.Withdraw(100000);






class BankAccount
{
    private string AccountNumber {  get; }
    private string OwnerName { get; set; }
    public  int Balance { get; private set; }

    public BankAccount(string number, string name, int balance)
    {
        AccountNumber = number;
        OwnerName = name;
        if (balance < 0)
        {
            Balance = 0;
        }
        else
        {
            Balance = balance;
        }
        Console.WriteLine($"계좌번호: {AccountNumber}");
        Console.WriteLine($"예금주: {OwnerName}");
        Console.WriteLine($"잔액: {Balance}");
    }

    public void Deposit(int amount)
    {
        if (amount>0)
        {
            Balance += amount;
            Console.WriteLine($"잔액: {Balance}원");
        }
    }

    public void Withdraw(int amount)
    {
        bool iswithdraw = false;
        if (amount>Balance)
        {
            Console.WriteLine($"출금 성공: {iswithdraw}");
            Console.WriteLine($"잔액: {Balance}원");
        }
        else
        {
            iswithdraw = true;
            Balance -= amount;
            Console.WriteLine($"출금 성공: {iswithdraw}");
            Console.WriteLine($"잔액: {Balance}원");
        }
    }
}