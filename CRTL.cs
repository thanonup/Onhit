using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRTL : MonoBehaviour
{
    public float movementSpeed = 1f;
    public int Status;
    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        AnimatWalking(h, v);

        if (Input.GetKey(KeyCode.Space))
        {
            Status = 2;
            anim.SetInteger("Statas", Status);
        }

    }

    void AnimatWalking(float h , float v)
    {
        if(h != 0f || v != 0)
        {
            Status = 1;
        }
        else
        {
            Status = 0;
        }
        anim.SetInteger("Statas", Status);
        transform.position = transform.position + new Vector3(h * movementSpeed * Time.deltaTime ,0, v * movementSpeed * Time.deltaTime);
    }
}
