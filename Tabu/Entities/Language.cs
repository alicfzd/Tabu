using Tabu.Entities;

namespace Tabu.Class
{
    public class Language
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Icon { get; set; } = null!;
        public IEnumerable<Game>?Games { get; set; }
        public  IEnumerable<Word>?Words { get; internal set; }
    }
}
