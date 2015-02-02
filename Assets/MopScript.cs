using UnityEngine;
using System.Collections;

public class MopScript : MonoBehaviour {
	public AudioClip oilDeath;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "drop")
		{
			Destroy(other.gameObject);
			AudioSource.PlayClipAtPoint(oilDeath,transform.position);
		}
	}
}