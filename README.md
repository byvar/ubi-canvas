# ubi-canvas
Level viewer and editor for UbiArt games such as Rayman Legends and Rayman Adventures

## Current support
- Rayman Legends (PC): viewing & editing
- Rayman Adventures (Android): viewing
- Rayman Origins (PC): limited viewing

## How to use
1. Download and install Unity 2019
2. Clone this project and open it with Unity
3. Open the Ubi-Canvas setup (located under Ubi-Canvas > Ubi-Canvas Setup in the toolbar)
4. Set the paths to the extracted game folders
![Unity Scene](readme-images/main.png)
5. Optionally more options can be set in the Controller. This can be located by choosing the MapViewer scene (located in Assets/Scenes/). Then in the hierarchy, select the Controller object. In the inspector you can set other options. If you want to load animations, check the relevant checkbox, otherwise uncheck it. Since loading is slow, there will be a major speed boost if you uncheck it.
6. Make sure "Maximize on Play" is unchecked (you will want to see the hierarchy and inspector) in the game view tab.
7. Click the play button and wait for it to load.
8. Have fun!

## Controls
- Game view: Shift to toggle camera controls, and WASD to move around after that. Press L to toggle lighting on/off, and G for gizmos.
- Scene view: Hold the right mouse button and use WASD to move around

## Source Code Documentation
Some general documentation can be found on the [Wiki](https://github.com/byvar/ubi-canvas/wiki).

## Misc tips
- I have not checked every scene. If there is an error, please let me know and I will do my best to fix it ASAP.
- Sometimes, you won't see anything in game view or things will be obscured. Press L to disable and enable lighting.
- To play different animations, navigate to the actor in the hierarchy and if it has animations, there will be a "skeleton" under it. Select it and use the relevant controls in the inspector to select a different animation.
- To add an actor from an act file to the scene, go to Window -> Add Actor while the scene is loaded. Fill in the path to the .act.ckd file relative to the GameDataBin folder. In the hierarchy, make sure to select the Scene object that you want to add the actor to, and click Load.
- To write a patch IPK file (this only works on Rayman Legends for now), go to Window -> Write Bundle while the scene is loaded. Select all the files you have edited and want to store in the patch bundle. Fill in the absolute path to the patch_PC.ipk file (this time including the filename), and write it. When it's ready, put it in the game folder and test your edits in-game!