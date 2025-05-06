namespace _8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] A = new int[5];

            Random rand = new Random();

            for (int i = 0; i < A.Length; i=i+1)
                A[i] = rand.Next(1, 201);

            label1.Text = string.Join(", ", A);
        }
    }
}
