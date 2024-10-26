using Exiled.API.Interfaces;

namespace EvilPump
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public float BlackCandyChange { get; set; } = 6f;
        public float BlueCandyChange { get; set; } = 5f;
        public float BrownCandyChange { get; set; } = 0f;
        public float EvilCandyChange { get; set; } = 0.1f;
        public float GreyCandyChange { get; set; } = 9.9f;
        public float GreenCandyChange { get; set; } = 11f;
        public float OrangeCandyChange { get; set; } = 10f;
        public float PinkCandyChange { get; set; } = 4f;
        public float PurpleCandyChange { get; set; } = 11f;
        public float RainbowCandyChange { get; set; } = 11f;
        public float RedCandyChange { get; set; } = 11f;
        public float WhiteCandyChange { get; set; } = 10f;
        public float YellowCandyChange { get; set; } = 11f;

    }
}
