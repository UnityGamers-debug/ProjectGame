using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //библиотека для работы со сценами

public class PlayerCharacter : MonoBehaviour
{
    private int _health = 500;
    private int maxHealth = 1000;

    public void Hurt(int damage)
    {
        _health -= damage;//уменьшение здоровья игрока
        Debug.Log("Health: " + _health);
        if (_health <= 0)
        {
            SceneManager.LoadScene("SampleScene");//Перезагрузить сцену SamleScene
        }
    }
}
