using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessMazeUI
{
    public partial class Form1 : Form
    {

        private readonly Image _character = ChessMazeUI.Properties.Resources.ninja;
        private int _currentPosition = 0;
        private readonly Button[] _gridOfButtons;
        private int _count = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "3x3 Game";
            MoveLbl.Text = "Move count is: 0";
            _gridOfButtons = new Button[] { button1, button2, button3, button5, button6, button7, button8, button9, button10 };
        }

        private int MoveCount()
        {
            _count++;
            MoveLbl.Text = $"Move count is: {_count}";
            return _count;
        }

        private void button_Click(object sender, EventArgs e)
        {
            MoveCount();
            Button button = (Button)sender;
            Text = $"Button {button.Name.Replace("button", "")} has been clicked.";
            _gridOfButtons[_currentPosition].BackgroundImage = null;

            _gridOfButtons[_currentPosition] = button;
            _gridOfButtons[_currentPosition].BackgroundImage = _character;
            _gridOfButtons[_currentPosition].BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }
    }
}
