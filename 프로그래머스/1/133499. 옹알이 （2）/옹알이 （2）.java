class Solution {
    public int solution(String[] babbling) {
        int answer = 0;
        String[] words = {"aya", "ye", "woo", "ma"};
        for(int i = 0; i < babbling.length; i++)
        {
            if(isBabbling(babbling[i], words))
                answer++;
        }
        return answer;
    }
    public boolean isBabbling(String target, String[] words)
    {
        String overlap = "";
        for(int i = target.length(); i > 0; i--)
        {
            for(int j = 0; j < words.length; j++)
            {
                if(target.startsWith(words[j]))
                {
                    if(overlap == words[j])
                        return false;
                    
                    overlap = words[j];
                    target = target.substring(words[j].length());
                    
                    if(target.length() == 0)
                        return true;
                        
                    i -= words[j].length() - 1;
                    break;
                }
            }
        }
        return false;
    }
}