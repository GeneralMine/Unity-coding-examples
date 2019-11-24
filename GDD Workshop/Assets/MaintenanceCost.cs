using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MaintenanceCost : MonoBehaviour {

    [SerializeField] private float cost = 1;
    [SerializeField] private float interval = 1;

    private float timer = 0;

    public PlayerWallet wallet;

    protected abstract float MaintenanceCosts { get; }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > interval){
            wallet.money -= MaintenanceCosts;

            Debug.Log("cost, reduced, amount left: " + wallet.money);
            timer = 0;
        }
        
        //Alternative 
        //for (/**/; timer > 1.0f; timer -= 1.0f) {
        //    wallet.money -= MaintenanceCosts;
        //}
	}
}
