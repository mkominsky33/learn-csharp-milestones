using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
    {
       public float moveSpeed = 10f;
       public float rotateSpeed = 75f;
        // 1
        public float jumpVelocity = 5f;

        public float distanceToGround = 0.1f;
              // 2
                     public LayerMask groundLayer;

        private float vInput;
        private float hInput;

// 1
private Rigidbody _rb;

private CapsuleCollider _col;
// 2
void Start()
{
// 3
    _rb = GetComponent<Rigidbody>();
    _col = GetComponent<CapsuleCollider>();
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
            // 5
  if(IsGrounded() && Input.GetKeyDown(KeyCode.Space)) {
          _rb.AddForce(Vector3.up * jumpVelocity,
              ForceMode.Impulse);
  }

              // 2
              Vector3 rotation = Vector3.up * hInput;
              // 3
              Quaternion angleRot = Quaternion.Euler(rotation *
                  Time.fixedDeltaTime);
              // 4
              _rb.MovePosition(this.transform.position +
                  this.transform.forward * vInput * Time.fixedDeltaTime);
// 5
               _rb.MoveRotation(_rb.rotation * angleRot);
          }
          private bool IsGrounded()
  {
      // 7
      Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
          _col.bounds.min.y, _col.bounds.center.z);
      // 8
      bool grounded = Physics.CheckCapsule(_col.bounds.center,
         capsuleBottom, distanceToGround, groundLayer,
            QueryTriggerInteraction.Ignore);
  // 9
  return grounded;
                  }
}
