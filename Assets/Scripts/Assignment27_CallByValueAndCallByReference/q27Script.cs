using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using Unity.VisualScripting;
using UnityEngine;

namespace AhmedBreeka.Assigmnment27
{
    public class q27Script : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int a = 5;
            int b = 10;


            // value
            Debug.Log("before call method Add_10 : " +a);
            Add_10(a);
            Debug.Log("after call method Add_10 : " + a);

            // ref
            Debug.Log("before call method Add_15 by ref : " + b);
            Add_15(ref b);
            Debug.Log("after call method Add_15(ref) : " + b);

            // out
            ChangeValue(out a);
            Debug.Log("after call method ChangeValue(out) : " + a);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void Add_10(int x){
            x += 10;
            Debug.Log("inside method Add_10 : " + x);
        }

        void Add_15(ref int x){
            x += 10;
            Debug.Log("inside method Add_15 (ref) : " + x);
        }

        void ChangeValue(out int x){
            x = 50;
            Debug.Log("inside method ChangeValue (out) : " + x);
        }
    }   
}

