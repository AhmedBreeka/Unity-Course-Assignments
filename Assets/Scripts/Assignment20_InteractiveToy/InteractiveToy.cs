using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

namespace AhmedBreeka.Assigmnment20
{
    public class InteractiveToy : MonoBehaviour
    {
        
        public float degr = 0f;
        public float angleInc = 0.1f;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                transform.position -= new Vector3(0.01f, 0, 0);
                
            }

            if(Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += new Vector3(0.01f, 0, 0);
                
            }

            if(Input.GetKey(KeyCode.RightArrow))
            {
                degr += angleInc;
                
            }

            if(Input.GetKey(KeyCode.LeftArrow))
            {
                degr -= angleInc;
                
            }

            transform.rotation = Quaternion.Euler(new Vector3(0,degr,0));
            
        }
    }
}
