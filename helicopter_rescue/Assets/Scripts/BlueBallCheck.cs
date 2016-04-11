using UnityEngine;
using System.Collections;

public class BlueBallCheck : MonoBehaviour 
{
	
	void  OnCollisionEnter2D (Collision2D ball)
	{
		if (ball.gameObject.tag == "blue_ball") {
			Destroy (ball.gameObject);
		}
	}


}
