# WriteDown

My attempt at a Markdown editor similar to [MarkdownPad](http://markdownpad.com/).

## Why?

Because I wanted an open sourced alternative to [MarkdownPad](http://markdownpad.com/) 
that is feature complete (i.e. I don't have to install third-party software 
to use the HTML preview) and that I could use offline (stuff like 
[SimpleMDE](https://simplemde.com/) is nice and all, but I'd rather 
have a desktop app than a fancy web page).

## Special Thanks To...

* [CefSharp](https://github.com/cefsharp/CefSharp) - The Chromium wrapper
used for the HTML preview
* [ScintillaNET](https://github.com/jacobslusser/ScintillaNET) - The Scintilla
wrapper used for the text editor.
* [MarkDig](https://github.com/lunet-io/markdig) - Convert's Markdown to
HTML super quickly and handles GitHub-flavor Markdown and emoji shortnames
for me.
* [MDITabControl](https://www.codeproject.com/Articles/16436/A-highly-configurable-MDI-tab-control-from-scratch) -
The best customizable tab control for DotNet out there.
* [Json.NET](https://github.com/JamesNK/Newtonsoft.Json) - Used to 
serialize/deserialize themes and configs.
* [WriteDown - Guard Edition](https://github.com/Guard13007/WriteDown) -
My friend's attempt at a Markdown editor, but written in 
[Electron](https://electron.atom.io/) and Cross-Platform. I came up with the
name, so I'm also using WriteDown.