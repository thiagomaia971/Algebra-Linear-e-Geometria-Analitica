using UnityEngine;
using System.Collections;

public class ArrowMove : MonoBehaviour {

    public GameObject Arrow;
    private float ModificationVelocityArrow = 5f;
    private bool playArrow;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Target")
        {
            ModificationVelocityArrow = 0;
        }
    }
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            playArrow = true;
        }
        if (playArrow)
        {
            Arrow.transform.Translate(Vector3.forward * (Time.deltaTime * ModificationVelocityArrow));
        }

    }

}
