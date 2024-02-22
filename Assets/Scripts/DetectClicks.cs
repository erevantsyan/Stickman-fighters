using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectClicks : MonoBehaviour
{
    // public GameObject b1, b2, b3, fon;
    // public Text Play, Namegame;

    // private bool click;

    void OnMouseDown()
    {
//         if (!click){
//             click = true;
//             Play.gameObject.SetActive (false);
//             Namegame.gameObject.SetActive (false);
//             b1.gameObject.SetActive (false);
//             b2.gameObject.SetActive (false);
//             b3.gameObject.SetActive (false);
//             fon.gameObject.SetActive (false);
//         }
        SceneManager.LoadScene(1);
    }

    // public void changeScene(int scene){
    //     SceneManager.LoadScene(scene);
    // }
}
