using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public Transform target; //Player
	public float smoothTime = 0.3F; //Camera Damp
	private Vector3 velocity = Vector3.zero;


	void Awake ()
	{


	}


	void FixedUpdate ()
	{
		Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
	}

}
