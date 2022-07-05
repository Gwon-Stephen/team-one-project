
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret () 
    {
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
}
