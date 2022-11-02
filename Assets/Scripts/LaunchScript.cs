using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScript : MonoBehaviour
{
    public Animation anim;
    public int force;
    private bool isCollide = false;
    [SerializeField] private GameObject Launcher;
    [SerializeField] private GameObject Ball;

    private void OnCollisionEnter(Collision collision)
    {
       isCollide = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollide = false;
    }


    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play();
            if (isCollide)
            {
            Ball.GetComponent<Rigidbody>().AddForce(0, force, -force, ForceMode.Impulse);
            }
        }        
    }
}
