namespace ECommerceEF
{
    partial class FormAddProduct
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(853, 47);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 80);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(853, 47);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 215);
            label2.Name = "label2";
            label2.Size = new Size(194, 41);
            label2.TabIndex = 3;
            label2.Text = "Product Price";
            // 
            // button1
            // 
            button1.Location = new Point(183, 521);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(745, 521);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 361);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 49);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 817);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormAddProduct";
            Text = "FormAddProduct";
            Load += FormAddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
    }
}