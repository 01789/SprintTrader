using UnityEngine;
using System.Collections;

public class ExampleChooser_Script : MonoBehaviour
{
	void OnGUI()
	{
		if (GUI.Button (new Rect (10, 10, 150, 50), "Landmark Travel")) {
				Application.LoadLevel (1);
		}
		if (GUI.Button (new Rect (10, 70, 150, 50), "Nav Point Travel")) {
				Application.LoadLevel (2);
		}
		if (GUI.Button (new Rect (10, 130, 150, 50), "Layered Map")) {
				Application.LoadLevel (3);
		}
		if (GUI.Button (new Rect (10, 190, 150, 50), "Store and Drydock")) {
				Application.LoadLevel (4);
		}
	}
}
