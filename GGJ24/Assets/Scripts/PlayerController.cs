using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed;
    
    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");


        var moveDir = new Vector2(x, y);

        moveDir.Normalize();

        transform.Translate(moveDir * _speed * Time.deltaTime);
    }
}
