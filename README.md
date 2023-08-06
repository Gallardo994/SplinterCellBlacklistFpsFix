# Splinter Cell Blacklist Fps Fix
Fixes performance stutters in Splinter Cell Blacklist game

# How to use
1. Launch the game
2. Launch SplinterCellBlacklistFpsFix.exe
3. Keep the application running while the game is running

# How it works
On modern systems, like Windows 11, the game fails to set proper process affinity to all available cores, resetting to only one core every time a new level or a cutscene loads. Every time you would want to play the game further, you'd have to set process affinity using Task Manager manually.

This application automates this process of setting affinity every 25 milliseconds to Blacklist_DX11_game.exe in the background.

Should also work for any other game which requires process affinity modification. Just change process name in the code and rebuild with .NET 7.