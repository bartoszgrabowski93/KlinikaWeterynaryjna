namespace KlinikaWeterynaryjna
{
    partial class TabelaZDanymi
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
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            zakończToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            dataGridView = new DataGridView();
            dodajButton = new Button();
            edytujButton = new Button();
            usunButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(544, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zakończToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(39, 21);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            zakończToolStripMenuItem.Size = new Size(198, 24);
            zakończToolStripMenuItem.Text = "Zakończ";
            zakończToolStripMenuItem.Click += zakończToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "Zwierzęta:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(30, 68);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 45;
            dataGridView.RowTemplate.Height = 27;
            dataGridView.Size = new Size(487, 233);
            dataGridView.TabIndex = 2;
            // 
            // dodajButton
            // 
            dodajButton.Location = new Point(45, 333);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(131, 49);
            dodajButton.TabIndex = 3;
            dodajButton.Text = "Dodaj";
            dodajButton.UseVisualStyleBackColor = true;
            // 
            // edytujButton
            // 
            edytujButton.Location = new Point(209, 333);
            edytujButton.Name = "edytujButton";
            edytujButton.Size = new Size(131, 49);
            edytujButton.TabIndex = 4;
            edytujButton.Text = "Edytuj";
            edytujButton.UseVisualStyleBackColor = true;
            // 
            // usunButton
            // 
            usunButton.Location = new Point(375, 333);
            usunButton.Name = "usunButton";
            usunButton.Size = new Size(131, 49);
            usunButton.TabIndex = 5;
            usunButton.Text = "Usun";
            usunButton.UseVisualStyleBackColor = true;
            // 
            // TabelaZDanymi
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 402);
            Controls.Add(usunButton);
            Controls.Add(edytujButton);
            Controls.Add(dodajButton);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TabelaZDanymi";
            Text = "TabelaZDanymi";
            Load += TabelaZDanymi_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private Label label1;
        private DataGridView dataGridView;
        private Button dodajButton;
        private Button edytujButton;
        private Button usunButton;
    }
}