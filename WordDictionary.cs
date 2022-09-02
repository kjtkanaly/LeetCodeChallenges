public class WordDictionary {
    
    public List<string> Tree;

    public WordDictionary() {
        Tree = new List<string>();
    }
    
    public void AddWord(string word) {
        Tree.Add(word);
    }
    
    public bool Search(string word) {
        
        if (word.Contains('.') == false)
        {
            for (int i = 0; i < Tree.Count; i++)
            {
                if (Tree[i] == word)
                {
                    return true;
                }
            }
        }
        else
        {
            for (int i = 0; i < Tree.Count; i++)
            {
                if (Tree[i].Length == word.Length)
                {
                    //Console.WriteLine(Tree[i] + " " + word);
                    int j = 0;
                    while(j < word.Length)
                    {
                        if (Tree[i][j] == word[j] || word[j] == '.')
                        {
                            j++;    
                        }   
                        else
                        {
                            break;
                        }
                    }
                    
                    if (j == word.Length)
                    {
                        return true;
                    }
                }
            }
        }
        
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */