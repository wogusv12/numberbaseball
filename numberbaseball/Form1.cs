using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberbaseball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(new String[] { textBox1.Text, textBox2.Text, textBox3.Text });
            listView1.Items.Add(newitem);

            check(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        public void check(String num, int strike, int ball)
        {
            String[] var;
            if (listView2.Items.Count >= 1)
            {
                var = new String[listView2.Items.Count];
                for (int i = 0; i < var.Length; i++)
                {
                    var[i] = listView2.Items[i].Text;
                }
                listView2.Items.Clear();
            } else
            {
                var = new String[876];

                for (int i = 0; i < 876; i++)
                {
                    var[i] = Convert.ToString(i + 123);
                }

            }
            MessageBox.Show("strike = " + strike + " ball = " + ball);

            char[] char_num = num.ToArray();
            if(strike != 0 || ball != 0)
            {
                
                if(strike ==0)
                {
                    if (ball == 1) {
                        for(int i = 0; i<var.Length; i++)
                        {
                            char[] var_array = var[i].ToArray();
                            //1번째자리에 a x 2번째자리에 b x 세번째자리에 c X
                            if (char_num[0] != var_array[0] && char_num[1] != var_array[1] && char_num[2] != var_array[2])
                            {
                                //2번째 3번째 자리에 a 일때
                                if(char_num[0]== var_array[1] || char_num[0] == var_array[2])
                                {
                                    //b가 1번째,3번째값이 아니고 c가 1,2번째가 아닐때
                                    if(char_num[1] !=var_array[0] && char_num[1] != var_array[2] && char_num[2] != var_array[0] && char_num[2] != var_array[1])
                                    {
                                        listView2.Items.Add(var[i]);
                                    }

                                }else if(char_num[1] == var_array[0] || char_num[1] == var_array[2]) //1, 3번째자리에 b일때
                                {    // a가 2,3번째가 아니고 c가 1,2번째가 아닐때
                                    if (char_num[0] != var_array[1] && char_num[0] != var_array[2] && char_num[2] != var_array[0] && char_num[2] != var_array[1])
                                    {
                                        listView2.Items.Add(var[i]);
                                    }
                                }else if(char_num[2] == var_array[0] || char_num[2] == var_array[1])
                                {
                                    if (char_num[0] != var_array[1] && char_num[0] != var_array[2] && char_num[1] != var_array[0] && char_num[1] != var_array[2])
                                    {
                                        listView2.Items.Add(var[i]);
                                    }
                                }
                            }

                        }
                    }
                    else if (ball == 2) {
                        for (int i =0; i< var.Length; i++)
                        {
                            char[] var_array = var[i].ToArray();
                            //1번째자리에 a x 2번째자리에 b x 세번째자리에 c X
                            if (char_num[0] != var_array[0] && char_num[1] != var_array[1] && char_num[2] != var_array[2])
                            {
                                //a가 2번째 자리일때
                                if(char_num[0] == var_array[1])
                                {
                                    //b가 1번째 자리일때
                                    if (char_num[1] == var_array[0])
                                    {
                                        if(char_num[2] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                        //b가 3번째 자리일때
                                    }else if(char_num[1] == var_array[2])
                                    {
                                        if(char_num[2] != var_array[0])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                        //c 가 첫번째 자리였을때
                                    }else if(char_num[2] == var_array[0])
                                    {
                                        if(char_num[1] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }

                                    }
                                    
                                } // a가 3번째 자리일때
                                else if(char_num[0] == var_array[2])
                                {
                                    //b가 1번째 자리일때
                                    if (char_num[1] == var_array[0])
                                    {
                                        if (char_num[2] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                      
                                    }

                                    //c가 1번째 자리일때
                                    else if (char_num[2] == var_array[0])
                                    {
                                        if (char_num[1] != var_array[1])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                     
                                    }

                                    //c가 2번째 자리일때
                                    else if (char_num[2] == var_array[1])
                                    {
                                        if (char_num[1] != var_array[0])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }

                                    }

                                }//b가 1번째 자리일때
                                else if(char_num[1] == var_array[0])
                                {
                                    if (char_num[0] == var_array[1])
                                    {
                                        if (char_num[2] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                   
                                    }
                                    else if (char_num[0] == var_array[2])
                                    {
                                        if (char_num[2] != var_array[1])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                    
                                    }
                                    else if (char_num[2] == var_array[1])
                                    {
                                        if (char_num[0] != var_array[3])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }

                                    }

                                }
                                //b가 3번째 자리일때 
                                else if(char_num[1] == var_array[2])
                                {
                                    if (char_num[0] == var_array[1])
                                    {
                                        if (char_num[2] != var_array[0])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                    }
                                    else if (char_num[2] == var_array[0])
                                    {
                                        if (char_num[0] != var_array[1])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                       
                                    }
                                    else if (char_num[2] == var_array[1])
                                    {
                                        if (char_num[0] != var_array[0])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }

                                    }
                                }//c가 1번째 자리일때
                                else if(char_num[2] == var_array[0])
                                {
                                    if (char_num[0] == var_array[1])
                                    {
                                        if (char_num[1] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                   
                                    }
                                    else if (char_num[0] == var_array[2])
                                    {
                                        if (char_num[2] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                       
                                    }
                                    else if (char_num[1] == var_array[2])
                                    {
                                        if (char_num[0] != var_array[1])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }

                                    }

                                }//c가 2번째 자리일때
                                else if(char_num[2] == var_array[1])
                                {
                                    if (char_num[0] == var_array[2])
                                    {
                                        if (char_num[1] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                        //b가 3번째 자리일때
                                    }
                                    else if (char_num[1] == var_array[0])
                                    {
                                        if (char_num[0] != var_array[2])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }
                                        //c 가 첫번째 자리였을때
                                    }
                                    else if (char_num[1] == var_array[2])
                                    {
                                        if (char_num[0] != var_array[0])
                                        {
                                            listView2.Items.Add(var[i]);
                                        }

                                    }

                                }

                            }

                        }

                    }
                    else if (ball == 3) { }

                }else if(strike ==1)
                {
                    if (ball == 0) { }
                    else if (ball == 1) { }
                    else if (ball == 2) { }
                }
                else if(strike == 2)
                {
                    if (ball == 0) { }
                    else if (ball == 1) { }

                }
                else { listView2.Items.Add(num); }
            }else
            {
                MessageBox.Show("no strike no ball");
            }
            

        }
    }
}
