using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class YellowBallCheck : MonoBehaviour 
{
	/*public AudioClip ballDeathClip;
	public Slider staminaSlider;
	public float startStamina;
	public float currentStamina;
	public float fatiguePower;
	public TakeDamage takeDamage;*/

	public AudioClip ballDeathClip;
	public Slider healthSlider;
	public float startHealth;
	public float currentHealth;
	public float hitPower;

	public HeartAnim heartAnim;



	AudioSource ballDeathAudio;


	void Awake ()
	{
		ballDeathAudio = GetComponent<AudioSource> ();
		currentHealth = startHealth;
	}
	
	void  OnTriggerEnter2D (Collider2D ball)
	{
		if (ball.tag == "yellow_ball") {
			ball.gameObject.GetComponent<YellowMover> ().moving = false; //запретил двигаться объекту
			Destroy (ball.gameObject, 0.5f); //время до смерти
			currentHealth -= hitPower;
			healthSlider.value = currentHealth;
			heartAnim.HittingHeart ();
			ballDeathAudio.clip = ballDeathClip;
			ballDeathAudio.Play ();


		}

		//print ("collide" + ball.gameObject.name);

		ball.GetComponent<Animator>().SetTrigger("blow");
	}
}
