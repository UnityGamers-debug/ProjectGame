﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{
    public void ReactToHit()
    {//метод, вызванный сценарием стрельбы
        StartCoroutine(Die()); //вызываем сопрограмму Die()
    }

    private IEnumerator Die()
    {//Изменяем цвет врага, ждем 1,5 секунды и уничтожаем его
        GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);//объект может уничтожить сам себя
    }
}