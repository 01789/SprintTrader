using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateNavPoint : MonoBehaviour
{
	public GameObject navPoint;
	private RaycastHit navPointPos;
	private GameObject navInstance;
	public GameObject StartPoint;
	public GameObject EndPoint;
	public float LineDrawSpeed = 6;
	public List<GameObject> Points = new List<GameObject>();
	private LineRenderer NavigationLine;
	private float counter;
	private float distance;
	private bool canPlace;
	private float totalDistance;

	void Start()
	{
		Points.Add (StartPoint);
		NavigationLine = GetComponent<LineRenderer> ();
		NavigationLine.SetPosition (0, Points[0].transform.position);
		NavigationLine.SetWidth (.01f, .01f);

		canPlace = true;
	}

	void Update()
	{
		if(Input.GetKeyDown("r"))
		{
			while (Points.Count > 1)
			{
				int x = 1;
				Destroy(Points[x]);
				Points.RemoveAt(x);
				x++;
			}
			NavigationLine.SetPosition (0, Points[0].transform.position);
			canPlace = true;
			NavigationLine.SetVertexCount(Points.Count);
		}
		if(Input.GetMouseButtonDown(0) && canPlace)
		{
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit,1000))
			{
				navPointPos = hit;
				PlaceNavPoint();
			}
		}
		if (Input.GetMouseButtonDown (1))
		{
			Points.Add(EndPoint);
			NavigationLine.SetVertexCount(Points.Count);
			for (int i = 0; i < Points.Count; i++)
			{
				NavigationLine.SetPosition (i, Points [i].transform.position);
			}
			canPlace = false;
		}
		for (int i = 0; i < Points.Count; i++)
		{
			Vector3 temp = Points[i].transform.position;
			temp.z = 0;
			Points[i].transform.position = temp;
		}

		/*if (Points.Count > 1)
		{
			counter += .1f / LineDrawSpeed;

			float y = Mathf.Lerp (0, distance, counter);

			Vector3 pointA = Points [Points.Count - 1].transform.position;
			Vector3 pointB = Points [Points.Count].transform.position;

			Vector3 pointAlongLine = y * Vector3.Normalize (pointB - pointA) + pointA;

			NavigationLine.SetPosition (1, pointAlongLine);
		}*/
	}

	void PlaceNavPoint()
	{
		navInstance = Instantiate(navPoint, navPointPos.point, Quaternion.identity) as GameObject;
		Points.Add (navInstance);
		totalDistance += distance;
		NavigationLine.SetVertexCount(Points.Count);
		for (int i = 0; i < Points.Count; i++)
		{
			NavigationLine.SetPosition (i, Points [i].transform.position);
		}

		distance = Vector3.Distance (Points[Points.Count-2].transform.position, Points[Points.Count-1].transform.position);
	}
}