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
### Question #1: Telling whether the player got promoted or fired
1. Add is_admitted to scriptable object
- Fill the bool in code for what the scriptable object is going to say whether the npc is going to be admitted or not
- In the unity, create one scriptable object and fill in the inspector to check which scriptable objects are going to be admitted based on the description. 
2. Check the players accuracy
- I have to create a variable that gets the current scriptable object representing the Alien  which is going to be called by a signleton
-  Create a bool that represents the players choice: whether they chose accept of deny
-  If statement that if the current alien = what the player chose, the score will update otherwise the score will decrease
3. Calculate Whether the Player got promoted or fire based on score ( end screen)
- Must iterate through all the list of the alien Scripatble objects first, which is connected to the AlienDisplay Script.
- Deactivate end screen in the start and then reactivate it. 
- Updates score text based on the ones answered correctly.
4. Putting everything in the inspector
- Hook up all the game objects in the inspector with the respective variables that were created in the code.
### Question #2: Breakdown Activity Reflection
Yes, I feel like my breakdowns helped me with the process of creating this feature. I think this was helpful because I was able to break down a complaicated problem into more, easier steps. I feel like the step on hooking it up in the editor was also helpful because I tend to get confused on that. To improve the breakdowns, I list spcific ways i can break them into actual method that I'm going to use.

### Question #3: Bridging Visual Scripting
Here is how I bridge visual scripting in my code. I bridge my thing in visual scripting in my statemachine during the NPC arrival state. Specifcally, In the "on enter state" it sets the location the beginning of the door and updates to the next alien and also updates the text with that aliens description. The method I bridged with is the Next Alien method I coded in my C# graph which checks for if there is aliens, and if there is updates with the next Alien Scirptable Object. In this bridge, I am calling a C# method from the graph in order to get the next Alien so it can update the sprite and the description with information from the scriptable object. 
<img width="1190" height="654" alt="Screenshot 2026-05-13 at 12 14 33 PM" src="https://github.com/user-attachments/assets/eff38454-eca6-4a66-aeac-d07c1bd053d3" />

### Question #4: Unity System
My Unity sytem I chose to grade is after all of the NPCs visit, the player is rewarded, punished, or scored based on how accurate their assessments were. I chose to update the score while in game nd based on what you get, you are either promoted or fired.
## Milestone 3 Devlog
### Question #1: Shader Graph
Here is a what is going on in my shader graph. The base color slot receives a color input that has been inverted by a one minus node after being sampled from the RGBA input from the main(T2) texture property. Also, the alpha gets the transparency,from the color inversionfrom the sample texture 2d node's Alpha input. Last, the alpha clip threshold is set to 0.1 so it creates a thin outline on the sprite rather than  the whole image being inverted. 

Graph:

<img width="590" height="412" alt="Screenshot 2026-05-27 at 10 59 26 AM" src="https://github.com/user-attachments/assets/4ba2cdfc-af66-4296-9fbc-f64bd63144a7" />

Before:

<img width="76" height="95" alt="Screenshot 2026-05-27 at 11 01 32 AM" src="https://github.com/user-attachments/assets/9c410b3e-2936-4399-b1b3-b7293d5ccdaa" />

After:

<img width="146" height="234" alt="Screenshot 2026-05-27 at 11 07 24 AM" src="https://github.com/user-attachments/assets/0f045762-02ee-4545-b684-4371cde5d161" />

### Question #2: Improvements
Here are the improvements I made since last playtesting. First, I made the npcs come and exit faster. I did this by adjusting my speed variable in my visual scripting graph. I also noticed this affected my transition time. Because of this, I had had to also to decrease the transition time. This contributed to the speed of the overall game. In addition, I fixed the bug of the ui click button popping up when the end screen popped up. Lastly, I added more npcs so that it can improve overall gameplay.

### Question #3: Content
Here is the new content I added since last milestone. First, I added a "click on the alien to inspect" ui. I found that in my milestone 2 build, people were having trouble to know when to click the alien. I also added 2 new npcs. This gives the player more chances to play the game. I also added the shader. My shader activates when you click on it and deactivates click accept or deny.

## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
