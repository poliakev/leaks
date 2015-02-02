using UnityEngine;
using System.Collections;

public class splats : MonoBehaviour {
    public Sprite splat;
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "box") {
            (renderer as SpriteRenderer).sprite = splat;
            Destroy(rigidbody2D);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
