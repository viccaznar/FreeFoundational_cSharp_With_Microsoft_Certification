string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have the required permission.");
    }
}
else
{
    Console.WriteLine("You do not have sufficent privileges.");
}
