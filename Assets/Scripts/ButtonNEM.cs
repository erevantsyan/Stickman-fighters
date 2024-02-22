using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNEM : MonoBehaviour
{
    public GameObject NEM;
    void OnMouseDown(){
        NEM.SetActive(false);
    }
}
