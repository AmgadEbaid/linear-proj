using Accord.Math;

namespace linear_equation_gui
{
    public partial class Form1 : Form
    {
        public static decimal[,] matrixOf(DataGridView grid1)
        {
            decimal[,] mat = new decimal[grid1.RowCount,grid1.ColumnCount];
            for (int i = 0; i < grid1.RowCount; i++)
            {
                for (int x = 0; x < grid1.ColumnCount; x++)
                {
                    mat[i,x]= Convert.ToDecimal(grid1.Rows[i].Cells[x].Value);
                    
                }
            }
            return mat;
        }
        public static double[,] getMatrix_double(DataGridView grid1)
        {
            double[,] mat = new double[grid1.RowCount, grid1.ColumnCount];
            for (int i = 0; i < grid1.RowCount; i++)
            {
                for (int x = 0; x < grid1.ColumnCount; x++)
                {
                    mat[i, x] = Convert.ToDouble(grid1.Rows[i].Cells[x].Value);

                }
            }
            return mat;
        }
        public static void print(decimal[,] matrix,RichTextBox rus)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    string an = matrix[i, x].ToString();
                    rus.AppendText(an);
                    rus.AppendText("\n ");
                }
                

            }
        }
        public static void __demo__(DataGridView mat,DataGridView vec,RichTextBox solveAt)
        {
            mat.RowCount = 3;
            mat.ColumnCount = 3;
            vec.RowCount = 3;
            
            
            mat.Rows[0].Cells[0].Value = 33;
            mat.Rows[1].Cells[0].Value = 2;
            mat.Rows[2].Cells[0].Value = 4;

            mat.Rows[0].Cells[1].Value = 1;
            mat.Rows[1].Cells[1].Value = -3;
            mat.Rows[2].Cells[1].Value = -5;

            mat.Rows[0].Cells[2].Value = 1;
            mat.Rows[1].Cells[2].Value = -1;
            mat.Rows[2].Cells[2].Value = -1;


            vec.Rows[0].Cells[0].Value = 3;
            vec.Rows[1].Cells[0].Value = 2;
            vec.Rows[2].Cells[0].Value = 1;

            solveMAt(mat, vec, solveAt);
           
        }

        public static void solveMAt(DataGridView matrix , DataGridView rightside,RichTextBox solveAt)
        {
            decimal[,] _matrix = matrixOf(matrix);

            decimal[,] _rightSide = matrixOf(rightside);
            bool isSingular = Matrix.IsSingular(getMatrix_double(matrix));


            if (isSingular)
            {
                solveAt.AppendText(isSingular.ToString());
            }
            else
            {
                Decimal[,] x = Matrix.Solve(_matrix, _rightSide, leastSquares: isSingular);

                print(x, solveAt);

            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount= Convert.ToInt16(rowCount.Value);
            dataGridView1.ColumnCount= Convert.ToInt16( colCount.Value);
            dataGridView2.RowCount = Convert.ToInt16(rowCount.Value);


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Decimal.ToInt32(rowCount.Value);
            int col = Decimal.ToInt32(colCount.Value);
            int[,] mat = new int[row,col];
            int[,] vec = new int[row, col];
            



        }

        private void solve_Click(object sender, EventArgs e)
        {
            solveMAt(dataGridView1, dataGridView2, richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            __demo__(dataGridView1,dataGridView2,richTextBox1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }

  
}