using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject finalBoss;
    public GameObject spawnPoint;
    public Vector3 position;
    
    void Start()
    {
        gameObject.transform.Translate(position);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            gameObject.transform.Translate(0, 0, 0.05f);
        if (Input.GetKey(KeyCode.S))
            gameObject.transform.Translate(0, 0, -0.05f);
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Rotate(0, -5, 0);
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Rotate(0, 5, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.transform.CompareTag("secretDoor"))
        {
            Debug.Log("Has chocado con una puerta secreta");
            Destroy(collision.gameObject);
            Instantiate(finalBoss, spawnPoint.transform.position, Quaternion.identity);
        }

    }
}
