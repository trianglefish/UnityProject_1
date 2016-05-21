using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CenterChecker : MonoBehaviour {

	GameObject ball;
	private PlayerController player; //чтобы обращаться к PlayerController
	private int count;
	public int countMax;
	public Text ballinsideText;

	public TakeDamage td;
	public HeartAnim heartAnim;

	public AudioClip insideClip; //сюда положим аудио с переменной insideClip
	public AudioClip deathClip;

	AudioSource insdieAudio; //ссылка на аудио источник из которого будет проигрываться аудио

	void Awake()
	{
		insdieAudio = GetComponent<AudioSource> (); //присвоили ссылке компонент из инспектора
	}


	void Update ()
	{
		if (count > countMax) {
			td.TakeDmg ();
		} else
			td.EmptyOfBalls ();    
		if (count > countMax) {
			heartAnim.HittingHeart ();
		} else {
			heartAnim.NotHittingHeart ();
		}
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
			BallInsideSound ();
			SetBallInsideText ();
			ballinsideText.GetComponent<Animator> ().SetTrigger ("ballInside");
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
		ballinsideText.text = "Balls inside: " + count.ToString() + "/"+countMax;
	}

	public void BallInsideSound ()
	{
		insdieAudio.clip = insideClip; //указали какой звук будет проигрываться
		insdieAudio.Play (); // сказали проиграть этот звук
	}

	public void SetBallFlewInsideText ()
	{
		count = count - 1;
		ballinsideText.text = "Balls inside: " + count.ToString() + "/"+countMax;
	}

	void TransformToZero ()
	{
		ball.transform.localPosition = transform.position;
	}

}
