namespace WinFormsApp1
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

        int[] Bubble(int[] tab)

        {
            int temp;
            bool cbz;
            do
            {
                cbz = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        cbz = true;
                    }
                }
            } while (cbz);

            return tab;
        }

        void Select(int[] tab)
        {
            int minIndex;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[minIndex] > tab[j])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = tab[minIndex];
                    tab[minIndex] = tab[i];
                    tab[i] = temp;
                }
            }
        }

        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var wynik = new int[liczbyS.Length];
            for (int i =0; i<liczbyS.Length; i++)
            {
                wynik[i] =int.Parse(liczbyS[i]);
            }
            return wynik;
        }
    }
}