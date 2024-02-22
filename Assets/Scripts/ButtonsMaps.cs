using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsMaps : MonoBehaviour
{
    public void LVL_1(){
        SceneManager.LoadScene(3);
    }

    public void Exit(){
        SceneManager.LoadScene(0);
    }
}
