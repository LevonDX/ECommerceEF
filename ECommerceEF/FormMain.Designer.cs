namespace ECommerceEF
{
    partial class FormMain
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
            listBox1 = new ListBox();
            btnAddSuppplyer = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(659, 1256);
            listBox1.TabIndex = 0;
            // 
            // btnAddSuppplyer
            // 
            btnAddSuppplyer.Location = new Point(770, 80);
            btnAddSuppplyer.Name = "btnAddSuppplyer";
            btnAddSuppplyer.Size = new Size(305, 58);
            btnAddSuppplyer.TabIndex = 1;
            btnAddSuppplyer.Text = "Add Supplyer";
            btnAddSuppplyer.UseVisualStyleBackColor = true;
            btnAddSuppplyer.Click += btnAddSuppplyer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(770, 160);
            button1.Name = "button1";
            button1.Size = new Size(305, 58);
            button1.TabIndex = 2;
            button1.Text = "Add Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 1256);
            Controls.Add(button1);
            Controls.Add(btnAddSuppplyer);
            Controls.Add(listBox1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnAddSuppplyer;
        private Button button1;
    }
}