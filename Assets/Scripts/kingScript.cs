using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class kingScript : MonoBehaviour {
	
	public Rigidbody obstacle1, obstacle2,player;

	public int blood=10;
	void OnCollisionEnter(Collision collision)
	{

		if(collision.gameObject.CompareTag("bullet"))
		{

			blood=blood-1;
		}
		if(blood==0)
		{
			Destroy(this.gameObject);
			Destroy(obstacle1.gameObject);
			Destroy(obstacle2.gameObject);
			 GameObject[] obstacles = GameObject.FindGameObjectsWithTag("kingbullet");
   			foreach(GameObject obstacle in obstacles)
   			GameObject.Destroy(obstacle);
		}
	}
	
}
