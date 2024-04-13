namespace LR6
{
    partial class LagrangeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrintGraph = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.groupBoxInputMethod = new System.Windows.Forms.GroupBox();
            this.textBoxManInput = new System.Windows.Forms.TextBox();
            this.radioButtonFileInput = new System.Windows.Forms.RadioButton();
            this.radioButtonManInput = new System.Windows.Forms.RadioButton();
            this.labelErrorInputMethod = new System.Windows.Forms.Label();
            this.labelErrorManInput = new System.Windows.Forms.Label();
            this.buttonPrintData = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonExecInterp = new System.Windows.Forms.Button();
            this.groupBoxInputMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrintGraph
            // 
            this.buttonPrintGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintGraph.Location = new System.Drawing.Point(307, 158);
            this.buttonPrintGraph.Name = "buttonPrintGraph";
            this.buttonPrintGraph.Size = new System.Drawing.Size(130, 23);
            this.buttonPrintGraph.TabIndex = 0;
            this.buttonPrintGraph.Text = "Построение графика";
            this.buttonPrintGraph.UseVisualStyleBackColor = true;
            this.buttonPrintGraph.Click += new System.EventHandler(this.buttonPrintGraph_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInput.Location = new System.Drawing.Point(12, 100);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(130, 23);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "Ввод данных";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonClearData
            // 
            this.buttonClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearData.Location = new System.Drawing.Point(12, 158);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(130, 23);
            this.buttonClearData.TabIndex = 3;
            this.buttonClearData.Text = "Очистка данных";
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // groupBoxInputMethod
            // 
            this.groupBoxInputMethod.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxInputMethod.Controls.Add(this.textBoxManInput);
            this.groupBoxInputMethod.Controls.Add(this.radioButtonFileInput);
            this.groupBoxInputMethod.Controls.Add(this.radioButtonManInput);
            this.groupBoxInputMethod.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputMethod.Name = "groupBoxInputMethod";
            this.groupBoxInputMethod.Size = new System.Drawing.Size(177, 79);
            this.groupBoxInputMethod.TabIndex = 4;
            this.groupBoxInputMethod.TabStop = false;
            this.groupBoxInputMethod.Text = "Метод ввода";
            // 
            // textBoxManInput
            // 
            this.textBoxManInput.Location = new System.Drawing.Point(137, 20);
            this.textBoxManInput.Name = "textBoxManInput";
            this.textBoxManInput.Size = new System.Drawing.Size(33, 20);
            this.textBoxManInput.TabIndex = 2;
            this.textBoxManInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxManInput_KeyPress);
            // 
            // radioButtonFileInput
            // 
            this.radioButtonFileInput.AutoSize = true;
            this.radioButtonFileInput.Location = new System.Drawing.Point(7, 44);
            this.radioButtonFileInput.Name = "radioButtonFileInput";
            this.radioButtonFileInput.Size = new System.Drawing.Size(114, 17);
            this.radioButtonFileInput.TabIndex = 1;
            this.radioButtonFileInput.TabStop = true;
            this.radioButtonFileInput.Text = "Импорт из файла";
            this.radioButtonFileInput.UseVisualStyleBackColor = true;
            // 
            // radioButtonManInput
            // 
            this.radioButtonManInput.AutoSize = true;
            this.radioButtonManInput.Location = new System.Drawing.Point(7, 20);
            this.radioButtonManInput.Name = "radioButtonManInput";
            this.radioButtonManInput.Size = new System.Drawing.Size(87, 17);
            this.radioButtonManInput.TabIndex = 0;
            this.radioButtonManInput.TabStop = true;
            this.radioButtonManInput.Text = "Ручной ввод";
            this.radioButtonManInput.UseVisualStyleBackColor = true;
            // 
            // labelErrorInputMethod
            // 
            this.labelErrorInputMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorInputMethod.AutoSize = true;
            this.labelErrorInputMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorInputMethod.ForeColor = System.Drawing.Color.Red;
            this.labelErrorInputMethod.Location = new System.Drawing.Point(247, 36);
            this.labelErrorInputMethod.Name = "labelErrorInputMethod";
            this.labelErrorInputMethod.Size = new System.Drawing.Size(158, 16);
            this.labelErrorInputMethod.TabIndex = 5;
            this.labelErrorInputMethod.Text = "Выберите метод ввода";
            this.labelErrorInputMethod.Visible = false;
            // 
            // labelErrorManInput
            // 
            this.labelErrorManInput.AutoSize = true;
            this.labelErrorManInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorManInput.ForeColor = System.Drawing.Color.Red;
            this.labelErrorManInput.Location = new System.Drawing.Point(195, 36);
            this.labelErrorManInput.Name = "labelErrorManInput";
            this.labelErrorManInput.Size = new System.Drawing.Size(252, 32);
            this.labelErrorManInput.TabIndex = 6;
            this.labelErrorManInput.Text = "<--Введите верное количество узлов\r\n                              1 <= n <= 19";
            this.labelErrorManInput.Visible = false;
            // 
            // buttonPrintData
            // 
            this.buttonPrintData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintData.Location = new System.Drawing.Point(12, 129);
            this.buttonPrintData.Name = "buttonPrintData";
            this.buttonPrintData.Size = new System.Drawing.Size(130, 23);
            this.buttonPrintData.TabIndex = 7;
            this.buttonPrintData.Text = "Вывод данных";
            this.buttonPrintData.UseVisualStyleBackColor = true;
            this.buttonPrintData.Click += new System.EventHandler(this.buttonPrintData_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonExecInterp
            // 
            this.buttonExecInterp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecInterp.Location = new System.Drawing.Point(307, 129);
            this.buttonExecInterp.Name = "buttonExecInterp";
            this.buttonExecInterp.Size = new System.Drawing.Size(130, 23);
            this.buttonExecInterp.TabIndex = 8;
            this.buttonExecInterp.Text = "Найти значение в X*";
            this.buttonExecInterp.UseVisualStyleBackColor = true;
            this.buttonExecInterp.Click += new System.EventHandler(this.buttonExecInterp_Click);
            // 
            // LagrangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 191);
            this.Controls.Add(this.buttonExecInterp);
            this.Controls.Add(this.buttonPrintData);
            this.Controls.Add(this.labelErrorManInput);
            this.Controls.Add(this.labelErrorInputMethod);
            this.Controls.Add(this.groupBoxInputMethod);
            this.Controls.Add(this.buttonClearData);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.buttonPrintGraph);
            this.Name = "LagrangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерполяция Лагранжа";
            this.groupBoxInputMethod.ResumeLayout(false);
            this.groupBoxInputMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintGraph;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.GroupBox groupBoxInputMethod;
        private System.Windows.Forms.RadioButton radioButtonFileInput;
        private System.Windows.Forms.RadioButton radioButtonManInput;
        private System.Windows.Forms.TextBox textBoxManInput;
        private System.Windows.Forms.Label labelErrorInputMethod;
        private System.Windows.Forms.Label labelErrorManInput;
        private System.Windows.Forms.Button buttonPrintData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonExecInterp;
    }
}

