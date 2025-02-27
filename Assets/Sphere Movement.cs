using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public GameObject _target;
    public float distance;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        distance = Vector3.Distance(this.transform.position, _target.gameObject.transform.position);
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetFloat("Distance", distance);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            this.transform.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            this.transform.position += new Vector3(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.W)) 
        {
            this.transform.position += new Vector3(0, 0, 1);
        }
        else if (Input.GetKeyDown(KeyCode.S)) 
        {
            this.transform.position += new Vector3(0, 0, -1);
        }

        distance = Vector3.Distance(this.transform.position, _target.gameObject.transform.position);
        m_Animator.SetFloat("Distance", distance);
    }

    

}
