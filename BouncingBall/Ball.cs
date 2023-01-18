namespace BouncingBall
{
    internal class Ball
    {
        private int _col;
        private int _row;
        private int _speedCol;
        private int _speedRow;

        public Ball(int col, int row, int speedCol, int speedRow)
        {
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
        }

        public void Show()
        {
            Console.CursorLeft = _col;
            Console.CursorTop = _row;
            Console.Write("O");
        }

        public void Move()
        {
            _col += _speedCol;
            _row += _speedRow;
            if (_col <= 0 || _col >= Console.WindowWidth-1) _speedCol = -_speedCol;
            if (_row <= 0 || _row >= Console.WindowHeight-1) _speedRow = -_speedRow;
        }
    }
}
