public class Solution {
    public uint reverseBits(uint n) {
        
        string Binary = Convert.ToString(n, 2);
        
        for (int i = Binary.Length; i < 32; i++)
        {
            Binary = "0" + Binary;
        }
        
        Console.WriteLine("Size: " + Binary.Length);
        Console.WriteLine("OG: " + Binary);
        
        // Flip UInt
        char[] C = Binary.ToCharArray();
        Array.Reverse(C);
        Binary = new string(C);
        
        Console.WriteLine("Flip: " + Binary);
        Console.WriteLine(Convert.ToUInt32(Binary, 2));
        
        return Convert.ToUInt32(Binary, 2);
    }
}