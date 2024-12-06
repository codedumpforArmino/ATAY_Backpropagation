using Backprop;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_Backpropagation
{
    public partial class Form1 : Form
    {
        Boolean isInit = false;
        NeuralNet[] myNeuralNets = new NeuralNet[100];
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
            for (int Ncount = 0; Ncount <= 99; Ncount++){
                myNeuralNets[Ncount] = new NeuralNet(4, Ncount+1, 1);
                dataGrid_NNList.Rows.Add(Ncount + 1, Ncount + 1, 0, "0/16");
            }
            //myNeuralNets = new NeuralNet(4, 4, 1);
            isInit = true;
            MessageBox.Show("99 Neural Networks created!");
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            if (!isInit) {
                MessageBox.Show("Create the Network first!");
                return;
            }

            dataGrid_NNList.Rows.Clear();

            int TrainCount;
            int SuccessCount;
            Boolean isFit;
            for (int Ncount = 0; Ncount <= 99; Ncount++)
            {
                isFit = false;
                TrainCount = 0;
                do
                {
                    SuccessCount = 0;

                    //train current Network
                    for (int DataCase = 0; DataCase < 16; DataCase++)
                    {
                        myNeuralNets[Ncount].setDesiredOutput(0, DataTable[DataCase, 4]);
                        myNeuralNets[Ncount].setInputs(0, DataTable[DataCase, 0]);
                        myNeuralNets[Ncount].setInputs(1, DataTable[DataCase, 1]);
                        myNeuralNets[Ncount].setInputs(2, DataTable[DataCase, 2]);
                        myNeuralNets[Ncount].setInputs(3, DataTable[DataCase, 3]);
                        myNeuralNets[Ncount].learn();
                    }
                    TrainCount++;

                    //test to check if they pass or not
                    for (int DataCase = 0; DataCase < 16; DataCase++)
                    {
                        myNeuralNets[Ncount].setInputs(0, DataTable[DataCase, 0]);
                        myNeuralNets[Ncount].setInputs(1, DataTable[DataCase, 1]);
                        myNeuralNets[Ncount].setInputs(2, DataTable[DataCase, 2]);
                        myNeuralNets[Ncount].setInputs(3, DataTable[DataCase, 3]);
                        myNeuralNets[Ncount].run();

                        if (DataCase == 15)
                        {
                            if (myNeuralNets[Ncount].getOuputData(0) > 0.6) //Threshold to decide if output yes or no
                            {
                                SuccessCount++;
                                
                            }

                        }
                        else
                        {
                            if (myNeuralNets[Ncount].getOuputData(0) < 0.6) //Threshold to decide if output yes or no
                            {
                                SuccessCount++; //outputs yes with 4 1s , incorrect
                            }
                        }
                    }

                    //output
                    if(SuccessCount == 16)
                    {
                        dataGrid_NNList.Rows.Add(Ncount+1, Ncount+1, TrainCount, SuccessCount + "/16");
                        isFit = true;
                    }
                } while (!isFit);

                
            }
            MessageBox.Show("Training Complete");
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            //Null Check
            if (string.IsNullOrWhiteSpace(txtBox_IndexInput.Text) || !int.TryParse(txtBox_IndexInput.Text, out _))
            {
                MessageBox.Show("Cannot get Network at that address");
                return;
            }
            if (!isInit)
            {
                MessageBox.Show("Create the Network first!");
                return;
            }

            int Net_Index = Convert.ToInt32(txtBox_IndexInput.Text);
            NeuralNet currNet = myNeuralNets[Net_Index-1];
            MessageBox.Show("Testing Neural Network #"+Net_Index);

            //Test
            dataGrid_NNTest.Rows.Clear();
            for (int DataCase = 0; DataCase < 16; DataCase++)
            {
                currNet.setInputs(0, DataTable[DataCase, 0]);
                currNet.setInputs(1, DataTable[DataCase, 1]);
                currNet.setInputs(2, DataTable[DataCase, 2]);
                currNet.setInputs(3, DataTable[DataCase, 3]);
                currNet.run();
                dataGrid_NNTest.Rows.Add(Net_Index, DataTable[DataCase, 0], DataTable[DataCase, 1], DataTable[DataCase, 2], DataTable[DataCase, 3], currNet.getOuputData(0));
               
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
