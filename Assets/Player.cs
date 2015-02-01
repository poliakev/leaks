using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float JetPackForce = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.AddForce (Vector2.up * JetPackForce);
			
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody2D.AddForce (-Vector2.right * JetPackForce);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody2D.AddForce (Vector2.right * JetPackForce);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody2D.AddForce (-Vector2.up * JetPackForce);
		}
	}
}
