using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CordinateDetector : MonoBehaviour
{
    private Vector3 coordinate = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        coordinate = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            coordinate = Input.mousePosition;
            Debug.Log(coordinate);
        }
    }
}
