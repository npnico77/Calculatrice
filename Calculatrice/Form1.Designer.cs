namespace Calculatrice
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.resultatComplet = new System.Windows.Forms.Label();
            this.ecran = new System.Windows.Forms.TextBox();
            this.buttonEgal = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button15, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button14, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button13, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(168, 153);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(79, 44);
            this.button16.TabIndex = 10;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.buttonOperateur_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(168, 103);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(79, 44);
            this.button15.TabIndex = 9;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buttonOperateur_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(168, 53);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(79, 44);
            this.button14.TabIndex = 8;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttonOperateur_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(113, 153);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 44);
            this.button12.TabIndex = 6;
            this.button12.Text = ",";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonVirgule_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 153);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 44);
            this.button11.TabIndex = 3;
            this.button11.Text = "-/+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonSigne_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(113, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 44);
            this.button10.TabIndex = 3;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(58, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 44);
            this.button9.TabIndex = 3;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 44);
            this.button8.TabIndex = 5;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 44);
            this.button5.TabIndex = 2;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(58, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 44);
            this.button6.TabIndex = 3;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(113, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 44);
            this.button7.TabIndex = 4;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonChiffre_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(168, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 44);
            this.button13.TabIndex = 7;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonOperateur_Click);
            // 
            // resultatComplet
            // 
            this.resultatComplet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultatComplet.Location = new System.Drawing.Point(18, 75);
            this.resultatComplet.MinimumSize = new System.Drawing.Size(320, 0);
            this.resultatComplet.Name = "resultatComplet";
            this.resultatComplet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultatComplet.Size = new System.Drawing.Size(320, 20);
            this.resultatComplet.TabIndex = 1;
            this.resultatComplet.Text = " ";
            this.resultatComplet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ecran
            // 
            this.ecran.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ecran.Location = new System.Drawing.Point(12, 21);
            this.ecran.Name = "ecran";
            this.ecran.Size = new System.Drawing.Size(326, 34);
            this.ecran.TabIndex = 2;
            this.ecran.Text = "0";
            this.ecran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonEgal
            // 
            this.buttonEgal.Location = new System.Drawing.Point(265, 217);
            this.buttonEgal.Name = "buttonEgal";
            this.buttonEgal.Size = new System.Drawing.Size(73, 94);
            this.buttonEgal.TabIndex = 3;
            this.buttonEgal.Text = "=";
            this.buttonEgal.UseVisualStyleBackColor = true;
            this.buttonEgal.Click += new System.EventHandler(this.buttonEgal_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(265, 117);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 44);
            this.button18.TabIndex = 4;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 342);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.buttonEgal);
            this.Controls.Add(this.ecran);
            this.Controls.Add(this.resultatComplet);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculatrice !!!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button13;
        private Label resultatComplet;
        private TextBox ecran;
        private Button buttonEgal;
        private Button button18;
    }
}