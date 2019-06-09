using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletKingScript : MonoBehaviour {

	private void OnCollisionEnter(Collision collision)
	{
		Destroy(this.gameObject);
		if(collision.gameObject.CompareTag("player"))
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
	void Update()
	{
		if(this.gameObject.transform.position.z<-10){
			Destroy(this.gameObject);
		}
	}

}
