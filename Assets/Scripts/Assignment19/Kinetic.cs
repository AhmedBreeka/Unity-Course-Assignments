using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinetic : MonoBehaviour
{
    public float degree = 0f;
    public float angleInc = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        degree += angleInc;

        transform.rotation = Quaternion.Euler(new Vector3(0f, degree, 0f));
    }
}