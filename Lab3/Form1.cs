namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncDate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = txtDate.Text.Split('.');
                int d = int.Parse(parts[0]);
                int m = int.Parse(parts[1]);
                int y = int.Parse(parts[2]);

                Triad myDate = new Date(d, m, y);
                myDate.Increase();

                lblResultDate.Text = myDate.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка! Введіть дату у форматі ДД.ММ.РРРР");
            }
        }

        private void btnIncTime_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = txtTime.Text.Split(':');
                int h = int.Parse(parts[0]);
                int m = int.Parse(parts[1]);
                int s = int.Parse(parts[2]);

                Triad myTime = new Time(h, m, s);
                myTime.Increase();

                lblResultTime.Text = myTime.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка! Введіть час у форматі ГГ:ХХ:СС");
            }
        }
    }
}
