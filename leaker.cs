using UnityEngine;
using System.Collections;

public class leaker : MonoBehaviour {
    public const string LAYER_NAME= "Default";
	public GameObject dropPrefab;
	public float spawnInterval;
	public float dropAngular;
	public Vector2 spawnDirection;

	private float spawnTimer;



	// Use this for initialization
	void Start () {
		spawnTimer = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer += Time.deltaTime;
		if (spawnTimer > spawnInterval) {
			GameObject drop = (GameObject)Instantiate(dropPrefab,transform.position,transform.rotation);
			drop.GetComponent<Rigidbody2D>().velocity = spawnDirection;
			drop.GetComponent<Rigidbody2D>().angularVelocity = dropAngular;
			drop.GetComponent<SpriteRenderer>().sortingLayerName = LAYER_NAME;
			spawnTimer = 0;
	}
}
}
