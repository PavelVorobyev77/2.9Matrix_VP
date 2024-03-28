using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._9Matrix_VP
{
    public partial class Form1 : Form
    {
        private int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        private int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transposedMatrix = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            return transposedMatrix;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFold_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromDataGridView(dataGridView1);
            int[,] matrix2 = GetMatrixFromDataGridView(dataGridView2);

            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                MessageBox.Show("Невозможно сложить/вычесть матрицы с разными размерами.");
                return;
            }

            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    // Выполняем сложение 
                    result[i, j] = matrix1[i, j] + matrix2[i, j]; // Сложение

                }
            }

            DisplayMatrixInDataGridView(result, dataGridView3);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromDataGridView(dataGridView1);
            int[,] matrix2 = GetMatrixFromDataGridView(dataGridView2);

            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                MessageBox.Show("Невозможно умножить матрицы с данными размерами.");
                return;
            }

            int[,] result = MultiplyMatrices(matrix1, matrix2);
            DisplayMatrixInDataGridView(result, dataGridView3);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromDataGridView(dataGridView1);
            int[,] matrix2 = GetMatrixFromDataGridView(dataGridView2);

            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                MessageBox.Show("Невозможно сложить/вычесть матрицы с разными размерами.");
                return;
            }

            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    // Выполняем вычитание
                    result[i, j] = matrix1[i, j] - matrix2[i, j]; // Вычитание
                }
            }

            DisplayMatrixInDataGridView(result, dataGridView3);
        }

        private void buttonTransposition_Click(object sender, EventArgs e)
        {
            if (radiobtn1.Checked == true)
            {
                int[,] matrix = GetMatrixFromDataGridView(dataGridView1);
                int[,] transposedMatrix = TransposeMatrix(matrix);
                DisplayMatrixInDataGridView(transposedMatrix, dataGridView3);
            }
            else
            {
                int[,] matrix = GetMatrixFromDataGridView(dataGridView2);
                int[,] transposedMatrix = TransposeMatrix(matrix);
                DisplayMatrixInDataGridView(transposedMatrix, dataGridView3);
            }
        }

        private void buttonMatrices1_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GenerateRandomMatrix(3, 3);
            DisplayMatrixInDataGridView(matrix1, dataGridView1);
        }

        private void buttonMatrices2_Click(object sender, EventArgs e)
        {
            int[,] matrix2 = GenerateRandomMatrix(3, 3);
            DisplayMatrixInDataGridView(matrix2, dataGridView2);
        }

        //генерация значений матриц.
        private int[,] GenerateRandomMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(1, 10); // Генерация случайного числа от 1 до 10
                }
            }

            return matrix;
        }

        //Отображение матриц в DataGridView 
        private void DisplayMatrixInDataGridView(int[,] matrix, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    dataGridView.Columns.Add("", "");
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = matrix[i, j] });
                    }
                    dataGridView.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int[,] GetMatrixFromDataGridView(DataGridView dataGridView)
        {
            int rows = dataGridView.Rows.Count;
            int cols = dataGridView.Columns.Count;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value);
                }
            }
            return matrix;
        }
    }
}

