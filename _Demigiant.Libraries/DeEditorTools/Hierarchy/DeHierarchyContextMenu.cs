﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2017/02/04 11:56
// License Copyright (c) Daniele Giardini

using DG.DemiLib.External;
using UnityEditor;
using UnityEngine;

namespace DG.DeEditorTools.Hierarchy
{
    public class DeHierarchyContextMenu : MonoBehaviour
    {
        [MenuItem("GameObject/DeHierarchy/Reset", false, 21)]
        static void SetColorReset()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.None); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ Blue", false, 21)]
        static void SetColorBlue()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.Blue); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ Green", false, 21)]
        static void SetColorGreen()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.Green); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ Orange", false, 21)]
        static void SetColorOrange()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.Orange); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ Purple", false, 21)]
        static void SetColorPurple()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.Purple); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ Red", false, 21)]
        static void SetColorRed()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.Red); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ Yellow", false, 21)]
        static void SetColorYellow()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.Yellow); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ BrightGrey", false, 21)]
        static void SetColorBrightGrey()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.BrightGrey); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ DarkGrey", false, 21)]
        static void SetColorDarkGrey()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.DarkGrey); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ Black", false, 21)]
        static void SetColorBlack()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.Black); }

        [MenuItem("GameObject/DeHierarchy/Set Color ▸ White", false, 21)]
        static void SetColorWhite()
        { DeHierarchy.SetColorForSelections(DeHierarchyComponent.HColor.White); }
    }
}