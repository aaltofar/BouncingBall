using BouncingBall;

var ball = new Ball(15, 3, 1, 1);
Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    ball.Show();
    ball.Move();
    Thread.Sleep(50);
}