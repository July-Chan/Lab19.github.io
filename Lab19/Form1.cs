namespace Lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strings = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] stringCounts = new int[strings.Length];
            int duplicateCount = 1;
            int n;

            //Пошук однакових рядків
            for (int i = 0; i < strings.Length; i++)
            {
                
                if (stringCounts[i] != 0)
                    continue;

                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (string.Equals(strings[i], strings[j]))
                    {
                        stringCounts[i]++;
                    }
                }
                if (stringCounts[i] != 0)
                {
                    duplicateCount++;
                }

            }
            textBox2.Text = duplicateCount.ToString();

            if (!int.TryParse(textBox4.Text, out n))
            {
                MessageBox.Show("Введіть ціле число 'n' у поле 'n'.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sameStartCount = 0;
            //Пошук однакових рядків за n
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (strings[i].Length >= n && strings[j].Length >= n && strings[i].Substring(0, n) == strings[j].Substring(0, n))
                    { 
                        sameStartCount++;
                    }
                }
            }


            textBox3.Text = sameStartCount.ToString();
        }
    }
}