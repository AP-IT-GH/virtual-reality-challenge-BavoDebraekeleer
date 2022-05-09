using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSounds : MonoBehaviour
{
    private AudioSource audioData;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        float speed = rb.velocity.magnitude;
        Debug.Log(speed);
        audioData.volume = speed;
        audioData.PlayOneShot(audioData.clip);

    }
}
