﻿namespace AmoreSucos
{
    partial class FrmCadastrarProduto
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Novo Produto :";
            // 
            // button2
            // 
            button2.Location = new Point(7, 227);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(337, 227);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 113);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Autenticar-se:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(99, 77);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 22);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 22);
            textBox3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 80);
            label5.Name = "label5";
            label5.Size = new Size(49, 14);
            label5.TabIndex = 1;
            label5.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 33);
            label4.Name = "label4";
            label4.Size = new Size(63, 14);
            label4.TabIndex = 0;
            label4.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 51);
            label3.Name = "label3";
            label3.Size = new Size(49, 14);
            label3.TabIndex = 4;
            label3.Text = "Litros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 31);
            label2.Name = "label2";
            label2.Size = new Size(84, 14);
            label2.TabIndex = 3;
            label2.Text = "Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 14);
            label1.TabIndex = 2;
            label1.Text = "Produto:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 22);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 22);
            textBox1.TabIndex = 0;
            // 
            // FrmCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(447, 286);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 9F, FontStyle.Bold);
            Name = "FrmCadastrarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrarProduto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}