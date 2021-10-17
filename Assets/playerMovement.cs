using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour {
	Rigidbody2D Rb;
	public float jumpForce;
	float score;

	public Text scoreTxt;
	public GameObject replay;
	public GameObject gameover;

	void Start () {
		Time.timeScale = 1;
		Rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreTxt.text = "Score : " + score;

		if (Input.GetMouseButtonDown (0)) {
			Rb.velocity = Vector2.up * jumpForce;
		}
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if(collision.gameObject.CompareTag("point")) {
			score++;
		}
		if (collision.gameObject.CompareTag("pipa") ||
			collision.gameObject.CompareTag("ground")) {
			
			Time.timeScale = 0;
			replay.SetActive (true);
			gameover.SetActive (true);

		}
	}

	public void ReplayGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
