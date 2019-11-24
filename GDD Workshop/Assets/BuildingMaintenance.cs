using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMaintenance : MaintenanceCost {

    protected override float MaintenanceCosts
    {
        get
        {
            return 10;
        }
    }
}
