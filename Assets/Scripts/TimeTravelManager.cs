using System.Collections;
using UnityEngine;

public class TimeTravelManager : MonoBehaviour
{
    public GameObject pastRoom;  // Assign the past version of the room
    public GameObject presentRoom; // Assign the present version of the room
    public float timeLimit = 5f; // Duration before switching back
    private bool isPastActive = false;

    private void Start()
    {
        // Ensure present room starts active and past room is inactive
        presentRoom.SetActive(true);
        pastRoom.SetActive(false);
    }

    public void TriggerTimeTravel()
    {
        StopAllCoroutines();
        SwapRooms();
        StartCoroutine(RevertAfterTime());
    }

    private void SwapRooms()
    {
        isPastActive = !isPastActive;
        pastRoom.SetActive(isPastActive);
        presentRoom.SetActive(!isPastActive);
    }

    private IEnumerator RevertAfterTime()
    {
        yield return new WaitForSeconds(timeLimit);
        SwapRooms();
    }

    private void Update() //Testing purposes only
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TriggerTimeTravel();
        }
    }
}