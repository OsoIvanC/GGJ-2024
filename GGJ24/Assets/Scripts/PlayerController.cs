using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed;

    [SerializeField]
    GameObject _inventoryUI;
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.I))
        {
            _inventoryUI.SetActive(!_inventoryUI.activeInHierarchy);
        }


        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");


        var moveDir = new Vector2(x, y);

        moveDir.Normalize();

        transform.Translate(moveDir * _speed * Time.deltaTime);
    }
}
