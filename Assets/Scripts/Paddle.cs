using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float yPosition = -4f;
    public float paddleHalfWidth = 1.25f;
    private Camera mainCamera;
    private float screenLeftLimit, screenRightLimit;

    void Start()
    {
        mainCamera = Camera.main;

        Vector3 screenLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 screenRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));

        screenLeftLimit = screenLeft.x + paddleHalfWidth;
        screenRightLimit = screenRight.x - paddleHalfWidth;
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0));
        float clampedX = Mathf.Clamp(worldPos.x, screenLeftLimit, screenRightLimit);
        transform.position = new Vector3(clampedX, yPosition, 0);
    }
}
