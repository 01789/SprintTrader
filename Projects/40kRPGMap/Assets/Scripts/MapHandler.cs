using UnityEngine;
using System.Collections;

public class MapHandler : MonoBehaviour
{
	public GameObject Galaxy;

	void Start()
	{
		Instantiate (Galaxy);
	}
}