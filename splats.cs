using UnityEngine;
using System.Collections;

public class splats : MonoBehaviour {
    public Sprite splat;
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "box") {
            (GetComponent<Renderer>() as SpriteRenderer).sprite = splat;
            Destroy(GetComponent<Rigidbody2D>());
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
