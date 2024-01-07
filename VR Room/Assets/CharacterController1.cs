using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController1 : MonoBehaviour
{
     public float speed = 10.0f;
    private float translation;
    private float horizmovement;


    private void Start()
    {
        
    }

    private void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        horizmovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(horizmovement, 0, translation);

    }

   

}
