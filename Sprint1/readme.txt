Controls:
Left/A - Go Left
Right/D - Go Right
Down/S - Crouch
Z - Jump
X - Run
C - Shoot
K - Pause
P - Unpause

The underworld theme song is not the conventional underworld theme, but more so a cool remixed underground theme song. As far as mario is concerned, the underground
is cooler and more hip than the overworld, and his playlist reflects it. 

Sprint Features:
1) Level 1-4 with Bowser
Spinning fire rods with adjustable parameters.
Retracting bridge upon axe collection
A decently “intelligent” Bowser.


2) Magic Mushroom
Inverted keyboard controls
Distorted music
Random colors
Altered physics
Upside - no damage from enemies!


Code Analysis:
Rule set use: Microsoft Basic Design Guidelines

Issues suppressed:

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1502	'MarioCollisionManager.ManageMarioCollisions(IMario, Chunk, IList<IPortal>, IList<IFloorPiece>)' has a cyclomatic complexity of 34. Rewrite or refactor the method to reduce complexity to 25.	Game	C:\Users\Srinidhi\Source\Repos\OneOfTheCoolerTeams3\Sprint1\Sprint1\Collision Classes\MarioCollisionManager.cs	40	Active
Reason: Code is more understandable than before

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1812	'NullItem' is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static methods, consider adding a private constructor to prevent the compiler from generating a default constructor.	Game	C:\Users\Srinidhi\Source\Repos\OneOfTheCoolerTeams2\Sprint1\Sprint1\Item Classes\NullItem.cs	11	Active
Reason: NullItem exists as a Null type for item, so that in case an item ever needs a default value, it does not have
		to hold a null pointer, which could potentially throw exceptions.

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1812	'ObjectData' is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static methods, consider adding a private constructor to prevent the compiler from generating a default constructor.	Game	C:\Users\Srinidhi\Source\Repos\OneOfTheCoolerTeams2\Sprint1\Sprint1\Level Files\LevelData.cs	11	Active
Reason: This class exists as a schema for the xml file.

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CS0169	The field 'ObjectData.ObjectType' is never used	Game	C:\Users\Srinidhi\source\repos\OneOfTheCoolerTeams3\Sprint1\Sprint1\Level Files\LevelData.cs	16	Active
Reason: These variables are part of the schema of the XML file.

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1024	Change 'AnimatedSprite.GetFrameOffset()' to a property if appropriate.	Game	C:\Users\Srinidhi\Source\Repos\OneOfTheCoolerTeams2\Sprint1\Sprint1\Sprite Classes\AnimatedSprite.cs	68	Active
Reason: GetFrameOffset is a protected method that is called only within one method, and not a property that can be 
		accessed by the whole class.

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1024	Change 'AnimatedSprite.GetFrameSource()' to a property if appropriate.	Game	C:\Users\Srinidhi\Source\Repos\OneOfTheCoolerTeams2\Sprint1\Sprint1\Sprite Classes\AnimatedSprite.cs	66	Active
Reason: GetFrameSource is a protected method that is called only within one method, and not a property that can be 
		accessed by the whole class.

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1823	It appears that field 'ObjectData.ObjectName' is never used or is only ever assigned to. Use this field or remove it.	Game	C:\Users\Srinidhi\Source\Repos\OneOfTheCoolerTeams2\Sprint1\Sprint1\Level Files\LevelData.cs	15	Active
Reason: Part of XML file schema

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1812	'Star' is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static methods, consider adding a private constructor to prevent the compiler from generating a default constructor.	Game	C:\Users\Srinidhi\source\repos\OneOfTheCoolerTeams3\Sprint1\Sprint1\Item Classes\Items\Star.cs	11	Active
Reason: Every item class is not explicitly instantiated, but done so through Activator.CreateInstance() when necessary.

Severity	Code	Description	Project	File	Line	Suppression State
Warning	CA1006	Consider a design where 'CollisionManager.GetValidBlockCollisions(IList<Tuple<IBlock, ICollision>>)' doesn't nest generic type 'IList<Tuple<IBlock, ICollision>>'.	Game	C:\Users\Srinidhi\source\repos\OneOfTheCoolerTeams3\Sprint1\Sprint1\Collision Classes\CollisionManager.cs	65	Active
Reason: Only a consideration and not a rule.