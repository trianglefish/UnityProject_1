using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CenterChecker : MonoBehaviour {

	GameObject ball;
	private PlayerController player; //чтобы обращаться к PlayerController
	private int count;
	public Text ballinsideText;
	public TakeDamage td;


	void Update ()
	{
		if (count > 2) {
			td.TakeDmg ();
		} else
			td.EmptyOfBalls ();
	}
				

	void  OnTriggerEnter2D (Collider2D lastBall)
	{
		if (lastBall.tag == "yellow_ball") 
		{
			player.GetBall (lastBall.gameObject.GetComponent<YellowMover> ());//вызвали функцию в PC и передали ей ссылку на вот этот шар с которым ты коллайдишься здесь
			ball = lastBall.gameObject;
			ball.transform.SetParent (transform);
			TransformToZero ();
			ball.GetComponent<YellowMover> ().moving = false;
			count = count + 1;
			SetBallInsideText ();
			ballinsideText.GetComponent<Animator> ().SetTrigger ("ballInside");
			//td.TakeDmg ();
			print ("мама");
		}
				
	}

	void Start()
	{
		player = GameObject.Find ("Player").GetComponent<PlayerController> (); //нашли гейм обжект.взяли его. класс
		count = 0;
		SetBallInsideText ();

	}

	public void SetBallInsideText ()
	{
		ballinsideText.text = "Balls inside: " + count.ToString() + "/5";
		/*if (count >= 5) 
		{
			count = 0;
		} */
	}
	public void SetBallFlewInsideText ()
	{
		count = count - 1;
		ballinsideText.text = "Balls inside: " + count.ToString() + "/5";
		/*if (count <= 0) 
		{
			count = 0;
		}*/
	}

	void TransformToZero ()
	{
		ball.transform.localPosition = transform.position;

	}

}
