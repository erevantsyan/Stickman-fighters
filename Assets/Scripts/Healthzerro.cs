using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthzerro : MonoBehaviour
{
    public GameObject js;
    public GameObject js1;
    public GameObject js2;
    public GameObject Death;
    public Image HP;
    private int count;

    // Update is called once per frame
    void Update()
    {
        if (HP.fillAmount == 0f){
            js.SetActive(false);
            js1.SetActive(false);
            js2.SetActive(false);
            Death.SetActive(true);
            count = 8;
            StaticWeapon.Monet += count;
        }
    }
}
