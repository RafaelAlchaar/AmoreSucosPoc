namespace AmoreSucos
{
    partial class FrmEstoque
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
            dgvEstoque = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Litros = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // dgvEstoque
            // 
            dgvEstoque.BackgroundColor = SystemColors.ControlLightLight;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { Produto, Litros });
            dgvEstoque.Location = new Point(-42, 3);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(519, 326);
            dgvEstoque.TabIndex = 0;
            dgvEstoque.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Produto.DataPropertyName = "Nome";
            Produto.HeaderText = "Sucos";
            Produto.Name = "Produto";
            // 
            // Litros
            // 
            Litros.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Litros.DataPropertyName = "Litros";
            Litros.HeaderText = "Litros";
            Litros.Name = "Litros";
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 328);
            Controls.Add(dgvEstoque);
            Font = new Font("Consolas", 9F, FontStyle.Bold);
            Name = "FrmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstoque";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Litros;
    }
}