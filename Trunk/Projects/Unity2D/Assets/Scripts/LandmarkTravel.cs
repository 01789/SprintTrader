using UnityEngine;
using System.Collections;

//Game save info
//http://answers.unity3d.com/questions/8480/how-to-scrip-a-saveload-game-option.html

public class LandmarkTravel: MonoBehaviour
{
	private Vector3 ObjectSize;
	private GameObject HoveredObject;
	public Material CurrentLocation;
	public Material OpenLocation;
	public Material ClosedLocation;
	static public GameObject YouAreHere;
	private GameObject Destination;
	public LineRenderer NavLine;
	private float distance;
	private float counter;
	private float LineDrawSpeed = 6f;
	private bool Go = false;
	public GUIText DistText;

	void Start()
	{
		ObjectSize = gameObject.transform.localScale;
		if (gameObject.CompareTag ("CurrentLocation"))
		{
			YouAreHere = gameObject;
			NavLine.SetPosition (0, YouAreHere.transform.position);
		}
	}

	void Update()
	{
		if (gameObject.CompareTag("CurrentLocation"))
		{
			renderer.material = CurrentLocation;
		}
		if (gameObject.CompareTag("OpenLocation"))
		{
			renderer.material = OpenLocation;
		}
		if(gameObject.CompareTag("ClosedLocation"))
		{
			renderer.material = ClosedLocation;
		}
		/*if (Go && counter < distance)
		{
			counter += .1f / LineDrawSpeed;
			print (distance);
			float y = Mathf.Lerp (0, distance, counter);
			
			Vector3 pointA = YouAreHere.transform.position;
			Vector3 pointB = Destination.transform.position;
			
			Vector3 pointAlongLine = y * Vector3.Normalize (pointB - pointA) + pointA;
			
			NavLine.SetPosition (1, pointAlongLine);
		}*/
	}

	void OnMouseOver()
	{
		HoveredObject = gameObject;
		distance = Vector3.Distance (YouAreHere.transform.position, HoveredObject.transform.position);
		NavLine.SetPosition (1, HoveredObject.transform.position);
		DistText.text = distance.ToString ();

		if (gameObject.CompareTag("OpenLocation"))
		{
			gameObject.transform.localScale = ObjectSize + (ObjectSize/2);
		}
		if (Input.GetMouseButtonDown (0) && !gameObject.CompareTag("CurrentLocation") && !gameObject.CompareTag("ClosedLocation"))
		{
			Destination = gameObject;
			SetDestination();
		}
	}

	void OnMouseExit()
	{
		gameObject.transform.localScale = ObjectSize;
	}

	void SetDestination()
	{
		YouAreHere.tag = "OpenLocation";
		Destination.tag = "CurrentLocation";
		Go = true;
		YouAreHere = Destination;
	}
}