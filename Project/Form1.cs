namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Phần Playfair
        private string[,] Matrix = new String[5, 5];
        private string Plaintext = "";
        bool isCreateMatrix = false;
        private string ascii = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        private void btn_en_de_playfair_Click(object sender, EventArgs e)
        {
            if (cb_encypt.Checked)
            {
                string Cyphertext = "";
                tb_cyphertext.Text = "";
                if (tb_plaintext == null || !isCreateMatrix)
                {
                    MessageBox.Show("Hãy nhập đầy đủ");
                    return;
                }
                Plaintext = tb_plaintext.Text.Trim();
                Plaintext = Plaintext.ToUpper();
                if ((Plaintext.Length % 2 != 0))
                {
                    Plaintext += "X";
                }
                List<String> temp_list = new List<String>();
                string temp = "";
                foreach (var item in Plaintext)
                {
                    if (item != ' ')
                    {
                        temp += item.ToString();
                        if (temp.Length == 2)
                        {
                            temp_list.Add(temp); temp = "";
                        }
                    }
                }
                foreach (var item in temp_list)
                {
                    Index index1 = new Index();
                    Index index2 = new Index();
                    int m = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (item[0].ToString() == Matrix[i, j])
                            {
                                index1.x = i; index1.y = j; m++;
                            }
                            if (item[1].ToString() == Matrix[i, j])
                            {
                                index2.x = i; index2.y = j; m++;
                            }
                        }
                    }
                    if (m == 2)
                    {
                        if (index1.y == index2.y)
                        {
                            Cyphertext += shiftWithX(index1); Cyphertext += shiftWithX(index2);
                        }
                        else if (index1.x == index2.x)
                        {
                            Cyphertext += shiftWithY(index1); Cyphertext += shiftWithY(index2);
                        }
                        else if (index1.y != index2.y && index1.x != index2.x)
                        {
                            Cyphertext += swapPosition(index1, index2.y); Cyphertext += swapPosition(index2, index1.y);
                        }
                    }
                }
                tb_cyphertext.Text = Cyphertext;
            }
            else if (cb_decrypt.Checked)
            {
                string Plaintext1 = "";
                tb_plaintext1.Text = "";
                if (tb_cypher_text == null || !isCreateMatrix)
                {
                    MessageBox.Show("Hãy nhập đầy đủ");
                    return;
                }
                string Cyphertext = tb_cypher_text.Text.Trim();
                Cyphertext = Cyphertext.ToUpper();
                if ((Cyphertext.Length % 2 != 0))
                {
                    Cyphertext += "X";
                }
                List<String> temp_list = new List<String>();
                string temp = "";
                foreach (var item in Cyphertext)
                {
                    if (item != ' ')
                    {
                        temp += item.ToString();
                        if (temp.Length == 2)
                        {
                            temp_list.Add(temp);
                            temp = "";
                        }
                    }
                }
                foreach (var item in temp_list)
                {
                    Index index1 = new Index();
                    Index index2 = new Index();
                    int m = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (item[0].ToString() == Matrix[i, j])
                            {
                                index1.x = i;
                                index1.y = j;
                                m++;
                            }
                            if (item[1].ToString() == Matrix[i, j])
                            {
                                index2.x = i;
                                index2.y = j;
                                m++;
                            }
                            if (m == 2) break;
                        }
                        if (m == 2) break;
                    }
                    if (index1.y == index2.y)
                    {
                        Plaintext1 += shiftWithX1(index1);
                        Plaintext1 += shiftWithX1(index2);
                        tb_plaintext1.Text = Plaintext1;
                    }
                    else if (index1.x == index2.x)
                    {
                        Plaintext1 += shiftWithY1(index1);
                        Plaintext1 += shiftWithY1(index2);
                        tb_plaintext1.Text = Plaintext1;
                    }
                    else if (index1.y != index2.y && index1.x != index2.x)
                    {
                        Plaintext1 += swapPosition1(index1, index2.y);
                        Plaintext1 += swapPosition1(index2, index1.y);
                        tb_plaintext1.Text = Plaintext1;
                    }
                }
                tb_plaintext1.Text = Plaintext1;
            }
            else
            {
                MessageBox.Show("Please select encryption or decryption mode.");
            }
        }
        private string shiftWithX(Index index)
        {
            index.x++;
            if (index.x > 4)
            {
                index.x = 0;
            }
            return Matrix[index.x, index.y];
        }
        private string shiftWithY(Index index)
        {
            index.y++;
            if (index.y > 4)
            {
                index.y = 0;
            }
            return Matrix[index.x, index.y];
        }
        private string swapPosition(Index index1, int offset)
        {
            int temp = offset;
            return Matrix[index1.x, temp];
        }
        private string shiftWithX1(Index index)
        {
            index.x--;
            if (index.x < 0)
            {
                index.x = 4;
            }
            return Matrix[index.x, index.y];
        }
        private string shiftWithY1(Index index)
        {
            index.y--;
            if (index.y < 0)
            {
                index.y = 4;
            }
            return Matrix[index.x, index.y];
        }
        private string swapPosition1(Index index1, int offset)
        {
            int temp = offset;
            return Matrix[index1.x, temp];
        }
        private void btn_create_matrix_Click(object sender, EventArgs e)
        {
            if (tb_key == null)
            {
                MessageBox.Show("Hãy nhập key!!");
                return;
            }
            isCreateMatrix = true;
            string en_key = tb_key.Text.Trim();
            en_key = en_key.ToUpper();
            string temp = "";
            foreach (var item in en_key)
            {
                if (temp.Contains(item) || item == ' ')
                {
                    continue;
                }
                temp += item;
            }
            foreach (var item in ascii)
            {
                if (temp.Contains(item))
                {
                    continue;
                }
                temp += item;
            }
            Thread newThread = new Thread(() => updateMatrix2(temp));
            newThread.Start();
            newThread.IsBackground = true;
            Thread newThread1 = new Thread(() => updateMatrix3(temp));
            newThread1.Start();
            newThread1.IsBackground = true;
        }
        
        private void updateMatrix2(string matrix)
        {
            int i = 1;
            foreach (var item in matrix)
            {
                TextBox tb = this.Controls.Find("mt_en" + i, true).FirstOrDefault() as TextBox;
                if (tb != null)
                {
                    Invoke(new Action(() =>
                    {
                        tb.Text = item.ToString();
                    }));
                }
                i++;
            }
        }
        private void updateMatrix3(string matrix)
        {
            int m = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Invoke(new Action(() =>
                    {
                        Matrix[i, j] = matrix[m].ToString();
                    }));
                    m++;
                }
            }
        }

        private void cb_encypt_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_encypt.Checked)
            {
                tb_key.Text = "";
                btn_en_de_playfair.Text = "Encrypt";
                cb_decrypt.Checked = false;
                label6.Text = "Ciphertext";
                label5.Text = "Enter Plaintext";
                tb_cyphertext.Visible = true;
                tb_cyphertext.Text = "";
                tb_plaintext.Visible = true;
                tb_plaintext.Text = "";
                tb_cypher_text.Visible = false;
                tb_plaintext1.Visible = false;
            }
            else
            {
                cb_decrypt.Checked = true;

            }
        }
        private void cb_decrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_decrypt.Checked)
            {
                tb_key.Text = "";
                btn_en_de_playfair.Text = "Decrypt";
                cb_encypt.Checked = false;
                label5.Text = "Enter Ciphertext";
                label6.Text = "Plaintext";
                tb_cyphertext.Visible = false;
                tb_plaintext.Visible = false;
                tb_cypher_text.Visible = true;
                tb_cypher_text.Text = "";
                tb_plaintext1.Visible = true;
                tb_plaintext1.Text = "";
            }
            else
            {
                cb_encypt.Checked = true;
            }
        }
    //Phần RSA

    }
}
