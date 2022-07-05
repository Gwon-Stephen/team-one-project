
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprints standardTurret;

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret ()
	{
        buildManager.SelectTurretToBuild(standardTurret);
    }
}
