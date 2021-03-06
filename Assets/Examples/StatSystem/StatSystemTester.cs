﻿using UnityEngine;
using Systems.StatSystem;


namespace Systems.Example
{
    /// <summary>
    /// What it's like to use the Stat System with an Entity
    /// </summary>
    public class StatSystemTester : MonoBehaviour
    {
        public Entity entity;

        public void AddToAttribute(int id)
        {
            StatType s = (StatType)id;
            entity.Stats.GetStat<StatAttribute>(s).ScaleStatToNextLevel();
        }

        public void SubtractFromAttribute(int id)
        {
            Debug.Log(id);
            StatType s = (StatType)id;
            entity.Stats.GetStat<StatAttribute>(s).ScaleStatToPrevLevel();
        }

        public void TakeDamage()
        {
            entity.TakeDamage(Random.Range(5, 20));
        }

        public void ReceiveHealth()
        {
            entity.RestoreHealth(Random.Range(5, 20));
        }

        public void RestoreHealth()
        {
            entity.RestoreHealth();
        }

        public void AddInventory()
        {
            entity.Stats.GetStat<StatVital>(StatType.InventoryCap).Value += Random.Range(1, 5);
        }

        public void RemoveFromInventory()
        {
            entity.Stats.GetStat<StatVital>(StatType.InventoryCap).Value -= Random.Range(1, 5);
        }

        public void ReceiveExp()
        {
            entity.Level.ModifyExp(Random.Range(75, 100));
        }

        public void UseMagic()
        {
            entity.Stats.GetStat<StatVital>(StatType.Magic).Value -= Random.Range(10, 15);
        }

        public void AddModifier()
        {
            entity.Stats.GetStat<StatRegeneratable>(StatType.Health).AddModifier(new StatModBasePercent(1f, false));
            entity.Stats.GetStat<StatRegeneratable>(StatType.Health).AddModifier(new StatModBaseAdd(50f));
            entity.Stats.GetStat<StatRegeneratable>(StatType.Health).AddModifier(new StatModBaseAdd(1.0f));
            entity.Stats.GetStat<StatRegeneratable>(StatType.Health).UpdateModifiers();
        }
    }
}
