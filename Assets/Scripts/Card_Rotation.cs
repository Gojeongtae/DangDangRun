using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Card_Rotation : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float rotationDuration = 2f;

    private bool isRotating = true;

    void Start()
    {
        StartCoroutine(RotateForSeconds());
    }

    IEnumerator RotateForSeconds()
    {
        yield return new WaitForSeconds(rotationDuration);
        isRotating = false;
    }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
    }
}