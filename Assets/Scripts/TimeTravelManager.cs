using System.Collections;
using UnityEngine;

public class TimeTravelManager : MonoBehaviour
{
    public GameObject pastRoom;  // Assign the past version of the room
    public GameObject presentRoom; // Assign the present version of the room
    public float timeLimit = 5f; // Duration before switching back
    private bool isPastActive = false;
    private bool timeTraveled = false; // One-way travel
    public FadeInEffect blackOverlay;

    private void Start()
    {
        // Ensure present room starts active and past room is inactive
        presentRoom.SetActive(true);
        pastRoom.SetActive(false);
    }

    public void TriggerTimeTravel()
    {
        if (!timeTraveled)
        {
            StopAllCoroutines();
            blackOverlay.transitionOverlay();
            SwapRooms();
            //StartCoroutine(RevertAfterTime());
        }
    }

    private void SwapRooms()
    {
        isPastActive = !isPastActive;
        pastRoom.SetActive(isPastActive);
        presentRoom.SetActive(!isPastActive);
        timeTraveled = true;
    }


    //private IEnumerator RevertAfterTime()
    //{
    //    yield return new WaitForSeconds(timeLimit);
    //    SwapRooms();
    //}
}
