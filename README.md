***Members of the group :***
- Camille Jouanet
- Louis Guilloré

## Repository content
This repository contains :
* a unity project
* an .apk file of the project build
* a link to a video recording of our project: [https://youtu.be/Apcb3fE25NQ](https://youtu.be/Apcb3fE25NQ)

# Main parts of the project
### We have 3 main exhibitions : the planetarium, the maze and the viscous experience.
#### Our project is set up in a school's gymnasium, to simulate the "science fair" theme

## The Planetarium 
This exhibition seeks to present stars and constellations, just like a real planetarium, but in a more immersive way. The user can go through the obscured entrance, turn on the light if wanted, and press the button in the middle of the room to teleport to the "planetarium" scene. There, the user can look at the different constellations all around them, while listening to ambiance music, and walk around on an invisible floor (there are also invisible walls to prevent falling). The button in the middle allows the user to come back to the gymnasium.

## The Maze
This exhibition's purpose is to demonstrate how UV lights can reveal invisible ink through instructions on how to navigate the maze. The user can select the ladder going down the hole in a corner of the gymnasium, teleporting them to the "maze" scene. Once in the maze, they have to navigate around with no clues at first, but once they arrive at approximately half of the maze, the lights will switch to UV lights, revealing secret messages on the wall leading to the exit. Once they arrive there, they can see the time they took to finish the maze, and interact with another ladder to come back to the gymnasium. There is ambiance music that starts up when loading in the scene, that changes once the lights switch.

## The Viscous experience
This exhibition's purpose is to demonstrate that different materials possess different viscous properties, and objects react differently passing through them. Several cubes made of different materials such as water, slime and mud are placed at one corner of the gymnasium, and in front of them a stack of balls on a table. The user can interact with the stack to spawn a ball in their hand, that they can throw in the different cubes, and observe how the ball reacts through them. If they lose the ball or anything happens to it, they can pick up another ball on the stack.

## Other
We also set up a small radio on a table in the gymnasium, playing music that can only be heard when close enough, and that can be carried through the gymnasium. Finally, several exit doors are set up around the gymnasium, allowing the user to quit the application in a proper way.

# List of objectives
### Here is a list of how we implemented each objective in our project : 

| Objective | Implementation |
| :---------------:|:---------------:|
| Virtual navigation by touch pad using gliding/flying metaphor | Implemented everywhere, allows the player to move around |
| Manipulation with ray casting at an offset distance | Implemented everywhere, allows to interact with teleporters, lights, doors, to grab the radio and the balls |
| Activation / Deactivation of objects during runtime | Several objects are activated and deactivated during the runtime, such as the invisible words in the maze, only being activated when the UV lights are turned on |
| Canvas + 3D TextMeshPro| There are several TextMeshPro, especially in the maze : all the invisible words are made with it. |
| Physics | The viscous experience is based on the different physics of each cubes when the ball interacts with them. |
| Lighting controlled during the interaction | There is an light in the planetarium that the user can turn on and off at will, and the lights changing automatically in the maze. |
| 3D audio integrated in the scene | There is ambiance music and the planetarium and maze scene made with 3D audio, but the 3D aspect of the audio is mostly heard with the radio, whose volume is heard depending on the distance between itself and the user. |
| Timer that counts down the time | Once the user enters the maze, there is a timer counting the time that they spent in this scene. It appears on the wall of the exit. |
| Scripting of object behaviours and logics in the scene | There are scripts on several objects, such as the teleporters, the activation of the UV lights in the maze,... |

# Limitations
### There are still several problems with the project, here is a list of the bugs still present and features we couldn't implement : 

- There is a giant model of the controller floating around the user, only visible with certain angles/positions of the controller.
- On the video showing the project, all the audios are glitching (they are normal when using the headset without recording).
- The balls spawned by the stack are not always grabbable, and grabbing the already spawned one is sometimes tricky.
- The gymnasium is pretty empty and lacking decorations, and some assets are left in the middle (with non accurate sizes).
- There is only one text and a few arrows appearing with the UV lights in the maze, we planned to add more all throughout the maze but ran out of time.
