using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float rotationPower;
	[SerializeField]
	private GameObject targetYellow;
	[SerializeField]
	private GameObject targetGreen;
	[SerializeField]
	private GameObject targetBlue; //G - g - 
	private YellowMover ball;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetKey ("right"))
			RotateRight ();
		if (Input.GetKey ("left"))
			RotateLeft ();
		if (Input.GetKey ("space") && ball != null) //null чтобы не вызывалась при пустой переменной
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
	}
	void Fire ()
	{
		ball.direction = targetYellow.transform.position;
		ball.moving = true;
		ball = null;
	}


		
}
