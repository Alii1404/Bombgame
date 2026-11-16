using System.Runtime.InteropServices;

namespace PanelCreate
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int count = 0;
        bool gameOver = false;

        [DllImport("winmm.dll", CharSet = CharSet.Auto)]
        private static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);

        private const uint SND_ASYNC = 0x0001;
        private const uint SND_FILENAME = 0x00020000;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Assets", "bomba.png"));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            label2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;

            Panel p = new Panel();
            p.Size = new Size(50, 50);
            p.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            p.Location = new Point(r.Next(0, gameArea.Width - p.Width),
                                   r.Next(0, gameArea.Height - p.Height));
            gameArea.Controls.Add(p);
            p.BringToFront();
            count++;
            label2.Text = count.ToString();

            Yoxla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;

            pictureBox1.Location = new Point(r.Next(0, gameArea.Width - pictureBox1.Width),
                                             r.Next(0, gameArea.Height - pictureBox1.Height));
            pictureBox1.BringToFront();
            Yoxla();
        }

        private void Yoxla()
        {
            foreach (Control c in gameArea.Controls)
            {
                if (c is Panel && c.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    OyunuBitir();
                    break;
                }
            }
        }

        private void OyunuBitir()
        {
            if (gameOver)
                return;

            gameOver = true;
            count = 0;
            label2.Text = "0";

            string ses = Path.Combine(Application.StartupPath, "Assets", "bomba.wav");
            PlaySound(ses, IntPtr.Zero, SND_FILENAME | SND_ASYNC);

            DialogResult d = MessageBox.Show(
                "Bomba panelə toxundu. Oyun bitdi!\nYeni oyun başlasın?",
                "Oyun bitdi",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (d == DialogResult.OK)
                YeniOyun();
        }

        private void YeniOyun()
        {
            for (int i = gameArea.Controls.Count - 1; i >= 0; i--)
            {
                if (gameArea.Controls[i] is Panel)
                    gameArea.Controls.RemoveAt(i);
            }

            count = 0;
            label2.Text = "0";
            pictureBox1.Location = new Point(65, 180);
            gameOver = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
                "Proqramdan çıxış edilsinmi?",
                "Bildiriş",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
                Close();
        }
    }
}
