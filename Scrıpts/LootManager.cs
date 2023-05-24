using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootManager : MonoBehaviour
{
    public GameObject lootobject;

    private void Start()
    {
        InvokeRepeating("LootMaker", 6f,5f);
    }
    public void LootMaker()
    {
        Vector3 lootpos = new Vector3(Random.Range(-35, 50), 7,Random.Range(-30,80));
        
        Destroy(Instantiate(lootobject, lootpos, Quaternion.identity),5f);
    }
}
