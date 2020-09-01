using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JengaLine : MonoBehaviour {

    public Material defaultMaterial;
    private bool toogleMouse;
    public GameObject camera;
    public GameObject jengaPiece;
    
    //ARCamera Position
    float xCam;
    float yCam;
    float zCam;

    //Jenga Object position
    float x;
    float y;
    float z;

    [SerializeField]
    private bool isSelected = false;

    private void Start()
    {
        camera = GameObject.Find("ARCamera");
    }

    public void SetSelected() {
        this.isSelected = true;
    }

    public void Move()
    {
        //GetComponent<Rigidbody>().AddForce(transform.forward * 10000);
    }

    IEnumerator OnMouseDown() 
    {
        if (!isSelected)
        {
            toogleMouse = true;

            jengaPiece = GetComponent<Renderer>().gameObject;
           // transform.position += new Vector3(0.2f, 0, 0);
           Debug.Log( " CAMERA+                   " + camera.transform.position.ToString() );
           xCam = camera.transform.position.x;
           yCam = camera.transform.position.y;
           zCam = camera.transform.position.z;
           
           x = jengaPiece.transform.position.x;
           y = jengaPiece.transform.position.y;
           z = jengaPiece.transform.position.z;

         
           GetComponent<Renderer>().material.color = Color.red;
           
           //wait 5 second for change color
            yield return new WaitForSeconds(5);
            GetComponent<Renderer>().material.color = Color.blue;

          
            
            toogleMouse = false;
        }
    }


    private void Update()
    {

        if (toogleMouse == true)
        {
            //  Debug.Log( " CAMERA                   " + camera.transform.position.ToString() );

            Debug.Log(xCam + " " + yCam + " " + zCam + " JENGA             " + camera.transform.position.ToString());


            jengaPiece.transform.position = new Vector3
                (x - (xCam - camera.transform.position.x) ,
                y - (yCam - camera.transform.position.y) / 1.5f,
                z - (zCam - camera.transform.position.z));
        }
    }
}
