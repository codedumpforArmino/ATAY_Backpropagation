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
            btn_init = new Button();
            btn_Train = new Button();
            btn_Test = new Button();
            dataGrid_NNList = new DataGridView();
            NeuralNetwork_num = new DataGridViewTextBoxColumn();
            Hidden_Neural = new DataGridViewTextBoxColumn();
            Train_count = new DataGridViewTextBoxColumn();
            Overall_accuracy = new DataGridViewTextBoxColumn();
            txtBox_IndexInput = new TextBox();
            dataGrid_NNTest = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Input = new DataGridViewTextBoxColumn();
            Input2 = new DataGridViewTextBoxColumn();
            Input3 = new DataGridViewTextBoxColumn();
            Input4 = new DataGridViewTextBoxColumn();
            Output = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_List = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNTest).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_init
            // 
            btn_init.Location = new Point(41, 12);
            btn_init.Name = "btn_init";
            btn_init.Size = new Size(138, 63);
            btn_init.TabIndex = 3;
            btn_init.Text = "Create Networks";
            btn_init.UseVisualStyleBackColor = true;
            btn_init.Click += btn_init_Click;
            // 
            // btn_Train
            // 
            btn_Train.Location = new Point(216, 12);
            btn_Train.Name = "btn_Train";
            btn_Train.Size = new Size(138, 63);
            btn_Train.TabIndex = 4;
            btn_Train.Text = "Train all Networks";
            btn_Train.UseVisualStyleBackColor = true;
            btn_Train.Click += btn_Train_Click;
            // 
            // btn_Test
            // 
            btn_Test.Location = new Point(3, 77);
            btn_Test.Name = "btn_Test";
            btn_Test.Size = new Size(94, 50);
            btn_Test.TabIndex = 5;
            btn_Test.Text = "Test";
            btn_Test.UseVisualStyleBackColor = true;
            btn_Test.Click += btn_Test_Click;
            // 
            // dataGrid_NNList
            // 
            dataGrid_NNList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_NNList.Columns.AddRange(new DataGridViewColumn[] { NeuralNetwork_num, Hidden_Neural, Train_count, Overall_accuracy });
            dataGrid_NNList.Location = new Point(704, 59);
            dataGrid_NNList.Name = "dataGrid_NNList";
            dataGrid_NNList.RowHeadersWidth = 62;
            dataGrid_NNList.Size = new Size(475, 989);
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
            Overall_accuracy.ToolTipText = "Number of Data sets it was able to correctly output";
            Overall_accuracy.Width = 150;
            // 
            // txtBox_IndexInput
            // 
            txtBox_IndexInput.Font = new Font("Segoe UI", 12F);
            txtBox_IndexInput.Location = new Point(3, 30);
            txtBox_IndexInput.Name = "txtBox_IndexInput";
            txtBox_IndexInput.Size = new Size(150, 39);
            txtBox_IndexInput.TabIndex = 8;
            // 
            // dataGrid_NNTest
            // 
            dataGrid_NNTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid_NNTest.ColumnHeadersHeight = 34;
            dataGrid_NNTest.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Input, Input2, Input3, Input4, Output });
            dataGrid_NNTest.Location = new Point(41, 227);
            dataGrid_NNTest.Name = "dataGrid_NNTest";
            dataGrid_NNTest.RowHeadersWidth = 62;
            dataGrid_NNTest.Size = new Size(614, 821);
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
            Output.ToolTipText = "Cells marked with Blue means the network has correct outputs";
            Output.Width = 105;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 10;
            label1.Text = "Test Node #";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_Test, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBox_IndexInput, 0, 1);
            tableLayoutPanel1.Location = new Point(373, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.48649F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.51351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Size = new Size(157, 150);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lbl_List
            // 
            lbl_List.AutoSize = true;
            lbl_List.Location = new Point(833, 31);
            lbl_List.Name = "lbl_List";
            lbl_List.Size = new Size(218, 25);
            lbl_List.TabIndex = 12;
            lbl_List.Text = "List of all Neural Networks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 199);
            label2.Name = "label2";
            label2.Size = new Size(239, 25);
            label2.TabIndex = 13;
            label2.Text = "Singular Neural Network Test";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 1060);
            Controls.Add(label2);
            Controls.Add(lbl_List);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGrid_NNTest);
            Controls.Add(dataGrid_NNList);
            Controls.Add(btn_Train);
            Controls.Add(btn_init);
            Name = "Form1";
            Text = "Battle Royale: Neural Networks";
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_NNTest).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_init;
        private Button btn_Train;
        private Button btn_Test;
        private DataGridView dataGrid_NNList;
        private TextBox txtBox_IndexInput;
        private DataGridView dataGrid_NNTest;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn NeuralNetwork_num;
        private DataGridViewTextBoxColumn Hidden_Neural;
        private DataGridViewTextBoxColumn Train_count;
        private DataGridViewTextBoxColumn Overall_accuracy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Input;
        private DataGridViewTextBoxColumn Input2;
        private DataGridViewTextBoxColumn Input3;
        private DataGridViewTextBoxColumn Input4;
        private DataGridViewTextBoxColumn Output;
        private Label lbl_List;
        private Label label2;
    }
}
