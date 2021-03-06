﻿using UnityEngine;
using System.Collections;
namespace Systems.StatSystem
{
    public interface IStatLinkable
    {
        int Linker { get; }

        void AddLinker(StatLinker linker);
        void ClearLinkers();
        void UpdateLinkers();
    }
}
