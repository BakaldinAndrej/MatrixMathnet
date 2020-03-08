using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Symbolics;
using System.Diagnostics;

namespace MatrixMathnet
{
    public class MathnetMatrixSolver : IMatrix
    {
        public double[,] Multiply(double[,] a, double[,] b, bool sparse)
        {
            Matrix<double> aM, bM;
            if (!sparse)
            {
                aM = Matrix<double>.Build.DenseOfArray(a);
                bM = Matrix<double>.Build.DenseOfArray(b);
                return (aM * bM).ToArray();
            }
            aM = Matrix<double>.Build.SparseOfArray(a);
            bM = Matrix<double>.Build.SparseOfArray(b);
            return (aM*bM).ToArray();
        }

        public double[,] Transponse(double[,] a, bool sparse)
        {
            Matrix<double> aM;
            if (!sparse)
            {
                aM = Matrix<double>.Build.DenseOfArray(a).Transpose();
                return aM.ToArray();
            }
            aM = Matrix<double>.Build.SparseOfArray(a).Transpose();
            return aM.ToArray();
        }

        public double[,] ParsedSolve(string formulaA, string formulaB, int columnA, int rowA, int columnB, int rowB, bool sparse, int opperation)
        {
            SymbolicExpression parsedA = SymbolicExpression.Parse(formulaA);
            SymbolicExpression parsedB = SymbolicExpression.Parse(formulaB);
            if (parsedA != null && parsedB != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                Matrix<double> mA, mB;
                Func<double, double, double> funcA = parsedA.Compile("x", "y");
                Func<double, double, double> funcB = parsedB.Compile("x", "y");
                IMatrix matrix = new MathnetMatrixSolver();

                switch (opperation)
                {
                    case 0:
                        {
                            if (!sparse)
                            {
                                mA = Matrix<double>.Build.Dense(columnA, rowA, (i, j) => funcA(i, j));
                                mB = Matrix<double>.Build.Dense(columnB, rowB, (i, j) => funcB(i, j));
                                return (mA * mB).ToArray();
                            }
                            mA = Matrix<double>.Build.Sparse(columnA, rowA, (i, j) => funcA(i, j));
                            mB = Matrix<double>.Build.Sparse(columnB, rowB, (i, j) => funcB(i, j));
                            return (mA * mB).ToArray();
                        }
                    case 1:
                        {
                            if (!sparse)
                            {
                                mA = Matrix<double>.Build.Dense(columnA, rowA, (i, j) => funcA(i, j)).Transpose();
                                return mA.ToArray();
                            }
                            mA = Matrix<double>.Build.Sparse(columnA, rowA, (i, j) => funcA(i, j)).Transpose();
                            return mA.ToArray();
                        }
                }
            }
            double[,] err = { { 0.0 } };
            return err;
        }
    }
}
