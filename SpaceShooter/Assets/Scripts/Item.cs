using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName; //Вводим имена в во вкладку Inspector
    private int _score; // счетчик очков

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + itemName); // вывод взятого объекта в консоль
        Destroy(this.gameObject);
        if (itemName == "cube")
        {//проверяем, является ли объект здоровьем
            _score++; //увеличиваем счетчик очков
            Debug.Log("Score: " + _score);
        }
    }
}
