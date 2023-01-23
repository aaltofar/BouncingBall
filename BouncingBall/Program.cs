using BouncingBall;

var rectangle = new Rectangle(15, 3, 1, 1, 4, 3);
Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    rectangle.Show();
    rectangle.Move();
    Thread.Sleep(50);
}