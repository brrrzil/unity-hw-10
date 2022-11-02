using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    [SerializeField] GameObject LeftFlipper, RightFlipper, TheSun, SecurityLight;
    public int totalScore;
    private AudioSource flip;

    private void Start()
    {
        flip = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            LeftFlipper.gameObject.GetComponent<HingeJoint>().useMotor = true;
            flip.Play();
        }        

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            LeftFlipper.gameObject.GetComponent<HingeJoint>().useMotor = false;
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            RightFlipper.gameObject.GetComponent<HingeJoint>().useMotor = true;
            flip.Play();
        }        

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            RightFlipper.gameObject.GetComponent<HingeJoint>().useMotor = false;
        }

        TheSun.gameObject.transform.Rotate(-0.1f, -0.05f, 0);
        SecurityLight.gameObject.transform.Rotate(0f, 0.3f, 1f);
    }
}
