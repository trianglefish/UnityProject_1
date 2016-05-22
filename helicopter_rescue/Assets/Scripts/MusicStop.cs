using UnityEngine;
using System.Collections;

public class MusicStop : MonoBehaviour {

	public PlayerController pc;

	AudioSource bgmusic;



	void Awake ()
	{
		bgmusic = GetComponent <AudioSource> ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (pc.rotationPower == 0) {
			bgmusic.enabled = false;
		}
	
	}
}
