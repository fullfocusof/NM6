using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LR6
{
    public partial class LagrangeForm : Form
    {
        private int nodes;
        private List<(float, float)> data;
        float xTarget, yTarget;

        public List<(float, float)> Data
        {
            get => data;
            set => data = value;
        }

        public int Nodes
        {
            get => nodes;
            set => nodes = value;
        }

        public float XTarget
        {
            get => xTarget;
            set => xTarget = value;
        }

        public float YTarget 
        { 
            get => yTarget; 
            set => yTarget = value; 
        }

        public LagrangeForm()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            groupBoxInputMethod.ForeColor = Color.Black;
            labelErrorInputMethod.Visible = false;
            labelErrorManInput.Visible = false;

            if (!radioButtonFileInput.Checked && !radioButtonManInput.Checked)
            {
                groupBoxInputMethod.ForeColor = Color.Red;
                labelErrorInputMethod.Visible = true;
            }
            else if (radioButtonManInput.Checked && (textBoxManInput.Text == string.Empty || int.Parse(textBoxManInput.Text) < 1 || int.Parse(textBoxManInput.Text) > 19))
            {
                groupBoxInputMethod.ForeColor = Color.Red;
                labelErrorManInput.Visible = true;
            }
            else if (radioButtonManInput.Checked)
            {
                Nodes = int.Parse(textBoxManInput.Text);
                Data = new List<(float, float)>(Nodes);
                InputForm temp = new InputForm(Nodes, this);
                temp.ShowDialog();
            }
            else if (radioButtonFileInput.Checked)
            {
                openFileDialog.Filter = "TXT files|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        string[] lines = File.ReadAllLines(filePath);

                        Nodes = int.Parse(lines[0]);

                        if (lines.Length > 0)
                        {
                            Data = new List<(float, float)>(Nodes);
                            for (int i = 1; i < Nodes + 1 && i < lines.Length; i++)
                            {
                                string[] values = lines[i].Split(' ');

                                if (values.Length == 2 && float.TryParse(values[0], out float x) && float.TryParse(values[1], out float y))
                                {
                                    Data.Add((x, y));
                                }
                            }

                            if (lines.Length > Nodes + 1 && float.TryParse(lines[Nodes + 1], out xTarget))
                            {
                                MessageBox.Show("Данные успешно введены", "Успешный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при считывании xTarget");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при считывании количества узлов");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
                    }

                }
            }
        }
    

        private void textBoxManInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            if (Data == null || Data.Count == 0)
            {
                MessageBox.Show("Данные отсутствуют", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Data.Clear();
                MessageBox.Show("Данные успешно удалены", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrintData_Click(object sender, EventArgs e)
        {
            if (Data == null || Data.Count == 0)
            {
                MessageBox.Show("Данные отсутствуют", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string temp = "X: ";
                foreach (var item in Data)
                {
                    temp += item.Item1.ToString() + "; ";
                }
                temp += "\nY: ";
                foreach (var item in Data)
                {
                    temp += item.Item2.ToString() + "; ";
                }
                temp += "\nX* = " + xTarget.ToString();

                MessageBox.Show(temp, "Данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonExecInterp_Click(object sender, EventArgs e)
        {
            if (Data == null || Data.Count == 0)
            {
                MessageBox.Show("Данные отсутствуют", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float result = 0;
                for (int i = 0; i < Data.Count; i++)
                {
                    float tempY = Data[i].Item2;
                    float numerator = 1;
                    float denominator = 1;
                    for (int j = 0; j < Data.Count; j++)
                    {  
                        if (j != i)
                        {
                            numerator *= (xTarget - Data[j].Item1);
                            denominator *= (Data[i].Item1 - Data[j].Item1);
                        }
                    }
                    result += tempY * numerator / denominator;
                }
                YTarget = result;

                MessageBox.Show("Значение функции в точке " + xTarget.ToString() + " = " + result.ToString(), "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrintGraph_Click(object sender, EventArgs e)
        {
            if (Data == null || Data.Count == 0)
            {
                MessageBox.Show("Данные отсутствуют", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GraphForm temp = new GraphForm(Nodes, this);
                temp.ShowDialog();
            }
        }
    }
}