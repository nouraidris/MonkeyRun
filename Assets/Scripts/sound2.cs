using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound2 : MonoBehaviour
{
    public static sound2 instance;
    public AudioSource winsource;
    public AudioClip winSound;
   

    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        winsource = GetComponent<AudioSource>();

    }
  

    // Update is called once per frame
    void Update()
    {
     
        }
    }

