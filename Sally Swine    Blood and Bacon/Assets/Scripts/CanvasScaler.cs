using UnityEngine;

public class CanvasScaler : MonoBehaviour
{
    // Adjust this value based on your desired reference resolution
    public Vector2 referenceResolution = new Vector2(1920, 1080);

    void Start()
    {
        ScaleCanvasToFitScreen();
    }

    void ScaleCanvasToFitScreen()
    {
        Canvas canvas = GetComponent<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("Script is attached to an object without a Canvas component.");
            return;
        }

        RectTransform rt = canvas.GetComponent<RectTransform>();

        float screenRatio = (float)Screen.width / Screen.height;
        float referenceRatio = referenceResolution.x / referenceResolution.y;

        float scaleFactor = screenRatio / referenceRatio;

        rt.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
    }
}
