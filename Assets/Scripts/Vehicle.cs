using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vehicle : MonoBehaviour
{
    public GameObject mycar;
    public GameObject myyacht;
    public GameObject areacar;
    public GameObject areayacht;
    public Button exitYatch;
    public Button exitCar;
    void Start()
    {
        exitYatch.interactable = false;
        exitCar.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            mycar.SetActive(true);
            areacar.SetActive(false);
            exitCar.interactable = true;



        }

        if (other.CompareTag("Yacht"))
        {
            myyacht.SetActive(true);
            areayacht.SetActive(false);
            exitYatch.interactable = true;
        }
    }

    public void ExitCar()
    {
        exitCar.interactable = false;
        mycar.SetActive(false);
        areacar.SetActive(true);
        this.transform.position = new Vector3(this.transform.position.x - 3, this.transform.position.y, this.transform.position.z);

    }

    public void ExitYacth()
    {
        exitYatch.interactable = false;
        myyacht.SetActive(false);
        areayacht.SetActive(true);
        this.transform.position = new Vector3(100, this.transform.position.y,-1);
    }
}
