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

namespace Warmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainView _mainView;
        public MainWindow()
        {
            InitializeComponent();
            _mainView = DataContext as MainView;
            

        }
        private void ArmSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            double result = 0;
            Scmenum bestResult = new Scmenum(0.0,0,0,0);
            for (int AttDie = 0; AttDie <= 3; AttDie++)
            {
                double attChance = AttChanceFinder(2+AttDie,_mainView.att);                
                for (int POWDie = 0; POWDie <=3; POWDie++)
                {
                    for (int ExtraAttacks = 0; ExtraAttacks <= 3; ExtraAttacks++)
                    {
                        if ((AttDie + POWDie + ExtraAttacks) <= 3)
                        {
                            result = (double)_mainView.arm + (double)POWDie*3.5;
                            if (result > bestResult.Result)
                                bestResult = new Scmenum(result,AttDie, POWDie, ExtraAttacks);
                        }
                    }
                }
            }
            OutBox.Text = bestResult.ResultString;
        }
        public double AttChanceFinder(int NumberOfDice, int ValueIn)
        {
            int testScore = 0;
            List<Die> Dice = new List<Die>();
            List<int> dieResults = new List<int>();
            int dieResult = 0;
            for (int i = 1; i <= NumberOfDice; i++)
            {
                Dice.Add(new Die());
            }
            int DieCounter = 1;
            while (DieCounter<=NumberOfDice)
            {
                dieResult = 0;
                foreach (Die d in Dice)
                {                    
                    dieResult += (d.getCurrentSide());
                }
                dieResults.Add(dieResult);
                if (dieResult >= ValueIn)
                    testScore++;
                if (Dice[DieCounter-1].isLastSide())
                {
                    DieCounter++;
                }
            }
            double test1 = Math.Pow(6, NumberOfDice);
            double test2 = (testScore / (Math.Pow(6, NumberOfDice)));

            return (testScore/(Math.Pow(6, NumberOfDice)));
        }
    }
    
}
