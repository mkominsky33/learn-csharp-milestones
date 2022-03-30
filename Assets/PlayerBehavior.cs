using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
         public float moveSpeed = 10f;
         public float rotateSpeed = 75f;

         public float jumpVelocity = 5f;
          private float vInput;
         private float hInput;
          // 1
          private Rigidbody _rb;
          // 2
          void Start()
          {
// 3
               _rb = GetComponent<Rigidbody>();
           }
           void Update()
           {
             vInput = Input.GetAxis("Vertical") * moveSpeed;
             hInput = Input.GetAxis("Horizontal") * rotateSpeed;
/* 4
this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
this.transform.Rotate(Vector3.up * hInput * Time.deltaTime); */
}
// 1
           void FixedUpdate()
           {
             if(Input.GetKeyDown(KeyCode.Space))
          {
// 3
              _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
           }}}
