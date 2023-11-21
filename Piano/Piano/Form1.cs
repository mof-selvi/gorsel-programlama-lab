using System.Collections;

namespace Piano
{
    public partial class Form1 : Form
    {
        ArrayList buttons;
        public Form1()
        {
            InitializeComponent();
        }

        private void GeneratePianoButtons(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            buttons = new ArrayList();

            int numOfButtons = 50;

            //siyah tuþlar
            for (int i = 0; i < numOfButtons; i++)
            {
                if( (i+1) % 7 == 3 || (i+1) % 7 == 0)
                {
                    continue;
                }
                Button button = new Button();
                button.Text = "" + i;
                button.Location = new Point(50 * i + 50 + 25, 50);
                button.Size = new Size(50, 60);
                button.BackColor = Color.DarkRed;
                button.ForeColor = Color.White;
                button.Visible = true;
                button.BringToFront();
                this.Controls.Add(button);

                button.TextAlign = ContentAlignment.BottomCenter;
                buttons.Add(button);
            }

            //beyaz tuþlar
            for (int i = 0; i < numOfButtons; i++)
            {
                Button button = new Button();
                button.Text = "" + i;
                button.Location = new Point(50 * i + 50, 50);
                button.Size = new Size(50, 120);
                button.BackColor = Color.Turquoise;
                button.ForeColor = Color.Black;
                button.Visible = true;
                button.BringToFront();
                this.Controls.Add(button);

                button.TextAlign = ContentAlignment.BottomCenter;
                buttons.Add(button);
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            foreach (Button btn in buttons)
            {
                btn.Location = new Point(btn.Location.X-25, btn.Location.Y);
            }
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            foreach (Button btn in buttons)
            {
                btn.Location = new Point(btn.Location.X + 25, btn.Location.Y);
            }
        }
    }
}