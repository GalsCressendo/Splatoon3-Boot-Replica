## DESCRIPTION
This is a project that replicate [Nintendo's Splatoon3 Game Boot loading scene](https://www.youtube.com/watch?v=VUbwy4GJp7U).
The main focus of this project is attempting to replicate the boot scene to learn unity's [Universal Render Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@16.0/manual/index.html) shaders graph.

## DEMO


## HOW TO TEST IT
Just clone the project to your local workspace or download it with zip files.
- Unity Project : Open the Unity-Project folder using Unity3D. This project using Unity 2022.3.12f1
- Build : Open the .exe file located in the build folder

## WHAT TO EXPECT AND WHAT CAN I DO?
- You can open the shader graph file and edit the shader graph to tweak it to your own liking.
- There are 2 sample texture that you can add to the shader graph for testing. You can add your own too.
- There's a single script (BootScene.cs) that responsible to adjusting some of the value in the shader graph. This will add some kind of randomness feels to it. You can tweak the value of every variables in this script except the Properties.