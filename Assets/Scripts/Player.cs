 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float force = 8f;
    public float speed = 5f;
    public Transform trans;
    public FixedJoystick js;
    public Animator anim;

    private bool faceRight = true;
    public bool onGround;
    public Transform Groundcheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;
    private bool jumpcontrol;

    public Collider2D poseStand;
    public Collider2D poseSquat;
    public float stp = 0;

    public Transform CheckLadder;
    public float checkRadius1 = 0.04f;
    public bool checkedLadder;
    public LayerMask Ladder;
    public Rigidbody2D rb;
    public float lspeed = 1f;
    public Transform Ladderpos;
    private bool LadderposCheck = true;

    public bool ladmovex;

    public Collider2D box;

    public Transform CheckTp;
    public bool checkedTp1;
    public bool checkedTp2;
    public LayerMask Tp1;
    public Transform TpPos1;
    public LayerMask Tp2;
    public Transform TpPos2;

    private int test = 0;
    public GameObject AK;
    public float offset = 0;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveX = js.Horizontal;
        float moveY = js.Vertical;
        if (js.Vertical < -0.8f && LadderposCheck){
            Ladderpos.position = new Vector3(Ladderpos.position.x, Ladderpos.position.y - 0.3f, Ladderpos.position.z);
            LadderposCheck = false;
        }
        else if (js.Vertical >= -0.8f && !LadderposCheck) {
            Ladderpos.position = new Vector3(Ladderpos.position.x, Ladderpos.position.y + 0.3f, Ladderpos.position.z);
            LadderposCheck = true;
        }
        CheckingGround();
        CheckingLader();
        LaddersMechanics();
        CheckingTp();
        TpMechanics();
        anim.SetFloat("squatcheck", stp);
        if (stp == 1f){

            anim.SetFloat("moveX", Mathf.Abs(moveX));
            anim.SetFloat("moveY", moveY);

            if (ladmovex){
                
                trans.Translate(Vector2.right * moveX * speed * Time.deltaTime);


                if (moveY > 0.5f)
                {
                    if (onGround && !checkedLadder) {
                        jumpcontrol = true;
                    }
                }   
                else {
                    jumpcontrol = false; 
                }
                
                if (jumpcontrol) trans.Translate(Vector2.up * force * Time.deltaTime);
                if (moveX > 0 && !faceRight){
                    flip ();
                }
                else if (moveX < 0 && faceRight){
                    flip ();
                }

            }
            
        }
        SquatCheck();

    }
    
    void flip () {
        faceRight = !faceRight;
        transform.localScale = new Vector3 (transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);
    }

    void CheckingGround(){
        onGround = Physics2D.OverlapCircle(Groundcheck.position, checkRadius, Ground);
        anim.SetBool("onGround", onGround);
    }

    void SquatCheck(){
        if (js.Vertical < -0.8f && onGround)
        {
            anim.SetBool("squat", true);
            poseStand.enabled = false;
            poseSquat.enabled = true;
            stp = 0;
            box.isTrigger = false;
        }
        else{
            anim.SetBool("squat", false);
            poseStand.enabled = true;
            poseSquat.enabled = false;
            stp = 1f;
            box.isTrigger = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(CheckLadder.position, checkRadius1);
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(CheckTp.position, checkRadius1);
    }

    void CheckingLader(){ 
        checkedLadder = Physics2D.OverlapPoint(CheckLadder.position, Ladder);
        anim.SetBool("onLadder", checkedLadder);
    }

    void LaddersMechanics(){
        float moveY = js.Vertical;
        float moveX = js.Horizontal;
        if (checkedLadder) {
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.velocity = new Vector2(0, moveY * lspeed);
            onGround = false;
            ladmovex = false;
        }
        else {
            rb.bodyType = RigidbodyType2D.Dynamic;
            ladmovex = true;
        }
    }

    void CheckingTp(){
        checkedTp1 = Physics2D.OverlapPoint(CheckTp.position, Tp1);
        checkedTp2 = Physics2D.OverlapPoint(CheckTp.position, Tp2);
    }

    void TpMechanics(){
        if (checkedTp1){
            rb.position = new Vector2(TpPos2.position.x, TpPos2.position.y);
        }
        if (checkedTp2){
            rb.position = new Vector2(TpPos1.position.x, TpPos1.position.y);
        }
    }
}