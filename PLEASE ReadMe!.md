GlitchQuest project repository for a team whose name cannot be spoken.

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