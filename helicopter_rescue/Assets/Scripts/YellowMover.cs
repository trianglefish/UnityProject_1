using UnityEngine;
using System.Collections;

public class YellowMover : MonoBehaviour
{
	public float speed;
	public Vector3 direction;
	public bool stop = false;

	/*Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}*/



	void Update ()
	{
		if (!stop) 
		{
			transform.Translate (direction * speed * Time.deltaTime);
		}


	}

}
