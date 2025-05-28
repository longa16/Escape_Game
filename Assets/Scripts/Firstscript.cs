using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class Firstscript : MonoBehaviour
{

   public int speed = 2;
    public bool myBool = true;
    public Rigidbody rb;
    public int Force = 100;
    public GameObject prefab;


    
    // Start is called before the first frame update
    void Start()
    {

       rb =  GetComponent<Rigidbody>();
        
        Debug.Log("Hello");
       // Debug.Log(value2); 
       

    }

    // Update is called once per frame
    void Update()
    {
        


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(horizontal*speed, 0, vertical*speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 100, 0));
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
       
        //Debug.Log("Iteratiion");
        //if (myBool == true)
        //{
        //    Debug.Log("La balle rebondit");

        //}

        //for(int i = 0; i<9; i++)
        //{
        //    Debug.Log( i); 
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    Debug.Log("Boutton appuyé");
        //    //transform.position = new Vector3(0, 0, 0);
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);

        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + -speed);
        //}

    }
}
