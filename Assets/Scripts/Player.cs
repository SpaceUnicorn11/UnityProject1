using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float BounceSpeed;
    public Game Game;
    public Platform CurrentPlatform;
    public ParticleSystem DeathParticles;
    public ParticleSystem VictoryParticles;
    public ParticleSystem BounceParticles;

    public void Bounce()
    {
        BounceParticles.Play();
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    public void ReachFinish()
    {
        VictoryParticles.Play();
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Die()
    {
        DeathParticles.Play();
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }
}