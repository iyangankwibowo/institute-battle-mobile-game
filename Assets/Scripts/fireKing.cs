using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireKing : MonoBehaviour {

public GameObject bulletPrefab;
	public float bulletSpeed = 10.0f,fireRateK = 5F;
	private float nextFireK =10f;
	public GameObject bulletSpawn;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if((this.gameObject.transform.position.y<1)&&Time.time > nextFireK)
		{
			nextFireK = Time.time + fireRateK;
			GameObject tempBullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, Quaternion.identity);
			tempBullet.GetComponent<Rigidbody>().velocity = -bulletSpawn.transform.up*bulletSpeed;
			
		}
	}
}
