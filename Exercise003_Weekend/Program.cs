int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend (int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay (int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    Console.Write("It's not a day of week!");
    return false;
}

int weekDay = Prompt("Enter a day of week: ");

if (ValidateWeekDay(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.Write("Ohh,that's weekend finally!");        
    }
    else
    {
        Console.Write("We have more work to do!");
    }
}