using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    public int speedRotation = 3;

    Rigidbody ControllerPlayer;

    public GameObject Bullet;
    public GameObject Dulo;


    void Fire()
    {
        if (Input.GetButtonUp("Fire4"))
        {
            Vector3 SpawnPoint = Dulo.transform.position;
            Quaternion SpawnRoot = Dulo.transform.rotation;
            GameObject BulletForFire = Instantiate(Bullet, SpawnPoint, SpawnRoot) as GameObject;
            Rigidbody Run = BulletForFire.GetComponent<Rigidbody>();
            Run.AddForce(BulletForFire.transform.forward * 30, ForceMode.Impulse);
            Destroy(BulletForFire, 1);
        }
    }


    void Start()
    { 
        player = (GameObject)this.gameObject;
    }

    void Update()
    {
        Fire();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Rotate(Vector3.down * speedRotation);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(Vector3.up * speedRotation);
        }
    }
}
