using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBotController : MonoBehaviour
{
    public Animator animate ;
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        Debug.Log(animate);
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow))
        {
            animate.SetBool("walking", true);
        }
        else
        {
            animate.SetBool("walking", false);
        }
    
    }
}
