using UnityEngine;
using System.Collections;

public class HeartAnim : MonoBehaviour {

	public void HittingHeart ()
	{
		GetComponent<Animator> ().SetBool ("Hitting", true);
	}
	public void NotHittingHeart ()
	{
		GetComponent<Animator> ().SetBool ("Hitting", false);
	}

}
