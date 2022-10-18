public class Trie {

    public List<string> Tree;
    
    public Trie() {
        Tree = new List<string>();
    }
    
    public void Insert(string word) {
        Tree.Add(word);
    }
    
    public bool Search(string word) {
        
        return Tree.Contains(word);
    }
    
    public bool StartsWith(string prefix) {
        
        bool check = false;
        
        for (int i = 0; i < Tree.Count; i++)
        {
            
            if (Tree[i].Contains(prefix) == true)
            {
                if (Tree[i][0..prefix.Length] == prefix)
                {
                    check = true;
                    break;
                }
            }
        }
        
        return check;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */