using System.Windows.Forms;

namespace Palindrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        
        private void button1_Click(object sender, EventArgs e)
        {
           int sayac = 0;
             string cumle = "";

             cumle = textBox1.Text;
            cumle= cumle.ToLower();
             List<char> normal_cumle = new List<char>();
             List<char> yeni_cumle= new List<char>();
             for (int i = 0; i < cumle.Length; i++) 
             {
                 if (cumle[i] != ' ') 
                 {
                     normal_cumle.Add(cumle[i]);
                    
                 }
             }

             for (int i = cumle.Length-1; i >= 0; i--) 
             {
                 if (cumle[i] != ' ')
                     yeni_cumle.Add(cumle[i]);
             }

             for (int i = 0; i < yeni_cumle.Count; i++) 
             {
                 if (yeni_cumle[i] == normal_cumle[i])
                     sayac++;
             }
             if (yeni_cumle.Count == sayac)
                 textBox2.Text= "Cümle palindromdur.";
             else
                 textBox2.Text= "Cümle palindrom deðildir.";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Cümlenizi Giriniz.";
            textBox1.Text = "";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}