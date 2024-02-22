using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonsWapons : MonoBehaviour
{

    public GameObject DesertDeagle;
    public GameObject AK;
    public GameObject Glock;
    public GameObject M4;
    public GameObject Uzi;
    public Player StickMan; 
    public FixedJoystick js;
    public FixedJoystick jsmain;
    public GameObject bullet_r;
    public GameObject bullet_l;
    public bool checkDD;
    public bool checkAK;
    public bool checkGlock;
    public bool checkM4;
    public bool checkUzi;
    public bool faceRight = true;
    public DestroyChest pr;


    [SerializeField] private float rotationLimit = 40;
    [SerializeField] private float rotationSpeed = 15;


    void Start(){
    }

    void Update()
    {
        StickMan.anim.SetFloat("moveweapY", js.Vertical);
        if (jsmain.Horizontal > 0) {
            faceRight = true;
        }
        else if (jsmain.Horizontal < 0)
        {
            faceRight = false;
        }
        if ((js.Horizontal > 0 || js.Horizontal < 0 || js.Vertical > 0 || js. Vertical < 0) && jsmain.Horizontal == 0 && jsmain.Vertical == 0){
            if (StickMan.onGround && StickMan.ladmovex){
                //guns
                bullet_l.SetActive (true);
                bullet_r.SetActive (true);
                if (StaticWeapon.CW == 0){
                    Glock.SetActive (true);
                    checkGlock = true;
                    StickMan.anim.SetBool("CheckGlock", checkGlock);
                }
                if (StaticWeapon.CW == 1){
                    DesertDeagle.SetActive (true);
                    checkDD = true;
                    StickMan.anim.SetBool("CheckDD", checkDD);
                }
                if (StaticWeapon.CW == 2) {
                    AK.SetActive (true);
                    checkAK = true;
                    StickMan.anim.SetBool("CheckAK", checkAK);
                }
                if (StaticWeapon.CW == 3){
                    M4.SetActive (true);
                    checkM4 = true;
                    StickMan.anim.SetBool("CheckM4", checkM4);
                }
                if (StaticWeapon.CW == 4) {
                    Uzi.SetActive (true);
                    checkUzi = true;
                    StickMan.anim.SetBool("CheckUzi", checkUzi);
                }
            }
        }
        else {
            Glock.SetActive (false);
            checkGlock = false;
            StickMan.anim.SetBool("CheckGlock", checkGlock);
            DesertDeagle.SetActive (false);
            checkDD = false;
            StickMan.anim.SetBool("CheckDD", checkDD);
            AK.SetActive (false);
            checkAK = false;
            StickMan.anim.SetBool("CheckAK", checkAK);
            M4.SetActive (false);
            checkM4 = false;
            StickMan.anim.SetBool("CheckM4", checkM4);
            Uzi.SetActive (false);
            checkUzi = false;
            StickMan.anim.SetBool("CheckUzi", checkUzi);
        }
        // StickMan.anim.SetBool("CheckAK", checkAK);
        // StickMan.anim.SetBool("CheckDD", checkDD);
    }
}