using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
	public int damage = 20;
	public LayerMask layerdestroy;
    public float distance;
    public Image HP;
    private float DMG;

	//public GameObject impactEffect; //Play an effect on inpact

	// Use this for initialization
	// void Start () {
	// 	Invoke("DestroyBullet", destroyTime);
	// }

	void Update ()
	{
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.right, distance, layerdestroy);
        if (other.collider != null)
        {
            if (other.collider.CompareTag("Ground"))
            {

                Destroy(gameObject);
            }
            if (other.collider.CompareTag("Player"))
            {
                Destroy(gameObject);
                DMG = (float)damage * 0.01f;
                HP.fillAmount -= DMG;
            }
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
	}
}
