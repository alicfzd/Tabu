﻿namespace Tabu.DTOs.Word
{
    public class WordCreateDto
    {
        public string Text { get; set; }
        public string Language { get; set; }
        public IEnumerable<string> BannedWords { get; set; }
    }
}
