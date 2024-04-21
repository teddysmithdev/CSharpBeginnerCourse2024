Action loggerAction = () =>
{
    System.Console.WriteLine("This is simple");
};

Func<int, int> loggerFunc = (int x) =>
{
    return x + 2;
};

var list = Enumerable.Range(1, 10).Select(i => i * 3).ToList();

var callCall = (Action func) =>
{
    func();
};

callCall(loggerAction);

public delegate int SuperCustom(int x);