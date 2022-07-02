using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        instance = this;
    }

    public GameObject standardTurretPrefab;

    void Start ()
    {
        turretToBuild = standardTurretPrefab;
    }
    private GameObject turretToBuild;
    
    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }
}
