using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public Sprite buttonPressed, buttonReleased;

	void OnMouseDown()
	{
		GetComponent <SpriteRenderer> ().sprite = buttonPressed;
	}

	void OnMouseUp()
	{
		GetComponent <SpriteRenderer> ().sprite = buttonReleased;
	}

	void OnMouseUpAsButton () //функция, которая проверяетя, чтобы кнопка нажималась в пределах коллайдера. Т.е. если нажмем, отведем палец от кнопки и отпустим - кнопка не нажмется
	{
		switch (gameObject.name) {                         //проверяем кейсы: если имея объекта gameObject.name совпадает с кейсом - загружаем лвл
		case "playButton":
			Application.LoadLevel ("level_1");
			break;
		case "information":
			Application.OpenURL ("http://google.com");     //проверяем кейсы: если имея объекта gameObject.name совпадает с кейсом - загружаем переходим по ссылке
            break;
		case "main_menu":
			Application.LoadLevel ("Main");
			break;
		}

	}
	 
}
