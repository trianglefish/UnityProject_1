using UnityEngine;
using System.Collections;

public class CenterChecker : MonoBehaviour {

	GameObject ball;

	void Start ()
	{
		ball = GameObject.Find("Yellow_ball");
	}


	void  OnCollisionEnter2D (Collision2D ball)
	{
		if (ball.gameObject.tag == "yellow_ball") 
		{
			TransformToZero ();
		}
				
	}

	void TransformToZero ()
	{
		ball.transform.localPosition = new Vector3 (0, 0, 0);
	}

}
