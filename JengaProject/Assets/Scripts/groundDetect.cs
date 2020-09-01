    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class groundDetect : MonoBehaviour, ITrackableEventHandler
{
    public GameObject tower;
    public GameObject cube;
    public GameObject cam;
    
    
    bool firstTrack;
    private TrackableBehaviour mTrackableBehaviour;
    // Use this for initialization
    void Start () {
        cam = GameObject.Find("ARCamera");
        
        Debug.Log( "                    " + cam.transform.position.ToString() );
        
        Debug.Log("detectedd target 0 ");
        
        
        
        //tower = GameObject.Find("Cube");

       cube = GameObject.Find("Cube");

        tower.SetActive(false);

        firstTrack = true;
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
    {
        Debug.Log("detectedd target 2");
       //tower.transform.position = new Vector3(7f, 0, 0);
       // tower.GetComponent<Rigidbody>().useGravity = true;

       // tower.transform.position = new Vector3(0, 0, 0);

        if (firstTrack && newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // View cube when imagetarget is found
            tower.SetActive(true);
            firstTrack = false;
        }
        else
        {
            // Todo
			tower.SetActive(false);
        }
    }


    //unimportant method
    protected virtual void OnTrackingFound()

    {
        Debug.Log("detected target");
    }


    // Update is called once per frame
    void Update () {
        Debug.DrawLine(transform.position, tower.transform.position);

      //  cube.transform.Translate(Vector3.left * 0.005f, Space.World);

        Vector3 pos = tower.transform.position;
        Vector3 pos1 = cube.transform.position;
        
//        Vector3 worldPoint = ARCamera.ScreenToWorldPoint(new Vector3(0, 0, 10));
//        Vector3 localPoint = QCARManager.Instance.ARCamera.transform.InverseTransformPoint(worldPoint);
 //       float halfFov = Mathf.Atan2(localPoint.y, localPoint.z);
        
        
//        Debug.Log(pos);
//       Debug.Log(pos1 + "  image" );

        
//        Vector3 screenPos = camera.ScreenToWorldPoint(new Vector3(0, 0, 10));
 //       Debug.Log("target is " + screenPos.x + " pixels from the left");
 //    Debug.Log( "                    " + cam.transform.position.ToString() );

     }
    
    
}
