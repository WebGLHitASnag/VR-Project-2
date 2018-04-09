<h1 align="center">CS 4331-002 - Virtual Reality Project 2</h1>
<p align="center"><img src="https://img.shields.io/badge/platform-Windows-blue.svg" alt="Supported platforms">  <img src="https://img.shields.io/github/last-commit/WebGLHitASnag/VR-Project-2.svg?style=social" alt="GitHub Last Commit">  <img src="https://img.shields.io/github/languages/top/WebGLHitASnag/VR-Project-2.svg?style=social" alt="GitHub Language"></p>

<h2 align="center">Due: Thursday, April 12th, 2018</h2>
<h2 align="center">Video Demonstration :soon: :tm:</h2>

## Try it out
- Download the game on our project's website: https://webglhitasnag.github.io/

***
<h1 align="center">Project Report</h1>
<p align="center">
  <img style="width: 50%" width="80%" height="80%" src="https://i.imgur.com/DeQz4Fw.png">
</p>

### We learned....
  - ...game development methodology and procedures.
  - ...that most of the development of our game pertained to tasks that were necessary in Project 1 (i.e. model placement and aesthetic design).
  - ...more about the Hydrologic Cycle than we thought there was.
  - ...about a small sample of Unity's API.
  - ...scripting with C#.
  
### Tools Used
  - [Unity](https://unity3d.com/) :video_game:
  - [Visual Studio](https://www.visualstudio.com/downloads/) :floppy_disk:
  - [Blender](https://www.blender.org/) :crystal_ball:
  - [Audacity](https://www.audacityteam.org/) :headphones:
  
### Biggest issues
  - Learning to use Unity and C# without any one in the group that has any prior experience.
  - *Integration of the project as a whole*
    - There were merge errors (i.e. duplicate Library data within scenes) between 4 branches of development
  - Maintaining portability (i.e. not including any extra dependencies for the final build of the game to run).
    - Taking into consideration the low level of performance provided by the computer in our lecture room, we wanted to keep the game as light as possible.
  - ***Dealing with Unity's randomness/unclear compile errors.***
    - Scenario: Project is saved, working changes are commited and pushed to their respective remote branches, Unity is closed. Unity is opened again and the game has reverted to a point in development that was before what was committed and the current working branch needs to be fast-forwarded.
  - VR implementation
    - Since this game is for our Virtual Reality class, we were hoping to be able to at least implement the use of the Oculus HMD and Touch Controllers into our game, but since no one on the team had a supported GPU and travelling to the lab to debug, attempt and debug again wasn't viable, this was not possible.
  
### Grade Requirements
 - [x] Have water as the central element of your project

## Contributors
  - [Xujia Wu](https://github.com/carolynwu)
  - [Jakob Dozier](https://github.com/JakobDozier)
  - [Mayur Bhakta](https://github.com/mBhakta95)
  - [Simon Woldemichael](https://github.com/swoldemi)

### Work Distribution
  - Xujia: Menu page, Level 1, planning
  - Jakob: Level 2, planning
  - Mayur: Level 2, planning
  - Simon: Level 1, planning, documentation
 
### Key features
  - The purpose of our game was to teach our players about the Hydrologic Cycle (also known as the Water Cycle). Level 1 of the game serves as a lesson to teach the basic concepts of the Hydrologic Cycle and level 2 gives the player a chance to apply what they learned and visualize the cycle as it happens under their control.

#### Menu
  - At the menu the player can select which level they would like to start on, view controls, the leaderboard (currently a work in progress) and game options (also a work in progress)
<p align="center">
  <img style="width: 50%" src="https://imgur.com/lwZRpcp.gif">
</p>
  
#### Level 1
  - On level 1, the player is required to pilot a boat to the land mass holding the classroom. Once reaching the inside of the class room the player will be given the option of starting a conversation with the teacher model within. The teacher will then give the student a lesson on the water cycle. Once the player has completed the lesson, they will be able to go back on the boat and pilot the boat to level 2.
  
  - Chat-like dialogue system
<p align="center">
  <img style="width: 50%" src="https://imgur.com/CN7EDOh.gif">
</p>

  - Animated model
<p align="center">
  <img style="width: 50%" src="https://i.imgur.com/xeM5BzP.gif">
</p>

  - Animated with Prefab animations provided by the Asset Store (linked at the bottom of this README)
<p align="center">
  <img style="width: 50%" src="https://i.imgur.com/lDl4Rvi.gif">
</p>
	
  - Working aquatic vehicle
    - Camera transitions achived with this C# code:
```cs

{
	//Selecting 0 moves the camera into the boat
	if(Input.GetKey("0"))
	{
		boat.GetComponent<Rigidbody>().isKinematic = false;
		boat.GetComponent<boat>().enabled = true;
		boatCamera.SetActive(true);

		player.SetActive(false);
	}

	//Pressing 1 sets the camera to FPS mode
	if(Input.GetKey("1"))
	{
		boat.GetComponent<Rigidbody>().isKinematic = true;
		boat.GetComponent<boat>().enabled = false;
		boatCamera.SetActive(false);

		player.SetActive(true);
		// move to start ing position
		player.transform.position = playerStartPos.transform.position;
	}
}
```
<p align="center">
  <img style="width: 50%" src="https://i.imgur.com/BmYdeLN.gif">
</p>

#### Level 2
  - In level 2, the player will begin on a terrain that will give them 3 options for what body of water they would like to trigger the water cycle on. Once they've walked into a teleporter and reached the part of the scene that houses the selected body of water, the player will be required to find a sphere, skinned to look like the sun. Once finding the sphere, the player will *scroll up* on the mouse wheel and use the *q* and *e* keys to control the temperature of the orb. As soon as the orb is active and has reached the correct temperature, the water in the scene wil begin to evaporate, a cloud will form, and it will begin to rain. A timer is used to keep track of how long it takes the player to complete the level.

### Planned timeline
  - We used a Trello board to track the progress and development of the project! :clipboard:
    - Trello Board link: https://trello.com/b/s1oLJZb3/cs-4331-002-group-6-virtual-reality-project-2

### External asset sources and Unity packages
  - Classroom: https://sketchfab.com/models/2a1e3b294c1e4e91bed794bfa520c4f4
  - Cloud (Level 1): https://sketchfab.com/models/116f49c23c4347eba340d0f59b0601f7
  - Character model: [Unity Asset Store](https://assetstore.unity.com/packages/3d/characters/unity-chan-model-18705)
  - Island Terrain Pack: [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/landscapes/free-island-collection-104753)
  - VR Samples: [Unity Asset Store](https://assetstore.unity.com/packages/essentials/tutorial-projects/vr-samples-51519)
  - ProBuilder: [Unity Asset Store](https://assetstore.unity.com/packages/tools/modeling/probuilder-111418)
  - TextMesh Pro: [Unity Asset Store](https://assetstore.unity.com/packages/essentials/beta-projects/textmesh-pro-84126)
  - Rain Drop Effect 2: [Unity Asset Store](https://assetstore.unity.com/packages/vfx/shaders/fullscreen-camera-effects/rain-drop-effect-2-59986)
  - Sky5X One: [Unity Asset Store](https://assetstore.unity.com/packages/2d/textures-materials/sky/sky5x-one-6332)
  - Nature Starter Kit 2: [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/nature-starter-kit-2-52977)
  - Standard Assets (provided by [the TA](http://github.com/alex-nguyen)): https://drive.google.com/open?id=1QZkop1Vl17tabTXLwWEYegCt9uq5Vr4r
  - Octocat logo: https://www.flaticon.com/free-icon/github-logo_25231
  
### References (more available on the [Trello Board](https://trello.com/b/s1oLJZb3/cs-4331-002-group-6-virtual-reality-project-2))
  - Menu development: https://www.youtube.com/watch?v=zc8ac_qUXQY
  - Animation Control: https://www.youtube.com/watch?v=wdOk5QXYC6Y&t=627s
  - Dialogue System: https://www.youtube.com/watch?v=_nRzoTzeyxU&t=3
  - Water animations w/ Blender: https://www.youtube.com/watch?v=VeGHNcOedAw