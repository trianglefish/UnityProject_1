using UnityEngine;
using System.Collections;

public class YellowBallCheck : MonoBehaviour 
{
	
	void  OnTriggerEnter2D (Collider2D ball)
	{
		if (ball.tag == "yellow_ball") {
			ball.gameObject.GetComponent<YellowMover> ().moving = false; //запретил двигаться объекту
			Destroy (ball.gameObject, 0.5f); //время до смерти 

		}

		//print ("collide" + ball.gameObject.name);

		ball.GetComponent<Animator>().SetTrigger("blow");
	}
}
