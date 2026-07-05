var app = new App();
app.Run();

class App
{
    public void Run()
    {
        Console.WriteLine("hello everyone");
        GreetWhite();
        GreetBlack();
    }

    public void GreetWhite()
    {
        Console.WriteLine("hello white");
    }

    public void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
} 