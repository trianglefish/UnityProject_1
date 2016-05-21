using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour {

	public Slider healthSlider;
	public float startHealth;
	public float currentHealth;
	public float hitPower;
	public PlayerController pc;

	void Awake()
	{
		currentHealth = startHealth;
	}
		
	public void TakeDmg ()
	{
		GetComponent<Animator> ().SetBool ("takeDamage", true);
		currentHealth -= hitPower * Time.deltaTime;
		healthSlider.value = currentHealth;
		if (currentHealth <= 0) {
			currentHealth = 0;
		}
		if (currentHealth <= 0) {
			pc.Death ();
		}
	}

	public void EmptyOfBalls ()
	{
		GetComponent<Animator> ().SetBool ("takeDamage", false);
	}
		
}
