using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cashGenerator : MonoBehaviour
{
    public int cashGen = 30;

    void Cash()
    {
        PlayerStats.Money += cashGen;
    }

    void Start() {
        InvokeRepeating("Cash", 0f, 1f);
    }
}
