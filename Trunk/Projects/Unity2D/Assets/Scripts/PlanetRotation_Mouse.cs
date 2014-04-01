using UnityEngine;
using System.Collections;

public class PlanetRotation_Mouse : MonoBehaviour
{

	public int speed;
	public float friction;
	public float lerpSpeed;
	private float xDeg;
	//private float yDeg;
	private Quaternion fromRotation;
	private Quaternion toRotation;
	public float RotStart = 12;

	void Start()
	{
		transform.Rotate(0, RotStart * Time.deltaTime, 0);
	}

	IEnumerator Example()
	{
		print ("called example");
		yield return new WaitForSeconds(5);
		RotStart = 0;
	}

	void Update ()
	{
		transform.Rotate(0, RotStart * Time.deltaTime, 0);
		if (Input.GetMouseButton (0))
		{
			Example();
			xDeg -= Input.GetAxis ("Mouse X") * speed * friction;
			//yDeg += Input.GetAxis ("Mouse Y") * speed * friction;
			fromRotation = transform.rotation;
			toRotation = Quaternion.Euler (/*yDeg,*/ 0, xDeg, 0);
			transform.rotation = Quaternion.Lerp (fromRotation, toRotation, Time.deltaTime * lerpSpeed);
		}
	}
}