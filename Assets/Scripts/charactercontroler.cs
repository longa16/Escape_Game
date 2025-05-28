using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHAR : MonoBehaviour
{
    public float PlayerSpeed = 5f;
    public int  SpeedRotation  = 5; 
    // Start is called before the first frame update
    public Rigidbody rb;
    public Animator animator;
    public Transform PlayerModel;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //rb.AddForce(new Vector3(horizontal*PlayerSpeed, 0, vertical * PlayerSpeed));
        rb.velocity = (new Vector3(horizontal*PlayerSpeed, rb.velocity.y, vertical * PlayerSpeed));
        Vector3 movmentDirection = new Vector3(horizontal,0,vertical ).normalized; // normalisation de la direction du joueur
        

        if (rb.velocity.magnitude > 0)
        {
            Quaternion playerRotation = Quaternion.LookRotation(movmentDirection);
            PlayerModel.rotation = Quaternion.Lerp(PlayerModel.rotation, playerRotation, SpeedRotation*Time.deltaTime);
            animator.SetInteger("status", 1);
        }
        else
        {
            animator.SetInteger("status", 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetInteger("status", 2);
        }
        else
        {
            animator.SetInteger("status", 1);
        }

    }
}
