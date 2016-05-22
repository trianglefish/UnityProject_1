using UnityEngine;
using System.Collections;

public class YelloColliderCheck : MonoBehaviour {

	public int score;
	public int scoreAmount;

	void  OnTriggerEnter2D (Collider2D other)
	{
		other.gameObject.SetActive (false);
		this.gameObject.SetActive (false);
		score = score + scoreAmount;
	}
}
