using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectionScript : MonoBehaviour
{
    private GameObject[] carsList;
    private int currentCar;

    // Start is called before the first frame update
    void Start()
    {
        carsList = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            carsList[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject car in carsList)
        {
            car.SetActive(false);
        }

        if(carsList[0])
        {
            carsList[0].SetActive(true);
            currentCar = 0;
        }
    }

    public void OnButtonPressed(string direction)
    {
        carsList[currentCar].SetActive(false);

        if(direction == "Right")
        {
            currentCar++;
            if(currentCar == carsList.Length)
            {
                currentCar = 0;
            }
        }
        else if (direction == "Left")
        {
            currentCar--;
            if(currentCar < 0)
            {
                currentCar = carsList.Length - 1;
            }
        }

        carsList[currentCar].SetActive(true);
    }
}
