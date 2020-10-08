using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public NetworkMan NMan;
    public Vector3 vec;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        NMan = FindObjectOfType<NetworkMan>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name != NMan.myAddress)
            return;
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        vec = new Vector3(v, h);
        transform.Translate(vec);
    }
}