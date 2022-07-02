
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    public Vector3 positionOffset;

    private Renderer rend;

    private GameObject turret;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't Build there!");
            return;
        }

        //Build turret :DDDDDDDDDDD
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
    
    void OnMouseEnter ()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
