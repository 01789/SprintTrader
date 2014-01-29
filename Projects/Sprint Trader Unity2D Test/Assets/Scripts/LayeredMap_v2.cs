using UnityEngine;
using System.Collections;

public class LayeredMap_v2 : MonoBehaviour
{
	public GameObject Backdrop;

	public Material Highlight;
	public Material UnHighlight;

	//http://wiki.unity3d.com/index.php?title=Which_Kind_Of_Array_Or_Collection_Should_I_Use?
	public GameObject[] LandmarkArray = new GameObject[1];

	//public bool PlanetIsDown;

	void Start()
	{
		//Set all selection zones as blank (color needed in editor to see them for placement)
		foreach(GameObject gameObject in LandmarkArray) 
		{
			gameObject.renderer.material = UnHighlight;
		}
	}

	void Update()
	{
		if (Input.GetMouseButtonDown (1))
		{
			/*Backdrop.renderer.material = Up;
			Instantiate (UpSelectionZones);
			Destroy (gameObject); */
		}
	}

	void OnMouseOver()
	{
		for (int i = 0; i < LandmarkArray.Length; i++)
		{
			print ("mouse over " + gameObject);
			//Current.renderer.material = Highlight;
			if(Input.GetMouseButtonDown(0))
			{
				/*Backdrop.renderer.material = Down;
				Instantiate(DownSelectionZones);
				Destroy(gameObject);
				/*if(DownIsAPlanet)
				{
					enable Planet_prefab
					with Planet_Name_Material
					and Planet_Name_SelectionZones
				}*/
			}
		}
	}

	void OnMouseExit()
	{
		renderer.material = UnHighlight;
	}
}