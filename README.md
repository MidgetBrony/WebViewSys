# WebViewSys

**WebViewSys** is a lightweight Windows-only WebView2 launcher that turns any URL into a standalone desktop app.  
Perfect for dashboards, kiosk systems, or turning web apps into "native-feeling" experiences—without dragging in Electron or Node.

##  Features

-  Open any valid URL in a frameless or kiosk-style window
-  Custom window title and icon support
-  Optional fixed window size (e.g. `1280x720`)
-  Minimal footprint – No Chromium duplication, just native WebView2
-  ESC closes the window instantly
-  Built-in `F5` support to reload the page

## Command Line Options

```bash
WebViewSys.exe [URL] [ICON_PATH.ico] [OPTIONS]
```

| Argument         | Description                                                 |
|------------------|-------------------------------------------------------------|
| `URL`            | (Required) The website or webapp to open                    |
| `.ico` path      | (Optional) Path to a `.ico` file for the window icon        |
| `--title`        | Sets the custom window title (default: "WebViewSys")        |
| `--notitlebar`   | Removes the window frame (borderless window)                |
| `--kiosk`        | Launches in fullscreen kiosk mode                           |
| `--size WxH`     | Sets a fixed window size (e.g. `--size 1280x720`)           |

## Example

```bash
WebViewSys.exe https://suno.com/ "C:\Path\To\Suno.ico" --title "SUNO" --notitlebar --size 1280x720
```

## 🛠 Requirements

- Windows 10+
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [WebView2 Runtime](https://developer.microsoft.com/en-us/microsoft-edge/webview2/)

## 📦 Build

Open in Visual Studio and hit `F5`, or:

```bash
dotnet build -c Release
```

## 🪪 License

MIT License  
Feel free to use, fork, or modify.
