using System.Text.RegularExpressions;

string hand = Console.ReadLine()!;
PoKer_Hand(hand);


static void PoKer_Hand(string h)
{

///////////////////////  преобразуем строку //////////////////////////////

    h = h.Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14");  
    string[] hand = h.Split(' ', StringSplitOptions.RemoveEmptyEntries);               
        string[] suites = ["H", "D", "C", "S"];
    
////////////////////////////тест на флеш/////////////////////////////////////

    var flush = suites.Where(s => hand.All(h => h.Contains(s))).ToList();
    bool flush_test = flush.Any()? true:false;
    
////////// сделаем цифры в int, отсортируем по возрастанию //////////////////

    hand = hand.Select(h => h.Remove(h.Length-1)).ToArray();
    int[] card_nums = Array.ConvertAll(hand, int.Parse);
    Array.Sort(card_nums);

/////////////////////////// тест на стрит ///////////////////////////////////

    var test = card_nums.Where((c1,c2) => c1==c2-1).ToList();
    int count = 1;
    for (int i = 0; i < card_nums.Length - 1; i++)                                      // посчитаем количество идущих подряд цифр
    {
        if (card_nums[i] == card_nums[i + 1] - 1)
            count++;
    }
    bool straight_test = count == 5 ? true : false;

/// для сравнения через Regex переведём цифры карт   ////// 
/// в их алфавитное соответствие, сохраним в строку, //////
/// где двойка будет == A, тройка == B и тд...       //////

    string? cards_nums_in_letters = string.Join("", card_nums.Select(i => (char)(64 + i))); ;

////////////////////////////// выведем на экран //////////////////////////

    if (straight_test && flush_test && card_nums[0] == 10)
        Console.WriteLine("Flash Royal");

    else if (straight_test && flush_test)
        Console.WriteLine("Straight Flush");

    else if (flush_test)
        Console.WriteLine("Flush");

    else if (straight_test)
        Console.WriteLine("Straight");

//////////////////////// через Regex найдем совпадения карт //////////////

    else if (Regex.IsMatch(cards_nums_in_letters, @".?(.)\1\1\1"))
        Console.WriteLine("Four of a Kind");

    else if (Regex.IsMatch(cards_nums_in_letters, @"(.)\1\1(.)\2") || Regex.IsMatch(cards_nums_in_letters, @"(.)\1(.)\2\2"))
        Console.WriteLine("Full House");

    else if (Regex.IsMatch(cards_nums_in_letters, @".*(.)\1\1.*"))
        Console.WriteLine("Three of a Kind");

    else if (Regex.IsMatch(cards_nums_in_letters, @".*(.)\1.*(.)\2"))
        Console.WriteLine("Two Pairs");

    else if (Regex.IsMatch(cards_nums_in_letters, @".*(.)\1.*"))
        Console.WriteLine("One Pair");
    
    else
        Console.WriteLine("High Card");
    
}
