using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayerSpin : MonoBehaviour
{
    [SerializeField] private GameObject record;
    [SerializeField] private GameObject reader;
    [SerializeField] private float recordSpeed = 5.0f;
    private bool readerInPosition = false;
    [SerializeField] private float readerPosition = 55.0f;
    [SerializeField] private float readerSpeed = 5.0f;
    private float parentRotation;

    // Start is called before the first frame update
    void Start()
    {
        parentRotation = this.transform.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(readerInPosition) record.transform.Rotate(0, recordSpeed, 0);
        else
        {
            reader.transform.Rotate(0, readerSpeed, 0);
            if (((reader.transform.rotation.y - parentRotation) * 360.0f) >= readerPosition) readerInPosition = true;
            Debug.Log((reader.transform.rotation.y - parentRotation) * 360.0f);
        }
    }
}
