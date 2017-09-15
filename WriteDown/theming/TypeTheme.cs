using Newtonsoft.Json;
using ScintillaNET;

namespace WriteDown {
    public class TypeTheme {
        public string Font { get; set; } = "Consolas";
        public int Size { get; set; } = 10;
        [JsonConverter(typeof(StringHexConverter))]
        public int ForeColor { get; set; }
        [JsonConverter(typeof(StringHexConverter))]
        public int BackColor { get; set; } = 0xffffff;
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public bool FillLine { get; set;  }
        public bool Hotspot { get; set; }

        public TypeTheme() { }

        public TypeTheme(TypeTheme parent) {
            if (parent.Font != null) Font = parent.Font;
            Size = parent.Size;
            ForeColor = parent.ForeColor;
            BackColor = parent.BackColor;
            Bold = parent.Bold;
            Italic = parent.Italic;
            Underline = parent.Underline;
            FillLine = parent.FillLine;
            Hotspot = parent.Hotspot;
        }

        public TypeTheme(Style parent) {
            if (parent.Font != null) Font = parent.Font;
            Size = parent.Size;
            ForeColor = parent.ForeColor.ToArgb();
            BackColor = parent.BackColor.ToArgb();
            Bold = parent.Bold;
            Italic = parent.Italic;
            Underline = parent.Underline;
            FillLine = parent.FillLine;
            Hotspot = parent.Hotspot;
        }
    }
}