switch (position)
{
    case "Assistant Developer";
        salary *= 1.05f;
        break;
    case "IT Support";
        salary *= 1.07f;
        break;
    case "Senior Developer";
        salary *= 1.10f;
        break;
    case "Administrator";
        salary *= 1.08f;
        break;
    case "Other";
        salary *= 1.03f;
        break;
}

Console.WriteLine($"Your Salary = {Math.Round(salary)}");
