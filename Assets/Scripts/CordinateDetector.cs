using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CordinateDetector : MonoBehaviour
{
    public Vector3 cordinate = Vector3.zero;
    public Camera cam;
    public Vector3 mousePos;
    
    // Start is called before the first frame update
    void Start()
    {
        cordinate = Vector3.zero;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
                Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane);
                cordinate = cam.ScreenToWorldPoint(mousePos);
                Debug.Log(cordinate);
                                          
        }
    }
}
