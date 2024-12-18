using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AhmedBreeka.Assigmnment19
{
    public class Kinetic : MonoBehaviour
    {
        public float degree = 0f;
        public float angleInc = 0.2f;
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

}
