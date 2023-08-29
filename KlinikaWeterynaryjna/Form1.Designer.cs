namespace KlinikaWeterynaryjna
{
    partial class LoginScreen
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
            zalogujButton = new Button();
            anulujButton = new Button();
            label1 = new Label();
            loginTextBox = new TextBox();
            hasloTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // zalogujButton
            // 
            zalogujButton.Location = new Point(81, 224);
            zalogujButton.Name = "zalogujButton";
            zalogujButton.Size = new Size(123, 50);
            zalogujButton.TabIndex = 0;
            zalogujButton.Text = "Zaloguj";
            zalogujButton.UseVisualStyleBackColor = true;
            zalogujButton.Click += zalogujButton_Click;
            // 
            // anulujButton
            // 
            anulujButton.Location = new Point(259, 224);
            anulujButton.Name = "anulujButton";
            anulujButton.Size = new Size(123, 50);
            anulujButton.TabIndex = 1;
            anulujButton.Text = "Anuluj";
            anulujButton.UseVisualStyleBackColor = true;
            anulujButton.Click += anulujButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 105);
            label1.Name = "label1";
            label1.Size = new Size(45, 22);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(166, 105);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(216, 25);
            loginTextBox.TabIndex = 3;
            // 
            // hasloTextBox
            // 
            hasloTextBox.Location = new Point(166, 161);
            hasloTextBox.Name = "hasloTextBox";
            hasloTextBox.Size = new Size(216, 25);
            hasloTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 164);
            label2.Name = "label2";
            label2.Size = new Size(47, 22);
            label2.TabIndex = 4;
            label2.Text = "Haslo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(167, 55);
            label3.Name = "label3";
            label3.Size = new Size(215, 24);
            label3.TabIndex = 6;
            label3.Text = "Podaj dane do zalogowania:";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 362);
            Controls.Add(label3);
            Controls.Add(hasloTextBox);
            Controls.Add(label2);
            Controls.Add(loginTextBox);
            Controls.Add(label1);
            Controls.Add(anulujButton);
            Controls.Add(zalogujButton);
            Name = "LoginScreen";
            Text = "Okno logowania";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button zalogujButton;
        private Button anulujButton;
        private Label label1;
        private TextBox loginTextBox;
        private TextBox hasloTextBox;
        private Label label2;
        private Label label3;
    }
}