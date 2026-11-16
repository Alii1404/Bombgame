namespace PanelCreate
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel gameArea;
        private Panel bottomPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gameArea = new Panel();
            pictureBox1 = new PictureBox();
            bottomPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gameArea
            // 
            gameArea.BackColor = Color.White;
            gameArea.Controls.Add(pictureBox1);
            gameArea.Dock = DockStyle.Fill;
            gameArea.Location = new Point(0, 0);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(857, 456);
            gameArea.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(65, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.Gray;
            bottomPanel.Controls.Add(label1);
            bottomPanel.Controls.Add(label2);
            bottomPanel.Controls.Add(button1);
            bottomPanel.Controls.Add(button2);
            bottomPanel.Controls.Add(button3);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 456);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(857, 66);
            bottomPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 0;
            label1.Text = "Xal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(104, 27);
            label2.Name = "label2";
            label2.Size = new Size(17, 19);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(206, 15);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 2;
            button1.Text = "Panel yarat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(395, 15);
            button2.Name = "button2";
            button2.Size = new Size(224, 40);
            button2.TabIndex = 3;
            button2.Text = "Bombanın yerini dəyiş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(674, 15);
            button3.Name = "button3";
            button3.Size = new Size(138, 40);
            button3.TabIndex = 4;
            button3.Text = "Çıxış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 522);
            Controls.Add(gameArea);
            Controls.Add(bottomPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanelCreate";
            gameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
