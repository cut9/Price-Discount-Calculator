while (true)
{
    Console.WriteLine("Цена?:");
    bool isPriceParsed = decimal.TryParse(Console.ReadLine(), out decimal price);
    Console.WriteLine("Скидка?:");
    bool isDiscountParsed = decimal.TryParse(Console.ReadLine(), out decimal discount);
    if (isPriceParsed && isDiscountParsed)
    {
        decimal savedMoney = (price * discount) / 100;
        decimal priceAfterDiscount = price - savedMoney;
        Console.WriteLine($"Цена с скидкой = {priceAfterDiscount}");
        Console.WriteLine($"Экономия = {savedMoney}");
    }
    Console.WriteLine("----------------------------------------");
}