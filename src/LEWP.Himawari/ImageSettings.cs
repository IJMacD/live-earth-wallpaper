using System;

namespace LEWP.Himawari
{
    public class ImageSettings
    {
        public int Width { get; set; }
        public string Level { get; set; }
        public int NumBlocks { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}