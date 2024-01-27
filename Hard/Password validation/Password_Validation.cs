CheckPass(Console.ReadLine()!);

static void CheckPass(string str)
{
    // 'n' количество цифр
    // 'l' длина пароля
    // 's' наличие символов

    int n = 0, l= str.Length;
    bool s = false;
    char[] ch = { '!', '@', '#', '$', '%', '&', '*' };

    for (int i = 0; i < str.Length; i++)
    {
        if (Char.IsNumber(str[i]))
        {
            n++;
            continue;
        }
        for(int j = 0; j < ch.Length; j++)
        {
            if (ch[j] == str[i])
                s = true;
        }

    }
    Console.WriteLine(n>=2 && l>=7 && s? "Strong":"Weak");

}
