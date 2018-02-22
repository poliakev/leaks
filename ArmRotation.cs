using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 mouse = Input.mousePosition;
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouse);

		Vector2 armToMouse = mouseWorldPosition - transform.position;
		armToMouse.Normalize ();
		Quaternion rotation = Quaternion.FromToRotation (Vector2.up, armToMouse);
		transform.rotation = rotation;


	}
}