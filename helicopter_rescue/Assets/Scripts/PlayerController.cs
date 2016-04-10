using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float rotationPower;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetKey ("right"))
			RotateRight ();
		if (Input.GetKey ("left"))
			RotateLeft ();
	}
		
	void RotateRight ()
	{
		transform.Rotate (0, 0, Time.deltaTime * -rotationPower);
	}

	void RotateLeft ()
	{
		transform.Rotate (0, 0, Time.deltaTime * rotationPower);
	}
		
}
