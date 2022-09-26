using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one Build Controller!");
            return;
        }
        instance = this;
    }

    public GameObject stantardTurretPrefab;
    public GameObject advancedTurretPrefab;

    private TurretBluePrint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn(Place place)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money!");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret  = (GameObject)Instantiate(turretToBuild.prefab, place.GetBuildPosition(), Quaternion.identity);
        place.turret = turret;

        Debug.Log("Turret Build! Money left: " + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        turretToBuild = turret;
    }
}
