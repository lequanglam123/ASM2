using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float maxSpeed;
    public float jumpHeight;

    bool facingRight;

    Rigidbody2D myBody;
    Animator myAnim;
    
    // Start is called before the first frame update
    void Start() 
    {
        myBody = GetComponent<Rigidbody2D>();                  
        myAnim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        myBody.velocity = new Vector2 (move * maxSpeed, myBody.velocity.y);

      
    }
}
