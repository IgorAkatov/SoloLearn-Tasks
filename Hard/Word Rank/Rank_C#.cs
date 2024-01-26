public class Program
{
   static List <string> allWords = new List<string>();
    public static void Main(string[] args)
    {
        string input = Console.ReadLine()!;       
        WordRank(input);
        Console.WriteLine((1+allWords.FindIndex(s => s == input)));

    }
    
    public static void WordRank(string word, string prefix = "")
    {
        if (word.Length < 2)
        {          
            allWords.Add(prefix + word);            
            return;
        }

        HashSet<char> s = new HashSet<char>(word);             
        List<char> sortedChars = new List<char>(s);            
        sortedChars.Sort();                                   
        
        foreach (char c in sortedChars)                          
        {
            List<char> letter = new List<char>(word);       
            letter.Remove(c);                                
            string output = string.Join("", letter);
            
            WordRank(output, prefix + c); 
        }
        
    }
}

