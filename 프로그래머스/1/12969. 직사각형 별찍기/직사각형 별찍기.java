import java.util.Scanner;

class Solution {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int column = sc.nextInt();
        int row = sc.nextInt();
        
        for(int rowIndex = 0; rowIndex < row; rowIndex++)
        {
            for(int columnIndex = 0; columnIndex < column; columnIndex++)
            {
                System.out.print("*");
            }
            
            System.out.println();
        }
    }
}