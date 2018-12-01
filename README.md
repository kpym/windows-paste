# Clip.exe and the missing Paste.exe

This repo contains the original source code from Joel 'Jaykul' Bennett's post on [huddledmasses.org](http://web.archive.org/web/20131124234800/http://huddledmasses.org/clipexe-and-the-missing-pasteexe)

- `clip.exe` (available in Windows) paste the parameter (or piped) test to the clipboard
- `paste.exe` (missing in Windows, except in PowerShell) paste the clipboard to the console

# How to compile this code

```
csc paste.cs
csc clip.cs
```

The C# compiler is available in the .Net Framework. For example for the version `3.5` its default path is `C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe`

# Use cases

If you use PowerShell this program will be probably useless for you as there are `Get-Clipboard` and `Set-Clipboard` that are more powerful than `paste` and `clip`.

If you need to use `cmd`, `GitBash` or some other shell, than it can be useful to have them.

## GitBash

As the linux `paste` command is available in GitBash you should probably rename `paste` to something like `fromclip` or `pilc` (reversed `clip`).
