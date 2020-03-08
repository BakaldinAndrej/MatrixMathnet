using NUnit.Framework;

namespace MatrixMathnet
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTransponse()
        {
            IMatrix matrix = new MathnetMatrixSolver();
            string formulaA = "x*2", formulaB = "y*3";
            int columnA = 100, rowA = 100;
            int columnB = 100, rowB = 100;
            bool sparse = false;
            int opp = 1;
            bool testComplete = true;

            double[,] m = matrix.ParsedSolve(formulaA, formulaB, columnA, rowA, columnB, rowB, sparse, opp);

            for (int i = 0; i < columnA; i++)
                for (int j = 0; j < rowA; j++)
                    if (m[i, j] != j*2) testComplete = false;
            Assert.True(testComplete);
        }

        [Test]
        public void TestMultiply()
        {
            IMatrix matrix = new MathnetMatrixSolver();
            string formulaA = "y*2", formulaB = "x*3";
            int columnA = 2, rowA = 3;
            int columnB = 3, rowB = 2;
            bool sparse = false;
            int opp = 0;
            bool testComplete = true;

            double[,] m = matrix.ParsedSolve(formulaA, formulaB, columnA, rowA, columnB, rowB, sparse, opp);

            for (int i = 0; i < columnA; i++)
                for (int j = 0; j < rowB; j++)
                    if (m[i, j] != 30) testComplete = false;
            Assert.True(testComplete);
        }

        [Test]
        public void TestLargeMultiply()
        {
            IMatrix matrix = new MathnetMatrixSolver();
            string formulaA = "1", formulaB = "x+y";
            int columnA = 100, rowA = 100;
            int columnB = 100, rowB = 100;
            bool sparse = false;
            int opp = 0;
            bool testComplete = true;

            double[,] m = matrix.ParsedSolve(formulaA, formulaB, columnA, rowA, columnB, rowB, sparse, opp);

            for (int i = 0; i < columnA; i++)
                for (int j = 0; j < rowB; j++)
                    if (m[i, j] != 4950 + j*100) testComplete = false;
            Assert.True(testComplete);
        }
    }
}