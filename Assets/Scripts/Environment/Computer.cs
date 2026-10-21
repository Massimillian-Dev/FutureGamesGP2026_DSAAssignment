using Environment.Tasks;
using UnityEngine;
using UnityEngine.Rendering;
using Utils;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {
        //[SerializeField] public Task testTask1;
        //[SerializeField] public Task testTask2;
        //[SerializeField] public Task testTask3;
        //[SerializeField] public Task testTask4;
        [SerializeField] public GenericQueue<Task> taskQueueHandler; // Put your stack/queue here :)

        public void OnInteract() {
            Task Temp = taskQueueHandler.Dequeue();
            Temp.Execute();

            //taskQueueHandler.Enqueue(testTask1);
            //taskQueueHandler.Enqueue(testTask2);
            //taskQueueHandler.Enqueue(testTask3);
            //taskQueueHandler.Enqueue(testTask4);


            //foreach(var task in taskQueueHandler)
            //    {

            //}
            //    if(taskQueueHandler != null) {
            //        Debug.Log(taskQueueHandler.Size());
            //        Task currentTask = taskQueueHandler.Dequeue();
            //        currentTask.Execute();
            //    }
            //}

        }
    }
}
