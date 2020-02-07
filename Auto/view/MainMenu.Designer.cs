namespace Autokauppa.view
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mittarilukema = new System.Windows.Forms.TextBox();
            this.Tilavuus = new System.Windows.Forms.TextBox();
            this.Hinta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Merkki = new System.Windows.Forms.ComboBox();
            this.Malli = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Polttoaine = new System.Windows.Forms.ComboBox();
            this.Väri = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Paivita = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaTietokantayhteyttäToolStripMenuItem.Click += new System.EventHandler(this.testaaTietokantayhteyttäToolStripMenuItem_Click);
            // 
            // Mittarilukema
            // 
            this.Mittarilukema.Location = new System.Drawing.Point(118, 73);
            this.Mittarilukema.Name = "Mittarilukema";
            this.Mittarilukema.Size = new System.Drawing.Size(100, 20);
            this.Mittarilukema.TabIndex = 1;
            // 
            // Tilavuus
            // 
            this.Tilavuus.Location = new System.Drawing.Point(342, 73);
            this.Tilavuus.Name = "Tilavuus";
            this.Tilavuus.Size = new System.Drawing.Size(100, 20);
            this.Tilavuus.TabIndex = 2;
            // 
            // Hinta
            // 
            this.Hinta.Location = new System.Drawing.Point(523, 73);
            this.Hinta.Name = "Hinta";
            this.Hinta.Size = new System.Drawing.Size(100, 20);
            this.Hinta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mittarilukema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Moottorin tilavuus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hinta:";
            // 
            // Merkki
            // 
            this.Merkki.FormattingEnabled = true;
            this.Merkki.Location = new System.Drawing.Point(76, 163);
            this.Merkki.Name = "Merkki";
            this.Merkki.Size = new System.Drawing.Size(121, 21);
            this.Merkki.TabIndex = 7;
            // 
            // Malli
            // 
            this.Malli.FormattingEnabled = true;
            this.Malli.Location = new System.Drawing.Point(283, 163);
            this.Malli.Name = "Malli";
            this.Malli.Size = new System.Drawing.Size(121, 21);
            this.Malli.TabIndex = 8;
            this.Malli.Click += new System.EventHandler(this.Malli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Merkki:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(246, 167);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(31, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Malli:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(611, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(482, 167);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(123, 13);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Rekisteröintipäivämäärä:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Uusi tietue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Tallenna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Tyhjennä";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Polttoaine
            // 
            this.Polttoaine.FormattingEnabled = true;
            this.Polttoaine.Location = new System.Drawing.Point(91, 242);
            this.Polttoaine.Name = "Polttoaine";
            this.Polttoaine.Size = new System.Drawing.Size(121, 21);
            this.Polttoaine.TabIndex = 18;
            this.Polttoaine.Click += new System.EventHandler(this.Polttoaine_Click);
            // 
            // Väri
            // 
            this.Väri.FormattingEnabled = true;
            this.Väri.Location = new System.Drawing.Point(280, 242);
            this.Väri.Name = "Väri";
            this.Väri.Size = new System.Drawing.Size(121, 21);
            this.Väri.TabIndex = 19;
            this.Väri.Click += new System.EventHandler(this.Väri_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Polttoaine:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Väri:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 159);
            this.dataGridView1.TabIndex = 22;
            // 
            // Paivita
            // 
            this.Paivita.Location = new System.Drawing.Point(751, 237);
            this.Paivita.Name = "Paivita";
            this.Paivita.Size = new System.Drawing.Size(75, 23);
            this.Paivita.TabIndex = 23;
            this.Paivita.Text = "Päivitä";
            this.Paivita.UseVisualStyleBackColor = true;
            this.Paivita.Click += new System.EventHandler(this.Paivita_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 442);
            this.Controls.Add(this.Paivita);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Väri);
            this.Controls.Add(this.Polttoaine);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Malli);
            this.Controls.Add(this.Merkki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hinta);
            this.Controls.Add(this.Tilavuus);
            this.Controls.Add(this.Mittarilukema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.TextBox Mittarilukema;
        private System.Windows.Forms.TextBox Tilavuus;
        private System.Windows.Forms.TextBox Hinta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Merkki;
        private System.Windows.Forms.ComboBox Malli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Polttoaine;
        private System.Windows.Forms.ComboBox Väri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Paivita;
    }
}