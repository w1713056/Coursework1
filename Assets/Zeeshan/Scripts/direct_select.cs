using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direct_select : MonoBehaviour
{
    [SerializeField]
    private float speed = 55.0f;
    [SerializeField]
    private Vector3 position;
    [SerializeField]
    private bool MouseOverObject = false;

    private void Start()
    {
        position = transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) && MouseOverObject == true)
        {
            move();
        }
        else if (Input.GetMouseButton(1) && MouseOverObject == true)
        {
            ResetMovement();
        }

    }

    private void OnMouseOver()
    {
        MouseOverObject = true;
    }
    

    private void OnMouseExit()
    {
        MouseOverObject = false;
    }
    

    private void move()
    {
        float TranslateX = Input.GetAxis("Mouse X") * speed;
        float TranslateZ = Input.GetAxis("Mouse Y") * speed;

        float NormalizeMovementX = TranslateX *Time.deltaTime;
        float NormalizeMovementY = Time.deltaTime;

        transform.Translate(-NormalizeMovementX, 0, -NormalizeMovementY);
    }

    private void ResetMovement()
    {
        transform.position = position;
    }

}
