using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SallyStartPosition : MonoBehaviour
{

    public GameObject Sally;
    // Start is called before the first frame update

    private void OnEnable()
    {
        Sally.transform.position = MainManager.SallyPosition;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
