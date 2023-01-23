using BouncingBall;

var rectangle = new Rectangle(20, 10, 1, 1);
Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    rectangle.Show();
    rectangle.Move();
    Thread.Sleep(50);
}



//Oppgave 1
//Ta utgangspunkt i denne koden: github.com / GetAcademy / BouncingBall
//Skriv om så det er et rektangel med bredde 4 og høyde 3 som spretter rundt. 
//    Du kan tegne et rektangel med en bokstav du velger, for eksempel med #:
//####
//####
//####
//Endre Ball til en klasse Rectangle
//Sprett i høyre kant skjer når høyre kant av rektangelet når høyre kant
//    Sprett i venstre kant skjer når venstre kant av rektangelet når venstre kant 
//Sprett i øvre kant skjer når øvre kant av rektangelet når øvre kant 
//    Sprett i nedre kant skjer når nedre kant av rektangelet når nedre kant 