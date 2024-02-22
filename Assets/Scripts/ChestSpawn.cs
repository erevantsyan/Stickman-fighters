using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawn : MonoBehaviour
{
    public GameObject Chest;
    public List<Transform> spawnPoints;
    private float time;
    public float startTime = 1;
    public float count = 0;
    public float countChest = 0;
    public int countWeap;


    // Start is called before the first frame update
    void Start()
    {   
        spawnPoints = new List<Transform>(spawnPoints);
        
    }

    void Update(){
        if (time <=0f){
            time = startTime;
            count += 1;
        }
        else time -= Time.deltaTime;

        if (count == 15  && countChest == 0){
            countChest = 1;
            var spawnPoint = Random.Range(0, spawnPoints.Count);
            var i = Random.Range(0, StaticWeapon.ChoiseWeapons.Count);
            countWeap = StaticWeapon.ChoiseWeapons[i];
            Instantiate(Chest, spawnPoints[spawnPoint].transform.position, Quaternion.identity).SetActive(true);
        }
        if (count == 46 && countChest == 1){
            countChest = 0;
            count = 0;
        }

    }
}
