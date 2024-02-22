using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonLVL : MonoBehaviour
{
    public void Exit(){
        StaticWeapon.CW = 0;
        SceneManager.LoadScene(1);
    }
}
