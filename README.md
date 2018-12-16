#  Cut [ctrl-x], Copy [ctrl-c] and Paste [ctrl-v] from command line

This repo contains code inspired by the original source code from Joel 'Jaykul' Bennett's post on [huddledmasses.org](http://web.archive.org/web/20131124234800/http://huddledmasses.org/clipexe-and-the-missing-pasteexe)

- `ctrl-x.exe` is (almost) the same as `clip.exe` (available in Windows) : paste piped text (and/or the parameters) to the clipboard
- `ctrl-c.exe` (missing in Windows) is same as `ctrl-x.exe` but also print to the standard output the piped text
- `ctrl-v.exe` (missing in Windows, except in PowerShell) paste the clipboard to the console

# How to compile this code

```
csc ctrl-x.cs
csc ctrl-c.cs
csc ctrl-v.cs
```

The C# compiler is available in the .Net Framework. For example for the version `3.5` its default path is `C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe`

# PowerShell vs cmd

If you use PowerShell this program will be probably useless for you as there are `Get-Clipboard` and `Set-Clipboard` that are more powerful than `ctrl-v` and `ctrl-x`.

If you need to use `cmd`, `GitBash` or some other shell, than it can be useful to have them.

# `ctrl-x` vs `clip`

The main difference is when the pasted text is single line :
- `clip` adds (or keeps) the `\n` to the end of the text
- `ctrl-x` removes (do not adds) the `\n` from the end of the text

# `ctrl-v` vs Joel 'Jaykul' Bennett's `paste`

- `paste` read and write lines, so there is always `\n` at the end of the text, and all the line endings are Windows standardized
- `ctrl-v` read the entire clipboard and write it as it is
