using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollison : MonoBehaviour
{
   
    public PlayerSpawner playerSpawner;
    public PlayerMovement playerMovement;
    public int score;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "gameoff")
        {
             score += 125;
            playerSpawner.SpawnPlayer();
        }
      
       
   
       
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Loot")
        {
            Destroy(other.gameObject);
            playerMovement.forwardForce += 2;
        }
    }

}
