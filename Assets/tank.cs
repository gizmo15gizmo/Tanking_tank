using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class tank : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 10;
    [SerializeField] private float rotationSpeed = 25;

    private Transform localTransform;

    private float rotateAxis;

    // Start is called before the first frame update
    void Start()
    {
        localTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        /*
        localTransform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        localTransform.Translate(Input.GetAxis("Vertical") * Vector3.forward * maxSpeed * Time.deltaTime);
        */

        localTransform.Rotate(Vector3.up, rotateAxis * rotationSpeed * Time.deltaTime);


    }

    public void HandleRotate(InputAction.CallbackContext inputContext)
    {
        rotateAxis = inputContext.ReadValue<float>();
        Debug.Log("Rotate  = " + rotateAxis);
    }

}
