using ConsoleApp5;

int x = 1;
int y = 2;

void DisplayInfo(ref int x, ref int y)
{
    x++;
    y++;
}

DisplayInfo(ref x, ref y);

Console.WriteLine($"Стало -> {x} было -> {x - 1}");
Console.WriteLine($"Стало -> {y} было -> {y - 1}");





