using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    private Vector3 direction;
    public float speed = 5.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime��?
        // ������ �������� �Ϸ�� �� ����� �ð��Դϴ�.


        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // ������ ����ȭ
        direction.Normalize();



        transform.position = transform.position + direction * speed * Time.deltaTime; 
        
    }
}
