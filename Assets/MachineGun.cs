using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    
    public Transform bulletTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        
    }
    void Fire()
    {
        GameObject go = ObjectPool.instance.GetPooledObject();
        if(go != null)
        {
            go.transform.position = bulletTransform.position;
            go.SetActive(true);
        }
    }
}
