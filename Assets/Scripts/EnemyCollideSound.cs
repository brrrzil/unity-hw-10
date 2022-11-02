using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollideSound : MonoBehaviour
{
    private AudioSource aud;

    private void OnCollisionEnter(Collision collision)
    {
        aud.Play();
    }

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
