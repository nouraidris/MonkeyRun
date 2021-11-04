using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound3 : MonoBehaviour
{
    public static sound3 instance;
    public AudioSource losesource;
    public AudioClip loseSound;
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        losesource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
