using System;
using System.Linq;

public class DnaStrand 
{
    public static string MakeComplement(string dna) // complement AACC -> TTDD 
    {
  
        char[] complement_dna = new char[dna.Length];

        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'A':
                complement_dna[i] = 'T';
                break;
                case 'T':
                complement_dna[i] = 'A';
                break;
                case 'C':
                complement_dna[i] = 'G';
                break;
                case 'G':
                complement_dna[i] = 'C';
                break;
            }
        } 
        return new string(complement_dna); 
    }
    // ^-- with just thatp, you can already run the code 

    public static bool  CheckUserInput(string input) // check user input
    {
        char[] valid_chars = {'A', 'T', 'C', 'G'}; 

        if (input.Length > 0)
        {
            for (int i = 0; i < input.Length; i++) 
            {
                if ((valid_chars).Contains(input[i]) == false)
                {
                    return false;
                } 
            }

            return true;        
        }

        else 
        {
            return false;
        }
    }


    public static void Main(String[] args)  
    {
        Console.Write("Enter the DNA sequence: ");
        string input = (Console.ReadLine()).ToUpper();

        while (CheckUserInput(input) == false) {
            Console.Write("Invalid input, try again: ");
            input = (Console.ReadLine()).ToUpper()
;
        }

        Console.Write("->\t{0}", MakeComplement(input));
        Console.ReadKey();
    }
}