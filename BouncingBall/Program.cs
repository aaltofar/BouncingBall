using BouncingBall;

var random = new Random();
var rectangleList = new List<BouncingBall.Rectangle>();

for (int i = 0; i < random.Next(3, 7); i++)
{
    var rectangle = new Rectangle(random.Next(1, 100), random.Next(1, 15), 1, 1, random.Next(3, 10), random.Next(3, 10));
    rectangleList.Add(rectangle);
}

Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    foreach (var rectangle in rectangleList)
    {
        rectangle.Show();
        rectangle.Move();
    }

    Thread.Sleep(50);
}