using UnityEngine;
using System.Collections;

public class CenterChecker : MonoBehaviour {

	GameObject ball;
	private PlayerController player; //чтобы обращаться к PlayerController


	void  OnTriggerEnter2D (Collider2D lastBall)
	{
		if (lastBall.tag == "yellow_ball") 
		{
			player.GetBall (lastBall.gameObject.GetComponent<YellowMover> ());//вызвали функцию в PC и передали ей ссылку на вот этот шар с которым ты коллайдишься здесь
			ball = lastBall.gameObject;
			ball.transform.SetParent (transform);
			TransformToZero ();
			ball.GetComponent<YellowMover> ().moving = false;
			print ("мама");
		}
				
	}

	void Start()
	{
		player = GameObject.Find ("Player").GetComponent<PlayerController> (); //нашли гейм обжект.взяли его. класс
	}

	void TransformToZero ()
	{
		ball.transform.localPosition = transform.position;

	}

}
