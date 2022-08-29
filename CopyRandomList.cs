/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        
        // Default
        if (head == null)
        {
            return null;
        }
        
        List<int>  Values  = new List<int>();
        List<Node> Nodes   = new List<Node>();
        List<int> Randoms = new List<int>();
        
        Node HeadCopy = head;
        
        while (HeadCopy != null)
        {
            Nodes.Add(new Node(HeadCopy.val));
            Values.Add(HeadCopy.val);
            
            HeadCopy = HeadCopy.next;
        }
        
        HeadCopy = head;
        
        while (HeadCopy != null)
        {
            if (HeadCopy.random != null)
            {
                //Console.WriteLine(Values.IndexOf(HeadCopy.random.val));
                Randoms.Add(Values.IndexOf(HeadCopy.random.val));   
            }
            else
            {
                //Console.WriteLine("null");
                Randoms.Add(-1);
            }
            
            HeadCopy = HeadCopy.next;
        }
        
        //Nodes = new List<Node>();
        
        Node PreviousNode = new Node(Values[Values.Count - 1]);
        PreviousNode.next = null;
        //PreviousNode.random = Randoms[Randoms.Count - 1];
        
        Node Output = PreviousNode;
        
        //Nodes.Add(Output);
        for (int i = Values.Count - 2; i > -1; i--)
        {
            Output = new Node(Values[i]);
            Output.next = PreviousNode;
            //Output.random = Randoms[i];
            PreviousNode = Output;
            
            //Nodes.Add(Output);
        }/**/

        Node OutputRandom = Output;
        for (int i = 0; i < Randoms.Count; i++)
        {
            if (Randoms[i] != -1)
            {
                
                Node OutputTarget = Output;
            
                for (int j = 0; j < Randoms[i]; j++)
                {
                    OutputTarget = OutputTarget.next;
                }
                //Console.WriteLine(OutputTarget.val);
                OutputRandom.random = OutputTarget;

                
            }
            
            OutputRandom = OutputRandom.next;
        }
        
        /*
        // Debug
        Node OutputCopy = Output;

        while (OutputCopy != null)
        {
            Console.WriteLine(OutputCopy.val);
            
            if (OutputCopy.next != null)
            {
                Console.WriteLine(OutputCopy.next.val);
            }
            else
            {
                Console.WriteLine("null");    
            }
            
            if (OutputCopy.random != null)
            {
                Console.WriteLine(OutputCopy.random.val);
            }
            else
            {
                Console.WriteLine("null");    
            }
            
            Console.Write("\n");
            
            OutputCopy = OutputCopy.next;
        }*/
            
        
        return Output;
    }
}