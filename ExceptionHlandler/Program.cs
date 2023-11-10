try
{
    int a = 10;
    int c = a / 0;

}
catch (DivideByZeroException ex1)
{
    Console.WriteLine("Cannot divide by zero !");
}

catch (Exception ex)
{
    throw ex;                                          
}
finally
{
    Console.WriteLine("Oke!");
}
Console.ReadLine();
