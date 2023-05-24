using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
   
    public GameObject ball;
    public Transform[] teleportLocations;
   
  

    public void SpawnPlayer()
    {
        int randomIndex = Random.Range(0, teleportLocations.Length); // Rastgele bir doðma noktasý seçiyoruz
        
        ball.transform.position = teleportLocations[randomIndex].position; // Karakteri seçilen doðma noktasýna yerleþtiriyoruz

    }
}
