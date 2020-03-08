using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MatrixMathnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cmbbOpperation.SelectedIndex = 0;
        }

        private void _btnCalc_Click(object sender, EventArgs e)
        {
            IMatrix matrix = new MathnetMatrixSolver();
            Stopwatch stopwatch = new Stopwatch();
            string formulaA = _tbAformula.Text, formulaB = _tbBformula.Text;
            int columnA = Convert.ToInt32(_tbAcolumn.Text), rowA = Convert.ToInt32(_tbArow.Text);
            int columnB = Convert.ToInt32(_tbBcolumn.Text), rowB = Convert.ToInt32(_tbBrow.Text);
            bool sparse = _chbSparseA.Checked && _chbSparseB.Checked;
            int opp = _cmbbOpperation.SelectedIndex;

            Cursor.Current = Cursors.WaitCursor;
            stopwatch.Start();
            double[,] m = matrix.ParsedSolve(formulaA, formulaB, columnA, rowA, columnB, rowB, sparse, opp);
            stopwatch.Stop();
            _rtbDialog.Text = "Время вычисления: " + stopwatch.ElapsedMilliseconds.ToString() + "милисекунд\n";
            for (int i = 0; i < 5 && i < m.GetLength(0); i++)
            {
                for (int j = 0; j < 5 && j < m.GetLength(1); j++)
                {
                    _rtbDialog.Text += m[i, j] + "      ";
                }
                _rtbDialog.Text += "\n";
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
