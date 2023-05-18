namespace BullandCow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuessNumber = new System.Windows.Forms.TextBox();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGuess1 = new System.Windows.Forms.Label();
            this.lblGuess2 = new System.Windows.Forms.Label();
            this.lblGuess3 = new System.Windows.Forms.Label();
            this.lblGuess4 = new System.Windows.Forms.Label();
            this.lblGuess5 = new System.Windows.Forms.Label();
            this.lblGuess6 = new System.Windows.Forms.Label();
            this.lblGuess7 = new System.Windows.Forms.Label();
            this.lblCows1 = new System.Windows.Forms.Label();
            this.lblCows2 = new System.Windows.Forms.Label();
            this.lblCows3 = new System.Windows.Forms.Label();
            this.lblCows4 = new System.Windows.Forms.Label();
            this.lblCows5 = new System.Windows.Forms.Label();
            this.lblCows6 = new System.Windows.Forms.Label();
            this.lblCows7 = new System.Windows.Forms.Label();
            this.lblBulls1 = new System.Windows.Forms.Label();
            this.lblBulls2 = new System.Windows.Forms.Label();
            this.lblBulls3 = new System.Windows.Forms.Label();
            this.lblBulls4 = new System.Windows.Forms.Label();
            this.lblBulls5 = new System.Windows.Forms.Label();
            this.lblBulls6 = new System.Windows.Forms.Label();
            this.lblBulls7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter guess number:";
            // 
            // txtGuessNumber
            // 
            this.txtGuessNumber.Location = new System.Drawing.Point(181, 42);
            this.txtGuessNumber.Name = "txtGuessNumber";
            this.txtGuessNumber.Size = new System.Drawing.Size(116, 29);
            this.txtGuessNumber.TabIndex = 1;
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.Location = new System.Drawing.Point(313, 42);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(137, 40);
            this.btnCheckResult.TabIndex = 2;
            this.btnCheckResult.Text = "Check Result";
            this.btnCheckResult.UseVisualStyleBackColor = true;
            this.btnCheckResult.Click += new System.EventHandler(this.btnCheckResult_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(27, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 457);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblBulls7, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBulls6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBulls5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBulls4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBulls3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBulls2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBulls1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCows6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCows5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCows4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCows3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCows2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCows1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCows7, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "6";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 38);
            this.label8.TabIndex = 7;
            this.label8.Text = "Guess";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 38);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cows";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 38);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bulls";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 45);
            this.label11.TabIndex = 10;
            this.label11.Text = "7";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGuess1
            // 
            this.lblGuess1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess1.AutoSize = true;
            this.lblGuess1.Location = new System.Drawing.Point(87, 38);
            this.lblGuess1.Name = "lblGuess1";
            this.lblGuess1.Size = new System.Drawing.Size(162, 38);
            this.lblGuess1.TabIndex = 11;
            this.lblGuess1.Text = "Guess";
            this.lblGuess1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess2
            // 
            this.lblGuess2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess2.AutoSize = true;
            this.lblGuess2.Location = new System.Drawing.Point(87, 76);
            this.lblGuess2.Name = "lblGuess2";
            this.lblGuess2.Size = new System.Drawing.Size(162, 38);
            this.lblGuess2.TabIndex = 12;
            this.lblGuess2.Text = "Guess";
            this.lblGuess2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess3
            // 
            this.lblGuess3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess3.AutoSize = true;
            this.lblGuess3.Location = new System.Drawing.Point(87, 114);
            this.lblGuess3.Name = "lblGuess3";
            this.lblGuess3.Size = new System.Drawing.Size(162, 38);
            this.lblGuess3.TabIndex = 13;
            this.lblGuess3.Text = "Guess";
            this.lblGuess3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess4
            // 
            this.lblGuess4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess4.AutoSize = true;
            this.lblGuess4.Location = new System.Drawing.Point(87, 152);
            this.lblGuess4.Name = "lblGuess4";
            this.lblGuess4.Size = new System.Drawing.Size(162, 38);
            this.lblGuess4.TabIndex = 14;
            this.lblGuess4.Text = "Guess";
            this.lblGuess4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess5
            // 
            this.lblGuess5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess5.AutoSize = true;
            this.lblGuess5.Location = new System.Drawing.Point(87, 190);
            this.lblGuess5.Name = "lblGuess5";
            this.lblGuess5.Size = new System.Drawing.Size(162, 38);
            this.lblGuess5.TabIndex = 15;
            this.lblGuess5.Text = "Guess";
            this.lblGuess5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess6
            // 
            this.lblGuess6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess6.AutoSize = true;
            this.lblGuess6.Location = new System.Drawing.Point(87, 228);
            this.lblGuess6.Name = "lblGuess6";
            this.lblGuess6.Size = new System.Drawing.Size(162, 38);
            this.lblGuess6.TabIndex = 16;
            this.lblGuess6.Text = "Guess";
            this.lblGuess6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess7
            // 
            this.lblGuess7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess7.AutoSize = true;
            this.lblGuess7.Location = new System.Drawing.Point(87, 266);
            this.lblGuess7.Name = "lblGuess7";
            this.lblGuess7.Size = new System.Drawing.Size(162, 45);
            this.lblGuess7.TabIndex = 8;
            this.lblGuess7.Text = "Guess";
            this.lblGuess7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCows1
            // 
            this.lblCows1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCows1.AutoSize = true;
            this.lblCows1.Location = new System.Drawing.Point(255, 38);
            this.lblCows1.Name = "lblCows1";
            this.lblCows1.Size = new System.Drawing.Size(78, 38);
            this.lblCows1.TabIndex = 8;
            this.lblCows1.Text = "Guess";
            this.lblCows1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCows2
            // 
            this.lblCows2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCows2.AutoSize = true;
            this.lblCows2.Location = new System.Drawing.Point(255, 76);
            this.lblCows2.Name = "lblCows2";
            this.lblCows2.Size = new System.Drawing.Size(78, 38);
            this.lblCows2.TabIndex = 8;
            this.lblCows2.Text = "Guess";
            this.lblCows2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCows3
            // 
            this.lblCows3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCows3.AutoSize = true;
            this.lblCows3.Location = new System.Drawing.Point(255, 114);
            this.lblCows3.Name = "lblCows3";
            this.lblCows3.Size = new System.Drawing.Size(78, 38);
            this.lblCows3.TabIndex = 8;
            this.lblCows3.Text = "Guess";
            this.lblCows3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCows4
            // 
            this.lblCows4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCows4.AutoSize = true;
            this.lblCows4.Location = new System.Drawing.Point(255, 152);
            this.lblCows4.Name = "lblCows4";
            this.lblCows4.Size = new System.Drawing.Size(78, 38);
            this.lblCows4.TabIndex = 8;
            this.lblCows4.Text = "Guess";
            this.lblCows4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCows5
            // 
            this.lblCows5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCows5.AutoSize = true;
            this.lblCows5.Location = new System.Drawing.Point(255, 190);
            this.lblCows5.Name = "lblCows5";
            this.lblCows5.Size = new System.Drawing.Size(78, 38);
            this.lblCows5.TabIndex = 8;
            this.lblCows5.Text = "Guess";
            this.lblCows5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCows6
            // 
            this.lblCows6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCows6.AutoSize = true;
            this.lblCows6.Location = new System.Drawing.Point(255, 228);
            this.lblCows6.Name = "lblCows6";
            this.lblCows6.Size = new System.Drawing.Size(78, 38);
            this.lblCows6.TabIndex = 8;
            this.lblCows6.Text = "Guess";
            this.lblCows6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCows7
            // 
            this.lblCows7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCows7.AutoSize = true;
            this.lblCows7.Location = new System.Drawing.Point(255, 266);
            this.lblCows7.Name = "lblCows7";
            this.lblCows7.Size = new System.Drawing.Size(78, 45);
            this.lblCows7.TabIndex = 8;
            this.lblCows7.Text = "Guess";
            this.lblCows7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulls1
            // 
            this.lblBulls1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBulls1.AutoSize = true;
            this.lblBulls1.Location = new System.Drawing.Point(339, 38);
            this.lblBulls1.Name = "lblBulls1";
            this.lblBulls1.Size = new System.Drawing.Size(78, 38);
            this.lblBulls1.TabIndex = 8;
            this.lblBulls1.Text = "Guess";
            this.lblBulls1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulls2
            // 
            this.lblBulls2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBulls2.AutoSize = true;
            this.lblBulls2.Location = new System.Drawing.Point(339, 76);
            this.lblBulls2.Name = "lblBulls2";
            this.lblBulls2.Size = new System.Drawing.Size(78, 38);
            this.lblBulls2.TabIndex = 8;
            this.lblBulls2.Text = "Guess";
            this.lblBulls2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulls3
            // 
            this.lblBulls3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBulls3.AutoSize = true;
            this.lblBulls3.Location = new System.Drawing.Point(339, 114);
            this.lblBulls3.Name = "lblBulls3";
            this.lblBulls3.Size = new System.Drawing.Size(78, 38);
            this.lblBulls3.TabIndex = 8;
            this.lblBulls3.Text = "Guess";
            this.lblBulls3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulls4
            // 
            this.lblBulls4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBulls4.AutoSize = true;
            this.lblBulls4.Location = new System.Drawing.Point(339, 152);
            this.lblBulls4.Name = "lblBulls4";
            this.lblBulls4.Size = new System.Drawing.Size(78, 38);
            this.lblBulls4.TabIndex = 8;
            this.lblBulls4.Text = "Guess";
            this.lblBulls4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulls5
            // 
            this.lblBulls5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBulls5.AutoSize = true;
            this.lblBulls5.Location = new System.Drawing.Point(339, 190);
            this.lblBulls5.Name = "lblBulls5";
            this.lblBulls5.Size = new System.Drawing.Size(78, 38);
            this.lblBulls5.TabIndex = 8;
            this.lblBulls5.Text = "Guess";
            this.lblBulls5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulls6
            // 
            this.lblBulls6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBulls6.AutoSize = true;
            this.lblBulls6.Location = new System.Drawing.Point(339, 228);
            this.lblBulls6.Name = "lblBulls6";
            this.lblBulls6.Size = new System.Drawing.Size(78, 38);
            this.lblBulls6.TabIndex = 8;
            this.lblBulls6.Text = "Guess";
            this.lblBulls6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulls7
            // 
            this.lblBulls7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBulls7.AutoSize = true;
            this.lblBulls7.Location = new System.Drawing.Point(339, 266);
            this.lblBulls7.Name = "lblBulls7";
            this.lblBulls7.Size = new System.Drawing.Size(78, 45);
            this.lblBulls7.TabIndex = 8;
            this.lblBulls7.Text = "Guess";
            this.lblBulls7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckResult);
            this.Controls.Add(this.txtGuessNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuessNumber;
        private System.Windows.Forms.Button btnCheckResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBulls7;
        private System.Windows.Forms.Label lblBulls6;
        private System.Windows.Forms.Label lblBulls5;
        private System.Windows.Forms.Label lblBulls4;
        private System.Windows.Forms.Label lblBulls3;
        private System.Windows.Forms.Label lblBulls2;
        private System.Windows.Forms.Label lblBulls1;
        private System.Windows.Forms.Label lblCows7;
        private System.Windows.Forms.Label lblCows6;
        private System.Windows.Forms.Label lblCows5;
        private System.Windows.Forms.Label lblCows4;
        private System.Windows.Forms.Label lblCows3;
        private System.Windows.Forms.Label lblCows2;
        private System.Windows.Forms.Label lblCows1;
        private System.Windows.Forms.Label lblGuess7;
        private System.Windows.Forms.Label lblGuess1;
        private System.Windows.Forms.Label lblGuess2;
        private System.Windows.Forms.Label lblGuess3;
        private System.Windows.Forms.Label lblGuess4;
        private System.Windows.Forms.Label lblGuess5;
        private System.Windows.Forms.Label lblGuess6;
    }
}

