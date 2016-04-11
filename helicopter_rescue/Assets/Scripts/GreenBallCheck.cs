using UnityEngine;
using System.Collections;

public class GreenBallCheck : MonoBehaviour 
{
	
	void  OnCollisionEnter2D (Collision2D ball)
	{
		if (ball.gameObject.tag == "green_ball") {
			Destroy (ball.gameObject);
		}
	}


}
