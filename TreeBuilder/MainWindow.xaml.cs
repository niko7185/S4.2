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

namespace TreeBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {

        private Stack<Grid> treeLevels;

        public MainWindow()
        {
            InitializeComponent();

            treeLevels = new Stack<Grid>();

            BuildMaxHeap();

        }

        private Grid BuildTree(BinaryTreeNode<int> node)
        {

            Border left = new Border();

            left.BorderThickness = new Thickness(2, 2, 0, 0);

            Border right = new Border();

            right.BorderThickness = new Thickness(0, 2, 2, 0);

            left.BorderBrush = Brushes.Black;

            left.Margin = new Thickness(0, 25, 0, 0);

            left.Height = 50;

            right.BorderBrush = Brushes.Black;

            right.Margin = new Thickness(0, 25, 0, 0);

            right.Height = 50;

            Label label = new Label();

            label.Content = node.Value;
            label.FontSize = 8;
            label.Padding = new Thickness(5);
            label.HorizontalContentAlignment = HorizontalAlignment.Center;
            label.Margin = new Thickness(0, 0, 0, 40);
            label.BorderBrush = Brushes.Black;
            label.BorderThickness = new Thickness(2);

            ColumnDefinition star = new ColumnDefinition();
            star.Width = new GridLength(1, GridUnitType.Star);

            ColumnDefinition auto = new ColumnDefinition();
            auto.Width = new GridLength(1, GridUnitType.Auto);

            Grid leftChild = new Grid();
            Grid rightChild = new Grid();

            if(node.LeftChild != null)
                leftChild = BuildTree(node.LeftChild);

            if(node.RightChild != null)
                rightChild = BuildTree(node.RightChild);

            Grid grid = new Grid();

            grid.ColumnDefinitions.Add(star);
            grid.ColumnDefinitions.Add(auto);
            grid.ColumnDefinitions.Add(star);

            grid.Children.Add(left);
            Grid.SetColumn(left, 0);

            grid.Children.Add(label);
            Grid.SetColumn(label, 1);

            grid.Children.Add(right);
            Grid.SetColumn(right, 2);

            if(node.Parent == null)
                treeLevels.Push(grid);

            if(!node.isEmpty)
            {

                if(leftChild.ColumnDefinitions.Count < rightChild.ColumnDefinitions.Count)
                {

                    for(int i = 0; i < rightChild.ColumnDefinitions.Count; i++)
                    {

                        leftChild.ColumnDefinitions.Add(rightChild.ColumnDefinitions[i]);

                        if(i < rightChild.Children.Count)
                        {
                            var child = rightChild.Children[i];

                            leftChild.Children.Add(child);

                            Grid.SetColumn(child, leftChild.ColumnDefinitions.Count - 1);

                        }

                    }

                    return leftChild;
                }
                else
                {
                    for(int i = 0; i < leftChild.ColumnDefinitions.Count; i++)
                    {

                        rightChild.ColumnDefinitions.Add(leftChild.ColumnDefinitions[i]);

                        if(i < leftChild.Children.Count)
                        {
                            var child = leftChild.Children[i];

                            rightChild.Children.Add(child);

                            Grid.SetColumn(child, rightChild.ColumnDefinitions.Count - 1);

                        }

                    }

                    return rightChild;
                }


            }


            return grid;
        }

        public void BuildMaxHeap()
        {

            MaxHeap<int> maxHeap = new MaxHeap<int>(new BinaryTreeNode<int>(100));

            maxHeap.Insert(53);
            maxHeap.Insert(85);
            maxHeap.Insert(65);
            maxHeap.Insert(54);
            maxHeap.Insert(83);
            maxHeap.Insert(97);

            treeLevels = new Stack<Grid>();

            treePanel.Children.Clear();

            BuildTree(maxHeap.Root);

            for(int i = 0; i < treeLevels.Count; i++)
            {
                treePanel.Children.Add(treeLevels.Pop());
            }

        }


    }
}
