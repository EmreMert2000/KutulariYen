using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

using UnityEngine.SocialPlatforms.Impl;


public class Tekrar : MonoBehaviour
{
    public float yükseklik, yer;
    public Transform ilk;
    public Text skore;
    public TextMeshProUGUI skortutucu, livescore;
    public int puan = 0;
    public int  maxskor;
   
    public GameObject kutu;
    public GameObject oyunsonu;
    public GameObject design;
    
    
   // public Button menübutton;
    
    public FixedJoystick fixedJoystick;
    public Rigidbody rb;
    public MeshRenderer[] renderers;
    
    void Start()
    {
        
       
        maxskor = PlayerPrefs.GetInt("maxskor");
        
        
    }
  
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        
        rb.velocity = new Vector3(fixedJoystick.Horizontal * 5f, rb.velocity.y, fixedJoystick.Vertical * 5f);
       
        if (transform.position.z >= yer || transform.position.y<=yükseklik)
        {
            
            design.gameObject.SetActive(false);
            oyunsonu.gameObject.SetActive(true);
            fixedJoystick.gameObject.SetActive(false);
          //  menübutton.gameObject.SetActive(false);
            
            
            
            
        }
       

    }
   
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Görünmez"))
        {
            puan += 25;
            skore.text = "Skor:" + puan;
            Color newcolor = Random.ColorHSV(0f, .25f, 0.4f, 1f);
            
            UygulamaMateryal(newcolor, 0);
            Destroy(Instantiate(kutu, transform.position, Quaternion.identity),2f);
            
            if (puan>=maxskor)
            {
                maxskor = puan;
                PlayerPrefs.SetInt("maxskor", puan);
                skortutucu.text = "High Score:" +puan;
            }
            else
            {
                maxskor = PlayerPrefs.GetInt("maxskor");
                skortutucu.text = "High Score:" +maxskor;
            }
            PlayerPrefs.SetInt("maxskor", maxskor);
            

        }
        if (other.gameObject.tag=="gameoff")
        {
            design.gameObject.SetActive(false);
            oyunsonu.gameObject.SetActive(true);
            fixedJoystick.gameObject.SetActive(false);
        }
       




    }
    void UygulamaMateryal(Color color, int target)
    {

        Material genarel = new Material(Shader.Find("Standard"));
        genarel.SetColor("_Color", color);


        for (int i = 0; i < renderers.Length; i++)
        {

            renderers[i].material = genarel;

        }
    } 
   
    

}

