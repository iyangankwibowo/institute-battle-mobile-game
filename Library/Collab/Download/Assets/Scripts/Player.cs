using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject bulletPrefab, king, king2;
	public float bulletSpeed = 10.0f, m_distanceTraveled = 0f;
	private GameObject bulletSpawn;


	// Use this for initialization
	void Start () {
		bulletSpawn = GameObject.Find("BulletSpawn");

	}
	
	// Update is called once per frame

	public void Jump(){
		
         Vector3 up = transform.TransformDirection(Vector3.up);
         this.GetComponent<Rigidbody>().AddForce (up * 7, ForceMode.Impulse);
     }

	void Update () {
	
		var orang = GameObject.Find("Player");
	
		if(Input.GetKeyDown(KeyCode.Space)){
				if(this.transform.position.y==0.5){
				 Jump();}
        }

		
			if(Input.GetButtonDown("Fire1"))
			{
				GameObject tempBullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, Quaternion.identity);
				tempBullet.GetComponent<Rigidbody>().velocity = bulletSpawn.transform.up*bulletSpeed;
			}
		

		if(king==null)
		{
			if (m_distanceTraveled < 60f) 
			jalan();
		}
		if(king2==null)
		{
			if (m_distanceTraveled < 120f) 
			jalan();
		}
		
	}
	void jalan()
	{
		{
    	Vector3 oldPosition = transform.position;
    	transform.Translate(0,0,1 *10* Time.deltaTime);
   		m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
  		}
	}
}
