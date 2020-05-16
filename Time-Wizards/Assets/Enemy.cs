using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    public int eHealth { get; set; }
    public int eAttackPow { get; set; }

}

interface IEnemy
{
    int eHealth { get; set; }
    int eAttackPow { get; set; }
}
