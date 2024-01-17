
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
  public float moveMult = 0.1f;
  public float turnMult;
  Rigidbody rb;
  public Transform head;

  void Start()
  {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;

    rb = GetComponent<Rigidbody>();
    head = Camera.main.transform;
  }

  void Update()
  {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    Vector3 forwardMovement = head.forward * -verticalInput;
    Vector3 rightMovement = head.right * -horizontalInput;

    Vector3 movementDirection = (forwardMovement + rightMovement).normalized * moveMult;

    rb.MovePosition(rb.position + movementDirection * Time.deltaTime);
  }

  void LateUpdate()
  {
    transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * turnMult);

    Vector3 e = head.eulerAngles;
    e.x -= Input.GetAxis("Mouse Y") * 2f;
    e.x = RestrictAngle(e.x, -85f, 85f);
    head.eulerAngles = e;
  }

  public static float RestrictAngle(float angle, float min, float max)
  {
    if (angle > 180) angle -= 360;
    else if (angle < -180) angle += 360;

    return Mathf.Clamp(angle, min, max);
  }
}