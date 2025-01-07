using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AhmedBreeka.Assigmnment26
{
    public class CreatureManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // new way
            List<Creature> creatures= new()
            {
                new Kangaroo(),
                new Duck()
            };

             /* old way
            List<Creature> animals= new List<Creature>();

            animals.Add(new Kangaroo());
            animals.Add(new Duck());
            */

            List<IRunnable> runnable = new List<IRunnable>();
            List<IJumpable> jumpable = new List<IJumpable>();
            List<ISwimmable> swimmable = new List<ISwimmable>();

            Kangaroo kangaroo = (Kangaroo)creatures[0];
            runnable.Add(kangaroo);
            jumpable.Add(kangaroo);

            Duck duck = (Duck)creatures[1];
            runnable.Add(duck);
            swimmable.Add(duck);

            foreach (var creature in creatures)
            {
                creature.Speak();
            }

            foreach (var creature in runnable)
            {
                creature.Run();
            }

            foreach (var creature in jumpable)
            {
                creature.Jump();
            }

            foreach (var creature in swimmable)
            {
                creature.Swim();
            }

           
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
