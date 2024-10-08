namespace Cezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char[] alfabet = ['a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż'];

        private void button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb1 = new System.Text.StringBuilder(); // Tworzymy StringBuilder, żeby łatwo zrobić linię tekstu bez znaków specjalnych
            string tekst1 = textBox1.Text; // Z wprowadzonego tekstu robimy zmienną 
            foreach (char c in tekst1)
            {
                if (char.IsLetter(c))  // Sprawdzamy, czy każdy znak wprowadzonego tekstu jest literą
                    sb1.Append(char.ToLower(c)); // Jeśli tak, to dodajemy do StringBuilder'a tą litęrę. Ta litera może być duża, więc korzystamy z ToLower()
            }
            tekst1 = sb1.ToString(); // Znów robimy ze StringBuilder'a stringa

            System.Text.StringBuilder sb2 = new System.Text.StringBuilder(); // Tworzymy drugi StringBuilder, żeby deszyfrowany tekst łatwo dodać do textBox'u
            int klucz = (int)numericUpDown1.Value; // Robimy klucz int'em 
            foreach (char c in tekst1)
            {
                int indeks = Array.IndexOf(alfabet, c); // Szukamy indeksy każdej literki z otrzymanej linii tekstu w tablicy z alfabetem  
                if (indeks != -1) // Sprawdzamy, czy na pewno literka jest w alfabecie
                {
                    char d = alfabet[(indeks + klucz) % alfabet.Length]; // Zapisujemy deszyfrowaną literkę i zapewniamy się, że alfabet się zapętla jak indeks dojdzie do końca
                    sb2.Append(d); // Dodajemy otrzymaną literę do drugiego StringBuilder'a 
                }
            }
            textBox3.Clear();
            textBox3.Text += sb2.ToString(); // Dodajemy deszyfrowany tekst do odpowiedniego textBox'u

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb1 = new System.Text.StringBuilder(); 
            string tekst2 = textBox2.Text; 
            foreach (char c in tekst2)
            {
                if (char.IsLetter(c))  
                    sb1.Append(char.ToLower(c)); 
            }
            tekst2 = sb1.ToString(); 

            System.Text.StringBuilder sb2 = new System.Text.StringBuilder(); 
            int klucz = (int)numericUpDown2.Value;  
            foreach (char c in tekst2)
            {
                int indeks = Array.IndexOf(alfabet, c); 
                if (indeks != -1) 
                {
                    char d = alfabet[(indeks - klucz + alfabet.Length) % alfabet.Length]; 
                    sb2.Append(d); 
                }
            }
            textBox4.Clear();
            textBox4.Text += sb2.ToString(); 
        }
    }
}
