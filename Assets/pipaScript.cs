using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipaScript : MonoBehaviour {
	float nilaiRandom;
	// Use this for initialization
	void Start () {
		nilaiRandom = Random.Range (-6.03f, -1.66f);
		transform.position = new Vector2 (transform.position.x, nilaiRandom);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, Vector2.left * 1000, Time.deltaTime * 5);
	}
}
