using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
    [SerializeField]
    private Camera cameraP1, cameraP2;
    [SerializeField]
    private GameObject centerLine;

    private float limitBetweenPlayers;
    
	// Use this for initialization
	void Start () 
    {
        limitBetweenPlayers = 6.7f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        float distance = Vector3.Distance(cameraP1.transform.position, cameraP2.transform.position);
        this.transform.position = 0.5f * (cameraP1.transform.position + cameraP2.transform.position);

        if(distance < limitBetweenPlayers)
        {
            this.GetComponent<Camera>().enabled = true;
            centerLine.gameObject.SetActive(false);
        }
        else
        {
            this.GetComponent<Camera>().enabled = false;
            centerLine.gameObject.SetActive(true);
        }
	}
}
