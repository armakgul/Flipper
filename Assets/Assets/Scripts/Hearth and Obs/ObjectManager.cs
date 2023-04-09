using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public ToggleObject[] objects;
    public ToggleObject[] obstacles;
    private int currentObjectIndex;
    private int currentObstacleIndex;

    void Start()
    {
        currentObjectIndex = 0;
        currentObstacleIndex = 0;
        DeactivateAllObstacles();
        ActivateNextObject();
    }

    public void ActivateNextObject()
    {
        if (currentObjectIndex < objects.Length)
        {
            objects[currentObjectIndex].SetActive(true);
            currentObjectIndex++;
        }
    }

    public void ActivateNextObstacle()
    {
        if (currentObstacleIndex < obstacles.Length)
        {
            obstacles[currentObstacleIndex].SetActive(true);
            currentObstacleIndex++;
        }
    }

    private void DeactivateAllObstacles()
    {
        foreach (ToggleObject obstacle in obstacles)
        {
            obstacle.SetActive(false);
        }
    }
}
