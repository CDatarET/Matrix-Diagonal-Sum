class Solution:
    def diagonalSum(self, mat):
        s = 0
        j = len(mat) - 1
        
        for i in range(len(mat)):
            s = s + mat[i][i]
            mat[i][i] = 0
            s = s + mat[i][j]
            j -= 1
        
        return s
