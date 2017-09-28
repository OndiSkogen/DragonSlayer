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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        Player player;
        private int level;
        Dragon dragon;

        public Game(Player p1)
        {
            player = p1;
            level = 1;
            dragon = new Dragon(level);
            InitializeComponent();
            UpdateStats();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            dragon.TakeDmg(player.Attack);
            player.TakeDmg(dragon.Attack());
            if (player.HitPoints <= 0)
            {
                this.Close();
                MessageBox.Show("You died!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else if (dragon.HitPoints <= 0)
            {
                level++;
                dragon = new Dragon(level);
                player.ResetHPAndMana(player.SlayerClass);
            }
            UpdateStats();
        }

        private void Magic_Click(object sender, RoutedEventArgs e)
        {
            dragon.TakeDmg(player.MagicAttack());
            player.TakeDmg(dragon.Attack());
            if (player.HitPoints <= 0)
            {
                this.Close();
                MessageBox.Show("You died!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else if (dragon.HitPoints <= 0)
            {
                level++;
                dragon = new Dragon(level);
                player.ResetHPAndMana(player.SlayerClass);
            }
            UpdateStats();
        }

        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            player.Heal();
            player.TakeDmg(dragon.Attack());
            if (player.HitPoints <= 0)
            {
                this.Close();
                MessageBox.Show("You died!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            UpdateStats();
        }

        private void UpdateStats()
        {
            PlayerHP.Text = player.HitPoints.ToString();
            PlayerMana.Text = player.Mana.ToString();
            DragonHP.Text = dragon.HitPoints.ToString();
            DragonLevel.Text = level.ToString();
        }
    }
}
