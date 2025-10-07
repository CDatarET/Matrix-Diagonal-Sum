public class Solution {
    public int DiagonalSum(int[][] mat) {
        int s = 0;
        int j = mat.Length - 1;
        for(int i = 0; i < mat.Length; i++){
            s = s + mat[i][i];
            mat[i][i] = 0;
            s = s + mat[i][j];
            j--;
        }

        return(s);
    }
}
