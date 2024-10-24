using System.Security.Cryptography;
using System.Text;

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
        private void cb_en_rsa_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_en_rsa.Checked)
            {
                btn_en_de_rsa.Text = "Encrypt";
                label3.Text = "Enter plaintext";
                label7.Text = "Cyphertext";
                d_number.Enabled = false;
                n_number.Enabled = false;
                e_number.Enabled = false;
                p_number.Enabled = false;
                q_number.Enabled = false;
                phin_number.Enabled = false;
                key_generation.Visible = true;
                cb_de_rsa.Checked = false;
                tb_plaintext_rsa.Visible = true;
                tb_cyphertext_rsa2.Visible = true;
                tb_cyphertext_rsa.Visible = false;
                tb_phaintext_rsa2.Visible = false;
            }
            else
            {
                cb_de_rsa.Checked = true;
            }
        }

        private void cd_de_rsa_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_de_rsa.Checked)
            {
                btn_en_de_rsa.Text = "Decrypt";
                label3.Text = "Enter Cyphertext";
                label7.Text = "Plaintext";
                d_number.Enabled = true;
                n_number.Enabled = true;
                e_number.Enabled = false;
                p_number.Enabled = false;
                q_number.Enabled = false;
                phin_number.Enabled = false;
                key_generation.Visible = false;
                cb_en_rsa.Checked = false;
                tb_cyphertext_rsa.Visible = true;
                tb_phaintext_rsa2.Visible = true;
                tb_plaintext_rsa.Visible = false;
                tb_cyphertext_rsa2.Visible = false;
            }
            else
            {
                cb_en_rsa.Checked = true;
            }
        }
        private long pow(long a, int x, int p)
        {
            long result = 1;
            a = a % p;
            while (x > 0)
            {
                if (x % 2 == 1)
                {
                    result = (result * a) % p;
                }
                x /= 2;
                a = (a * a) % p;
            }
            return result;
        }
        private int generateRandomNumber(int bitlentgh)
        {
            int byteLength = (bitlentgh + 7) / 8;
            byte[] randomBytes = new byte[byteLength];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return BitConverter.ToInt16(randomBytes, 0);
        }
        private bool isPrime(int prime)
        {
            if (prime <= 1) return false;
            if (prime <= 3) return true;
            if (prime % 2 == 0) return false;

            int r = 0;
            int d = prime - 1;

            while (d % 2 == 0)
            {
                r++;
                d /= 2;
            }
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int a = random.Next(2, prime - 2);
                long x = pow(a, d, prime);
                if (x == 1 || x == prime - 1)
                {
                    continue;
                }
                for (int j = 0; j < r; j++)
                {
                    x = pow(x, 2, prime);
                    if (x == prime - 1)
                    {
                        break;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private (long gcd, long x, long y) extended_gcd (long a, long b)
        {
            if (a == 0)
            {
                return (b, 0, 1);
            }

            var result = extended_gcd(b % a, a);
            long gcd = result.gcd;
            long x1 = result.x;
            long y1 = result.y;

            long x = y1 - (b / a) * x1;
            long y = x1;

            return (gcd, x, y);
        }
        private long modInverse(int e, long phiN)
        {
            var result = extended_gcd(e, phiN);
            long gcd = result.gcd;
            long x = result.x;

            if (gcd != 1)
            {
                return -1; 
            }
            else
            {
                return (x % phiN + phiN) % phiN; 
            }
        }
        private string DecimalToBase64(int decimalNumber)
        {
            byte[] byteArray = BitConverter.GetBytes(decimalNumber);
            string base64String = Convert.ToBase64String(byteArray);
            return base64String;
        } 
        private void btn_en_de_rsa_Click(object sender, EventArgs e)
        {
            if (cb_en_rsa.Checked)
            {
                string plaintext = tb_plaintext_rsa.Text.Trim();
                int so_e = Int32.Parse(e_number.Text.Trim());
                int n = Int32.Parse(n_number.Text.Trim());
                string cyphertext = "";
                foreach (var item in plaintext)
                {
                    long c = pow((int)item, so_e, n);
                    string hexString = c.ToString("X8");
                    //cyphertext += DecimalToBase64(c);
                    cyphertext += hexString + " ";
                }
                tb_cyphertext_rsa2.Text = cyphertext;
            }
            else if (cb_de_rsa.Checked)
            {
                string cyphertextString = tb_cyphertext_rsa.Text.Trim();
                int d = Int32.Parse(d_number.Text.Trim());
                int n = Int32.Parse(n_number.Text.Trim());
                string plaintext = "";
                string[] cyphertextArray = cyphertextString.Split(' ');
                foreach (var item in cyphertextArray)
                {
                    long c = pow(Convert.ToInt32(item,16), d, n);
                    char temp = Convert.ToChar(c);
                    //cyphertext += DecimalToBase64(c);
                    plaintext += temp + "";
                }
                tb_phaintext_rsa2.Text = plaintext;
            }
        }

        private void key_generation_Click(object sender, EventArgs e)
        {
            int p, q, so_e;
            while (true)
            {
                p = generateRandomNumber(16);
                if (isPrime(p))
                {
                    break;
                }
            }
            while (true)
            {
                q = generateRandomNumber(16);
                if (isPrime(q))
                {
                    break;
                }
            }
            while (true)
            {
                so_e = generateRandomNumber(16);
                if (isPrime(so_e))
                {
                    break;
                }
            }
            long n = p * q;
            long phiN = (p-1) * (q-1);
            long d = modInverse(so_e, phiN);
            if (d == -1) return;

            p_number.Text = p.ToString();
            q_number.Text = q.ToString();
            e_number.Text = so_e.ToString();
            n_number.Text = n.ToString();
            d_number.Text = d.ToString();
            phin_number.Text = phiN.ToString();
        }
    }
}
