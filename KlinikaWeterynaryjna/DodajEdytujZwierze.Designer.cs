﻿namespace KlinikaWeterynaryjna
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
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            zaakceptujButton = new Button();
            anulujButton = new Button();
            gatunekListBox = new ListBox();
            wlascicielListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(205, 60);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 0;
            label1.Text = "Informacje o zwierzeciu:";
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
            // textBox2
            // 
            textBox2.Location = new Point(116, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 25);
            textBox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Location = new Point(116, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 25);
            textBox3.TabIndex = 6;
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
            // 
            // anulujButton
            // 
            anulujButton.Location = new Point(247, 294);
            anulujButton.Name = "anulujButton";
            anulujButton.Size = new Size(127, 52);
            anulujButton.TabIndex = 10;
            anulujButton.Text = "Anuluj";
            anulujButton.UseVisualStyleBackColor = true;
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
            // wlascicielListBox
            // 
            wlascicielListBox.FormattingEnabled = true;
            wlascicielListBox.ItemHeight = 17;
            wlascicielListBox.Location = new Point(116, 245);
            wlascicielListBox.Name = "wlascicielListBox";
            wlascicielListBox.Size = new Size(258, 21);
            wlascicielListBox.TabIndex = 12;
            // 
            // DodajEdytujZwierze
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 372);
            Controls.Add(wlascicielListBox);
            Controls.Add(gatunekListBox);
            Controls.Add(anulujButton);
            Controls.Add(zaakceptujButton);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DodajEdytujZwierze";
            Text = "DodajEdytujZwierze";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button zaakceptujButton;
        private Button anulujButton;
        private ListBox gatunekListBox;
        private ListBox wlascicielListBox;
    }
}