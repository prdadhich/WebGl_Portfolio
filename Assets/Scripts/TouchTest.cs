using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    private float initialDistance;
    private Vector3 initialScale;
    private Vector3 newScale;
    private float currentDistance;
    public GameObject spawnedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var touchZero = Input.GetTouch(0);
        var touchOne = Input.GetTouch(1);
        if (touchZero.phase == TouchPhase.Ended || touchZero.phase == TouchPhase.Canceled || touchOne.phase == TouchPhase.Ended || touchOne.phase == TouchPhase.Canceled)
        {
            return;

        }

        if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
        {
            initialDistance = Vector2.Distance(touchZero.position, touchOne.position);
            initialScale = spawnedObject.transform.localScale;
        }
        else
        {
            currentDistance = Vector2.Distance(touchZero.position, touchOne.position);
            var factor = currentDistance / initialDistance;

            newScale = factor * initialScale;

            spawnedObject.transform.localScale = newScale;

        }
    }
}
