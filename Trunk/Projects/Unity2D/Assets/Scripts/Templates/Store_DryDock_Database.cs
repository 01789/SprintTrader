using UnityEngine;
using System.Collections;

public class Store_DryDock_Database : MonoBehaviour
{
	public GameObject[] Ship;
	public GameObject[] Reactors;
	public GameObject[] Shields;
	public GameObject[] Armors;
	public GameObject[] CargoBays;
	public GameObject[] Sensors;
	public GameObject[] FTLDrives;
	public GameObject[] LifeSupportSystems;
	public GameObject[] Equipment;
	public GameObject[] PortWeapons;

	void OnGUI ()
	{
		if (GUI.Button (new Rect (10, 10, 150, 50), "Reactor"))
		{
			Instantiate(Reactors[0], gameObject.transform.position, gameObject.transform.rotation);
		}
		if (GUI.Button (new Rect (10,70,150,50), "Weapon 1"))
		{
			Instantiate (PortWeapons[0], gameObject.transform.position, gameObject.transform.rotation);
		}
		if (GUI.Button (new Rect (10,130,150,50), "Weapon 2"))
		{
			Instantiate (PortWeapons[1], gameObject.transform.position, gameObject.transform.rotation);
		}
		if (GUI.Button (new Rect (10,190,150,50), "Exit"))
		{
			OpenDrydock.InterfaceCounter = true;
			Destroy(gameObject);
		}
	}
	

	void Update ()
	{
	}
}
