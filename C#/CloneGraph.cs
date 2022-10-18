/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    
    public List<int> nodeValues = new List<int>();
    public List<List<int>> NodeNeighborValues = new List<List<int>>();
    
    public Node CloneGraph(Node node) {
        
        // Defaults
        if (node == null)
        {
            return null;   
        }
        
        if (node.neighbors.Count == 0)
        {
            return new Node(node.val);
        }

        
        FindAllNodes(node);
        
        List<Node> CopyList = new List<Node>();
        
        for (int i = 0; i < nodeValues.Count; i++)
        {
            Node Copy = new Node(nodeValues[i]);    
            CopyList.Add(Copy);
        }
        
        for (int i = 0; i < CopyList.Count; i++)
        {
            for (int j = 0; j < NodeNeighborValues[i].Count; j++)
            {
                int index = CopyList.FindIndex(x => x.val == NodeNeighborValues[i][j]);
                CopyList[i].neighbors.Add(CopyList[index]);
            }
        }
             
        
        
        return CopyList[0];
    }
    
    public void FindAllNodes(Node node)
    {
        if (nodeValues.Contains(node.val) == false)
        {
            Console.WriteLine(node.val);
            nodeValues.Add(node.val);
            
            List<int> NeighborValues = new List<int>();
            
            Console.Write("Neighbors: \n");
            for (int i = 0; i < node.neighbors.Count; i++)
            {
                NeighborValues.Add(node.neighbors[i].val);
                Console.WriteLine(node.neighbors[i].val);
            }
            Console.Write("\n");
            
            NodeNeighborValues.Add(NeighborValues);
        
            for (int i = 0; i < node.neighbors.Count; i++)
            {
                FindAllNodes(node.neighbors[i]);
            }
        }
        
    }
}
             