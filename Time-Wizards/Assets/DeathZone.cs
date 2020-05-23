using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    Transform spawnPoint;

    private void Awake()
    {
        SpawnPoint spawn = FindObjectOfType<SpawnPoint>();
        spawnPoint = spawn.transform;
    }

    public void TeleportPlayer(CharacterController player)
    {
        player.enabled = false;
        player.transform.position = spawnPoint.transform.position;
        player.enabled = true;
    }
}
