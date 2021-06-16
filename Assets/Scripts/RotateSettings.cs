using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "lessons/Lesson1/Rotate Settings")]

public class RotateSettings : ScriptableObject
{
    [SerializeField] private float _speed = 1;

    public float Speed { get { return _speed; } }

}
