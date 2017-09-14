﻿using System.Collections.Generic;
using System.Drawing;
using ScintillaNET;
using Newtonsoft.Json;

namespace WriteDown {
    public class SyntaxTheme {
        public enum LexerType {
            Default, LineBegin, Strong1, Strong2, Em1, Em2, Header1, Header2, Header3, Header4, Header5, Header6, 
            PreChar, UListItem, OListItem, BlockQuote, Strikeout, HRule, Link, Code, Code2, CodeBk 
        }

        public TypeTheme defaultTextHighlight { get; set; } = new TypeTheme();
        [JsonConverter(typeof(StringHexConverter))]
        public int caretColor { get; set; } = 0;
        public IDictionary<LexerType, TypeTheme> syntaxHighlight { get; } = new Dictionary<LexerType, TypeTheme>();

        public SyntaxTheme() {
            for (int i = 0; i < 22; i++) syntaxHighlight.Add((LexerType)i, new TypeTheme());
        }

        public void applySyntaxTheme(Scintilla editor) {
            if (editor == null) return;
            if (editor.Lexer != Lexer.Markdown) editor.Lexer = Lexer.Markdown;
            editor.CaretForeColor = Color.FromArgb(caretColor);
            applyStyleTheme(editor.Styles[Style.Default], defaultTextHighlight);
            foreach (var type in syntaxHighlight.Keys) {
                var theme = syntaxHighlight[type];
                applyStyleTheme(editor.Styles[(int)type], theme);
            }
        }

        void applyStyleTheme(Style style, TypeTheme theme) {
            if (theme.Font != null) style.Font = theme.Font;
            style.Size = theme.Size;
            style.ForeColor = Color.FromArgb(theme.ForeColor);
            style.BackColor = Color.FromArgb(theme.BackColor);
            style.Bold = theme.Bold;
            style.Italic = theme.Italic;
            style.Underline = theme.Underline;
        }
    }
}