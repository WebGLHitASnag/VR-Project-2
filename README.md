# CS 4331-002 - Virtual Reality Project 2
## Due: Tuesday, April 3rd, 2018

## Video demonstration

## Try it out

***
## Project Report

### We learned....

### Biggest issues
  - Learning to use Unity and C# without having any prior experience.
  
## Contributors
  - Carolyn Wu
  - Jakob Dozier
  - Mayur Bhakta
  - Simon Woldemichael

### Work Distribution
  - Carolyn: Menu page, Level 1, planning
  - Jakob: Level 2, planning
  - Mayur: Level 2, planning
  - Simon: Level 1, planning, documentation
 
### Key features
The speed of the boat
```

	public float turnSpeed = 5000f;
	public float accellerateSpeed = 5000f;
```
Add collider for the boat
we cannot use mesh collider in that model cause this model is not convex

so there are four cubes which now are invisiable to stop users walking off the boat
![screenshot 12](https://user-images.githubusercontent.com/22507322/38460883-c2eb8d44-3a88-11e8-8689-7161fedc4907.png)

switch the boat mode and walking around mode by pressing 0 or 1

```
		if(Input.GetKey("0"))
		{
			boat.GetComponent<Rigidbody>().isKinematic = false;
			boat.GetComponent<boat>().enabled = true;
			boatCamera.SetActive(true);

			player.SetActive(false);
		}

		//set to FPS mode//
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



### Grade Requirements
 - [x] Have water as the central element of your project

### Planned timeline
  - We used a Trello board to track the progress of the project
    - Trello Board link: https://trello.com/b/s1oLJZb3/cs-4331-002-group-6-virtual-reality-project-2

### External asset sources and Unity packages
  - Classroom: https://sketchfab.com/models/2a1e3b294c1e4e91bed794bfa520c4f4#
  - Island terrain pack: [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/landscapes/free-island-collection-104753)
  - VR Sampels: [Unity Asset Store](https://assetstore.unity.com/packages/essentials/tutorial-projects/vr-samples-51519)
  -boat https://www.youtube.com/watch?v=s_RIfCfMlPc&t=410s
