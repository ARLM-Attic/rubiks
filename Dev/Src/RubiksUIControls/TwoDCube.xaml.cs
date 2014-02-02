using RubiksCore;
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

namespace RubiksUIControls
{
    /// <summary>
    /// Interaction logic for TwoDCube.xaml
    /// </summary>
    public partial class TwoDCube : UserControl
    {
        private int _gridSquareSize = 50;

        public TwoDCube()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty CubeProperty =
            DependencyProperty.Register("Cube", typeof(RubiksCube), typeof(TwoDCube),
            new PropertyMetadata(RubiksCubeSet));

        private static void RubiksCubeSet(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TwoDCube)d).InitializeCube((RubiksCube)e.NewValue);
        }

        public RubiksCube Cube
        {
            get
            {
                return (RubiksCube)GetValue(CubeProperty);
            }
            set
            {
                SetValue(CubeProperty, value);
            }
        }

        private void InitializeCube(RubiksCube cube)
        {
            for(int row = 0; row < cube.CubeSize * 3; row++)
            {
                _cubeGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(_gridSquareSize) });
            }

            for(int column = 0; column < cube.CubeSize * 4; column++)
            {
                _cubeGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(_gridSquareSize) });
            }

            foreach(TwoDPosition position in CreatePositionsForCube())
            {
                CreateRect(cube.GetColor(position), position.Y, position.X);
            }
        }

        private void CreateRect(Color color, int rowNumber, int columnNumber)
        {
            Border border = new Border();
            border.CornerRadius = new CornerRadius(1);
            border.BorderBrush = new SolidColorBrush(Colors.Black);
            border.BorderThickness = new Thickness(3);
            
            Rectangle rect = new Rectangle();
            rect.Fill = new SolidColorBrush(color);

            border.Child = rect;

            _cubeGrid.Children.Add(border);
            Grid.SetColumn(border, columnNumber);
            Grid.SetRow(border, rowNumber);
        }

        private IEnumerable<TwoDPosition> CreatePositionsForCube()
        {
            List<TwoDPosition> positions = new List<TwoDPosition>();

            for (int y = Cube.CubeSize - 1; y <= Cube.CubeSize * 2 - 1; y++)
            {
                for(int x = 0; x < Cube.CubeSize * 4 - 1; x++)
                {
                    positions.Add(new TwoDPosition(x, y));
                }
            }



            return positions;
        }
    }
}
