using UnityEngine;
using System.Collections;
 
public class PlayerMove : MonoBehaviour {

	public GameObject player;
	Vector2 targetPosition;

	void Start () {

		targetPosition = transform.position;
	}
	void Update(){

		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit)){
				targetPosition = hit.point;
				player.transform.position = targetPosition;
			}
		}
	}
}