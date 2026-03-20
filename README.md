# Jimmy_Vegas_Intro_Unity6 My notes

- link: [Course Link](https://www.youtube.com/watch?v=HwI90YLqMaY&list=PLGV4LXy81abZJaSZL-6HqOLQHzztjVlh-)
- Author: [Jimmy Vegas](https://www.youtube.com/@JimmyVegasUnity)
- note: These notes and code are me following along with the course, and may not reflect the author 100%
- as always, please refer back to the original author's work!

## Unity, quick reminder of QWERTY tools:

| Command | Tool/Mode | Description |
| :--- | :--- | :--- |
| **Q** | Hand | For panning and navigating the Scene view. |
| **W** | Move | For translating (moving) objects along their X, Y, and Z axes. |
| **E** | Rotate | For rotating objects around their local or global axes. |
| **R** | Scale | For uniformly or non-uniformly scaling (stretching/resizing) objects. |
| **T** | Rect Transform | Primarily used for UI elements and 2D objects. |
| **Y** | Transform | A combination of the Move, Rotate, and Scale tools in a single gizmo. |

# Resource for course
- TBD
# Housekeeping
- I am using 6000.3.7f1 LTS.
- this is later than the one in the course (he is using: 6000.0.24f1)
- (probably good enough, but aware there will be differences)

# Preamble
- author discusses how to install unity
# Create Project
- Projects:
    - [NEW Project]
    - 6000.3.0f1
    - Universal 3D
    - name it `Jimmy_Vegas_Intro_Unity6`
- Don't use cloud! Not sure why Unity wants my stuff, but I will manage this with git myself
- after a few moments it will create `C:\Users\steve\unity_projects\Jimmy_Vegas_Intro_Unity6`
- set up git (I am using powershell; you do you)
<pre>
     set-location 'C:\Users\steve\unity_projects\Jimmy_Vegas_Intro_Unity6\'
     Set-Content -Path README.md -Value "in progress, not done yet!"
     # (copy a .gitignore from a previous project or internet)
     git init
     git add .
     git commit -m "Initial commit - new project, readme"
</pre>
- URP, press the [Remove Readme Assets] button
- Open Package Manager (Window, Package Management, Package Manager)
    - observe that comes "pre-installed"
    - remove JetBrains (I don't have that)
    - remove Visual Scripting (it adds things to project that are , for us, unnecessary overhead)
    - close Package Manager


# Intro to the UI
- author does some useful notes tabs and stuff
- In my notes, I  refer to panels as:

| &nbsp; Panel Name &nbsp; | &nbsp; Short Form &nbsp; | &nbsp; Description &nbsp; |
| :--- | :--- | :--- |
| &nbsp; Scene | &nbsp; **S** | &nbsp; Where you can drag objects and build 3D scene |
| &nbsp; Hierarchy | &nbsp; **H** | &nbsp;  See objects and their inheritance |
| &nbsp; Inspector | &nbsp; **I** | &nbsp; Detailed information on components for selected object &nbsp;|
| &nbsp; Project | &nbsp; **P** | &nbsp;  See resources relative to file directory |
| &nbsp; Game | &nbsp; **G** | &nbsp; Where the game is played |

- there are others.
- note about game objects - you can add **ANY** component.
- many components do **NOT** apply.
- all objects have a transform
- middle mouse wheel pushed in , move mouse, PAN around
- right mouse button pushed, a different ? type of PAN
- arrows on selected objects can be pulled by their arrows
    - X is red
    - Y is green 
    - Z is blue
 
# Lesson 2 - Textures and Materials
- [link](https://www.youtube.com/watch?v=yuLcssPwGLc&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8)
- [resources](https://www.patreon.com/posts/117433042)
- download the resources, and unzip
- in P, observe the Scenes (and in my case, a Settings) folder
- create a Textures folder
- go into the Textures folder
- drag the Brick, Ground and Stone jpg files into the Assets/Textures in P
- create a Cube on the S; (use right click Create 3d Cube)
    - Position: 0 0 0 
    - Rotation: 0 0 0
    - Scale: 20	1 20   (note: author says Y, but he means X, LOL)
- drag Texture Ground into S and on to the "Cube" we created
- observe that unity creates a Materials folder and creates a material
- you can only assign materials, and unity knows this
- rename Cube to Ground (makes more sense) in H
- observe that the ground (zoom in) is very flat and sorta shiny, not realistic
- select Ground in P, Assets, Textures and dupe it (ctrl-d)
- with the Ground 1 selected, modify in I
    - Texture Type: Normal Map
    - Create from Grayscale [x]
    - [Apply]
- open P, Assets, Materials, click Ground
- note: Albedo is now Base Map (version thing)
    - Source: Albedo Alpha
- we need to drag Ground 1 from Assets, Textures, into the square to the lef5t of Normal Map
- play around with settings
    - Metallic Map: 0.4
    - Smoothness: 0.33
    - Source: Metallic Alpha
- add a Cube to H
    - Position: 0 0 0
    - while holding CTRL, drag Cube out of the ground
- open P, Assets, Materials
- dupe Ground, rename Brick
- set Base Map to Brock.jpg  (I locked the H using lock in upper right corner, then found and dragged Brick in textures and dragged)
- drag Brick material onto the cube in H
- rename Cube to Brick
    - Scale 4 4 1
- go to Textures, Brick, dupe it, 
    - change texture type to Normal Map
    - create from GrayScale
    - [Apply]
- P, Assets, Materials click on Brick
- lock
- drag Brick 1 from P, Assets, Textures onto Normal Map
- unlock
- P, Assets, Materials, Brick 
    - Albedo Alpha
    - Metallic: 0
    - Smoothness: 0.85
    - Normal Map: 0.5
- drag brick out of the ground - click H, Brick, ctrl and drag Y
- scale: 5 5 1
- drag to edge (Position: -7 3 9)
- dupe, drag position: -2 3 9
- dupe, drag to (3 3 9)


# Lesson3 - Prefabs and Game Objects
- [link](https://www.youtube.com/watch?v=1Gw_olVUgcA&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=3)
- [resources](https://www.patreon.com/posts/117433831)
- download and unzip author's Unity6_03_Assets.zip
- create empty game object in H, rename to BrickWall
- (temporarily) make the BrickWall a child of Brick(1)
- set its Position to 0 0 0 (so it is in that position relative to Brick(1)
- Drag BrickWall out, and place it below Ground (as a peer of)
- select Brick, Brick(1) and Brick(2) and make them children of BrickWall
- in P, Assets create a folder called Prefabs
- drag BrickWall into Prefabs folder
- next, drag P - BrickWall into the H
     - Position 0 0 0
     - Rotation 0 90 0
     - hold crtl pull up on the Y (so Position 0 3 0)
     - move around to make a corner ( -10 3 1)
- dupe Ground 3 times
- move them so you have a nice 2x2 layout
- create empty called Ground (hold the phone, two Ground? and that works?!)
- move the "grounds" into the new Ground you made
- drag that into Prefabs (in P, Prefabs)
- in P, Assets creat folder called Objects
- from the assets we unzipped earlier, drag and drop Stone Bridge and Fence folders into Objects
- you will see an error:
<pre>
3ds Max could not be found.
Make sure that 3ds Max is installed and associated with .max files.
Can't import normals, because mesh 'Plane01' doesn't have any.
Can't import normals, because mesh 'Tube01' doesn't have any.
Mesh 'Plane01' has no normals. Recalculating normals.
Mesh 'Tube01' has no normals. Recalculating normals.
</pre>
- these errors are expected and can safely be ignored
- open console and click Clear
- (oh. ok)
- in P, Assets, Objects, Fence
- drag `wall_wood_straight` into H
    - way too small
    - Position 0 0.55 0
    - Rotation: 
    - Scale: 100 100 100
- in P, Assets, Objects, Stone Bridge
- drag `bridge` into H
    - way too big
    - open bridge, delete Plane01
    - Position 0 -4 -52
    - Rotation: 
    - Scale: .1 .1 .1


# Lesson 4 - Lighting and Shadows
- [link](https://www.youtube.com/watch?v=9Yh_p8rpysc&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=4)


- first thing I notices is my setup was not rendering shadows, at all
- so in the top bar of the Scene tab (S) there are a number of shadow rendering icons
- I picked Shaded Draw Mode (which looks like what author is using)
- next observe that moving the Direction Light Position, does nothing
- however, you can rotate along X or Y, and observe the shadows moving
- you can also change the color of the light in I, Emission
- when I deactivate the Directional Light (checkbox, upper left) the light goes out
- BUT; I still see stuff. Author doesn't
- from @grahamhill:
<pre>
For those having problems with their scene not going dark after disabling the directional
light, go to Edit>Lighting>Clear Baked Data. 
</pre>
- that works for me
- next, create a Point Light in the H
- author tweaks a few things, mainly purposes
- of note, intensity is much different in my version of the pipeline
- to get what author has, I cranked it from 1 to 20
- this was after googling.
- next, create a Spot Light in H
- mess with its position, range, intensity and color
- set the color to a yellow, drag it over the bridge, and make the cone bigger (via Shape)
- the bridge doesn't look quite right
- click on bridge, right click, Prefab, unpack completely
- drag bridge texture map (so override the one that was built in)
- drag in bridge normal map
- set normal map to 0.75
- Directional Light in H, Intensity 0.5
- author suggest we fiddle about 

# Lesson 5 - Gravity and Physics
- [link](https://www.youtube.com/watch?v=cx43BJTr6Lc&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=5)
- observe when click an object in the H, green lines outline. They represent collison-able.
- in H, create a 3d - sphere
     - Position 3 6 -15
- find Stone in Assets, Textures and drag it onto the ball in the S
- find Main Camera in H, Position 0 1 -25
- press play, observe nothing happening (you should be able to see the ball)
- click on Sphere in H
- in I, scroll down to [Add Component]
- pull down, find and add RigidBody
- press play and observe that the ball falls
- if you drag the ball over the bridge, the ball will fall through the bridge
- so why is the Ground colliding, and not the bridge ?
- if you click the bridge, you will note no green outline - it has no collider
- aside: if you click Ground, Ground you can observe it has a collider (Box Collider)
- so, select bridge, Tube01 in H
- in I, scroll to [Add Component]
- add a Box Collider (note: author is all click on physics, - nah just search)
- author discusses types of colliders
- Box (draws a box around shape) vs Mesh (tries to map to the shape)
- modify Box Collider Center Y: 2.5 so that it lines up with the road and not the railings of the bridge
- author drops a ball on the bridge
- author angles the bride, so we can watch the ball roll
- author dupes the fence, and drops it with a Box collider (so it lands without falling)
- author makes the fence have a Mesh collider, so it falls more naturally
- author dupes the fence making a few, watch them interact
- author has the fences push off of one another
- aside: there appears to be 5 (3D) colliders. We don't get into them. Recommend to reader Capsule.

# Lesson 6 - Animation
- [link](https://www.youtube.com/watch?v=CGqWi5wjeTM&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=6)
- generally, animations are created using a 3d modelling program
- our objective is to make the object wall_wood_straight to open and close like a gate
- dupe the wall_wood_straight
    - Position: -1.62 0.42 0
- dupe again
    - Position: -3.212 0.42 0
- Create Empty, rename Fence
    - drag two duped wall_wood_straight into Fence
    - drag Fence into P, Assets, Prefabs
- drag Fence from P into scene
    - Position: (mine doesn't match authors - at all. No idea why, so moved to a logical location manually)
- right click H, Create, 3D object Cube
- move cube to be at the pivot point of the gate (approx.: 0.0 0.0 0.42)
- note: if you put this on the wall_wood_straight, and zero it, and then remove it...)
- ok, scale: 0.1 2 0.1
- move Position 0.061 0.558 0
- rename to Gate
- make wall_wood_straight a child of Gate
- as experiment, on the Gate, click and drag Rotation Y, and watch the gate move around
- turn off [ ] Mesh Renderer on the Gate (so we can't see the pivot cube)
- Create a folder in Assets called Animations
- add a Tab via the triple dots, called Animations
- (you can add it beside Game for example)
- make sure we are in our Animations folder (P)
- make sure the Gate is selected (H)
- in the Animation, press [Create], name it GateSwing
- (should save some files in Animations in P
- in Animations, press record (red button beside Preview)
- author does weird stuff. Just click [Add Property] and Transform - Rotation
- set frame to 120
- change Y: 75
- set frame 240
- change Y: 0, change Y to 75 (forcing a keyframe, create 120 frames of no movement)
- set frame to 360
- change Y: 0
- press the record button again (to stop recording)
- move main camera closer to gate (0 1 -6)
- run, watch the gate swing
- to stop the animation from looping
- click GateSwing in P, Assets, Animations, GateSwing
- Loop Time [ ] unchecked
- run again, gate swings once

# Lesson 7 - Intro to C# Programming in UNITY6
- [link](https://www.youtube.com/watch?v=fheKzs9F8_U&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=7)
- in P, Assets create a folder called Scripts
- in that folder, right click, Create a new MonoBehaviourScript (aka Script) named StarterScript
- LOL- author says it will open, more than likely, in Visual Studio
- so, yah your gonna need to install visual studio, and configure unity to use it. Good Luck!
- anyway, C# is a language. By having: "using UnityEngine;" and ": MonoBehaviour", we get unity stuff.
- classname "StarterScript" must match the filename "StarterScript.cs"
- author incorrectly calls a comment an annotation. 
- this is important to not confuse, annotations, aka attributes, are used to provide metadata
- comments are just notes for the programmer
- anyway, "Start()" runs once and only once when the "game starts"
- "Update" is called once per frame (per rendering of the game)
- author incorrectly calls static things variables. 
- a variable is string that identifies a piece of memory where data can stored
- a variable has a specific type (int, string. etc) so the amount and handling of the memory is defined
- a variable can store anything, so long as it fits and is compatible with its type
- oh like this; so the inspector can see the variable:
<pre>
    [SerializeField] int myNumber;
</pre>
- alternatively you cold declare it public; but this is not always a great idea
- public is more resource and more prone to other classes manipulating it
- so this makes me happy :-)
- author tries to explain what a code statement is, without explaining it.
- a code state is what the parser reads in. It can be contained within {} or it can be a semicolon.
- he adds more variables
<pre>
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice=false;
</pre>
- he mentions the AI helping out; I personally have a love/hate with autocomplete
- if you chose to turn it off, you can request it via ctrl-space
- he adds a "int myOtherNumber;" as a demo of leaving stuff out
- for reference, a "In C#, a class variable (field) declared without an explicit access modifier defaults to private"
- while we are in the mood: "The [SerializeField] attribute in Unity C# allows private or protected variables to be serialized and displayed in the Unity Inspector..."
- so, those private as we have declared them
- oh, this
<pre>
    [SerializeField] GameObject myGate;
</pre>
- ok. save the script
- author correctly points out the green lines
- back to unity
- add a empty Game Object to H, name it ScriptHolder
- ok, drag StartScript (P, Assets, Scripts) to I of ScriptHolder
- observe the four variables we "SerializedField" are there 
- back to script; adjust Start
<pre>
   void Start()
   {
       myNumber = 4;
       myName = "Steve";
       myChoice = true;
       myGate.SetActive(true);
   }
</pre>
- save, unity
- drag Gate into ScriptHolder, My Gate
- Gate, deactivate
- run, you can watch the gate appear and open, 
- and you can see in ScriptHolder that variables have been set
- back to script
- author explains how an if work, and what equals equals means
- (which is fine)
- here is my version
<pre>
using UnityEngine;

public class StarterScript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice=false;
    int myOtherNumber;

    [SerializeField] GameObject myGate;
    
    void Start()
    {
        myNumber = 4;
        myName = "Steve";
        myChoice = true;
    }

    void Update()
    {
        if (myChoice)
        {
            myGate.SetActive(true);
        } else
        {
            myGate.SetActive(false);
        }
        
    }
}
</pre>
- save, unity. run. Note if you toggle MyChoice the gate toggles too

# Lesson 8 - Player and Assets Store
- [link](https://www.youtube.com/watch?v=Hug0LZDFCH4&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=8)
- author's version is different. Mine is: Window - Package Management - Asset Store
- login
- search for starter assets
- click Starter Assets - FirstPerson... from Unity Technologies - Free
- clicking that, and continuing intelligently, will lead you to the Package Manager
- Download
- Import
- Install/Upgrade
- I got two packages that didn't have valid signatures. So I removed them. This may cause issues.
- I imported the rest
- restarted the IDE because he did. I didn't get a message to
- Assets - Starter Assets - FirstPersonController - Prefabs 
- drag PlayerCapsuleController into H
- try play - it sorta works? you can move around using awsd and arrow keys
- in H, drag Main Camera into PlayerCapsule - PlayerCameraRoot
- zero out the Camera's position
- play again, pretty FPS
- BUG: he has collision on his fence; I don't.
- so, P, Assets, Prefabs, double click Fence, wall_wood_straight(1) add component, Box Collider
- so, H, click Gate, wall_wood_straight add component, Box Collider
- play again, gate and fences now collide (block)
- as aside, I had look at the script that comes with StarterAssetsInputs. 
- its not all that impressive; I recommend looking it over.

# Lesson 9 - Canvas and UI
- [link](https://www.youtube.com/watch?v=iHK_92QOvzo&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=9)
- Create a Text in H
- [import TMP Essentials], then close the popup
- select Canvas
    - Canvas Scaler component, UI Scale Mode, Scale with screen size
    - Reference Resolution 1920 x 1080
    - Match 0.5
- select Text
    - Pos X: 0 Pos Y: 0
    - discussion of anchor point in Rect Transform
    - for example, you will argue your reticle in the dead center
    - or you HP in the top left or top right



# Lesson 10 - Text assignment in Code
- [link](https://www.youtube.com/watch?v=geRIMokPsNQ&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=10)
- updating to Unity release 6000.3.8f1 LTS 
- update takes about 5 minutes
- select H, Canvas, Text
    - set top left anchoring point
- select H, Canvas
    - move Text to the top left of the Canvas (Pos 260, -113, 0)
    - Width: 300, Heigh: 75
    - rename to Name1
- dupe Name1, to Name2
- bug? Canvas should have a reference resolution of 1920 x 1080; somehow mine was 800x600
- adjust this
- select H, Canvas, Name2
    - move Text to the top left of the Canvas (Pos 1182, -113, 0)
    - Width: 300, Heigh: 75
- Open StarterScript in visual studio
<pre>
    [SerializeField] GameObject name1;
    [SerializeField] GameObject name2;
</pre>
- in the update, modify
<pre>
    void Update()
    {
        if (myChoice)
        {
            name1.GetComponent<TMP_Text>().text = myName;
            myGate.SetActive(true);
        } else
        {
            myGate.SetActive(false);
        }
        
    }
</pre>
- note: I let VS put in a using for TMPro.
- save, unity
- select H, ScriptHolder object
    - assign Name1 and Name2  (drag from Canvas over)
- run, see the Name appear
- back to script
- modify the name1 assignment:
<pre>
            //name1.GetComponent<TMP_Text>().text = myName;
            name1.GetComponent<TMP_Text>().text = $"My Number: {myNumber} My Name: {myName}";
</pre>
- save, run, see changes
- back to script
- light Name2 as well
<pre>
    void Update()
    {
        if (myChoice)
        {
            //name1.GetComponent<TMP_Text>().text = myName;
            name1.GetComponent<TMP_Text>().text = $"My Number: {myNumber} My Name: {myName}";
            name2.GetComponent<TMP_Text>().text = $"";
            myGate.SetActive(true);
        } else
        {
            myGate.SetActive(false);
            name1.GetComponent<TMP_Text>().text = $"";
            name2.GetComponent<TMP_Text>().text = $"My Number: {myNumber} My Name: {myName}";
        }
        
    }
</pre>
- save, unity, run
- you will need to flip the My Choice flag on ScriptHolder
- text should flip sides
- personal note. 
<pre>
Author uses GetComponent to, well, get the component. However, Unity is fairly intelligent. You can, for example,
create a "[SerializeField] TMP_Text name1" field, assign that the Name1.  It will automatically find the 
matching component on the GameObject you drag over. I mention this because it is a common use case, and according to Gemini AI, its more efficient. 
</pre>

# Lesson 11 - Font Manipulation 
- [link](https://www.youtube.com/watch?v=cv43iZv6sh4&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=11)
- P, Assets - rclick, Folder; name it Fonts
- author doesn't provide a font
- download: https://fonts.google.com/selection?categoryFilters=Appearance:%2FTheme%2FTechno
- download https://fonts.google.com/download/next-steps?categoryFilters=Feeling:%2FExpressive%2FCalm
- extract each, drag files into Fonts folder you created
- next we need to create a Font Asset
- Window- TextMeshPro - Font Asset Creator
- select a font - say Audiowide-Regular if you used my links (since the author gives us nada)
- click [Generate Font Atlas]
- [Save]
- observe that the P, Assets, Fonts - the icon for it is now  a giant F
- close the window
- in H, Canvas, Name1 - drag your font into Font Asset
- if you look at game view, you will see that the font has changed
- repeat for your second font, FunnelSans-Variable in my case
- put the second font on the Name2
- you can modify the font Vertex Color
- H, Canvas, Name1, Vertex Color - lime green... 13CB34? up to you
     - *B*old,  *U*nderline, Font Size 100
     - make the Rect bigger to contain the larger text
- H, Canvas, Name2, Vertex Color - rind... F10D25? up to you
     - *B*old,  *I*talic, Font Size 100
     - make the Rect bigger to contain the larger text
- author messes arounf with styles and wrapping and colors


# Lesson 12 - UI Buttons
- [link](https://www.youtube.com/watch?v=TmP-AEUSpck&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=12)
## author forgot to put a house in the scene, lets do that now
- author provides a WoodHouse asset, in a file called Unity6_12_assets.zip, on his patreon
- download this, extract, drag WoodHouse folder into P, Assets, Objects
- drag P, Assets, Objects, WoodHouse, Farmhouse onto the Scene
    - Scale : .25
    - Position: 16 .5 -19
- observe the house is gray.
- rightclick H, Farmhouse OBJ; prefab, unpack
- drag from P, Assets, Objects, WoodHouse, Materials, Farmhouse Texture  onto the Scene, the house
## and back to UI buttons
- right click H, Canvas; UI(canvas) , Button
    - Width: 412 Height: 120
    - PosX: -775  PosY: -350 PosZ: 0  (bottom left)
    - set the anchor position to bottom left
- H, Canvas; UI(canvas) , Button, Text
    - Text: Open Gate
    - Font: AudioWide  (or whatever you downloaded)
    - Font Size: 50 (a size that fits the button nicely)
    - Bold
- H, Canvas; UI(canvas) , Button
    - Image - Color: 7F8FFF  (light blue)
    - Button - Highlighted Color: B9F0FF
    - Button - Pressed Color: 0031FF
    - Button - Selected Color: D754EE
- author realizes that the mouse will not click button
- to resolve this, he tries:
    - find H, PlayerCapsule, PlayerCameraRoot, Main Camera
    - drag the Main Camera out, just above PlayerCapsule
- this doesn't fix it for me; as soon as I select the game the cursor locks
- notes:
<pre>
This is a common issue in Unity, typically occurring because the game view locks 
the cursor upon clicking.

       // Unlock and show the cursor
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
will unlock.
</pre>
- I will add this to StarterScript Start() for now
- and we are able to see the button interactions 
- digging in a bit more, we can see in "\Assets\StarterAssets\InputSystem\StarterAssetsInputs.cs"
<pre>
		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

</pre>
- which is code from "Starter Assets - Third Person Character Controller"
- my guess (?) is that the author has a slightly different version of this lib
- anyway, we can comment out this to do the test the author wants,
- or we can override it in our own StartScript, and do the test
- probably want to uncomment though
- find H, Gate
- activate it
- scroll down to Animator, double click Gate
- anywhere on the grid, right click, create empty state
- right click the "New State" and set layer as default
- open StarterScript in VS
- comment out the myGate.SetActive(true) and myGate.SetActive(false);
- add a method
<pre>
    public void OpenGate()
    {
        myGate.GetComponent<Animator>().Play("GateSwing");
    }
</pre>
- save, unity
- H, Canvas, Button
    - scroll down to the OnClick, press + to add placeholder for handler
    - drag ScriptHolder into Non-Object
    - set No Function to StarterScript.OpenGate
- lets add a button that hides the first button
- duplicate H, Canvas, Button
- change text to Hide Button
- back into Startscript
- add accessor
<pre>
    [SerializeField] GameObject gateButton;
</pre>
- add code

<pre>
    public void HideButton()
    {
        gateButton?.SetActive(false);
    }
</pre>
- save, unity
- assign Button into ScriptHolder Gate Button
- Button(1) - set on click to StarterScript.HideButton
- run test


# Lesson 13 - Fade Screens
- [link](https://www.youtube.com/watch?v=E7g3A45UVt0&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=13)
- rightclick - H, Canvas; UI, RawImage. Rename to FadeIn
    - stretch to expand left and right
    - Left 0  Top 0 Pos Z 0
    - Right 0 Bottom 0
    - Color: 000000 (black)
- make sure that FadeIn is slected
- you need a Animation tab open (my wasn't, author's was)
    - near where Project tab is, press triple dots, enable Animation tab
    - click [Create], name it FadeIn
    - press the record button (big round red button)
    - I, Color, type alpha to be 255 (even if it is already, type it )
    - go to frame 180
    - I, Color, type alpha to be 0 (even if it is already, type it )
    - press the record button
- P, Assets, Animations, FadeIn - uncheck Loop
- run
- seems to work, but you can't click buttons
- ok, so move the FadeIn above the buttons, so the buttons are rendered later
- now the buttons are on the screen and not part of the fade, but they do work
- for now, put FadeIn on the bottom of the Canvas
- select Animator tab, click FadeIn, set I, SPeed: -1
- it fades in
- set it back
- now everything is always black ?!
- exit the IDE, restart unity
- yep - the entire animations is broken
- delete FadeIn
- build it all over again
- ok, it works
- if you want a FadeOut, its the same thing, but go from alpha 0 to alpha 255
- since the Speed thing is (appears to be) broken, just avoid it
- so, my buttons don't work, and author's may not either, he skipped them
- easy enough, there is, on RawImage, a Raycast Target, set to unchecked
- technically, we should do this when the FadeIn is done its animation
- simple enough, head back into animation and record the RayCast at 0 checked
- and at 180 as unchecked
- not sure why the author didn't do this... maybe he has a reason



# Lesson 14 - Event Sequences and Co-routines
- [link](https://www.youtube.com/watch?v=ji0Ucrd6cOU&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=14)
- sounds like author wants:
    - fade in our screen
    - turn fade in screen off
    - open the gate
    - wait a couple seconds
    - fade out
- ok, so add a FadeOut, like FadeIn, but from 0 to 255 alpha, and use color FFFFFF (white)
- open StarterScript
- sidenote:
<pre>
a coroutine is declared as a method with an IEnumerator return type and includes one or more yield return statements in its body. This allows the function to pause execution and resume on a later frame.
</pre>
- add in accessors
<pre>
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject fadeOut;
</pre>
- create a coroutine
<pre>
    IEnumerator MySequence()
    {

        yield return new WaitForSeconds(0.5f);
        fadeIn.SetActive(false);   // hide the fadeIn screen
        myGate.GetComponent<Animator>().Play("GateSwing");
        yield return new WaitForSeconds(4f);
        gateButton?.SetActive(false); // hide a button
        yield return new WaitForSeconds(2f);
        // author does some stuff with a sphere ; not going to bother
        yield return new WaitForSeconds(2f);
        fadeOut.SetActive(true);

    }
</pre>
- in start, launch the coroutine 
<pre>
...
        StartCoroutine(MySequence());
...
</pre>
- save, unity
- assign FadeIn and FadeOut in the ScriptHolder
- make Canvas, FadeIn (active )
- make Canvas, FadeOut (inactive)

# Lesson 15
- [link](https://www.youtube.com/watch?v=T78WxOx4ojU&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=15)
- couple things, I am tried of looking at a blank canvas
- so, in unity, H, Canvas, FadeIn - deactivate it
- in ScriptHolder, add code
<pre>
     fadeIn.SetActive(true);   // show the fadeIn screen
</pre>
- that way I can see stuff.
- you will need to get the resources from the authors patreon page
- create folder Audio in Assets
- create folder called Music in Audio
- extract the folder from the downloaded file

- drag into Audio/Music the file Overworld.wav
- in H, create game object called BGM (back ground music)
- drag and drop the music file Overworld onto BGM (it add component)
- press play
- click on loop
- reduce the volume  0.25. pitch .8
- play, sounds ok
- deactivate BGM
- add another game object, call it Ding
- P, Assets, Audio create FX folder
- drag Ding.wav into FX
- drag P, Assets, Audio, FX, Ding onto H, Ding
- open StarterScript
<pre>
    [SerializeField] AudioSource ding;
</pre>
- asdjust HideButton
<pre>
    public void HideButton()
    {
        //gateButton?.SetActive(false);
        ding?.Play();
    }
</pre>
- save, unity
- ScriptHolder, assign Ding
- play
- author's buttons are broken - mine are fine because of the ray trace thing (is this new?)



# Lesson 16 - Add collectible gems
- [link](https://www.youtube.com/watch?v=PIxTdytTCsk&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=16)
- go to authors patreon page and download the assets 
- extract, and copy the collect001.wav to the P,Assets, Audio, FX folder
- copy the Gem folder to the P, Assets, Objects folder
- rclick H create object, 3D,  Cube; rename Gem
    - place at -7 1 -6
- open P, Assets, Objects, Gem, Prefabs
- observe the "pink" prefabbed gems
- drag OldSingleCut onto the H, Gem
    - Position: 0 -0.02 0
    - Scale: 40 40 40
- select H, Gem, OldSingleCut, Mesh
    - remove the Mesh collider
- select H, Gem
    - uncheck Mesh renderer
- select P, Assets, Materials
- create new material, rename Red
- in I, 
    - Shader: Standard  (note: the author is default to Standard, so he doesn't say this)
    - Albedo: Red (so FF0000)
    - so that didn't work. sigh.
    - Shader: Universal Render Pipeline/Complex Lit
    - Base Map: Red (so FF0000)
    - Metallic Map: .5
    - Smoothness: .5
- in H, select Ding
    - replace Audio Generator with Collect001
- in P, Scripts; create MonoBehaviourScript - GenCollect
- open GenCollect in visual studio
- accessor:
<pre>
    [SerializeField] AudioSource ding;
</pre>
- remove the Start and Update methods
- add a trigger enter handler
<pre>
    void OnTriggerEnter(Collider other)
    {
        ding.Play(); 
        Destroy(gameObject);
    }
</pre>
- save, unity
- drag GemCollect onto the H, Gem
- select H, Gem
- drag H, Ding into Ding (on the script in I)
- Box Collider - Is Trigger [x]
- dupe the Gem
- move it around
- run
- dupe the red material, make a green one
- dup the ding game object, makes its pitch deeper
- modify the duped gem to to use the material and new ding sound


# Lesson 17 - RayCast
- [link](https://www.youtube.com/watch?v=-PIIZL4IoRk&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=17)
- imaginary beam from a location forward, and tell you how far away you are from a collision 
- P, Scripts, new Mono, rename to RayCasting, open in Visual Studio
- remove Start
- author is creating a public static. He doesn't explain that you are adding a variable to the class,
- nor does the author explain the design impact of this decision.  
<pre>
    public static float distanceFromTarget = 0.0f;
</pre>
- author doesn't initialize; I assume C# will assign 0 anyway, but explicit assignment is better.
- author adds a testing value
<pre>
    [SerializeField] float toTarget = 0.0f;
</pre>
- alternative: a singleton, and then you can toss the static and the extra variable. 
- lets poll in update:  (events are probably considered to advanced)
<pre>
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = toTarget;
        }

    }
</pre>
- I use the transform.forward (its less typing and googleG says its the same)
- save, unity
- attach the RayCasting script on the player (however you like)
- run
- try script on PlayerCameraRoot instead
- (in this case, does it matter? anyway, super important if we VR)



# Lesson 18 - interaction with objects using raycaster
- [link](https://www.youtube.com/watch?v=gtHJ5p5A-5Y&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=18)
- grab and extra from patreon the TreasueChest 
- open P, Assets, Objects
- drag TreasureChest in
- open P, Assets, Objects, TreasureChest
- drag prefab onto the scene
- I had to fix textures and remap them onto the prefab (I am using the URP )
- adjust chest_prefab_open
    - Position: 13, 1.4, -6
    - Rotation: 0 -90 0
- make a cube around the chest
- hide the cube mesh
- rclick chest_prefab_open, prefab, unpack
- select TopSwing
- Animation tab, create, save as OpenChest
- press record, X=0 (even if is already) 
- at frame 60, X= -62
- press record again
- back to P, Assets, Animations
- select OpenChest, in I uncheck Loop Time
- select TopSwing
- select the Animator tab
- rclick create new empty state, set as default
- Project, Scripts, rclick create Mono rename to OpenChest
- open in visual studio
- code:
<pre>
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] float internalDistance;
    [SerializeField] bool chestOpen = false;
    [SerializeField] GameObject chest;

    void Update()
    {
        internalDistance = RayCasting.distanceFromTarget;
        if (chestOpen == false && internalDistance < 2)
        {
            chestOpen = true;
            chest.GetComponent<Animator>().Play("OpenChest");
        }
    }
}
</pre>
- save, unity
- attach OpenChest script to the Cube we create around the chest
- rename Cube to ChestTrigger
- drag TopSwing into Chest (yes, this is confusing naming)
- do chest, as coded opens immediately
- this because THE DEFAULT VALUE FOR interalDistance is 0. 
- fix this? (author doesn't bother)
- set the interalDistance to a big (> 2) value.
- still buggy, if you get within 2 OF ANY OBJECT it will open the box
- maybe too asdvanced, but you can use Layers to detect specific things (if chest was on a layer)
- or class check the thing
- or call a method from the raycaster on the object
- author adds a keypress check, must be within 2 and press E
- (this doesn't really fix it, but it hides it well. Why would anytone press E while facing a wall?)
<pre>
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            //if (Input.GetKeyDown(KeyCode.E))
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                toTarget = hit.distance;
                distanceFromTarget = toTarget;
                hitThing = hit.collider.gameObject;
            }
        }
</pre>
- I had adjust is key scan; mine is newer, just a version thing I guess.
- remeber, the keyscan is not great; since the user can go up to any object and press E
- and the chest will open

# Lesson 19 - Pathing
- [link](https://www.youtube.com/watch?v=wQcapkjgguk&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=19)
- so the objective is to move a shape (cube) around a predetermined path
- a navmesh would be the advanced way of doing this
- add a cube to the scene
    - Position: 23 2 6
    - Scale: 1 3 1 
- P, Assets, Script, create Mono, rename: PathFollow
- open in Visual Studio
- acessors:
<pre>

    [SerializeField] int xPos;
    [SerializeField] int zPos;
    [SerializeField] GameObject destination;
    [SerializeField] int position = 1;
</pre>
- switch back to unity
- H, rclick, create, 3d, cube
    - Position: 22 1 -6
- back to the script
<pre>
... ok, you can watch the video if you want the authors code. I will not write a coroutine with if statements in it like that
</pre>
- unity
- rename Cube(1) to Destination
- rename Cube to NPC
- attach PathFollow script to NPC
- attach Destination to script Destination
- go back into script and set all the Y=2
- (the reason for that is the shape of the Destination (specifically its Y) is different
- the author, for some reason, is not doing this at all correct (maybe to avoid explaining coroutines to new programmers)
- anyway, a co-routine will pickup right after yield
- this means you don't need positions, or if statements
- just do this:
<pre>
public class PathFollow : MonoBehaviour
{
    [SerializeField] int xPos = 22;
    [SerializeField] int zPos = -6;
    [SerializeField] GameObject destination;
    [SerializeField] bool resetMove= false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resetMove = true;
        destination.transform.position = new Vector3(xPos,2, zPos);
        StartCoroutine(NextDestination());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(destination.transform);
        transform.position = Vector3.MoveTowards(transform.position,
            destination.transform.position,
            0.01f);
        if (resetMove == false)
        {
            resetMove= true;
            StartCoroutine(NextDestination());
        }
    }

    IEnumerator NextDestination()
    { 
        yield return new WaitForSeconds(2f);
        xPos = 22; zPos = -6;
        destination.transform.position = new Vector3(xPos,2, zPos);
        yield return new WaitForSeconds(2f);
        xPos = 16; zPos = -6;
        destination.transform.position = new Vector3(xPos,2, zPos);
        yield return new WaitForSeconds(2f);
        xPos = 20; zPos = 0;
        destination.transform.position = new Vector3(xPos,2, zPos);
        resetMove = false;
    }
}
</pre>
- and even this is bloated
- chuck out the Destination object ; it serves no purpose since author sets xpos and zpos
- in fact, as written, there no need for ANY Serialized fields
- we should pass in a Vector2 array of points for the NPC to follow
- but for now, we will stick with authors original hard coded
<pre>
public class PathFollow : MonoBehaviour
{
    private GameObject destination;

    void Start()
    {
        destination = new GameObject("Destination");
        destination.transform.position = new Vector3(20, 2, 0);
        StartCoroutine(NextDestination());
    }

    void Update()
    {
        transform.LookAt(destination.transform);
        transform.position = Vector3.MoveTowards(transform.position,
            destination.transform.position,
            0.01f);
    }

    IEnumerator NextDestination()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            destination.transform.position = new Vector3(22, 2, -6);
            yield return new WaitForSeconds(2f);
            destination.transform.position = new Vector3(16, 2, -6);
            yield return new WaitForSeconds(2f);
            destination.transform.position = new Vector3(20, 2, 0);
        }
    }
}
</pre>
- NOTE: the coroutine and its while loop. Thats how you do that, maybe with an external flag to stop it.
- I am going to redo the pathing as an exercise later

# Lesson 20: Build an EXE
- [link](https://www.youtube.com/watch?v=7Q_-vjFBe5I&list=PLZ1b66Z1KFKhO7R6Q588cdWxdnVxpPmA8&index=20)

- File - Build Profiles
- Scene List
- You should have one scene, Scenes/SampleScene, and it should be select and be the 0th scene
- select Window, it should be Active, if not, the bottom right will have a button to [Switch Platform]
- Close this for now
- Edit - Project Settings
- select Player
- set Company Name. etc (defaults will work)
- select Quality
- in mine, a lot of settings are missing, URP sets them for me.
- File - Build Profiles - Windows - Build and RUn
- use ...\unity_projects\Builds\Jimmy_Vegas_Intro_Unity6
- (picked a spot outside of the git so that we don't drag unnecessary artifacts into GitHub later)
- game will launch
- Course work ends here; I do have a few small things to "fix"


# Bug/Feature Fix list, from course
## Resolution is 1024x768
- Edit - Project Settings
- FullScreen Mode should be Windowed
- try 1920 x 1080 (or whatever canvas is set to)

## font sizes are bad
- just make them smaller

## GPU coil whine
- probably just add
<pre>
     Application.targetFrameRate = 60;
</pre>
- to your start in StarterScript
- it depends on your GPU, that worked for me

## Name2 is not anchored to top right
- fix is to H, Canvas, Name2 - set anchor to top right

## canvas is always displayed, and buttons don't work
- open StarterScript
- add an accessor for the Canvas
<pre>
    [SerializeField] GameObject canvas;
</pre>
- save, unity, assign Canvas to Canvas
- deactivate Canvas
- back to script
- in update, scan for a key, tab is probably a good choice
<pre>
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            canvas.SetActive(!canvas.activeSelf);
            // Unlock and show the cursor
            if (canvas.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            } else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

            }
        }
</pre>
- thats a bit simple, and should probably be moved to its own code and cleaned up

## there is no exit for code
- in Starterscript, add a QuitGame() method:
<pre>
    public void QuitGame()
    {
        Application.Quit(); // Closes the application
    }
</pre>
- save, unity
- Canvas, dupe the Ding button (Button (1)) rename to ExitButton 
- set ExitButton - Text to "Exit"
- set On Click to StartScript.QuitGame
- NOTE: this does nothing when in IDE mode, and only matters when standalone
- so test with Build and Run


