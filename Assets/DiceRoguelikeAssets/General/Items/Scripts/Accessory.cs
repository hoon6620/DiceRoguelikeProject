﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSemiRoguelike
{
    [System.Serializable]
    public class Accessory : BaseItem
    {
        [SerializeField] private PassiveSkill skillPrefab;
        private PassiveSkill _skill;

        public Accessory(Accessory other)
        {
            _id = other._id;
            _name = other._name;
            _sprite = other._sprite;
            _ability = other._ability;
            skillPrefab = other.skillPrefab;
        }

        protected override void Init()
        {
            _skill = GameObject.Instantiate(skillPrefab, owner.transform);
            _skill.Init(owner);
        }

        public void Activate()
        {
            _skill.Passive();
            _skill.Init(owner);
        }
    }
}
