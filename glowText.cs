using UnityEngine;
using System.Collections;
using TMPro;

public class glowText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float minGlowIntensity = 0;
    public float maxGlowIntensity = 3.0f;
    public float changeInterval = 0.1f;

    private void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshProUGUI>();
        }

        // Start the animation coroutine
        StartCoroutine(ChangeGlowIntensity());
    }

    private IEnumerator ChangeGlowIntensity()
    {
        while (true)
        {
            // Randomly choose a new glow intensity between min and max values
            float newGlowIntensity = Random.Range(minGlowIntensity, maxGlowIntensity);

            // Apply the new glow intensity to the TMP text
            textMeshPro.faceColor = new Color(textMeshPro.faceColor.r, textMeshPro.faceColor.g, textMeshPro.faceColor.b, newGlowIntensity);

            // Wait for the specified interval before changing again
            yield return new WaitForSeconds(changeInterval);
        }
    }
}
