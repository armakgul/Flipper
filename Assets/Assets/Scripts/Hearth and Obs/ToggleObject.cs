using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        SetActive(false);
    }

    public void SetActive(bool isActive)
    {
        spriteRenderer.enabled = isActive;
        boxCollider2D.enabled = isActive;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
    {
        SetActive(false);
        ObjectManager objectManager = FindObjectOfType<ObjectManager>();
        objectManager.ActivateNextObject();
        objectManager.ActivateNextObstacle();
    }
    }
}
