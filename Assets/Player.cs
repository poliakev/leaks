using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float JetPackForce = 10;
    public GameObject spriteplayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    
        void Update () {

		Vector2 mouse = Input.mousePosition;
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouse);

		Vector2 armToMouse = mouseWorldPosition - transform.position;
        if (armToMouse.x < 0) {
            spriteplayer.transform.localScale = new Vector3 (-1,1,1);
  
        }
        else
        {
            spriteplayer.transform.localScale = new Vector3(1, 1, 1);
        }
    }
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
