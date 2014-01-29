using UnityEngine;
using System.Collections;

public class LayeredMap : MonoBehaviour
{
	//These are the selection zones for the current map layer - used to destroy when moving up or down
	public GameObject Current;
	//The Hierarchy is Galaxy => Segmentum => Sector => Star System => Planet => Location
	//Going Up is bigger, down is smaller.
	public GameObject Up;
	public GameObject Down;

	//Material references for the mouse-over
	public Material Highlight;
	public Material UnHighlight;

	void Start()
	{
		//Sets all selection zones as blank (color needed in editor to see them for placement)
		renderer.material = UnHighlight;
	}

	void Update()
	{
		//Right click to go Up.
		if(Input.GetMouseButtonDown(1))
		{
			Instantiate(Up);
			Destroy(Current);
		}
	}
	
	void OnMouseOver()
	{
		renderer.material = Highlight;
		//Left click to go Down.
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(Down);
			Destroy(Current);
		}
	}

	void OnMouseExit()
	{
		renderer.material = UnHighlight;
	}
}