public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        //int[] Steps = new int[position.Length];
        List<int> Steps = new List<int>(position.Length);
        
        
        for (int i = 0; i < position.Length; i++)
        {
            Steps.Add(i); //Steps[i] = i;
        }
        
        int MaxStep = target / speed.Min();
        
        Array.Sort(position, speed);
        
        List<int> Position = position.ToList();
        List<int> Speed    = speed.ToList();
        
        for (int i = 0; i < MaxStep; i++)
        {
            int RemoveIndex = Position.FindIndex(x => x >= target);
            while (RemoveIndex != -1)
            {
                Position.RemoveAt(RemoveIndex);
                Speed.RemoveAt(RemoveIndex);
                
                RemoveIndex = Position.FindIndex(x => x >= target);
            }
            
            
            for (int j = Position.Count - 1; j > -1; j--)
            {
                //Console.Write(Position[j] + ", ");
                
                Position[j] += Speed[j];    
                
                if (j < (Position.Count - 1))
                {
                    if ((Position[j] >= Position[j + 1]))
                    {
                        Position[j] = Position[j + 1];
                        
                        Steps.Remove(j);
                    }    
                    
                }
                
            }
            
            //Console.Write(" Count: " + Steps.Count + "\n");
        }
     
        
        return Steps.Count; //Steps.Distinct().ToArray().Length;
    }
}

/*
for (int i = 0; i < position.Length; i++)
        {
            Steps.Add(0);
            
            while (position[i] < target)
            {
                Console.Write();
                
                position[i] += speed[i];
                
                Steps[i]++;
            }
            
            Console.WriteLine(Steps[i]);
        }
*/