using System;
using UnityEngine;


public class InitCar : MonoBehaviour
{
    [SerializeField] private GameObject bodyCar;
    [SerializeField] private Item[] CastomCar;

    private Changer _changer;

    private void Awake()
    {
        _changer = new Changer();
    }

    private void OnEnable()
    {
        _changer.Enable();
        _changer.ChangerCar.volvo.performed += context=> Init(CastomCar[0]);
        _changer.ChangerCar.audi.performed += context=> Init(CastomCar[1]);
        _changer.ChangerCar.Lada.performed += context=> Init(CastomCar[2]);
        _changer.ChangerCar.Toyota.performed += context=> Init(CastomCar[3]);
        _changer.ChangerCar.Honda.performed += context=> Init(CastomCar[4]);
    }
    private void OnDisable()
    {
        _changer.Disable();
        _changer.ChangerCar.volvo.performed -= context=> Init(CastomCar[0]);
        _changer.ChangerCar.volvo.performed -= context=> Init(CastomCar[1]);
        _changer.ChangerCar.volvo.performed -= context=> Init(CastomCar[2]);
        _changer.ChangerCar.volvo.performed -= context=> Init(CastomCar[3]);
        _changer.ChangerCar.volvo.performed -= context=> Init(CastomCar[4]);
    }

    
    
   
    
    private void Init(Item castomCar)
    {
        bodyCar.GetComponent<MeshFilter>().mesh = castomCar.bodyCar;
    }

   
}
