using UnityEngine;
using System.Collections;

public class PlanetRotation_ArrowKeys : MonoBehaviour
{
	public float xSpeed;
	public float ySpeed;
	public float zSpeed;
	public float KeyIncrease;

	void Update ()
	{
		transform.Rotate(
			xSpeed * Time.deltaTime,
			ySpeed,
			zSpeed * Time.deltaTime
			);

		if(Input.GetKeyUp("left"))
		{
			ySpeed += KeyIncrease;
		}
		if(Input.GetKeyUp("right"))
		{
			ySpeed -= KeyIncrease;
		}
	}
}
