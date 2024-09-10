using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 rotationChange;
    public Vector3 positionChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
        transform.Rotate (rotationChange);
        transform.position += positionChange;

    }
}
