namespace KlinikaWeterynaryjna
{
    partial class DodajEdytujZwierze
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
            nazwaTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            zaakceptujButton = new Button();
            anulujButton = new Button();
            gatunekListBox = new ListBox();
            dataOstWizytyTextBox = new TextBox();
            wlascicielTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 58);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Dodaj zwierze:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 95);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Nazwa";
            // 
            // nazwaTextBox
            // 
            nazwaTextBox.Location = new Point(116, 92);
            nazwaTextBox.Name = "nazwaTextBox";
            nazwaTextBox.Size = new Size(258, 25);
            nazwaTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 143);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 3;
            label3.Text = "Gatunek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(98, 17);
            label4.TabIndex = 5;
            label4.Text = "Data ost. wizyty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 245);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 7;
            label5.Text = "Właściciel";
            // 
            // zaakceptujButton
            // 
            zaakceptujButton.Location = new Point(95, 294);
            zaakceptujButton.Name = "zaakceptujButton";
            zaakceptujButton.Size = new Size(127, 52);
            zaakceptujButton.TabIndex = 9;
            zaakceptujButton.Text = "Zaakceptuj";
            zaakceptujButton.UseVisualStyleBackColor = true;
            zaakceptujButton.Click += zaakceptujButton_Click;
            // 
            // anulujButton
            // 
            anulujButton.Location = new Point(247, 294);
            anulujButton.Name = "anulujButton";
            anulujButton.Size = new Size(127, 52);
            anulujButton.TabIndex = 10;
            anulujButton.Text = "Anuluj";
            anulujButton.UseVisualStyleBackColor = true;
            anulujButton.Click += anulujButton_Click;
            // 
            // gatunekListBox
            // 
            gatunekListBox.FormattingEnabled = true;
            gatunekListBox.ItemHeight = 17;
            gatunekListBox.Location = new Point(116, 139);
            gatunekListBox.Name = "gatunekListBox";
            gatunekListBox.Size = new Size(258, 21);
            gatunekListBox.TabIndex = 11;
            gatunekListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataOstWizytyTextBox
            // 
            dataOstWizytyTextBox.Location = new Point(116, 195);
            dataOstWizytyTextBox.Name = "dataOstWizytyTextBox";
            dataOstWizytyTextBox.Size = new Size(258, 25);
            dataOstWizytyTextBox.TabIndex = 12;
            // 
            // wlascicielTextBox
            // 
            wlascicielTextBox.Location = new Point(116, 237);
            wlascicielTextBox.Name = "wlascicielTextBox";
            wlascicielTextBox.Size = new Size(258, 25);
            wlascicielTextBox.TabIndex = 13;
            // 
            // DodajEdytujZwierze
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 372);
            Controls.Add(wlascicielTextBox);
            Controls.Add(dataOstWizytyTextBox);
            Controls.Add(gatunekListBox);
            Controls.Add(anulujButton);
            Controls.Add(zaakceptujButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nazwaTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajEdytujZwierze";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DodajEdytujZwierze";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nazwaTextBox;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button zaakceptujButton;
        private Button anulujButton;
        private ListBox gatunekListBox;
        private TextBox dataOstWizytyTextBox;
        private TextBox wlascicielTextBox;
    }
}