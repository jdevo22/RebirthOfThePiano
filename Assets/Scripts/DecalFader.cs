using System.Collections;
using UnityEngine;

public class DecalRemover : MonoBehaviour
{
    public float delayBeforeRemoval = 0f; // Delay in seconds before removing the decals

    public void RemoveDecals()
    {
        // Start the coroutine to handle the delay and removal
        StartCoroutine(RemoveDecalsAfterDelay());
    }

    private IEnumerator RemoveDecalsAfterDelay()
    {
        // Wait for the specified delay before proceeding
        yield return new WaitForSeconds(delayBeforeRemoval);

        // Find all child objects and disable them
        foreach (Transform child in transform)
        {
            // Disable the game object (to hide it but keep it in the scene)
            child.gameObject.SetActive(false);
        }
    }
}
