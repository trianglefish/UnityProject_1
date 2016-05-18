using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float rotationPower;
	[SerializeField] //приватные переменные в инспекторе показывались чтобы
	private GameObject targetYellow;
	[SerializeField]
	private GameObject targetGreen;
	[SerializeField]
	private GameObject targetBlue; //G - g - 
	private YellowMover ball;
	public CenterChecker bic;


    public List<YellowMover> listOfBalls = new List<YellowMover> ();

	void Start ()
	{
		
	}
		
	void Update ()
	{
		if (Input.GetKey ("right"))
			RotateRight ();
		if (Input.GetKey ("left"))
			RotateLeft ();
		if (Input.GetKeyDown ("space") && ball != null) //null чтобы не вызывалась при пустой переменной
			Fire ();
		
	}
		
	void RotateRight ()
	{
		transform.Rotate (0, 0, Time.deltaTime * -rotationPower);
	}

	void RotateLeft ()
	{
		transform.Rotate (0, 0, Time.deltaTime * rotationPower);
	}

	public void GetBall (YellowMover newBall)
	{
		ball = newBall;
		listOfBalls.Add (newBall); //добавили новый шарик в список
	}

	void Fire ()
	{
		ball.direction = targetYellow.transform.position;
		ball.transform.parent = null;
		ball.moving = true;
		listOfBalls.Remove (ball);//удалили шар из списка по фаеру
		print("огонь");
		bic.SetBallFlewInsideText ();
		ball = null;
		if (listOfBalls.Count > 0) 
		{
			ball = listOfBalls [listOfBalls.Count - 1];
		}

	}

}
  