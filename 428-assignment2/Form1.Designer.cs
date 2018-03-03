namespace _428_assignment2
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
            this.from = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pricetextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(101, 36);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(146, 21);
            this.from.TabIndex = 1;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(101, 63);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(146, 21);
            this.To.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(101, 90);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(146, 21);
            this.length.TabIndex = 5;
            this.length.TextChanged += new System.EventHandler(this.length_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Length";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(101, 117);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(146, 21);
            this.width.TabIndex = 7;
            this.width.TextChanged += new System.EventHandler(this.width_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Width";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(101, 144);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(146, 21);
            this.height.TabIndex = 9;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Height";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(101, 171);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(146, 21);
            this.weight.TabIndex = 11;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Post type";
            // 
            // Pricetextbox
            // 
            this.Pricetextbox.Location = new System.Drawing.Point(101, 227);
            this.Pricetextbox.Name = "Pricetextbox";
            this.Pricetextbox.ReadOnly = true;
            this.Pricetextbox.Size = new System.Drawing.Size(146, 21);
            this.Pricetextbox.TabIndex = 15;
            this.Pricetextbox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 20);
            this.comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 318);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pricetextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Pricetextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

