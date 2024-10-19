using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField]
    Animator animator;

    [SerializeField]
    bool canInteract;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Interact()
    {
        if (Inventory.Instance.KeyCount <= 0)
            return;

        canInteract = false;

        animator.SetTrigger("Open");
    }

    public void DestroyChest()
    {
        gameObject.SetActive(false);

        Inventory.Instance.KeyCount--;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
                Interact();
        }
    }

    private void LateUpdate()
    {
        transform.GetChild(0).gameObject.SetActive(canInteract);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
            canInteract = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
            canInteract = false;   
    }
}
