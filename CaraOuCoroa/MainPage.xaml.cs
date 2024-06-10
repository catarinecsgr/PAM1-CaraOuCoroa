using CaraOuCoroa.Models;

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
            string escolha = SidePicker.SelectedItem.ToString();
            string sorteado = new Coin().Girar();
            CoinImage.Source = sorteado.ToLower()+".jpg";
            ResultLabel.Text = escolha == sorteado ? $"Parabéns! Deu {sorteado}, você ganhou!" : $"Que pena, deu {sorteado}, você perdeu!";
        }
    }

}
