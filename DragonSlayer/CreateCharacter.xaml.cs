using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DragonSlayer
{
    /// <summary>
    /// Interaction logic for CreateCharacter.xaml
    /// </summary>
    public partial class CreateCharacter : Window
    {
        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem temp = (ListBoxItem)type.SelectedItem;
            
            if (temp == null || characterName.Text == null)
            {
                MessageBox.Show("Fill in both name and class");
            }
            else
            {
                string slayerName = characterName.Text;
                string slayerClass = temp.Content.ToString();
                Player player1 = new Player(slayerName, slayerClass);
                Game game = new Game();
                game.Show();
                this.Close();
            }            
        }
    }
}
