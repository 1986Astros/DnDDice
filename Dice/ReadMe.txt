You can pull DieControl.vb into your project and that's all you need to use.

-- Additional items in this project --

"All Dice" control panel that shows the 6 types available, and shows off the features of the DieControl. Click a row in ListView to specify that die value.
"DieSaveDialog" can configure a die to save to an image file.

Some possibly useful code samples:

* Draw regular and irregular 3-D shapes for entertainment or marketing purposes (not scientific)
* Basics (and more) of creating a UserControl
* Refresh yourself on why trig was so cool when you first learned it
* Use clipping to update only the relevant changes to an image to reduce flicker
* Use a Timer to animate
* Flip-book animation
* Draw bitmaps with differing transparencies
* Rotate the Graphics surface to draw text at an angle
* Use Reflection to agnostically data bind two objects

If you want to enhance:
* Adding animations - SaveAnimationImages = True in DieControl.vb for some helpful debugging tools.
* Adding die shapes - mimic the way the 6 shapes are rendered.
	- Each die shape has a Sub to draw the faces, edges and verteces.
	- Each die shape has a Sub to create rectangles for rendering and displaying die values.
	- Look at the references to the property Sides, that will lead you to the other changes.

!! Some of the code is annotated with sources that I used. Those sources have other relevant good stuff. !!

CAVEATS
* I intuited and guessed the angles for the 8-sided and 10-sided dice.
* Rollx with axis animation exposes a minor flaw in drawing the animation.
* Some animations include edges in the animation panels. Workaround is to make the font slightly smaller.