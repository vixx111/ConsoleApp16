using System;
public class PhoneCall
{
    private int duration;
    private decimal costPerMinute;
    public PhoneCall(int duration, decimal costPerMinute)
    {
        this.duration = duration;
        this.costPerMinute = costPerMinute;
    }
    public string GetInfo()
    {
        return $"Продолжительность разговора: {duration} мин, Стоимость одной минуты: {costPerMinute} руб.";
    }
    public decimal CalculateTotalCost()
    {
        return duration * costPerMinute;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите продолжительность разговора в минутах:");
        string durationInput = Console.ReadLine();
        Console.WriteLine("Введите стоимость одной минуты :");
        string costInput = Console.ReadLine();
        if (int.TryParse(durationInput, out int duration) &&
            decimal.TryParse(costInput, out decimal cost))
        {
            PhoneCall call = new PhoneCall(duration, cost);
            decimal totalCost = call.CalculateTotalCost();
            Console.WriteLine(call.GetInfo());
            Console.WriteLine($"Общая стоимость разговора: {totalCost} руб.");
        }
        else
        {
            Console.WriteLine("Введите корректные значения.");
        }
    }
}