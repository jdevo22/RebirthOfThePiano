using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectSelectDetector : MonoBehaviour
{
    public string targetObjectName = "Magic Book"; // Change this to the name of the object to detect
    public TimeTravelManager timeTravelManager;

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        GameObject selectedObject = args.interactableObject.transform.gameObject;

        if (selectedObject.name == targetObjectName)
        {
            timeTravelManager.TriggerTimeTravel();
        }
    }
}
