using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    private GameManager gm;
    private string materialName;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }


    void Update()
    {
 
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position-new Vector3(0f,0.23f,0f), transform.rotation);
        splash.transform.parent = collision.gameObject.transform;

        materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;


        if (materialName == ("UnSafe Color (Instance)"))
        {
            gm.ReStartGame();
        }
        else if (materialName == ("Last Ring (Instance)"))
        {
            Debug.Log("Next Level");
        }
    }

}
