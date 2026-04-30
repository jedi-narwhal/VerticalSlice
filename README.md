# GDIM33 Vertical Slice
## Milestone 1 Devlog
### Question #1
Here is how my visual scripting graph works. The purpose of my visual scripting graph is to update the text for the alien to know what traits traits to match it too. This graph is hooked up to my alien info game object.  I start my graph with on start because so that the person knows what to look for and connected this to the set text mesh pro node. The text mesh pro node has inputs. In the TextMeshPro, I put the my variable that I made containing the value of the text mesh pro from the editor connecting the UNity editor text mest pro to my graph. Also inputted to set text mesh pro is another variable containg my scriptable object. This variable is connected to another node that gets the description from the scriptable object because we want only want the content of the textmesh pro to hold the description. That is connected to one of the inputs of the set text mesh pro.
### Question #2
<img width="1433" height="1822" alt="IMG_859EDFE88F1E-1" src="https://github.com/user-attachments/assets/8fd7cd3f-f942-46e0-a2e6-3dfbfb1fa94f" />

  Here is how my statemachine is connnected to the rest of my breakdown. First, The player inspection state is directly connected to the ui in my game specifically, the accept/deny buttons. In this state, these game objects become activated and are now appearing on the screen to prevent the player from choosing accept or deny before the clues and inspection is present.It is also related to my player because they have the option to click and inspect the alien, then choose whether they want to accept of deny this alien. Once the accept or deny button is clicked, it will trigger an event in the transition to departure that will create a state change.
  In the npc arrival state, deals with the npc itself. The ui image containing the npc sprite via scriptable object is first placed on a set loacation on enter state so it runs before the logic. On update, it gets the ui image current location and moves it to a set location and triggers an event. This event starts the timer to switch states. This interacts with my npc system moving the sprite contained in teh npc scriptable object across and into the cue. It also is has the same version of the sprite magnifined in the inspection window.
  In the npc departure state deals with the npc leaving the scene. First, on enter state the ui accept/deny buttons are deactivated. This interacts with y ui system and makes it clear that there has been a state change. It also prevents the player to cheat and move on to the next game object. On update, it gets the npc's location and moves it toward a point at the exit of the queue to simulate it is leaving.  This interacts with my npc system moving the sprite contained in teh npc scriptable object across and into the cue. It also is has the same version of the sprite magnifined in the inspection window.
## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
