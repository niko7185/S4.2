using DataStructures;
using System;
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

namespace TowersOfHanoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {

        private ViewModel view;
        private Grid[] pins;
        private int selectedPin;

        public MainWindow()
        {
            InitializeComponent();

            pins = new Grid[] { pinOne, pinTwo, pinThree };

            view = new ViewModel();

            DataContext = view;

            selectedPin = -1;

            SetDisks();

        }

        private void PinDrop(object sender, DragEventArgs e)
        {

        }

        private void DiskMove(object sender, MouseButtonEventArgs e)
        {

            Grid pin = (Grid)sender;
            Int32.TryParse(pin.Uid.Last().ToString(), out int pinNumber);

            if(selectedPin > -1)
            {

                bool moved = view.PlaceDisk(pinNumber, selectedPin);

                if(moved)
                {

                    SwitchDisks(pinNumber, selectedPin);

                    if(view.Stacks[2].Count == view.RingNumber)
                    {
                        MessageBox.Show("Well done! You win", "You win", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                }

                pins[selectedPin].Background = Brushes.Transparent;

                selectedPin = -1;
            }
            else
            {

                if(pin.Children.Count <= 1)
                    return;

                selectedPin = pinNumber;

                pin.Background = Brushes.LightGreen;
            }

        }

        public void SetUpRings(Stack<int> stack, int pinNumber)
        {

            if(stack.Count == 0)
            {
                return;
            }

            int diskNumber = stack.Pop();

            AddDisk(diskNumber, pinNumber, stack.Count);

            SetUpRings(stack, pinNumber);

        }

        public void SetDisks()
        {

            for(int i = view.RingNumber; i > 0; i--)
            {
                view.PlaceDisk(0, 1, i);
            }

            Stack<int> stack = view.Stacks[0].Clone() as Stack<int>;

            if(stack != null)
            {

                SetUpRings(stack, 0);
            }

        }

        public void AddDisk(int diskNumber, int pinNumber, int count)
        {

            Border disk = new Border();

            disk.Background = Brushes.Black;
            disk.CornerRadius = new CornerRadius(10);

            int diskSize = 85 - (diskNumber * 10);

            disk.Margin = new Thickness(diskSize, 1, diskSize, 1);

            disk.Uid = "disk-" + diskNumber;

            pins[pinNumber].Children.Add(disk);

            Grid.SetRow(disk, 7 - count);

            Grid.SetZIndex(disk, 1);

        }

        public void SwitchDisks(int newStack, int oldStack)
        {

            int diskNumber = view.Stacks[newStack].Peek();

            AddDisk(diskNumber, newStack, view.Stacks[newStack].Count - 1);

            for(int i = 1; i < pins[oldStack].Children.Count; i++)
            {
                Int32.TryParse(pins[oldStack].Children[i].Uid.Last().ToString(), out int displayDiskNumber);

                if(displayDiskNumber == diskNumber)
                {
                    pins[oldStack].Children.RemoveAt(i);

                    break;
                }

            }

        }

        private void ResetTowers(object sender, RoutedEventArgs e)
        {

            for(int i = 0; i < 3; i++)
            {
                pins[i].Children.Clear();

                Border pin = new Border();

                pin.Width = 10;
                Grid.SetRowSpan(pin, 8);
                Panel.SetZIndex(pin, 0);
                pin.CornerRadius = new CornerRadius(5, 5, 0, 0);
                pin.Background = Brushes.DarkRed;

                pins[i].Children.Add(pin);

                view.ResetStacks(i);
            }

            SetDisks();
        }
    }
}
