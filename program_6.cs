using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    public GameObject car;
    public GameObject bus;
    public AudioSource cars,buss;

    void start()
    {
        bus.SetActive(false);
        car.SetActive(false);
    }

    public void openBus()
    {
        bus.SetActive(true);
        car.SetActive(false);
        buss.Play();
    }
    public void openCar()
    {
        car.SetActive(true);
        bus.SetActive(false);
        cars.Play();
    }
}
