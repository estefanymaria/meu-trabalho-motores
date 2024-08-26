using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        UnityEngine.Vector3 direcao = new Vector3(x:h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
