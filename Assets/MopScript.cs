using UnityEngine;
using System.Collections;

public class MopScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "drop")
		{
			Destroy(other.gameObject);
		}
	}
}