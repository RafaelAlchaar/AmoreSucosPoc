namespace AmoreSucos
{
    partial class FrmAdicionarEstoqueSuco
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
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(231, 14);
            label1.TabIndex = 0;
            label1.Text = "Quantidade que deseja Adicionar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 22);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 72);
            label2.Name = "label2";
            label2.Size = new Size(49, 14);
            label2.TabIndex = 2;
            label2.Text = "Litros";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(7, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 190);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Autentique-se";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 113);
            label4.Name = "label4";
            label4.Size = new Size(49, 14);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 54);
            label3.Name = "label3";
            label3.Size = new Size(63, 14);
            label3.TabIndex = 2;
            label3.Text = "Usuário:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 22);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 22);
            textBox2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(266, 387);
            button1.Name = "button1";
            button1.Size = new Size(75, 21);
            button1.TabIndex = 4;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(12, 385);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmAdicionarEstoqueSuco
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(363, 420);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Consolas", 9F, FontStyle.Bold);
            Name = "FrmAdicionarEstoqueSuco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdicionarEstoqueSuco";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}