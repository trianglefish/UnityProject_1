using UnityEngine;
using System.Collections;

public class GreenBallCheck : MonoBehaviour 
{
	
	void  OnTriggerEnter2D (Collider2D ball)
	{
		if (ball.tag == "green_ball") {
			Destroy (ball.gameObject);
		}
	}


}
