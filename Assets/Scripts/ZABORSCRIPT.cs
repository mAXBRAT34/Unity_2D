using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZABORSCRIPT : MonoBehaviour
{
    [Range(0, 1)]
    public float power = 0.1f;
    [Header("Position Jiggler")]
    public bool positionJiggler = true;
    public bool rotationJiggler = true;

    public Vector3 positionJiggleAmount;
    public Vector3 rotationJiggleAmount;

    [Range(0, 100)]
    public float positionFrequency = 10f;
    [Range(0, 100)]
    public float rotationFrequency = 10f;

    float positionTime;
    float rotationTime;
    Vector3 basePosition;
    Quaternion baseRotation;

    private void Start()
    {
        basePosition = transform.localPosition;
        baseRotation = transform.localRotation;
    }

    private void Update()
    {
        var dt = Time.deltaTime;
        positionTime += dt * positionFrequency;
        rotationTime += dt * rotationFrequency;

        if (positionJiggler)
            transform.localPosition = basePosition + positionJiggleAmount * Mathf.Sin(positionTime) * power;

        if (rotationJiggler)
            transform.localRotation = baseRotation * Quaternion.Euler(rotationJiggleAmount * Mathf.Sin(rotationTime) * power);
    }
}
