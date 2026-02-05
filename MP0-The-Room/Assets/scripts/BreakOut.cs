using UnityEngine;

public class BreakOut : MonoBehaviour
{
    public Transform outsideSpawnPoint;   // empty above the plane

    private Vector3 roomPosition;
    private Quaternion roomRotation;
    private bool isOutside = false;

    void Start()
    {
        // Save starting position (inside room)
        roomPosition = transform.position;
        roomRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!isOutside)
            {
                transform.position = outsideSpawnPoint.position;
                transform.rotation = outsideSpawnPoint.rotation;
            }
            else
            {
                transform.position = roomPosition;
                transform.rotation = roomRotation;
            }

            isOutside = !isOutside;
        }
    }
}
