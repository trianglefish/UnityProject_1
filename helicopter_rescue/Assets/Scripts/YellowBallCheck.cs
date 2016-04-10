using UnityEngine;
using System.Collections;

public class YellowBallCheck : MonoBehaviour 
{
	
	void  OnCollisionEnter2D (Collision2D ball)
	{
		if (ball.gameObject.tag == "yellow_ball") {
			Destroy (ball.gameObject);
		}
	}


}
