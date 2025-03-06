namespace WFInicial
{
    partial class FormEx7
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
            btnCadastrar = new Button();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            lblValorProduto = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(71, 110);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(18, 44);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(58, 15);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Produtos:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(82, 38);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(82, 71);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 4;
            // 
            // lblValorProduto
            // 
            lblValorProduto.AutoSize = true;
            lblValorProduto.Location = new Point(18, 73);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(36, 15);
            lblValorProduto.TabIndex = 3;
            lblValorProduto.Text = "Valor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 169);
            Controls.Add(txtValorProduto);
            Controls.Add(lblValorProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private Label lblValorProduto;
    }
}