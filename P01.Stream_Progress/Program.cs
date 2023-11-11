using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            var file = new File("File name", 12, 123);
            var music = new Music("Singer", "Album", 12456, 1249);

            var stream = new StreamProgressInfo(file);
            Console.WriteLine(stream.CalculateCurrentPercent());
            stream = new StreamProgressInfo(music);
            Console.WriteLine(stream.CalculateCurrentPercent());
        }
    }
}
