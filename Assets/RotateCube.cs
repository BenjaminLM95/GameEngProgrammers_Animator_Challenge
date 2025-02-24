using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RotateCube : MonoBehaviour
{
    public bool cRot;
    Animator c_Animator;
    public TextMeshProUGUI rotatingStatus;
    private string rotateMessage; 
    // Start is called before the first frame update
    void Start()
    {
        c_Animator = gameObject.GetComponent<Animator>();
        cRot = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            if (!cRot)
                cRot = true;
            else
                cRot = false; 
        }
                

        if(cRot == false) 
        {
            c_Animator.SetBool("Rotate", false);
            rotateMessage = "The cube is still";
        }

        if(cRot == true) 
        {
            c_Animator.SetBool("Rotate", true);
            rotateMessage = "The cube is rotating"; 
        }

        rotatingStatus.text = rotateMessage; 
    }
}
