using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameObject Knife;
    public Player StickMan; 
    public bool checkweapon;
    public FixedJoystick js;
    public FixedJoystick jsmain;
    public bool checkknife;
    public bool checkPunch;
    public int Prefab;
    public GameObject punch;
    public Collider2D punchStay;
    public Collider2D punchSquad;
    public int damage = 30;


    [SerializeField] private float rotationLimit = 40;
    [SerializeField] private float rotationSpeed = 15;

    public bool rotate = false;

    void Start(){

        Prefab = StaticWeapon.ChoiseWeapons2;
    }

    void FixedUpdate()
    {
        float targetRotate = rotate ? rotationLimit : 0f;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(targetRotate, 0, 0);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed);

        if (js.Horizontal !=0f && js.Vertical >= -0.8f || jsmain.Horizontal != 0 && jsmain.Vertical != 0)
            checkweapon = false;
        if (!checkweapon) 
        {
            checkPunch = false;
            Knife.SetActive (false);
            checkknife = false;
        }
        StickMan.anim.SetBool("checkKnife", checkknife);
        StickMan.anim.SetBool("CheckPunch", checkPunch);
        StickMan.anim.SetBool("UpCheck", rotate);
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotate = true;
        if (StickMan.onGround && StickMan.ladmovex && jsmain.Horizontal == 0 && jsmain.Vertical == 0 && js.Horizontal == 0 && (js.Vertical == 0 || js.Vertical < -0.8f)){
            punch.SetActive (true);
            if (js.Vertical < -0.8f) { 
                punchStay.enabled = false;
                punchSquad.enabled = true;
            }
            else {
                punchStay.enabled = true;
                punchSquad.enabled = false;
            }
            if (Prefab == 0){
                checkweapon = true;
                checkPunch = true;
                damage = 10;
            }
            if (Prefab == 1) {
                Knife.SetActive (true);
                checkweapon = true;
                checkknife = true;
                damage = 15;
            }
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        punch.SetActive (false);
        rotate = false;
    }
}
