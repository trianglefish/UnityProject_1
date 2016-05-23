using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public Sprite buttonPressed, buttonReleased;
	public string action; //переменная для определения действий пользователя

	void OnMouseDown()
	{
		GetComponent <SpriteRenderer> ().sprite = buttonPressed;
	}

	void OnMouseUp()
	{
		GetComponent <SpriteRenderer> ().sprite = buttonReleased;
	}

	void OnMouseAsButton () //функция, которая проверяетя, чтобы кнопка нажималась в пределах коллайдера
	{
		switch (gameObject.name) {
		case "playButton":
			Application.LoadLevel (1);
			break;
		case "information":
			Application.OpenURL ("http://google.com");
			print ("где ссыль блять");
            break;
		}
	}
	 
}
