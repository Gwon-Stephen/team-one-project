
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprints standardTurret;
    public TurretBlueprints missileLauncher;
    public TurretBlueprints cashGenerator;
    public TurretBlueprints sniper;

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret ()
	{
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
	{
		Debug.Log("Missile Launcher Selected");
		buildManager.SelectTurretToBuild(missileLauncher);
	}

    public void SelectCashGenerator()
	{
		Debug.Log("Cash Generator Selected");
		buildManager.SelectTurretToBuild(cashGenerator);
	}

    public void SelectSniper()
	{
		Debug.Log("Sniper Selected");
		buildManager.SelectTurretToBuild(sniper);
	}
}
