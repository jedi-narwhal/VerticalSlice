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
Here is how I bridge visual scripting in my code. I bridge my thing in visual scripting in my statemachine during the NPC arrival state. Specifcally, In the "on enter state" it sets the location the beginning of the door and updates to the next alien and also updates the text with that aliens description. The method I bridged with is the Next Alien method I coded in my C# graph which checks for if there is aliens, and if there is updates with the next Alien Scriptable Object. In this bridge, I am calling a C# method from the graph in order to get the next Alien so it can update the sprite and the description with information from the scriptable object. 
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
Here is the new content I added since last milestone. First, I added a "click on the alien to inspect" ui. I found that in my milestone 2 build, people were having trouble to know when to click the alien. I also added 2 new npcs. This gives the player more chances to play the game. I also added the shader. My shader activates when you click on it and deactivates click accept or deny. I also cleaned up the checklist text. Specfically, I put a new background behind it, made it more like a list, and added it so you are inspecting 3 bullet points for each npc. I also had these bullet points include things to inspect in x-ray view. 


## Final Devlog
### Question #1: Core Gameloop & Vertical Slice
An NPC (alien)  is displayed and arrives in the queue with a list of traits to check for.The player examines the NPC in normal view and xray view activated by clicking on it. In addition, a pop up view shows a specfic body part related to what you are suppose to investigate.The player makes a decision: let the NPC through (it is correct) or flag them as an anomaly (it is wrong).The result is scored: correct calls earn points, false positives and missed anomalies are penalized. The NPC leaves the queue and the next appears. After all NPCs in the shift queue have been processed, the shift ends and the player is either fired or promoted based their score. 
This relates to my Vertical Slice due to the fact that there is an NPC that you have to click on to inspect. The body parts will also pop up. I also added that you can do an x ray view in subsitution for the fog, because I relized the fog wouldn't be using a shade and I needed one. In addition, is scored whether you let the right one through and deny the right ones. Also, at the end of the "shift" you are either fired or promoted.
It illistates to the player that what the full game would be like because it includes all the mechanics, ui, scoring system. The only thing you would be adding to the full game is more NPCs. 
### Question #2: Activating/Deactivating Rendering Effect

<img width="536" height="386" alt="Screenshot 2026-05-30 at 6 49 51 PM" src="https://github.com/user-attachments/assets/1bce0385-efef-4b34-a66e-b53b1fc03645" />


<img width="750" height="587" alt="Screenshot 2026-05-30 at 6 49 28 PM" src="https://github.com/user-attachments/assets/d4583259-3f96-477b-9f60-1ce37bf73cb3" />

Here is how I activate and deactivate my rendering effect. First, is activating it. I serialized the material in this inspector so I can put my shader in there. Then created a method to change the alien's material. This method is excuted when I click on the alien. Then, here is how I deactivate it. I do this through visual scripting because it is only exclusive through the player inspection state. As the visual scripting is exiting the player inspection state via the button click of the accept or deny button an event the custom event is triggered. In this event, I set the material back to the default sprite and then the state transititon happens.

## Question #3: Breaking down larger processes to specific systems
I feel like I use a little bit of both systems. To explain, I like to have the bubble diagram that allows me to see the overall systems of the game. I also like to use the task list to see how to break down a specific feature in the bubble diagram. I plan incoporating both to make sure I created the feature correctly and so I see and understand on how it fits in the bigger picture. I feel like breaking the smaller pieces allows me to figure out features one at a time rather then jumping to random places to figure out what to do. Next time, I would probably use both systems. Using the bubble map, allows me to see the bigger picture of my task. While using a task breakdown, it allows me to map out specific step for a specfic feature.

Here is how my process is in terms of doing the Vertical Slice. The beginning was a mess. I realized by week 4, I made a terrible bubble diagram and my code for my game was all over the place. I was also very confused and panicked. Then I sat down for one day and then rewrote my whole bubble diagram and adjusted my code accordingly. From then on, every new feature I created I broke down and saw how it would play into my bubble diagram. This went a lot better and I would like to carry this with me. Toward to end, I felt really good about my methods.

## Open-source assets
### Audio: 
- https://www.youtube.com/watch?v=XuzWi92C8Bw
### Sprites: 
- https://opengameart.org/content/3x-updated-32x32-scifi-roguelike-enemies
### Backgound pics:
- Door: https://www.thesciencewriter.org/borders-stories/better-woman-ai-companion-fiction
- Lab: https://roomescapeartist.com/2022/04/22/the-secret-chambers-arlington-the-area-51-adventure-review/

### UI
- Text Dashboard: https://www.shutterstock.com/image-vector/digital-design-frame-gaming-menu-touching-2527862943?dd_referrer=




