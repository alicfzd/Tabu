﻿using Tabu.Enums;

namespace Tabu.DTOs.Games
{
    public class GameCreateDto
    {
        public GameLevel GameLevel { get; set; }
        public int FailCount { get; set; }
        public int SkipCount { get; set; }
        public int Seconds { get; set; }
        public string Language { get; set; }
    }
}
