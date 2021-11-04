using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager instance;
    public AudioSource coinsscource;
    public AudioClip coinSound;
   
   

    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinsscource = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
