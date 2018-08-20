using UnityEngine;
using System.Collections;

public class DisplayControls : MonoBehaviour
{	
	void OnGUI()
	{
		GUI.Label(new Rect(10, 210, 500, 50), "Panoramic Framework for Unity3D by CreaTech Interactive http://www.createchinteractive.com");	
		GUI.Label(new Rect(10, 250, 500, 50), "Mouse controls : Left click and drag to pan, mouse wheel to zoom, left click to trigger hotspot");	
		GUI.Label(new Rect(10, 290, 500, 50), "Keyboard controls : Arrow keys to pan, + and - keys to zoom");
		GUI.Label(new Rect(10, 320, 500, 50), "Alternatively, use the Gui buttons at the bottom of the screen to navigate with Right Click");
		GUI.Label(new Rect(10, 350, 500, 50), "In this example, there's a hotspot on the eiffel tower that will play a sound when clicked on");	
	}
}
