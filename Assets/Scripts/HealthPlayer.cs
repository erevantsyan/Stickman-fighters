using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class HealthPlayer : MonoBehaviour
{
    public GameObject js;
    public GameObject js1;
    public GameObject but;
    public Image HP;
    public bullet BulletD;
    
	public LayerMask layerdestroy;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.right, distance, layerdestroy);
        if (other.collider.CompareTag("Bullet")){
            HP.fillAmount -= (float)BulletD.damage * 0.01f;
        }
    }
}
