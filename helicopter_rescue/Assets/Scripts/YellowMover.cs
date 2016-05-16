using UnityEngine;
using System.Collections;

public class YellowMover : MonoBehaviour
{
	public float speed;
	public Vector3 direction;
	public bool moving = true;

	/*Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}*/



	void Update () //нихуя не понял
	{
		if (moving) 
		{
			transform.Translate (direction * speed * Time.deltaTime, Space.World);
		}


	}

}
