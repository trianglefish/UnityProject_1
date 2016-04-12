using UnityEngine;
using System.Collections;

public class YellowBallCheck : MonoBehaviour 
{
	
	void  OnTriggerEnter2D (Collider2D ball)
	{
		if (ball.tag == "yellow_ball") {
			Destroy (ball.gameObject);
		}
	}


}
