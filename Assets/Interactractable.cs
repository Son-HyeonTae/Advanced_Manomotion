using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactractable : MonoBehaviour {
    [SerializeField]
    public InteractableCubeBehavior currentInteractableCube;

    void Update() {
        DetectHandGestureClick();
    }

    public void SetCurrentInteractable(InteractableCubeBehavior obj) {
        currentInteractableCube = obj;
    }

    void DetectHandGestureClick() {
        HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;
        
        //The click happens when I perform the Click Gesture : Open Pinch -> Closed Pinch -> Open Pinch 
        if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.CLICK) {
            //Logic that should happen when I click
            if (currentInteractableCube) {
                currentInteractableCube.InteractWithCube();
            }
        }
    }

    void DetectMouseClick() {
        //The click happens when I release the left mouse buttons
        if (Input.GetMouseButtonUp(0)) {
            //Logic that should happen when I click.
            if (currentInteractableCube) {
                currentInteractableCube.InteractWithCube();
            }
        }
    }
}