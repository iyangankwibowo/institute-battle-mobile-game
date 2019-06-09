using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
//	public GameObject player;
	public float startPos;
	private void OnCollisionEnter(Collision collision)
	{
		Destroy(this.gameObject);
		if(collision.gameObject.CompareTag("tower"))
		{
			Destroy(collision.gameObject);
		}
		if(collision.gameObject.CompareTag("obstacle"))
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
	void Start()
	{
		startPos = this.transform.position.z;
	}
	void Update()
	{
	if(this.transform.position.z-startPos >= 30){
		Destroy(this.gameObject);
	}
	}

}
