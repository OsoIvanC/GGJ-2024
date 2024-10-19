using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    [field: SerializeField] public int KeyCount;

    private void Awake()
    {
        Instance = this;
    }
}
