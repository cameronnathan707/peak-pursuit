using UnityEngine;

public class SkipButton : MonoBehaviour
{
    public Transform vrRigPlayerObject; // Reference to your VR rig player object
    public Transform targetPlane; // Reference to the plane where you want to move the VR rig player object

    public void OnButtonClick()
    {
        // Get the position of the top of the plane
        Vector3 targetPosition = targetPlane.position + (Vector3.up * (targetPlane.localScale.y / 2f));

        // Move the VR rig player object to the top of the plane
        vrRigPlayerObject.position = targetPosition;
    }
}