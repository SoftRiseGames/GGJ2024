using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // Reference to the SpriteRenderer component
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Check if the SpriteRenderer component exists
        if (spriteRenderer != null)
        {
            // Set the sprite color to a random color
            SetRandomColor();
        }
        else
        {
            Debug.LogError("SpriteRenderer component not found on the GameObject.");
        }
    }

    void SetRandomColor()
    {
        // Generate random values for RGB
        float randomRed = Random.value;
        float randomGreen = Random.value;
        float randomBlue = Random.value;

        // Create a new color using the random values
        Color randomColor = new Color(randomRed, randomGreen, randomBlue);

        // Set the SpriteRenderer color to the random color
        spriteRenderer.color = randomColor;
    }
}
