using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JengaLineMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        HighlightSelectedBlock();
    }

    private static void HighlightSelectedBlock()
    {
        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "JengaLine")
                {
                    JengaLine jengaLine = hit.collider.GetComponent<JengaLine>();
                    jengaLine.SetSelected();
                    jengaLine.GetComponent<Renderer>().material.color = Color.blue;
                    jengaLine.Move();
                }
            }
        }
    }
}
