using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AhmedBreeka.Assigmnment19
{

    public class ScaleObjects : MonoBehaviour
    {

        public GameObject[] loopChapes;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            float displacment = 1f;
            
            foreach(GameObject loopChape in loopChapes)
            {
                displacment += 0.1f;

                float t = Mathf.PingPong(Time.time * displacment, 1f);
                float scaleObject = Mathf.SmoothStep(1f, 1.2f, t);

                loopChape.transform.localScale = new Vector3(scaleObject, 1f, scaleObject);
            }
        }
    }
}
