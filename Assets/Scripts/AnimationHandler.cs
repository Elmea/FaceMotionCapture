using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    Vector3 StartPosition;
    Quaternion StartRotation;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = gameObject.transform.position;
        StartRotation = gameObject.transform.rotation;
    }

    public void ResetPosition()
    {
        gameObject.transform.position = StartPosition;
        gameObject.transform.rotation = StartRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
