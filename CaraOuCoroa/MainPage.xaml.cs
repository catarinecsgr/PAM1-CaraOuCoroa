namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SidePicker.SelectedIndex = 0;
        }

        private async void CoinFlipButton_Clicked(object sender, EventArgs e)
        {
            string Escolha = SidePicker.SelectedItem.ToString();

            int choice = 0;
            if (Escolha == "CARA") choice = 1;

            int rnd = new Random().Next(0, 2);
            string resultado = "CARA";
            if(rnd == 0) resultado = "COROA";

            if (rnd == choice)
            {
                ResultLabel.Text = $"EBA!! Deu {resultado} Você ganhou!";
            } else
            {
                ResultLabel.Text = $"Deu {resultado}, você perdeu! HAHAHAH >:D";
            }
        }
    }

}
