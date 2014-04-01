using UnityEngine;
using System.Collections;

public class _GameHandler : MonoBehaviour {

	public float GameTime;
	public int PlayerMoney;
	public int PlayerFuel;

	public int ActiveHandler;

	public GameObject PlayerShip;
	public GameObject MapHandler;
	public GameObject ShipHandler;
	public GameObject TravelHandler;

	void Start ()
	{
		//ActiveHandler = MapHandler;
	}
	
	void Update ()
	{
		switch(ActiveHandler)
		{
		case 1:
			//instantiate(TravelHandler, Vector3(0,0,0), Quaternion.identity);
			break;
		case 2:
			//instantiate(ShipHandler, Vector3(0,0,0), Quaternion.identity);
			break;
		default:
			//instantiate(MapHandler, Vector3(0,0,0), Quaternion.identity);
			break;
		}
	}
}
