using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateControl : MonoBehaviour {
    private int lastPlateNum;

    [SerializeField]
    private GameObject[] plates;

    void Start() {
        lastPlateNum = 0;
        
        for (int i=0; i<plates.Length; i++) {
            if (plates[i]==null) {
                continue;
            }
            plates[i].SetActive(false);
        }
    }

    public void ChangePlate(int plateNum) {
        if (lastPlateNum == 0) {
            lastPlateNum = plateNum;
            plates[plateNum].SetActive(true);
        } else {
            plates[lastPlateNum].SetActive(false);
            lastPlateNum = plateNum;
            plates[plateNum].SetActive(true);
        }
    }
}
