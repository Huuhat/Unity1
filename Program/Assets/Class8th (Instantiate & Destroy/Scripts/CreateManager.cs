using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject Unit;

    private GameObject clone;

    void Start()
    {
      clone = Instantiate(Unit);
        
        clone.transform.position = new Vector3(0, 0, -5);
    }

}
