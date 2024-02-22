using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M4 : MonoBehaviour
{

    public GameObject bullet_r;
    public GameObject bullet_l;
    public ButtonsWapons faceB;
    public Transform point;
    private float time;
    public float startTime;
    public float offset;
    public FixedJoystick js;
    public FixedJoystick jsmain;
    public GameObject weap;
    public DestroyChest pr;

    public int currentAmmo = 30;
    public int allAmmo = 60;

    [SerializeField]
    private Text ammoCount;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticWeapon.CW == 3){
            if (StaticWeapon.reloadWeap){
                StaticWeapon.reloadWeap = false;
                currentAmmo = 30;
                allAmmo = 60;
            }
            if (js.Horizontal > 0 && faceB.faceRight){
                float rotatez = Mathf.Atan2(js.Vertical, Mathf.Abs(js.Horizontal)) * Mathf.Rad2Deg;
                weap.transform.rotation = Quaternion.Euler(0f, 0f, rotatez + offset);
            }
            else if (js.Horizontal < 0 && !faceB.faceRight){
                float rotatez = Mathf.Atan2(-1f * js.Vertical, Mathf.Abs(js.Horizontal)) * Mathf.Rad2Deg;
                weap.transform.rotation = Quaternion.Euler(0f, 0f, rotatez + offset);
            }
            
            if (time <=0f){
                if (js.Horizontal != 0 && js.Vertical != 0 && faceB.faceRight && currentAmmo > 0){
                    Instantiate(bullet_r, point.position, weap.transform.rotation);
                    currentAmmo -= 1;
                    time = startTime;
                }
                else if (js.Horizontal != 0 && js.Vertical != 0 && !faceB.faceRight && currentAmmo > 0){
                    Instantiate(bullet_l, point.position, weap.transform.rotation);
                    currentAmmo -= 1;
                    time = startTime;
                }
            }
            else time -= Time.deltaTime;
            
            ammoCount.text = currentAmmo + " / " + allAmmo;

            if (currentAmmo == 0 && allAmmo > 0)
            {
                Reload();
            }
        }
    }

    void Reload(){
        currentAmmo = 30;
        allAmmo -= 30;
    }
}