﻿using BasicTowerDefender.Manager;
using UnityEngine;

namespace BasicTowerDefender.Ally
{
    public class Allies : MonoBehaviour
    {
        [SerializeField] private int pointCost;
        [SerializeField] private int health;
        private int currentHealth;

        public int PointCost => pointCost;

        private void Start()
        {
            currentHealth = health;
        }

        public void AddPointToScore(int points)
        {
            GameplayUIManager.Instance.AddToScore(points);
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}