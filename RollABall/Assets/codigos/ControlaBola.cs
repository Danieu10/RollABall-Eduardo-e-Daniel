using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlaBola : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 5;
    public Rigidbody rb;
    public float forcapulo = 5;
    int qntidadepulo = 0;
    public GameObject renascer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pulo();
    }

    void FixedUpdate()
    {
        Vector3 movebola = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += movebola * velocidade * Time.deltaTime;
        

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
        }

      
        condicaovitoria.instance.somaponto();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "solo")
        {
            qntidadepulo = 0;
        }
        
        if (collision.gameObject.tag == "vazio")
        {
            transform.position = renascer.transform.position;
        }
    }

    void Pulo()
    {
        if (Input.GetButtonDown("Jump") && qntidadepulo==0)
        {
            rb.AddForce(new Vector3(0f,forcapulo),ForceMode.Impulse);
            qntidadepulo++;
        }
    }
}
