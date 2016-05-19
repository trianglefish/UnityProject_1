using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour {

	public Slider healthSlider;
	public int startHealth;
	public int currentHealth;
	public AudioClip deathClip;
	public int hitPower;

	void Awake()
	{
		currentHealth = startHealth;
	}

	void Update()
	{
		if (damaged)
	}

	public void TakeDmg ()
	{
        GetComponent<Animator> ().SetTrigger ("FullOfBalls");
		currentHealth -= hitPower;
		healthSlider.value = currentHealth;
		bool damaged;
	}

	public void EmptyOfBalls ()
	{
		GetComponent<Animator> ().SetTrigger ("EmptyOfBalls");
	}
}
