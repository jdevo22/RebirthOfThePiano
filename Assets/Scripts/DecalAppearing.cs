using System.Collections;
using UnityEngine;

public class DecalAppearing : MonoBehaviour
{
    public float appearDelay = 1f; // Delay before decals become visible

    private Material[] decalMaterials;

    void Awake()
    {
        // Get all the materials of the child objects (decals)
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        decalMaterials = new Material[renderers.Length];

        for (int i = 0; i < renderers.Length; i++)
        {
            decalMaterials[i] = renderers[i].material;

            // Initially set all decals to be fully transparent (alpha = 0)
            decalMaterials[i].color = new Color(decalMaterials[i].color.r, decalMaterials[i].color.g, decalMaterials[i].color.b, 0f);
        }
    }

    // Public method to start making the decals appear when called
    public void StartAppearingDecals()
    {
        StartCoroutine(AppearDecals());
    }

    private IEnumerator AppearDecals()
    {
        // Wait for the specified delay before making the decals visible
        yield return new WaitForSeconds(appearDelay);

        // Immediately set all decals to be fully visible (alpha = 1)
        foreach (var material in decalMaterials)
        {
            Color currentColor = material.color;
            material.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1f);
        }
    }
}
