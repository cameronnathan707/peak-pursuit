using UnityEngine;


public class PlaneCheck : MonoBehaviour
{
    public Transform xrRigTransform;
    public Transform planeTransform;
    public GameObject objectToUnhide;
    public GameObject timer;

    

   public void Update() {
    if(xrRigTransform.position.y >= planeTransform.position.y) {
        objectToUnhide.SetActive(true);
        timer.GetComponent<Timer>().timerIsRunning = false;
    }
   }
}