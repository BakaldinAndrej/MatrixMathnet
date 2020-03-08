namespace MatrixMathnet
{
    public interface IMatrix
    {
        double[,] Multiply(double[,] a, double[,] b, bool sparse = false);
        double[,] Transponse(double[,] a, bool sparse = false);
        double[,] ParsedSolve(string formulaA, string formulaB, int columnA, int rowA, int columnB, int rowB, bool sparse, int opperation);
    }
}
