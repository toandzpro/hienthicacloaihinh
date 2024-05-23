using System.Text;

public class Baitap15
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Menu();

            int a = GetMenuChoice();

            if (a == 4)
            {
                break;
            }

            hinhve(a);
        }
    }

    static void Menu()
    {
        Console.WriteLine("Chọn hình để vẽ:");
        Console.WriteLine("1. Hình vuông");
        Console.WriteLine("2. Hình chữ nhật");
        Console.WriteLine("3. Hình tam giác");
        Console.WriteLine("4. Thoát");
    }

    static int GetMenuChoice()
    {
        Console.Write("Nhập số thứ tự hình bạn muốn vẽ: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.Write("Lựa chọn không hợp lệ. Vui lòng nhập lại: ");
        }
        return choice;
    }

    public static void hinhve(int a)
    {
        switch (a)
        {
            case 1:
                vehinhvuong();
                break;
            case 2:
                vehinhchunhat();
                break;
            case 3:
                vetamgiac();
                break;
        }
    }

    public static void vehinhvuong()
    {
        Console.Write("Nhập kích thước cạnh hình vuông: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(new string('*', size).Replace("*", "* "));
        }
    }

    public static void vehinhchunhat()
    {
        Console.Write("Nhập chiều rộng hình chữ nhật: ");
        int chieurong = int.Parse(Console.ReadLine());
        Console.Write("Nhập chiều cao hình chữ nhật: ");
        int Chieucao = int.Parse(Console.ReadLine());

        for (int i = 0; i < Chieucao; i++)
        {
            Console.WriteLine(new string('*', chieurong).Replace("*", "* "));
        }
    }

    public static void vetamgiac()
    {
        Console.Write("Nhập chiều cao hình tam giác: ");
        int Chieucao = int.Parse(Console.ReadLine());

        for (int i = 1; i <= Chieucao; i++)
        {
            Console.WriteLine(new string('*', i).Replace("*", "* ")); 
        }
    }
}
