using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunchDamage : MonoBehaviour
{
    private bool CheckedDamage;
    public GameObject Player;
    public VirtualButton damag;
    public Image HP;
    private float DMGHP;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.gameObject == Player){
            DMGHP = (float)damag.damage * 0.01f;
            HP.fillAmount -= DMGHP;
        }
    }
}
