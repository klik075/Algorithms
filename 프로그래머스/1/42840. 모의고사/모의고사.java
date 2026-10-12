import java.util.Arrays;
import java.util.stream.IntStream;

class Solution {
    public int[] solution(int[] answers) {
        int[] people = new int[3];
        for(int i = 0; i < answers.length; i++)
        {
            for(int j = 0; j < people.length; j++)
            {
                if(answers[i] == answerOfPerson(j, i))
                    people[j]++;
            }
        }
        
        int max = Arrays.stream(people).max().orElse(0);
        int[] indexes = IntStream.range(0, people.length)
            .filter(i -> people[i] == max)
            .map(i -> i + 1)
            .toArray();
        
        return indexes;
    }
    
    public int answerOfPerson(int personIdx, int idx)
    {
        switch(personIdx)
        {
            case 0:
                return idx % 5 + 1;
            case 1:
                int[] arr2 = {1, 3, 4, 5};
                return idx % 2 == 0 ? 2 : arr2[(idx / 2) % arr2.length];
            case 2:
                int[] arr3 = {3, 1, 2, 4, 5};
                return arr3[(idx / 2) % arr3.length];
            default:
                return 0;
        }
    }
}