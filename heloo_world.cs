using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heloo_world : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� ������������ ���������
    public GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
    }

    // Update is called once per frame
    void SpawnObject()
    {
        // ������� ����� ������-����
        GameObject clone = Instantiate(objectToClone, transform.position, Quaternion.identity);

        

        

        // ����������� ������� ����� 2 �������
        Destroy(clone, 15.0f);
    }

    void Update()
    {
        // �������� ���� ������������
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // ������� ������ ����������� ��������
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;

        // ��������� �������� � ���������
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        SpawnObject();
    }
}
