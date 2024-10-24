namespace Project
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
            tb = new TextBox();
            panel6 = new Panel();
            label7 = new Label();
            label1 = new Label();
            btn_create_matrix = new Button();
            label2 = new Label();
            btn_en_de_playfair = new Button();
            panel3 = new Panel();
            mt_en5 = new TextBox();
            mt_en4 = new TextBox();
            mt_en3 = new TextBox();
            mt_en2 = new TextBox();
            mt_en1 = new TextBox();
            mt_en25 = new TextBox();
            mt_en24 = new TextBox();
            mt_en23 = new TextBox();
            mt_en22 = new TextBox();
            mt_en21 = new TextBox();
            mt_en20 = new TextBox();
            mt_en19 = new TextBox();
            mt_en18 = new TextBox();
            mt_en17 = new TextBox();
            mt_en16 = new TextBox();
            mt_en15 = new TextBox();
            mt_en14 = new TextBox();
            mt_en13 = new TextBox();
            mt_en12 = new TextBox();
            mt_en11 = new TextBox();
            mt_en10 = new TextBox();
            mt_en9 = new TextBox();
            mt_en8 = new TextBox();
            mt_en7 = new TextBox();
            mt_en6 = new TextBox();
            tb_key = new TextBox();
            tb_cyphertext = new TextBox();
            panel7 = new Panel();
            label6 = new Label();
            tb_plaintext = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            Playfair = new TabPage();
            panel1 = new Panel();
            cb_decrypt = new CheckBox();
            cb_encypt = new CheckBox();
            tabControl1 = new TabControl();
            RSA = new TabPage();
            panel4 = new Panel();
            cd_de_rsa = new CheckBox();
            cb_en_rsa = new CheckBox();
            label10 = new Label();
            phin_number = new TextBox();
            label11 = new Label();
            q_number = new TextBox();
            label12 = new Label();
            p_number = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            key_generation = new Button();
            btn_en_de = new Button();
            label4 = new Label();
            d_number = new TextBox();
            label8 = new Label();
            e_number = new TextBox();
            label9 = new Label();
            n_number = new TextBox();
            tb_plaintext1 = new TextBox();
            panel5 = new Panel();
            panel8 = new Panel();
            tb_cypher_text = new TextBox();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            Playfair.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            RSA.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Dock = DockStyle.Fill;
            tb.Location = new Point(573, 31);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.ScrollBars = ScrollBars.Vertical;
            tb.Size = new Size(369, 476);
            tb.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(573, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(369, 28);
            panel6.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(120, 4);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 1;
            label7.Text = "Enter Cyphertext";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 82);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 3;
            label1.Text = "Enter key";
            // 
            // btn_create_matrix
            // 
            btn_create_matrix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_create_matrix.Location = new Point(21, 413);
            btn_create_matrix.Name = "btn_create_matrix";
            btn_create_matrix.Size = new Size(139, 43);
            btn_create_matrix.TabIndex = 7;
            btn_create_matrix.Text = "Create Matrix";
            btn_create_matrix.UseVisualStyleBackColor = true;
            btn_create_matrix.Click += btn_create_matrix_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 152);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 6;
            label2.Text = "5x5 Matrix";
            // 
            // btn_en_de_playfair
            // 
            btn_en_de_playfair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_en_de_playfair.Location = new Point(171, 413);
            btn_en_de_playfair.Name = "btn_en_de_playfair";
            btn_en_de_playfair.Size = new Size(104, 43);
            btn_en_de_playfair.TabIndex = 5;
            btn_en_de_playfair.Text = "Encrypt";
            btn_en_de_playfair.UseVisualStyleBackColor = true;
            btn_en_de_playfair.Click += btn_en_de_playfair_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(mt_en5);
            panel3.Controls.Add(mt_en4);
            panel3.Controls.Add(mt_en3);
            panel3.Controls.Add(mt_en2);
            panel3.Controls.Add(mt_en1);
            panel3.Controls.Add(mt_en25);
            panel3.Controls.Add(mt_en24);
            panel3.Controls.Add(mt_en23);
            panel3.Controls.Add(mt_en22);
            panel3.Controls.Add(mt_en21);
            panel3.Controls.Add(mt_en20);
            panel3.Controls.Add(mt_en19);
            panel3.Controls.Add(mt_en18);
            panel3.Controls.Add(mt_en17);
            panel3.Controls.Add(mt_en16);
            panel3.Controls.Add(mt_en15);
            panel3.Controls.Add(mt_en14);
            panel3.Controls.Add(mt_en13);
            panel3.Controls.Add(mt_en12);
            panel3.Controls.Add(mt_en11);
            panel3.Controls.Add(mt_en10);
            panel3.Controls.Add(mt_en9);
            panel3.Controls.Add(mt_en8);
            panel3.Controls.Add(mt_en7);
            panel3.Controls.Add(mt_en6);
            panel3.Location = new Point(21, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 214);
            panel3.TabIndex = 4;
            // 
            // mt_en5
            // 
            mt_en5.BackColor = SystemColors.Window;
            mt_en5.Location = new Point(200, 11);
            mt_en5.Name = "mt_en5";
            mt_en5.ReadOnly = true;
            mt_en5.Size = new Size(23, 23);
            mt_en5.TabIndex = 77;
            // 
            // mt_en4
            // 
            mt_en4.BackColor = SystemColors.Window;
            mt_en4.Location = new Point(159, 11);
            mt_en4.Name = "mt_en4";
            mt_en4.ReadOnly = true;
            mt_en4.Size = new Size(23, 23);
            mt_en4.TabIndex = 76;
            // 
            // mt_en3
            // 
            mt_en3.BackColor = SystemColors.Window;
            mt_en3.Location = new Point(116, 11);
            mt_en3.Name = "mt_en3";
            mt_en3.ReadOnly = true;
            mt_en3.Size = new Size(23, 23);
            mt_en3.TabIndex = 75;
            // 
            // mt_en2
            // 
            mt_en2.BackColor = SystemColors.Window;
            mt_en2.Location = new Point(73, 11);
            mt_en2.Name = "mt_en2";
            mt_en2.ReadOnly = true;
            mt_en2.Size = new Size(23, 23);
            mt_en2.TabIndex = 74;
            // 
            // mt_en1
            // 
            mt_en1.AcceptsReturn = true;
            mt_en1.BackColor = SystemColors.Window;
            mt_en1.Location = new Point(30, 11);
            mt_en1.Name = "mt_en1";
            mt_en1.ReadOnly = true;
            mt_en1.Size = new Size(23, 23);
            mt_en1.TabIndex = 73;
            // 
            // mt_en25
            // 
            mt_en25.BackColor = SystemColors.Window;
            mt_en25.Location = new Point(200, 180);
            mt_en25.Name = "mt_en25";
            mt_en25.ReadOnly = true;
            mt_en25.Size = new Size(23, 23);
            mt_en25.TabIndex = 72;
            // 
            // mt_en24
            // 
            mt_en24.BackColor = SystemColors.Window;
            mt_en24.Location = new Point(159, 180);
            mt_en24.Name = "mt_en24";
            mt_en24.ReadOnly = true;
            mt_en24.Size = new Size(23, 23);
            mt_en24.TabIndex = 71;
            // 
            // mt_en23
            // 
            mt_en23.BackColor = SystemColors.Window;
            mt_en23.Location = new Point(116, 180);
            mt_en23.Name = "mt_en23";
            mt_en23.ReadOnly = true;
            mt_en23.Size = new Size(23, 23);
            mt_en23.TabIndex = 70;
            // 
            // mt_en22
            // 
            mt_en22.BackColor = SystemColors.Window;
            mt_en22.Location = new Point(73, 180);
            mt_en22.Name = "mt_en22";
            mt_en22.ReadOnly = true;
            mt_en22.Size = new Size(23, 23);
            mt_en22.TabIndex = 69;
            // 
            // mt_en21
            // 
            mt_en21.BackColor = SystemColors.Window;
            mt_en21.Location = new Point(30, 180);
            mt_en21.Name = "mt_en21";
            mt_en21.ReadOnly = true;
            mt_en21.Size = new Size(23, 23);
            mt_en21.TabIndex = 68;
            // 
            // mt_en20
            // 
            mt_en20.BackColor = SystemColors.Window;
            mt_en20.Location = new Point(201, 139);
            mt_en20.Name = "mt_en20";
            mt_en20.ReadOnly = true;
            mt_en20.Size = new Size(23, 23);
            mt_en20.TabIndex = 67;
            // 
            // mt_en19
            // 
            mt_en19.BackColor = SystemColors.Window;
            mt_en19.Location = new Point(160, 139);
            mt_en19.Name = "mt_en19";
            mt_en19.ReadOnly = true;
            mt_en19.Size = new Size(23, 23);
            mt_en19.TabIndex = 66;
            // 
            // mt_en18
            // 
            mt_en18.BackColor = SystemColors.Window;
            mt_en18.Location = new Point(117, 139);
            mt_en18.Name = "mt_en18";
            mt_en18.ReadOnly = true;
            mt_en18.Size = new Size(23, 23);
            mt_en18.TabIndex = 65;
            // 
            // mt_en17
            // 
            mt_en17.BackColor = SystemColors.Window;
            mt_en17.Location = new Point(74, 139);
            mt_en17.Name = "mt_en17";
            mt_en17.ReadOnly = true;
            mt_en17.Size = new Size(23, 23);
            mt_en17.TabIndex = 64;
            // 
            // mt_en16
            // 
            mt_en16.BackColor = SystemColors.Window;
            mt_en16.Location = new Point(31, 139);
            mt_en16.Name = "mt_en16";
            mt_en16.ReadOnly = true;
            mt_en16.Size = new Size(23, 23);
            mt_en16.TabIndex = 63;
            // 
            // mt_en15
            // 
            mt_en15.BackColor = SystemColors.Window;
            mt_en15.Location = new Point(201, 95);
            mt_en15.Name = "mt_en15";
            mt_en15.ReadOnly = true;
            mt_en15.Size = new Size(23, 23);
            mt_en15.TabIndex = 62;
            // 
            // mt_en14
            // 
            mt_en14.BackColor = SystemColors.Window;
            mt_en14.Location = new Point(160, 95);
            mt_en14.Name = "mt_en14";
            mt_en14.ReadOnly = true;
            mt_en14.Size = new Size(23, 23);
            mt_en14.TabIndex = 61;
            // 
            // mt_en13
            // 
            mt_en13.BackColor = SystemColors.Window;
            mt_en13.Location = new Point(117, 95);
            mt_en13.Name = "mt_en13";
            mt_en13.ReadOnly = true;
            mt_en13.Size = new Size(23, 23);
            mt_en13.TabIndex = 60;
            // 
            // mt_en12
            // 
            mt_en12.BackColor = SystemColors.Window;
            mt_en12.Location = new Point(74, 95);
            mt_en12.Name = "mt_en12";
            mt_en12.ReadOnly = true;
            mt_en12.Size = new Size(23, 23);
            mt_en12.TabIndex = 59;
            // 
            // mt_en11
            // 
            mt_en11.BackColor = SystemColors.Window;
            mt_en11.Location = new Point(31, 95);
            mt_en11.Name = "mt_en11";
            mt_en11.ReadOnly = true;
            mt_en11.Size = new Size(23, 23);
            mt_en11.TabIndex = 58;
            // 
            // mt_en10
            // 
            mt_en10.BackColor = SystemColors.Window;
            mt_en10.Location = new Point(201, 51);
            mt_en10.Name = "mt_en10";
            mt_en10.ReadOnly = true;
            mt_en10.Size = new Size(23, 23);
            mt_en10.TabIndex = 57;
            // 
            // mt_en9
            // 
            mt_en9.BackColor = SystemColors.Window;
            mt_en9.Location = new Point(160, 51);
            mt_en9.Name = "mt_en9";
            mt_en9.ReadOnly = true;
            mt_en9.Size = new Size(23, 23);
            mt_en9.TabIndex = 56;
            // 
            // mt_en8
            // 
            mt_en8.BackColor = SystemColors.Window;
            mt_en8.Location = new Point(117, 51);
            mt_en8.Name = "mt_en8";
            mt_en8.ReadOnly = true;
            mt_en8.Size = new Size(23, 23);
            mt_en8.TabIndex = 55;
            // 
            // mt_en7
            // 
            mt_en7.BackColor = SystemColors.Window;
            mt_en7.Location = new Point(74, 51);
            mt_en7.Name = "mt_en7";
            mt_en7.ReadOnly = true;
            mt_en7.Size = new Size(23, 23);
            mt_en7.TabIndex = 54;
            // 
            // mt_en6
            // 
            mt_en6.BackColor = SystemColors.Window;
            mt_en6.Location = new Point(31, 51);
            mt_en6.Name = "mt_en6";
            mt_en6.ReadOnly = true;
            mt_en6.Size = new Size(23, 23);
            mt_en6.TabIndex = 53;
            // 
            // tb_key
            // 
            tb_key.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_key.Location = new Point(21, 106);
            tb_key.Multiline = true;
            tb_key.Name = "tb_key";
            tb_key.ScrollBars = ScrollBars.Vertical;
            tb_key.Size = new Size(254, 34);
            tb_key.TabIndex = 2;
            // 
            // tb_cyphertext
            // 
            tb_cyphertext.Dock = DockStyle.Fill;
            tb_cyphertext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_cyphertext.Location = new Point(0, 0);
            tb_cyphertext.Multiline = true;
            tb_cyphertext.Name = "tb_cyphertext";
            tb_cyphertext.ReadOnly = true;
            tb_cyphertext.ScrollBars = ScrollBars.Vertical;
            tb_cyphertext.Size = new Size(610, 226);
            tb_cyphertext.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(332, 253);
            panel7.Name = "panel7";
            panel7.Size = new Size(610, 28);
            panel7.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(271, 4);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 5;
            label6.Text = "Cyphertext";
            // 
            // tb_plaintext
            // 
            tb_plaintext.Dock = DockStyle.Fill;
            tb_plaintext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_plaintext.Location = new Point(0, 0);
            tb_plaintext.Multiline = true;
            tb_plaintext.Name = "tb_plaintext";
            tb_plaintext.ScrollBars = ScrollBars.Vertical;
            tb_plaintext.Size = new Size(610, 221);
            tb_plaintext.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(258, 5);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 4;
            label5.Text = "Enter Plaintext";
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(332, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 29);
            panel2.TabIndex = 6;
            // 
            // Playfair
            // 
            Playfair.Controls.Add(panel8);
            Playfair.Controls.Add(panel7);
            Playfair.Controls.Add(panel5);
            Playfair.Controls.Add(panel2);
            Playfair.Controls.Add(panel1);
            Playfair.Location = new Point(4, 24);
            Playfair.Name = "Playfair";
            Playfair.Padding = new Padding(3);
            Playfair.Size = new Size(945, 510);
            Playfair.TabIndex = 0;
            Playfair.Text = "Playfair";
            Playfair.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(cb_decrypt);
            panel1.Controls.Add(cb_encypt);
            panel1.Controls.Add(btn_create_matrix);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_en_de_playfair);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_key);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 504);
            panel1.TabIndex = 3;
            // 
            // cb_decrypt
            // 
            cb_decrypt.AutoSize = true;
            cb_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_decrypt.Location = new Point(171, 31);
            cb_decrypt.Name = "cb_decrypt";
            cb_decrypt.Size = new Size(83, 25);
            cb_decrypt.TabIndex = 9;
            cb_decrypt.Text = "Decrypt";
            cb_decrypt.UseVisualStyleBackColor = true;
            cb_decrypt.CheckedChanged += cb_decrypt_CheckedChanged;
            // 
            // cb_encypt
            // 
            cb_encypt.AutoSize = true;
            cb_encypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_encypt.Location = new Point(23, 31);
            cb_encypt.Name = "cb_encypt";
            cb_encypt.Size = new Size(81, 25);
            cb_encypt.TabIndex = 8;
            cb_encypt.Text = "Encrypt";
            cb_encypt.UseVisualStyleBackColor = true;
            cb_encypt.CheckedChanged += cb_encypt_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Playfair);
            tabControl1.Controls.Add(RSA);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(953, 538);
            tabControl1.TabIndex = 1;
            // 
            // RSA
            // 
            RSA.Controls.Add(tb);
            RSA.Controls.Add(panel6);
            RSA.Controls.Add(panel4);
            RSA.Location = new Point(4, 24);
            RSA.Name = "RSA";
            RSA.Padding = new Padding(3);
            RSA.Size = new Size(945, 510);
            RSA.TabIndex = 1;
            RSA.Text = "RSA";
            RSA.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(cd_de_rsa);
            panel4.Controls.Add(cb_en_rsa);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(phin_number);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(q_number);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(p_number);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(key_generation);
            panel4.Controls.Add(btn_en_de);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(d_number);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(e_number);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(n_number);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(570, 504);
            panel4.TabIndex = 0;
            // 
            // cd_de_rsa
            // 
            cd_de_rsa.AutoSize = true;
            cd_de_rsa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cd_de_rsa.Location = new Point(161, 25);
            cd_de_rsa.Name = "cd_de_rsa";
            cd_de_rsa.Size = new Size(83, 25);
            cd_de_rsa.TabIndex = 33;
            cd_de_rsa.Text = "Decrypt";
            cd_de_rsa.UseVisualStyleBackColor = true;
            // 
            // cb_en_rsa
            // 
            cb_en_rsa.AutoSize = true;
            cb_en_rsa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_en_rsa.Location = new Point(25, 25);
            cb_en_rsa.Name = "cb_en_rsa";
            cb_en_rsa.Size = new Size(81, 25);
            cb_en_rsa.TabIndex = 32;
            cb_en_rsa.Text = "Encrypt";
            cb_en_rsa.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(296, 155);
            label10.Name = "label10";
            label10.Size = new Size(113, 21);
            label10.TabIndex = 31;
            label10.Text = "PhiN Number: ";
            // 
            // phin_number
            // 
            phin_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phin_number.Location = new Point(408, 152);
            phin_number.Name = "phin_number";
            phin_number.ReadOnly = true;
            phin_number.Size = new Size(150, 29);
            phin_number.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(296, 120);
            label11.Name = "label11";
            label11.Size = new Size(91, 21);
            label11.TabIndex = 29;
            label11.Text = "Q Number: ";
            // 
            // q_number
            // 
            q_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            q_number.Location = new Point(408, 117);
            q_number.Name = "q_number";
            q_number.ReadOnly = true;
            q_number.Size = new Size(150, 29);
            q_number.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(296, 85);
            label12.Name = "label12";
            label12.Size = new Size(92, 21);
            label12.TabIndex = 27;
            label12.Text = "P  Number: ";
            // 
            // p_number
            // 
            p_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_number.Location = new Point(408, 82);
            p_number.Name = "p_number";
            p_number.ReadOnly = true;
            p_number.Size = new Size(150, 29);
            p_number.TabIndex = 26;
            p_number.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 222);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 25;
            label3.Text = "Plaintext";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 246);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(570, 258);
            textBox1.TabIndex = 24;
            // 
            // key_generation
            // 
            key_generation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            key_generation.Location = new Point(300, 187);
            key_generation.Name = "key_generation";
            key_generation.Size = new Size(126, 48);
            key_generation.TabIndex = 23;
            key_generation.Text = "Key Generation";
            key_generation.UseVisualStyleBackColor = true;
            // 
            // btn_en_de
            // 
            btn_en_de.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_en_de.Location = new Point(432, 187);
            btn_en_de.Name = "btn_en_de";
            btn_en_de.Size = new Size(126, 48);
            btn_en_de.TabIndex = 22;
            btn_en_de.Text = "Encrypt";
            btn_en_de.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 152);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 20;
            label4.Text = "D Number: ";
            // 
            // d_number
            // 
            d_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            d_number.Location = new Point(119, 149);
            d_number.Name = "d_number";
            d_number.ReadOnly = true;
            d_number.Size = new Size(150, 29);
            d_number.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 117);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 18;
            label8.Text = "E Number: ";
            // 
            // e_number
            // 
            e_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            e_number.Location = new Point(119, 114);
            e_number.Name = "e_number";
            e_number.ReadOnly = true;
            e_number.Size = new Size(150, 29);
            e_number.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 82);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 16;
            label9.Text = "N  Number: ";
            // 
            // n_number
            // 
            n_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n_number.Location = new Point(119, 79);
            n_number.Name = "n_number";
            n_number.ReadOnly = true;
            n_number.Size = new Size(150, 29);
            n_number.TabIndex = 15;
            // 
            // tb_plaintext1
            // 
            tb_plaintext1.Dock = DockStyle.Fill;
            tb_plaintext1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_plaintext1.Location = new Point(0, 0);
            tb_plaintext1.Multiline = true;
            tb_plaintext1.Name = "tb_plaintext1";
            tb_plaintext1.ReadOnly = true;
            tb_plaintext1.ScrollBars = ScrollBars.Vertical;
            tb_plaintext1.Size = new Size(610, 226);
            tb_plaintext1.TabIndex = 10;
            tb_plaintext1.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(tb_cypher_text);
            panel5.Controls.Add(tb_plaintext);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(332, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(610, 221);
            panel5.TabIndex = 11;
            // 
            // panel8
            // 
            panel8.Controls.Add(tb_plaintext1);
            panel8.Controls.Add(tb_cyphertext);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(332, 281);
            panel8.Name = "panel8";
            panel8.Size = new Size(610, 226);
            panel8.TabIndex = 12;
            // 
            // tb_cypher_text
            // 
            tb_cypher_text.Dock = DockStyle.Fill;
            tb_cypher_text.Location = new Point(0, 0);
            tb_cypher_text.Multiline = true;
            tb_cypher_text.Name = "tb_cypher_text";
            tb_cypher_text.Size = new Size(610, 221);
            tb_cypher_text.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 538);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Playfair.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            RSA.ResumeLayout(false);
            RSA.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tb;
        private Panel panel6;
        private Label label7;
        private Label label1;
        private Button btn_create_matrix;
        private Label label2;
        private Button btn_en_de_playfair;
        private Panel panel3;
        private TextBox mt_en5;
        private TextBox mt_en4;
        private TextBox mt_en3;
        private TextBox mt_en2;
        private TextBox mt_en1;
        private TextBox mt_en25;
        private TextBox mt_en24;
        private TextBox mt_en23;
        private TextBox mt_en22;
        private TextBox mt_en21;
        private TextBox mt_en20;
        private TextBox mt_en19;
        private TextBox mt_en18;
        private TextBox mt_en17;
        private TextBox mt_en16;
        private TextBox mt_en15;
        private TextBox mt_en14;
        private TextBox mt_en13;
        private TextBox mt_en12;
        private TextBox mt_en11;
        private TextBox mt_en10;
        private TextBox mt_en9;
        private TextBox mt_en8;
        private TextBox mt_en7;
        private TextBox mt_en6;
        private TextBox tb_key;
        private TextBox tb_cyphertext;
        private Panel panel7;
        private Label label6;
        private TextBox tb_plaintext;
        private Label label5;
        private Panel panel2;
        private TabPage Playfair;
        private Panel panel1;
        private CheckBox cb_encypt;
        private TabControl tabControl1;
        private TabPage RSA;
        private CheckBox cb_decrypt;
        private Panel panel4;
        private Label label3;
        private TextBox textBox1;
        private Button key_generation;
        private Button btn_en_de;
        private Label label4;
        private TextBox d_number;
        private Label label8;
        private TextBox e_number;
        private Label label9;
        private TextBox n_number;
        private Label label10;
        private TextBox phin_number;
        private Label label11;
        private TextBox q_number;
        private Label label12;
        private TextBox p_number;
        private CheckBox cd_de_rsa;
        private CheckBox cb_en_rsa;
        private TextBox tb_plaintext1;
        private Panel panel8;
        private Panel panel5;
        private TextBox tb_cypher_text;
    }
}
