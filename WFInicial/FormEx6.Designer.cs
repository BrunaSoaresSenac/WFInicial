namespace WFInicial
{
    partial class FormEx6
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
            btnCalcular = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            lblHoras = new Label();
            txtHoras = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(102, 119);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(102, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(41, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(43, 54);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(41, 15);
            lblHoras.TabIndex = 4;
            lblHoras.Text = "Horas:";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(102, 51);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 3;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(26, 83);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(70, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor Horas:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(102, 80);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 183);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblHoras);
            Controls.Add(txtHoras);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(btnCalcular);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblHoras;
        private TextBox txtHoras;
        private Label lblValor;
        private TextBox txtValor;
    }
}