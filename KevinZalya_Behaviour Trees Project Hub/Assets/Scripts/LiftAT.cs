using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace NodeCanvas.Tasks.Actions
{

    public class LiftAT : ActionTask
    {

        public Transform loot;
        public Transform magnet;
        public float pickUpSpeed;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {
            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {

            
        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {
            if (loot.transform.position.y < magnet.transform.position.y)
            {
                loot.transform.position += Vector3.up * pickUpSpeed * Time.deltaTime;

                if (loot.transform.position.y == magnet.transform.position.y)
                {
                    loot.transform.position = magnet.transform.position;

                    EndAction(true);
                }
            }
        }

        //Called when the task is disabled.
        protected override void OnStop()
        {

        }

        //Called when the task is paused.
        protected override void OnPause()
        {

        }
    }
}