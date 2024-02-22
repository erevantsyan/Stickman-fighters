using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 20f;
	public int damage = 40;
	public float destroyTime;
	public Rigidbody2D rb;
	//public GameObject impactEffect; //Play an effect on inpact

	// Use this for initialization
	// void Start () {
	// 	Invoke("DestroyBullet", destroyTime);
	// }

	void Update ()
	{
		transform.Translate(Vector2.up * speed * Time.deltaTime);
	}
	// private void DestroyBullet(){
	// 	Destroy(gameObject);
	// }
}