using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 movement;
    [SerializeField] float speed;
    private Rigidbody rigidbody;
    void Start()
    {
        //inspector ekranýndan seçmek yerine kod kullanarak rigidbody compeonentini bulduk
        rigidbody= GetComponent<Rigidbody>();
    }

    void Update()
    {

        MoveThePlayer();

    }

    private void MoveThePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        movement = new Vector3(x, 0f, z);
        //transform.position += movement;
        rigidbody.AddForce(movement);
    }
}