using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cameraMove : MonoBehaviour
{

    public GameObject player;

    [SerializeField]
    float leftLimit, rightLimit, bottomLimit, UpperLimit;


    void Update()
    {

        transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10f); 

        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
        Mathf.Clamp(transform.position.y, bottomLimit, UpperLimit), transform.position.z);
        
    }

}
