using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public GameObject prefabsMonster;

    float nowTime;
    float minTime = 1f;
    float maxTime = 5f;
    public float creatTime = 1f;

    void Start()
    {
        creatTime = Random.Range(minTime, maxTime);
    }


    void Update()
    {
        nowTime = nowTime + Time.deltaTime;
        if (nowTime > creatTime)
        {
            GameObject monster = Instantiate(prefabsMonster);
            monster.transform.position = transform.position;

            creatTime = Random.Range (minTime, maxTime);

            nowTime = 0;
        } 
    }
}
