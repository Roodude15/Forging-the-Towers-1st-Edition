using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint bulletTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserTurret; 

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance; 
    }

    public void SelectBulletTurret()
    {
        Debug.Log("Bullet Turret Selected");
        buildManager.SelectTurretToBuild(bulletTurret); 
    }

    public void SelectMissileTurret()
    {
        Debug.Log("Missile Turret Selected");
        buildManager.SelectTurretToBuild(missileLauncher); 
    }

    public void SelectLaserTurret()
    {
        Debug.Log("Laser Turret Selected");
        buildManager.SelectTurretToBuild(laserTurret); 
    }
}
