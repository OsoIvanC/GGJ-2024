using UnityEngine;

public class Key : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Inventory.Instance.KeyCount += 1;

        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Interact();
    }
}
