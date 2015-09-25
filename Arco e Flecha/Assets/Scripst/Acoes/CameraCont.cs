using UnityEngine;
using System.Collections;

public class CameraCont : MonoBehaviour {
    public GameObject firstCamera;
    public GameObject secondCamera;
    public GameObject thirtCamera;
   // public double test = Input.GetAxis("Vertical");
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //firstCamera.camera.
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            ChangeCamera();
        }
	}

    private void ChangeCamera() {
        if (firstCamera.GetComponent<Camera>().enabled)
        {
            firstCamera.GetComponent<Camera>().enabled = !firstCamera.GetComponent<Camera>().enabled;
            secondCamera.GetComponent<Camera>().enabled = !secondCamera.GetComponent<Camera>().enabled;
            //thirtCamera.GetComponent<Camera>().enabled = !thirtCamera.GetComponent<Camera>().enabled;
        }
        else if(secondCamera.GetComponent<Camera>().enabled) {
            //firstCamera.GetComponent<Camera>().enabled = !firstCamera.GetComponent<Camera>().enabled;
            secondCamera.GetComponent<Camera>().enabled = !secondCamera.GetComponent<Camera>().enabled;
            thirtCamera.GetComponent<Camera>().enabled = !thirtCamera.GetComponent<Camera>().enabled;
        }
        else{
            firstCamera.GetComponent<Camera>().enabled = !firstCamera.GetComponent<Camera>().enabled;
            //secondCamera.GetComponent<Camera>().enabled = !secondCamera.GetComponent<Camera>().enabled;
            thirtCamera.GetComponent<Camera>().enabled = !thirtCamera.GetComponent<Camera>().enabled;
        }

        
    }
}
