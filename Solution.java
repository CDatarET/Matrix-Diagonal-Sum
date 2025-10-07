class Solution {
    public int diagonalSum(int[][] mat) {
        int s = 0;
        int j = mat.length - 1;
        for(int i = 0; i < mat.length; i++){
            s = s + mat[i][i];
            mat[i][i] = 0;
            s = s + mat[i][j];
            j--;
        }

        return(s);
    }
}
