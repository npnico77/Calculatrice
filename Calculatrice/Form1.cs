namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation;
        double number1;
        double number2;
        double resultat;
        bool virgule=false;

        private void buttonChiffre_Click(object sender, EventArgs e)
        {
           Button bt = (Button)sender; 
            
            if (ecran.Text.Equals("0"))
            {
                ecran.Text = bt.Text;               
            }
            else
            {
                ecran.Text += bt.Text;
            }
            resultatComplet.Text += bt.Text;
        }
        private void buttonVirgule_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (virgule == false)
            {
                ecran.Text += bt.Text;
                virgule = true;
                resultatComplet.Text += bt.Text;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ecran.Text = "0";
            resultatComplet.Text = "";
            virgule = false;
        }

        private void buttonOperateur_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            number1 = Convert.ToDouble(ecran.Text);
            ecran.Text = "0";
            operation = bt.Text;
            resultatComplet.Text += bt.Text;
            virgule= false;
        }
        private void buttonSigne_Click(object sender, EventArgs e)
        {
            double nbre = Convert.ToDouble(ecran.Text);
            if(Math.Sign(nbre) == -1)
            {
                ecran.Text = ecran.Text.Remove('-');
            }
            else
            {
                if (ecran.Text.Equals("0"))
                {
                    ecran.Text = "-";
                    resultatComplet.Text = "-";
                }
                else
                {
                    ecran.Text = "-" + ecran.Text;
                    resultatComplet.Text += "-";
                }
            }
        }
        private void buttonEgal_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(ecran.Text);
            virgule = false;
            switch (operation)
            {
                case "+" :
                    resultat = number1 + number2;
                    ecran.Text = Convert.ToString(resultat);
                    break;

                case "-":
                    resultat = number1 - number2;
                    ecran.Text = Convert.ToString(resultat);
                    break;

                case "/":
                    resultat = number1 / number2;
                    ecran.Text = Convert.ToString(resultat);
                    break;

                case "*":
                    resultat = number1 * number2;
                    ecran.Text = Convert.ToString(resultat);
                    break;

                default:
                    ecran.Text = "0";
                    resultatComplet.Text = "0";
                    break;
            }
            resultatComplet.Text += "=" + Convert.ToString(resultat);
        }

    }
}