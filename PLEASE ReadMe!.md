# GlitchQuestProjectSWHB
GlitchQuest project repository for Team Super Weenie Hut Boys.
Past and current changes.

## Bad Grid
We don't need GameLoop.cs, that can run in Main() for Program.cs. Now stuff can be displayed.
Also Grid.cs is a Panel, which makes it easier to display itself. If you go to Draw() in Grid.cs,
you'll see its been updated.

## Grid Notes
#### **Change Line Color**
go to grid.cs and in the Draw class edit this line 
- ```Pen pen = new Pen(Color.Yellow);```

#### Change Background Color
Go to grid.cs and edit this line under the main grid class
- `this.BackColor = Color.Blue;`

## Unsizable Fixed Screen 3/28/24
Go to Form1.cs Design properties. Under FormBorderStyle change to FixedSingle. For MaximizeBox
switch to False. The code's been updated on GitHub with all past changes so far. You can still
move the screen around like the Python Idler, but nothing can be resized.

## GitHub Crisis Averted 4/2/24
All code is updated with the most recent version, no extra programs or files either.
