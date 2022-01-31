using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimator;
    float input_x = 0;
    float input_y = 0;
    public float speed = 2.5f;
    bool IsWalking = false;
    void Start()
    {
        IsWalking = false;

    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        IsWalking = (input_x != 0 || input_y != 0);

        if(IsWalking)
        {
            var move = new Vector3(input_x,input_y,0).normalized;
            transform.position += move * speed * Time.deltaTime; 
            playerAnimator.SetFloat("Input_x", input_x);
            playerAnimator.SetFloat("Input_y", input_y);

        }
        playerAnimator.SetBool("IsWalking",IsWalking);

            if(Input.GetButtonDown("Fire1"))
            {
                playerAnimator.SetTrigger("Attack");
            }

    }

}
