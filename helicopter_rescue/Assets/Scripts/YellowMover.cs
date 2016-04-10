using UnityEngine;
using System.Collections;

public class YellowMover : MonoBehaviour
{
	public float speed;
	public Vector3 direction;
	
	void Update ()
	{
		transform.Translate (direction * speed * Time.deltaTime);
	}

}
