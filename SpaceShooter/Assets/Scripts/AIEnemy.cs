using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public float speed = 1.0f; //скорость врага
    public float damage = 1.0f; //урон, наносимый персонажу
    public float maxDistance = 10.0f; //максимальная дистанция обнаружения героя
    public float minDistance = 1.0f;

    public float distance; //переменная для опр – я дистанции между игроком и врагом
    public Transform target; //объект, за которым будет следить враг

    // Update is called once per frame
    void Update()
    {

    }
}
