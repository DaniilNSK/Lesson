//Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10,"z")
Console.WriteLine(res);