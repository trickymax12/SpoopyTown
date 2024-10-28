using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boo : MonoBehaviour
{
    public Rigidbody pumpkinRb;
    private AudioSource PumpkinAudio;
    public AudioClip scare;
    // Start is called before the first frame update
    void Start()
    {
        pumpkinRb = GetComponent<Rigidbody>();
        PumpkinAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
