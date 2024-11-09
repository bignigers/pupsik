using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heloo_world : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость передвижения персонажа
    public GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
    }

    // Update is called once per frame
    void SpawnObject()
    {
        // Создаем новый объект-клон
        GameObject clone = Instantiate(objectToClone, transform.position, Quaternion.identity);

        

        

        // Уничтожение объекта через 2 секунды
        Destroy(clone, 15.0f);
    }

    void Update()
    {
        // Получаем ввод пользователя
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Создаем вектор направления движения
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;

        // Применяем движение к персонажу
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        SpawnObject();
    }
}
