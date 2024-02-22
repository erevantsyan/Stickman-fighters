using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonShopScene : MonoBehaviour
{

    public GameObject WeaponsObj;
    public GameObject WeaponsObjBut;
    public GameObject WeaponsImg;
    public GameObject WeaponsMObj;
    public GameObject WeaponsMObjBut;
    public GameObject WeaponsMImg;
    public GameObject WeaponsStart;
    public GameObject WeaponsMStart;
    public GameObject MoneyStart;
    public GameObject DE;
    public GameObject NEM;
    public Text Coins;
    public static Image DEimage;
    public static Text DEtxt;
    public static GameObject Ak;
    public static Image Akimage;
    public static Text Aktxt;
    public static GameObject M4;
    public static Image M4image;
    public static Text M4txt;
    public static GameObject Uzi;
    public static Image Uziimage;
    public static Text Uzitxt;
    public static GameObject Knife;
    public static Image Knifeimage;
    public static Text Knifetxt;
    private bool CheckWeapons = true;
    private bool CheckWeaponsMelee = false;


    void Update(){
        Coins.text = $"{StaticWeapon.Monet}";
    }  

    public void NEMBut(){
        NEM.SetActive (false);
        if (CheckWeapons){
            WeaponsObj.SetActive (true);
            WeaponsImg.SetActive (true);
            WeaponsObjBut.SetActive (true);
            WeaponsStart.SetActive (true);
        }
        if (CheckWeaponsMelee){
            WeaponsMObj.SetActive (true);
            WeaponsMImg.SetActive (true);
            WeaponsMObjBut.SetActive (true);
            WeaponsMStart.SetActive (true);
        }
    }

    public void Exit(){
        SceneManager.LoadScene(0);
    }

    public void Weapons(){
        WeaponsObj.SetActive (true);
        WeaponsImg.SetActive (true);
        WeaponsMObj.SetActive (false);
        WeaponsMImg.SetActive (false); 
        WeaponsStart.SetActive (false);
        WeaponsMStart.SetActive (false);
        MoneyStart.SetActive (false);
        WeaponsObjBut.SetActive (true);
        WeaponsMObjBut.SetActive (false);
        CheckWeapons = true;
        CheckWeaponsMelee = false;
    }

    public void MeleeWeapons(){
        WeaponsObj.SetActive (false);
        WeaponsImg.SetActive (false);
        WeaponsMObj.SetActive (true);
        WeaponsMImg.SetActive (true);
        WeaponsObjBut.SetActive (false);
        WeaponsMObjBut.SetActive (true);
        WeaponsStart.SetActive (false);
        WeaponsMStart.SetActive (false);
        MoneyStart.SetActive (false);
        CheckWeapons = false;
        CheckWeaponsMelee = true;
    }

    public void MoneyButton(){
        WeaponsObj.SetActive (false);
        WeaponsImg.SetActive (false);
        WeaponsMObj.SetActive (false);
        WeaponsMImg.SetActive (false);
        WeaponsObjBut.SetActive (false);
        WeaponsMObjBut.SetActive (false);
        WeaponsStart.SetActive (false);
        WeaponsMStart.SetActive (false);
        MoneyStart.SetActive (true);
        NEM.SetActive (false);
        CheckWeapons = false;
        CheckWeaponsMelee = false;
    }

    public void ButtonDE(){
        if (DE.CompareTag("Buy")){
            if (StaticWeapon.Monet < 540)
            {
                NEM.SetActive (true);
                WeaponsObj.SetActive (false);
                WeaponsImg.SetActive (false);
                WeaponsMObj.SetActive (false);
                WeaponsMImg.SetActive (false);
                WeaponsStart.SetActive (false);
                WeaponsObjBut.SetActive (false);
                WeaponsMObjBut.SetActive (false);
            }
            else {
                DE.tag = "Select_on";
                DEimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
                DEtxt.text = "Selected";
                StaticWeapon.Monet -= 540;
                StaticWeapon.ChoiseWeapons.Add(1);
            }

        }
        else if (DE.CompareTag("Select_on")){
            DE.tag = "Select_off";
            DEimage.color = new Color(1f, 1f, 1f, 1f);
            DEtxt.text = "removed";
            DEtxt.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            StaticWeapon.ChoiseWeapons.Remove(1);
        }
        else if (DE.CompareTag("Select_off")){
            DE.tag = "Select_on";
            DEimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            DEtxt.text = "Selected";
            DEtxt.color = new Color(1f, 1f, 1f, 1f);
            StaticWeapon.ChoiseWeapons.Add(1);
        }
    }

    public void ButtonAK(){
        if (Ak.CompareTag("Buy")){
            if (StaticWeapon.Monet < 790)
            {
                NEM.SetActive (true);
                WeaponsObj.SetActive (false);
                WeaponsImg.SetActive (false);
                WeaponsMObj.SetActive (false);
                WeaponsMImg.SetActive (false);
                WeaponsStart.SetActive (false);
                WeaponsObjBut.SetActive (false);
                WeaponsMObjBut.SetActive (false);
            }
            else {
                Ak.tag = "Select_on";
                Akimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
                Aktxt.text = "Selected";
                StaticWeapon.Monet -= 790;
                StaticWeapon.ChoiseWeapons.Add(2);
            }

        }
        else if (Ak.CompareTag("Select_on")){
            Ak.tag = "Select_off";
            Akimage.color = new Color(1f, 1f, 1f, 1f);
            Aktxt.text = "removed";
            Aktxt.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            StaticWeapon.ChoiseWeapons.Remove(2);
        }
        else if (Ak.CompareTag("Select_off")){
            Ak.tag = "Select_on";
            Akimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            Aktxt.text = "Selected";
            Aktxt.color = new Color(1f, 1f, 1f, 1f);
            StaticWeapon.ChoiseWeapons.Add(2);
        }
    }

    public void ButtonM4(){
        if (M4.CompareTag("Buy")){
            if (StaticWeapon.Monet < 870)
            {
                NEM.SetActive (true);
                WeaponsObj.SetActive (false);
                WeaponsImg.SetActive (false);
                WeaponsMObj.SetActive (false);
                WeaponsMImg.SetActive (false);
                WeaponsStart.SetActive (false);
                WeaponsObjBut.SetActive (false);
                WeaponsMObjBut.SetActive (false);
            }
            else {
                M4.tag = "Select_on";
                M4image.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
                M4txt.text = "Selected";
                StaticWeapon.Monet -= 870;
                StaticWeapon.ChoiseWeapons.Add(3);
            }

        }
        else if (M4.CompareTag("Select_on")){
            M4.tag = "Select_off";
            M4image.color = new Color(1f, 1f, 1f, 1f);
            M4txt.text = "removed";
            M4txt.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            StaticWeapon.ChoiseWeapons.Remove(3);
        }
        else if (M4.CompareTag("Select_off")){
            M4.tag = "Select_on";
            M4image.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            M4txt.text = "Selected";
            M4txt.color = new Color(1f, 1f, 1f, 1f);
            StaticWeapon.ChoiseWeapons.Add(3);
        }
    }

    public void ButtonUzi(){
        if (Uzi.CompareTag("Buy")){
            if (StaticWeapon.Monet < 690)
            {
                NEM.SetActive (true);
                WeaponsObj.SetActive (false);
                WeaponsImg.SetActive (false);
                WeaponsMObj.SetActive (false);
                WeaponsMImg.SetActive (false);
                WeaponsStart.SetActive (false);
                WeaponsObjBut.SetActive (false);
                WeaponsMObjBut.SetActive (false);
            }
            else {
                Uzi.tag = "Select_on";
                Uziimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
                Uzitxt.text = "Selected";
                StaticWeapon.Monet -= 690;
                StaticWeapon.ChoiseWeapons.Add(4);
            }

        }
        else if (Uzi.CompareTag("Select_on")){
            Uzi.tag = "Select_off";
            Uziimage.color = new Color(1f, 1f, 1f, 1f);
            Uzitxt.text = "removed";
            Uzitxt.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            StaticWeapon.ChoiseWeapons.Remove(4);
        }
        else if (Uzi.CompareTag("Select_off")){
            Uzi.tag = "Select_on";
            Uziimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            Uzitxt.text = "Selected";
            Uzitxt.color = new Color(1f, 1f, 1f, 1f);
            StaticWeapon.ChoiseWeapons.Add(4);
        }
    }

    public void ButtonKnife(){
        if (Knife.CompareTag("Buy")){
            if (StaticWeapon.Monet < 690)
            {
                NEM.SetActive (true);
                WeaponsObj.SetActive (false);
                WeaponsImg.SetActive (false);
                WeaponsMObj.SetActive (false);
                WeaponsMImg.SetActive (false);
                WeaponsStart.SetActive (false);
                WeaponsObjBut.SetActive (false);
                WeaponsMObjBut.SetActive (false);
            }
            else {
                Knife.tag = "Select_on";
                Knifeimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
                Knifetxt.text = "Selected";
                StaticWeapon.Monet -= 690;
                StaticWeapon.ChoiseWeapons2 = 1;
            }

        }
       if (Knife.CompareTag("Select_on")){
            Knife.tag = "Select_off";
            Knifeimage.color = new Color(1f, 1f, 1f, 1f);
            Knifetxt.text = "removed";
            Knifetxt.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            StaticWeapon.ChoiseWeapons2 = 1;
        }
        else if (Knife.CompareTag("Select_off")){
            Knife.tag = "Select_on";
            Knifeimage.color = new Color(0.1215686f, 0.7137255f, 0.4784314f, 1f);
            Knifetxt.text = "Selected";
            Knifetxt.color = new Color(1f, 1f, 1f, 1f);
            StaticWeapon.ChoiseWeapons2 = 0;
        }
    }
}