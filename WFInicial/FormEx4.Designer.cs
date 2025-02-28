namespace WFInicial
{
    partial class FormEx4
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
            txtNum2 = new TextBox();
            lblNum2 = new Label();
            btnMaior = new Button();
            txtNum1 = new TextBox();
            lblNum1 = new Label();
            txtNum3 = new TextBox();
            lblNum3 = new Label();
            SuspendLayout();
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(90, 53);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 9;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(22, 56);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(63, 15);
            lblNum2.TabIndex = 8;
            lblNum2.Text = "Número 2:";
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(42, 117);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(129, 23);
            btnMaior.TabIndex = 7;
            btnMaior.Text = "Mostrar Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(90, 24);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 6;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(22, 27);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 15);
            lblNum1.TabIndex = 5;
            lblNum1.Text = "Número 1:";
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(90, 83);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 11;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(22, 86);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(63, 15);
            lblNum3.TabIndex = 10;
            lblNum3.Text = "Número 3:";
            // 
            // FormEx4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 181);
            Controls.Add(txtNum3);
            Controls.Add(lblNum3);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(btnMaior);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "FormEx4";
            Text = "FormEx4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum2;
        private Label lblNum2;
        private Button btnMaior;
        private TextBox txtNum1;
        private Label lblNum1;
        private TextBox txtNum3;
        private Label lblNum3;
    }
}