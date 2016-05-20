using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour {

	public Slider healthSlider;
	public float startHealth;
	public float currentHealth;
	public AudioClip deathClip;
	public float hitPower;

	void Awake()
	{
		currentHealth = startHealth;
	}

	void Update()
	{
		healthSlider.value = Mathf.Lerp(healthSlider.value, currentHealth, 1 * Time.deltaTime);
	}

	public void TakeDmg ()
	{
		GetComponent<Animator> ().SetBool ("takeDamage", true);
		currentHealth -= hitPower * Time.deltaTime;
		healthSlider.value = currentHealth;
	}

	public void EmptyOfBalls ()
	{
		GetComponent<Animator> ().SetBool ("takeDamage", false);
	}
}
