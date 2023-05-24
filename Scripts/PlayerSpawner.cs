using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
   
    public GameObject ball;
    public Transform[] teleportLocations;
   
  

    public void SpawnPlayer()
    {
        int randomIndex = Random.Range(0, teleportLocations.Length); // Rastgele bir do�ma noktas� se�iyoruz
        
        ball.transform.position = teleportLocations[randomIndex].position; // Karakteri se�ilen do�ma noktas�na yerle�tiriyoruz

    }
}
