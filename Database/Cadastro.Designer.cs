namespace Database
{
    partial class Cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 89);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 175);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 239);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 303);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 3;
            label4.Text = "Confirme a senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(327, 300);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 31);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(327, 379);
            button1.Name = "button1";
            button1.Size = new Size(186, 34);
            button1.TabIndex = 7;
            button1.Text = "Efetuar cadastro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}