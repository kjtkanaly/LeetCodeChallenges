public class Solution {
    public string Multiply(string num1, string num2) {
        
        List<ulong> Numb2 = new List<ulong>();
        
        for (int i = 0; i < num2.Length; i++)
        {
            Numb2.Add(Convert.ToUInt64(new String(num2[i], 1)));
        }
        
        ulong Numb1 = Convert.ToUInt64(num1);
        
        Console.WriteLine("Number 1: " + Numb1);
        Console.Write("\n");
        Console.Write("Number 2: ");
        for (int i = 0; i < Numb2.Count; i++)
        {
            Console.Write(Numb2[i] + ", ");
        }
        Console.Write("\n");
        
        double Output = 0;
        
        for (int i = Numb2.Count - 1; i > -1; i--)
        {
            Output += Numb1 * Numb2[i] * Math.Pow(10, Numb2.Count - 1 - i);
            
            // Debug
            Console.WriteLine(Numb1 * Numb2[i] * Math.Pow(10, Numb2.Count - 1 - i));
        }

        return Output.ToString();
    }
}