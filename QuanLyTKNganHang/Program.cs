// See https://aka.ms/new-console-template for more information
double balance = 0;
double withdraw = 0;
double currentBalance = 0;



try
{
    do
    {
        Console.WriteLine(" Nhap so du tai khoan:  ");
        balance = double.Parse(Console.ReadLine());
        if (balance <= 0)
        {
            Console.WriteLine("Vui long nhap so duong lon hon 0");
        }
    } while (balance <= 0);
    
    
    Console.WriteLine("Chon chuc nang");
    Console.WriteLine("1.Xem So du");
    Console.WriteLine("2. Nhap so tien muon rut");
    Console.WriteLine("3.Thoat ");
    int input =  int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
           Console.WriteLine($"So du: {balance} ");
            break;
        case 2:
            Console.WriteLine("Nhap so tien muon rut:  ");
            withdraw = double.Parse(Console.ReadLine());

            if (withdraw > balance)
            {
                throw new Exception(" So du khong du");
            }

            currentBalance = balance - withdraw;
            Console.WriteLine(" Rut tien thanh cong ");
            Console.WriteLine($"So du con lai la {currentBalance}");
            break;
        default:
            Console.WriteLine(" Vui long chon chuc nang  ");
            break;
    }
    
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Da ket thuc giao dich  ");
}

