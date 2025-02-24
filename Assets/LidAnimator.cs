using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidAnimator : MonoBehaviour
{
    Animator lid_Animator;
    // Start is called before the first frame update
    void Start()
    {
        lid_Animator = gameObject.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            lid_Animator.ResetTrigger("ChestTrigger"); 
            lid_Animator.SetTrigger("ChestTrigger"); 
        }
    }
}
