using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObjects : MonoBehaviour
{
    
    public GameObject Weapons;
    public GameObject WeaponsButton;
    private Vector3 screenPoint, offset;
    private float _lockedYPos;

    void Update(){
        if(Weapons.transform.position.x > 0){ 
            Weapons.transform.position = Vector3.MoveTowards (Weapons.transform.position, new Vector3 (0f, Weapons.transform.position.y, Weapons.transform.position.z), Time.deltaTime * 100f);
            WeaponsButton.transform.position = Vector3.MoveTowards (WeaponsButton.transform.position, new Vector3 (0f, WeaponsButton.transform.position.y, WeaponsButton.transform.position.z), Time.deltaTime * 100f);
        }
        else if(Weapons.transform.position.x < -8f) {
            Weapons.transform.position = Vector3.MoveTowards (Weapons.transform.position, new Vector3 (-8f, Weapons.transform.position.y, Weapons.transform.position.z), Time.deltaTime * 100f);
            WeaponsButton.transform.position = Vector3.MoveTowards (WeaponsButton.transform.position, new Vector3 (-8f, WeaponsButton.transform.position.y, WeaponsButton.transform.position.z), Time.deltaTime * 100f);
        }
    }

    void OnMouseDown (){
        _lockedYPos = screenPoint.x;
        offset = Weapons.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag (){
        Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
        curPosition.y = _lockedYPos;
        Weapons.transform.position = curPosition;
        WeaponsButton.transform.position = curPosition;
    }
}
