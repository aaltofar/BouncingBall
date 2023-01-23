namespace BouncingBall
{
    internal class Rectangle
    {
        private int _col;
        private int _row;
        private int _speedCol;
        private int _speedRow;
        private int _width;
        private int _height;

        public Rectangle(int col, int row, int speedCol, int speedRow, int width, int height)
        {
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
            _width = width;
            _height = height;
        }

        public void Show()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.CursorLeft = _col + i;
                    Console.CursorTop = _row + j;
                    Console.Write("M");
                }
            }
        }

        public void Move()
        {
            _col += _speedCol;
            _row += _speedRow;
            if (_col <= 0 || _col >= Console.WindowWidth - _width) _speedCol = -_speedCol;
            if (_row <= 0 || _row >= Console.WindowHeight - _height) _speedRow = -_speedRow;
        }
    }
}