using UnityEngine;
using System.Collections;

public class OpenDrydock : MonoBehaviour {

	public GameObject DryDockInterface;
	public static bool InterfaceCounter = true;

	public Material Highlight;

	void OnMouseOver ()
	{
		renderer.material = Highlight;
		if (Input.GetMouseButtonDown (0) && InterfaceCounter == true)
		{
			Instantiate (DryDockInterface);
			InterfaceCounter = false;
		}
	}
}