// Bật chế độ Unicode trong Visual Studio
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

// Tính BMI
Console.Write("Nhập cân nặng: ");
float canNang = float.Parse(Console.ReadLine()!);

Console.Write("Nhập chiều cao (m): ");
float chieuCao = float.Parse(Console.ReadLine()!);
float bmi = canNang / (chieuCao * chieuCao);

Console.WriteLine($"Chỉ số BMI của bạn là {bmi:0.00}");

//phân loại BMI (Gầy/Bình thường/Thừa cân/Béo phì theo chuẩn WHO)
if (bmi < 18.5)
{
    Console.WriteLine("Bạn thuộc nhóm gầy");
    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! Hãy ăn nhiều hơn nhé");
}
else
{
    if (bmi < 24.9)
    {
        Console.WriteLine("Bạn thuộc nhóm bình thường");
        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! Hãy giữ điều độ, tập thể dục thể thao thường xuyên.");
    }
    else
    {
        if (bmi < 29.9)
        {
            Console.WriteLine("Bạn thuộc nhóm thừa cân");
            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! Hãy giảm ăn, năng luyện tập thể thao");
        }
        else
        {
            Console.WriteLine("Bạn thuộc nhóm béo phì");
            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! Giảm ngay ăn nhiều, năng vận động");
        }
    }
}

// Thêm gì nữa ở đây?


//Giữ màn hình được mở
Console.ReadKey();