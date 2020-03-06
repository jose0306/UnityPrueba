using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    float rotar=30f;
    float move=10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Movement();
    }
    void Rotate(){
        if(Input.GetKey(KeyCode.Q))
        transform.Rotate(new Vector3(0f,-rotar,0f)* Time.deltaTime);
        else if(Input.GetKey(KeyCode.E))
        transform.Rotate(new Vector3(0f,rotar,0f)* Time.deltaTime);
    }
    void Movement(){
        if(Input.GetKey(KeyCode.W))
        transform.Translate(Vector3.forward *move * Time.deltaTime);
         if(Input.GetKey(KeyCode.S))
        transform.Translate(Vector3.back *move* Time.deltaTime);
         if(Input.GetKey(KeyCode.A))
        transform.Translate(Vector3.left *move* Time.deltaTime);
         if(Input.GetKey(KeyCode.D))
        transform.Translate(Vector3.right *move* Time.deltaTime);
    }
}
