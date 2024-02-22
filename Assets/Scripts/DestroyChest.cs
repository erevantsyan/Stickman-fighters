using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChest : MonoBehaviour
{
    public ChestSpawn counts;
    public GameObject Player;
    public int count;

    // Update is called once per frame
    void Update()
    {
        
        if (counts.count == 15 && counts.countChest == 1){
            var i = Random.Range(0, StaticWeapon.ChoiseWeapons.Count);
            count = StaticWeapon.ChoiseWeapons[i];
        }
        if (counts.count == 45 && counts.countChest == 1)
        {
            Destroy(gameObject);
        }
    }

     private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == Player){
            StaticWeapon.CW = counts.countWeap;
            StaticWeapon.reloadWeap = true;
            Destroy(gameObject);
        }
    }
}
