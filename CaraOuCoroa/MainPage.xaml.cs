namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SidePicker.SelectedIndex = 0;
        }

        private void CoinFlipButton_Clicked(object sender, EventArgs e)
        {
            string Escolha = SidePicker.SelectedItem.ToString();

            int choice = 0;
            if (Escolha == "COROA") choice = 1;
            int rnd = new Random().Next(0, 2);
            string resultado = "";
            if(rnd == 0)
            {
                resultado = "CARA";
                CoinImage.Source = "cara.jpg";
            } else
            {
                resultado = "COROA";
                CoinImage.Source = "coroa.jpg";
            }

            if(rnd == choice)
            {
                ResultLabel.Text = $"Iupi!! Deu {resultado}, você ganhou!!";
            }
            else
            {
                ResultLabel.Text = $"Poxa. Deu {resultado}, você perdeu.";
            }
        }
    }

}
