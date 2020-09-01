using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class lineMove : MonoBehaviour {

    float moveSpeed = 0.77F;
    float movX;
    float movY;
    float movZ;


    void OnMouseDrag()
    {
        movX = Input.GetAxis("Mouse X") * moveSpeed * Mathf.Deg2Rad;
        movY = Input.GetAxis("Mouse Y") * moveSpeed * Mathf.Deg2Rad;
        movZ = Input.GetAxis("Mouse Z") * moveSpeed * Mathf.Deg2Rad;

        transform.position += new Vector3(movX, 0, 0);
        transform.position += new Vector3(0, movY, 0);
        transform.position += new Vector3(0, 0, movZ);
    
    }

    void OnMouseDown()
    {


    }



        void Update()
    {

    }
}
