using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6
{
    public partial class InputForm : Form
    {
        private LagrangeForm parent;

        public InputForm(int nodes, LagrangeForm parentLink)
        {
            parent = parentLink;

            InitializeComponent();

            Label x = new Label();
            x.Text = "X: ";
            x.Location = new Point(5, 20);
            x.AutoSize = true;
            Controls.Add(x);

            Label y = new Label();
            y.Text = "Y: ";
            y.Location = new Point(5, 60);
            y.AutoSize = true;
            Controls.Add(y);

            Label xTarget = new Label();
            xTarget.Text = "X*: ";
            xTarget.Location = new Point(5, 100);
            xTarget.AutoSize = true;
            Controls.Add(xTarget);

            for (int i = 0; i < nodes; i++)
            {
                TextBox textBoxX = new TextBox();
                textBoxX.Size = new Size(50, 20);
                textBoxX.Location = new Point(30 + i * 60, 20);
                textBoxX.KeyPress += textBox_KeyPress;
                Controls.Add(textBoxX);

                TextBox textBoxY = new TextBox();
                textBoxY.Size = new Size(50, 20);
                textBoxY.Location = new Point(30 + i * 60, 60);
                textBoxY.KeyPress += textBox_KeyPress;
                Controls.Add(textBoxY);
            }

            TextBox textBoxXTarget = new TextBox();
            textBoxXTarget.Size = new Size(50, 20);
            textBoxXTarget.Location = new Point(30, 100);
            textBoxXTarget.KeyPress += textBox_KeyPress;
            Controls.Add(textBoxXTarget);

            Button buttonReadyInput = new Button();
            buttonReadyInput.Text = "ОК";
            buttonReadyInput.Location = new Point((nodes - 1) * 60 - 5, 120);
            buttonReadyInput.Click += buttonReadyInput_Click;
            Controls.Add(buttonReadyInput);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',' || textBox.Text.Contains(",") || textBox.SelectionStart == 0) &&
                (e.KeyChar != '-' || textBox.Text.Contains("-") || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void buttonReadyInput_Click(object sender, EventArgs e)
        {
            List<float> xValues = new List<float>();
            List<float> yValues = new List<float>();

            TextBox[] textBoxes = Controls.OfType<TextBox>().ToArray();

            for (int i = 0; i < textBoxes.Length; i += 2)
            {
                if (i + 1 < textBoxes.Length)
                {
                    if (float.TryParse(textBoxes[i].Text, out float xValue) && float.TryParse(textBoxes[i + 1].Text, out float yValue))
                    {
                        xValues.Add(xValue);
                        yValues.Add(yValue);
                    }
                    else
                    {
                        MessageBox.Show("Введены неверные данные XY", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (float.TryParse(textBoxes[textBoxes.Length - 1].Text, out float xTargetValue))
            {
                parent.XTarget = xTargetValue;
            }
            else
            {
                MessageBox.Show("Введены неверные данные X*", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < xValues.Count; i++)
            {
                (float, float) temp;
                temp.Item1 = xValues[i];
                temp.Item2 = yValues[i];
                parent.Data.Add(temp);
            }

            MessageBox.Show("Данные успешно введены", "Успешный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
