using Environment.Tasks;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using Utils;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {

        [SerializeField] public GenericQueue<Task> taskQueueHandler; // Put your stack/queue here :)
        [SerializeField] public GameObject terminalTextLight;
        


        [SerializeField] public float cameraMoveSpeed = 5f;
        [SerializeField] public GameObject playerCameraHolder;
        public Camera playerCamera;
        public Camera computerCamera;
        [SerializeField] public GameObject computerCameraHolder;
        

        public bool terminalIsOn = false;
        public bool readingTerminal = false;

        public void OnInteract() {

            //set teminal text and lights active
            
            
            terminalIsOn = !terminalIsOn;
            readingTerminal = !readingTerminal;

            

//            switch(expression) {
//                case x:
//                    // code block
//                    break;
//                case y:
//                    // code block
//                    break;
//                default:
//                    // code block
//                    break;
//            }


            Task Temp = taskQueueHandler.Dequeue();
            Temp.Execute();
        }

        public void Start() {
            Camera playerCamera = playerCameraHolder.GetComponentInChildren<Camera>();
            Camera computerCamera = computerCameraHolder.GetComponentInChildren<Camera>();
        }

        public void FixedUpdate() {
            if(readingTerminal) {
                playerCamera.transform.position = Vector3.Lerp(playerCamera.gameObject.transform.position, computerCamera.transform.position, cameraMoveSpeed * Time.deltaTime);
            }
            else {
                playerCamera.transform.position = Vector3.Lerp(playerCamera.gameObject.transform.position, playerCameraHolder.transform.position, cameraMoveSpeed * Time.deltaTime);
            }
            if(terminalIsOn) {
                terminalTextLight.SetActive(true);
            }
            else {
                terminalTextLight.SetActive(false);
            }
        }
    }
}
