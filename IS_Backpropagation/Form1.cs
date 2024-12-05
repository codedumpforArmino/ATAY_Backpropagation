using Backprop;
using System.Windows.Forms;

namespace IS_Backpropagation
{
    public partial class Form1 : Form
    {
        NeuralNet myNeuralNets;
        int[,] DataTable =
        {
            {0, 0, 0, 0, 0 },
            {0, 0, 0, 1, 0 },
            {0, 0, 1, 0, 0 },
            {0, 0, 1, 1, 0 },
            {0, 1, 0, 0, 0 },
            {0, 1, 0, 1, 0 },
            {0, 1, 1, 0, 0 },
            {0, 1, 1, 1, 0 },
            {1, 0, 0, 0, 0 },
            {1, 0, 0, 1, 0 },
            {1, 0, 1, 0, 0 },
            {1, 0, 1, 1, 0 },
            {1, 1, 0, 0, 0 },
            {1, 1, 0, 1, 0 },
            {1, 1, 1, 0, 0 },
            {1, 1, 1, 1, 1 }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            /*
            for (int Ncount = 1; Ncount <= 100; Ncount++){
                myNeuralNets[Ncount] = new NeuralNet(4, Ncount, 1);
            }
            */
            myNeuralNets = new NeuralNet(4, 4, 1);
            MessageBox.Show("99 Neural Networks created!");
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            int isComplete = 0;
            int ORcase = 0;
            do
            {
                for(int DataCase = 0; DataCase < 16; DataCase++)
                {
                    myNeuralNets.setDesiredOutput(0, DataTable[DataCase, 4]);
                    myNeuralNets.setInputs(0, DataTable[DataCase, 0]);
                    myNeuralNets.setInputs(1, DataTable[DataCase, 1]);
                    myNeuralNets.setInputs(2, DataTable[DataCase, 2]);
                    myNeuralNets.setInputs(3, DataTable[DataCase, 3]);
                    myNeuralNets.learn();
                }

                isComplete++;
            } while (isComplete <= 100);
            MessageBox.Show("Training Complete");
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            NeuralNet currNet;
            MessageBox.Show("Testing...");
            txtbox_Output.Text = "" + myNeuralNets.getOuputData(0);

            //Test
            dataGrid_NNTest.Rows.Clear();
            for (int DataCase = 0; DataCase < 16; DataCase++)
            {
                myNeuralNets.setInputs(0, DataTable[DataCase, 0]);
                myNeuralNets.setInputs(1, DataTable[DataCase, 1]);
                myNeuralNets.setInputs(2, DataTable[DataCase, 2]);
                myNeuralNets.setInputs(3, DataTable[DataCase, 3]);
                myNeuralNets.run();
                dataGrid_NNTest.Rows.Add(1, DataTable[DataCase, 0], DataTable[DataCase, 1], DataTable[DataCase, 2], DataTable[DataCase, 3], myNeuralNets.getOuputData(0));
               
                //cell formtting
                if(DataCase == 15)
                {
                    var value = dataGrid_NNTest.Rows[15].Cells[5].Value;
                    float Threshold = float.Parse(value.ToString());

                    if(Threshold > 0.6) //Threshold to decide if output yes or no
                    {
                        dataGrid_NNTest.Rows[15].Cells[5].Style.BackColor = Color.LightBlue; //outputs yes with 4 1s, correct
                    }
                    else
                    {
                        dataGrid_NNTest.Rows[15].Cells[5].Style.BackColor = Color.LightSalmon; //outputs no with 4 1s, incorrect
                    }

                }
                else
                {
                    var value = dataGrid_NNTest.Rows[DataCase].Cells[5].Value;
                    float Threshold = float.Parse(value.ToString());

                    if (Threshold > 0.6) //Threshold to decide if output yes or no
                    {
                        dataGrid_NNTest.Rows[DataCase].Cells[5].Style.BackColor = Color.LightSalmon; //outputs yes with 4 1s , incorrect
                    }
                    else
                    {
                        dataGrid_NNTest.Rows[DataCase].Cells[5].Style.BackColor = Color.LightBlue; //outputs no with 4 1s , correct
                    }
                }
            }
            
        }
    }
}
