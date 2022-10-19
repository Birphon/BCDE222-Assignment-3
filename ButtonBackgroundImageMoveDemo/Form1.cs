using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessMazeUI
{
    public partial class Form1 : Form
    {

        // private Image _character = Image.FromFile(@"..\..\..\Resources\ninja-simple-512.png");
        // Application.ExecutablePath       

        /* 
         * Access Resources folder of the project
         * 1. In Solution Explorer, double click ProjectNameSpace -> Properties -> Resources.resx
         * 2. Click Add Resources menu to add new image resource named as imageName
         * 3. access the new added resource by ProjectNameSpace.Properties.Resources.imageName
         */
        private readonly Image _character = ChessMazeUI.Properties.Resources.ninja;
        private int _currentPosition = 0;
        private readonly Button[] _gridOfButtons;

        public Form1()
        {
            InitializeComponent();

            _gridOfButtons = new Button[] { button1, button2, button3, button5, button6, button7, button8, button9, button10 };
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Text = $"Button {button.Name.Replace("button", "")} has been clicked.";
            _gridOfButtons[_currentPosition].BackgroundImage = null;

            _gridOfButtons[_currentPosition] = button;
            _gridOfButtons[_currentPosition].BackgroundImage = _character;
            _gridOfButtons[_currentPosition].BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
