
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;
    public Color notEnoughMoneyColor;

    public Vector3 positionOffset;

    private Renderer rend;

    [Header("Optional")]
	public GameObject turret;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
	{
		return transform.position + positionOffset;
	}

    void OnMouseDown()
    {
        if (!buildManager.CanBuild)
        {
            return;
        }

        if(turret != null)
        {

            Debug.Log("Can't Build there!");
            return;
        }

       buildManager.BuildTurretOn(this);
    }
    
    void OnMouseEnter ()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }

        if(buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        } else
        {
            rend.material.color = notEnoughMoneyColor;
        }
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
