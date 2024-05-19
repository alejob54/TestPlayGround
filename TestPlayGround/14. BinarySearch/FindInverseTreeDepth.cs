namespace TestPlayGround;

public class FindInverseTreeDepth
{    
    public int GetDepth(string preorderSequence)
    {
        int maxDepth = 0;
        int currentDepth = 0;
        int index = 0;
        
        // Helper function to traverse the tree
        void Traverse()
        {
            if (index >= preorderSequence.Length)
                return;
            
            if (preorderSequence[index] == 'X')
            {
                currentDepth++;
                if (currentDepth > maxDepth)
                {
                    maxDepth = currentDepth;
                }
                
                index++;
                Traverse(); // Traverse left subtree
                
                index++;
                Traverse(); // Traverse right subtree
                
                currentDepth--; // Go back up after both subtrees are traversed
            }
            else if (preorderSequence[index] == 'Y')
            {
                index++;
            }
        }
        
        Traverse();
        return maxDepth;
        
    }
}
