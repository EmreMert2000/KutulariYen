using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyprefab;
    public int enemycount;
    public Vector3 enemypos;
    public OnTrigger ontrigger;
    public ButtonManager buttonmanager;
    public ScoreManager scoremanager;
    private void Start()
    {
           int enemycount = Random.Range(12,20);
        
        for (int i = 0; i < enemycount; i++)
            {
                Vector3 enemypos = new Vector3(Random.Range(-35,60), 7, -60);
                Instantiate(enemyprefab, enemypos, Quaternion.identity);
            }
        


    }
    private void Update()
    {
        GameObject kutu = GameObject.FindWithTag("Kutu");

        if (kutu != null)
        {
           
        }
        else
        {
            
            buttonmanager.scene();
        }
    }
    
    

}
