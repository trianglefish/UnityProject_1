using UnityEngine;
using System.Collections;

public class CenterChecker : MonoBehaviour {

	GameObject ball;

	void  OnTriggerEnter2D (Collider2D lastBall)
	{
		if (lastBall.tag == "yellow_ball") 
		{
			ball = lastBall.gameObject;
			ball.transform.SetParent (transform);
			TransformToZero ();
			ball.GetComponent<YellowMover> ().moving = false;
			print ("мама");
		}
				
	}

	void TransformToZero ()
	{
		ball.transform.localPosition = transform.position;

	}

}
