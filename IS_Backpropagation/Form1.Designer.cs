namespace IS_Backpropagation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtbox_Input1 = new TextBox();
            txtbox_Output = new TextBox();
            txtbox_Input2 = new TextBox();
            btn_init = new Button();
            btn_Train = new Button();
            btn_Test = new Button();
            dataGrid_NNList = new DataGridView();
            NeuralNetwork_num = new DataGridViewTextBoxColumn();
            Hidden_Neural = new DataGridViewTextBoxColumn();
            Train_count = new DataGridViewTextBoxColumn();
            Overall_accuracy = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGrid_NNTest = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Input = new DataGridViewTextBoxColumn();
            Input2 = new DataGridViewTextBoxColumn();
            Input3 = new DataGridViewTextBoxColumn();
            Input4 = new DataGridViewTextBoxColumn();
            Output = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNTest).BeginInit();
            SuspendLayout();
            // 
            // txtbox_Input1
            // 
            txtbox_Input1.Font = new Font("Segoe UI", 12F);
            txtbox_Input1.Location = new Point(93, 44);
            txtbox_Input1.Name = "txtbox_Input1";
            txtbox_Input1.Size = new Size(150, 39);
            txtbox_Input1.TabIndex = 0;
            // 
            // txtbox_Output
            // 
            txtbox_Output.Font = new Font("Segoe UI", 12F);
            txtbox_Output.Location = new Point(318, 156);
            txtbox_Output.Name = "txtbox_Output";
            txtbox_Output.Size = new Size(150, 39);
            txtbox_Output.TabIndex = 1;
            // 
            // txtbox_Input2
            // 
            txtbox_Input2.Font = new Font("Segoe UI", 12F);
            txtbox_Input2.Location = new Point(93, 116);
            txtbox_Input2.Name = "txtbox_Input2";
            txtbox_Input2.Size = new Size(150, 39);
            txtbox_Input2.TabIndex = 2;
            // 
            // btn_init
            // 
            btn_init.Location = new Point(112, 313);
            btn_init.Name = "btn_init";
            btn_init.Size = new Size(138, 63);
            btn_init.TabIndex = 3;
            btn_init.Text = "Create Network";
            btn_init.UseVisualStyleBackColor = true;
            btn_init.Click += btn_init_Click;
            // 
            // btn_Train
            // 
            btn_Train.Location = new Point(318, 313);
            btn_Train.Name = "btn_Train";
            btn_Train.Size = new Size(138, 63);
            btn_Train.TabIndex = 4;
            btn_Train.Text = "Train Network";
            btn_Train.UseVisualStyleBackColor = true;
            btn_Train.Click += btn_Train_Click;
            // 
            // btn_Test
            // 
            btn_Test.Location = new Point(526, 313);
            btn_Test.Name = "btn_Test";
            btn_Test.Size = new Size(138, 63);
            btn_Test.TabIndex = 5;
            btn_Test.Text = "Test";
            btn_Test.UseVisualStyleBackColor = true;
            btn_Test.Click += btn_Test_Click;
            // 
            // dataGrid_NNList
            // 
            dataGrid_NNList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_NNList.Columns.AddRange(new DataGridViewColumn[] { NeuralNetwork_num, Hidden_Neural, Train_count, Overall_accuracy });
            dataGrid_NNList.Location = new Point(704, 89);
            dataGrid_NNList.Name = "dataGrid_NNList";
            dataGrid_NNList.RowHeadersWidth = 62;
            dataGrid_NNList.Size = new Size(475, 959);
            dataGrid_NNList.TabIndex = 6;
            // 
            // NeuralNetwork_num
            // 
            NeuralNetwork_num.HeaderText = "NN #";
            NeuralNetwork_num.MinimumWidth = 8;
            NeuralNetwork_num.Name = "NeuralNetwork_num";
            NeuralNetwork_num.Width = 64;
            // 
            // Hidden_Neural
            // 
            Hidden_Neural.HeaderText = "HNeural";
            Hidden_Neural.MinimumWidth = 8;
            Hidden_Neural.Name = "Hidden_Neural";
            Hidden_Neural.ToolTipText = "Number of Hidden Neurons";
            Hidden_Neural.Width = 96;
            // 
            // Train_count
            // 
            Train_count.HeaderText = "Train Count";
            Train_count.MinimumWidth = 8;
            Train_count.Name = "Train_count";
            Train_count.ToolTipText = "Number of Trainings Completed";
            Train_count.Width = 96;
            // 
            // Overall_accuracy
            // 
            Overall_accuracy.HeaderText = "Accuracy";
            Overall_accuracy.MinimumWidth = 8;
            Overall_accuracy.Name = "Overall_accuracy";
            Overall_accuracy.Width = 150;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(93, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(93, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 39);
            textBox2.TabIndex = 8;
            // 
            // dataGrid_NNTest
            // 
            dataGrid_NNTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid_NNTest.ColumnHeadersHeight = 34;
            dataGrid_NNTest.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Input, Input2, Input3, Input4, Output });
            dataGrid_NNTest.Location = new Point(41, 452);
            dataGrid_NNTest.Name = "dataGrid_NNTest";
            dataGrid_NNTest.RowHeadersWidth = 62;
            dataGrid_NNTest.Size = new Size(614, 596);
            dataGrid_NNTest.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "NN #";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 90;
            // 
            // Input
            // 
            Input.HeaderText = "Input";
            Input.MinimumWidth = 8;
            Input.Name = "Input";
            Input.Width = 90;
            // 
            // Input2
            // 
            Input2.HeaderText = "Input";
            Input2.MinimumWidth = 8;
            Input2.Name = "Input2";
            Input2.Width = 90;
            // 
            // Input3
            // 
            Input3.HeaderText = "Input";
            Input3.MinimumWidth = 8;
            Input3.Name = "Input3";
            Input3.Width = 90;
            // 
            // Input4
            // 
            Input4.HeaderText = "Input";
            Input4.MinimumWidth = 8;
            Input4.Name = "Input4";
            Input4.Width = 90;
            // 
            // Output
            // 
            Output.HeaderText = "Output";
            Output.MinimumWidth = 8;
            Output.Name = "Output";
            Output.Width = 105;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 1060);
            Controls.Add(dataGrid_NNTest);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGrid_NNList);
            Controls.Add(btn_Test);
            Controls.Add(btn_Train);
            Controls.Add(btn_init);
            Controls.Add(txtbox_Input2);
            Controls.Add(txtbox_Output);
            Controls.Add(txtbox_Input1);
            Name = "Form1";
            Text = "Battle Royale: Neural Networks";
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_Input1;
        private TextBox txtbox_Output;
        private TextBox txtbox_Input2;
        private Button btn_init;
        private Button btn_Train;
        private Button btn_Test;
        private DataGridView dataGrid_NNList;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn NeuralNetwork_num;
        private DataGridViewTextBoxColumn Hidden_Neural;
        private DataGridViewTextBoxColumn Train_count;
        private DataGridViewTextBoxColumn Overall_accuracy;
        private DataGridView dataGrid_NNTest;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Input;
        private DataGridViewTextBoxColumn Input2;
        private DataGridViewTextBoxColumn Input3;
        private DataGridViewTextBoxColumn Input4;
        private DataGridViewTextBoxColumn Output;
    }
}
