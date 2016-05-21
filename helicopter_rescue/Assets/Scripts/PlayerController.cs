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
	public BallsManager bm;

	bool fireEnable;
	public AudioClip deathClip;
	public AudioClip fireClip;


	AudioSource playerAudio;


    public List<YellowMover> listOfBalls = new List<YellowMover> ();

	void Awake ()
	{
		playerAudio = GetComponent <AudioSource> (); //ссылка на компонт
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
		
	public void RotateRight ()
	{
		transform.Rotate (0, 0, Time.deltaTime * -rotationPower);
	}

	public void RotateLeft ()
	{
		transform.Rotate (0, 0, Time.deltaTime * rotationPower);
	}

	public void GetBall (YellowMover newBall)
	{
		ball = newBall;
		listOfBalls.Add (newBall); //добавили новый шарик в список
	}

	public void Fire ()
	{
		ball.direction = targetYellow.transform.position;
		playerAudio.clip = fireClip;
		playerAudio.Play ();
		ball.transform.parent = null;
		ball.moving = true;
		listOfBalls.Remove (ball);//удалили шар из списка по фаеру
		bic.SetBallFlewInsideText ();
		ball = null;
		if (listOfBalls.Count > 0) 
		{
			ball = listOfBalls [listOfBalls.Count - 1];
		}

	}

	public void Death ()
	{
		rotationPower = 0;
		bm.StopSpawn ();

	}


}
  