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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // original code used to generate table data
            /*
            using (db)
            {
                
                Character c1 = new Character() { Name = "Bestel", LocationName = "Lioneye's Watch", CharacterImage="/images/Bestel_npc_screenshot.jpg" };
                Character c2 = new Character() { Name = "Dominus", LocationName = "Upper Sceptre of God", CharacterImage="/images/444px-Dominus_screenshot.png" };

                Character c3 = new Character() { Name = "Tandi", LocationName = "Shady Sands", CharacterImage="/images/FO01_NPC_Tandi_N.png"};
                Character c4 = new Character() { Name = "The Master", LocationName="Los Angeles Vault", CharacterImage="/images/FO01_NPC_Master_B.png"};

                ComputerGame g1 = new ComputerGame() { Name="Path of Exile", Genre="ARPG, MMORPG"};
                ComputerGame g2 = new ComputerGame() { Name="Fallout 1", Genre="CRPG, Isometric, Turn-Based"};

                g1.Characters.Add(c1);
                g1.Characters.Add(c2);

                g2.Characters.Add(c3);
                g2.Characters.Add(c4);

                db.Games.Add(g1);
                db.Games.Add(g2);

                db.SaveChanges();

            }
            */
            
            var query = from b in db.Games
                        select b;

            gamesLbx.ItemsSource = query.ToList();
            
        }

        private void gamesLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int id = Convert.ToInt32(gamesLbx.SelectedValue);

            if (id > 0)
            {
                var query = from g in db.Characters
                            where g.ComputerGameId == id
                            select g;

                charactersLbx.ItemsSource = query.ToList();
            }
        }

        private void charactersLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            charImg.Source = new BitmapImage(new Uri((string)charactersLbx.SelectedValue, UriKind.Relative));
        }
    }
}
