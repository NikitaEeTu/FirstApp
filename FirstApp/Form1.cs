using System.CodeDom;

namespace FirstApp
{
    public partial class Form1 : Form
    {

        Image[] image_arr = new Image[6] { Properties.Resources.dice1, Properties.Resources.dice__5_1, Properties.Resources.dice__4_1, Properties.Resources.dice__3_1, Properties.Resources.dice__2_1, Properties.Resources.dice__1_1 };


        private String determineAWinner(int first_player_number, int second_player_number)
        {

            if(first_player_number > second_player_number)
            {
                return "First player won";
            }

            else if(first_player_number < second_player_number)
            {
                return "Second player won";
            }
            else
            {
                return "Draw";
            }
        }

        private int generateRandomNumber(int min, int max)
        {
            Random rnd = new Random();

            int random_number = rnd.Next(min, max);

            return random_number;
        }
        private Image getRandomImage(Image[] arrWithImages, int randomNumber)
        {
            Random rnd = new Random();

            int random_number = rnd.Next(0, arrWithImages.Length);

            return arrWithImages[random_number];
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int firstUserRandomNumber = generateRandomNumber(0, image_arr.Length);
            int secondUserRandomNumber = generateRandomNumber(0, image_arr.Length);


            pictureBox3.Image = getRandomImage(image_arr, firstUserRandomNumber);
            pictureBox4.Image = getRandomImage(image_arr, secondUserRandomNumber);

            textBox1.Text = determineAWinner(firstUserRandomNumber, secondUserRandomNumber);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (pictureBox3.Visible && pictureBox4.Visible)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                button2.Text = "Show images";
            }
            else
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                button2.Text = "Hide images";
            }


        }
    }
}