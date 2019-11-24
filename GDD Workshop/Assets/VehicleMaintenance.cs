using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMaintenance : MaintenanceCost {

    protected override float MaintenanceCosts
    {
        get
        {
            return 5;
        }
    }
}
