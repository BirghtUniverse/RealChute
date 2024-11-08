﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using KSP.UI;
using KSP.UI.Screens;
using RealChute.Extensions;
using RUI.Icons.Selectable;
using ToolbarControl_NS;
using UnityEngine;
using KSP.Localization;

/* RealChute was made by Christophe Savard (stupid_chris). You are free to copy, fork, and modify RealChute as you see
 * fit. However, redistribution is only permitted for unmodified versions of RealChute, and under attribution clause.
 * If you want to distribute a modified version of RealChute, be it code, textures, configs, or any other asset and
 * piece of work, you must get my explicit permission on the matter through a private channel, and must also distribute
 * it through the attribution clause, and must make it clear to anyone using your modification of my work that they
 * must report any problem related to this usage to you, and not to me. This clause expires if I happen to be
 * inactive (no connection) for a period of 90 days on the official KSP forums. In that case, the license reverts
 * back to CC-BY-NC-SA 4.0 INTL.*/

namespace RealChute
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RCToolbarManager : MonoBehaviour
    {
        #region Instance
        public static RCToolbarManager Instance { get; private set; }
        #endregion

        #region Fields
        private ToolbarControl controller;
        private bool visible;
        private GameObject settings;
        #endregion

        #region Methods
        // ReSharper disable once MemberCanBeMadeStatic.Local - breaks event call
        private void AddFilter()
        {
            //Loads the RealChute parachutes icon
            Texture2D normal = new Texture2D(32, 32), selected = new Texture2D(32, 32);
            normal.LoadImage(File.ReadAllBytes(Path.Combine(RCUtils.PluginDataURL, "FilterIcon.png")));
            selected.LoadImage(File.ReadAllBytes(Path.Combine(RCUtils.PluginDataURL, "FilterIcon_selected.png")));
            Icon icon = new Icon(Local.RCParachutes, normal, selected);

            //Adds the Parachutes filter to the Filter by Function category
            PartCategorizer.Category filterByFunction = PartCategorizer.Instance.filters.Find(f => f.button.categorydisplayName == "#autoLOC_453547"); //Filter by Function
            PartCategorizer.AddCustomSubcategoryFilter(filterByFunction, Local.Parachutes, Local.Parachutes, icon,
                p => p.moduleInfos.Any(m => m.moduleName == Local.RealChute || m.moduleName == Local.Parachutes));

            //Sets the buttons in the Filter by Module category
            List<PartCategorizer.Category> modules = PartCategorizer.Instance.filters
                .Find(f => f.button.categorydisplayName == "#autoLOC_453705").subcategories; //Filter by Module
            modules.Remove(modules.Find(m => m.button.categoryName == Local.ProceduralChute));
            modules.Select(m => m.button).Single(b => b.categoryName == Local.RealChute).SetIcon(icon);

            //Apparently needed to make sure the buttons in Filter by Function show when the editor is loaded
            UIRadioButton button = filterByFunction.button.activeButton;
            button.SetState(UIRadioButton.State.False, UIRadioButton.CallType.APPLICATION, null, false);
            button.SetState(UIRadioButton.State.True, UIRadioButton.CallType.APPLICATION, null, false);
        }

        private void Show()
        {
            if (this.visible) return;

            this.settings = new GameObject(Local.RealChuteSettingsWindow, typeof(SettingsWindow));
            this.visible = true;
        }

        private void Hide()
        {
            if (!this.visible) return;

            Destroy(this.settings);
            this.visible = false;
        }

        internal void RequestHide() => this.controller.SetFalse(true);
        #endregion

        #region Initialization
        private void Awake()
        {
            if (CompatibilityChecker.IsAllCompatible && !Instance)
            {
                Instance = this;
                DontDestroyOnLoad(this);
                return;
            }

            //Removes RealChute parts from being seen if incompatible
            PartLoader.LoadedPartsList
                      .Where(p => p.moduleInfos.Exists(m => m.moduleName == Local.RealChute || m.moduleName == "ProceduralChute"))
                      .ForEach(p => p.category = PartCategories.none);
        }

        private void Start()
        {
            if (Instance != this) return;

            Debug.Log("[RealChute]: Adding toolbar events");
            ToolbarControl.RegisterMod(nameof(RealChute), DisplayName: Local.RealChuteSettings, useBlizzy: false, useStock: true, NoneAllowed: false);

            this.controller = this.gameObject.AddComponent<ToolbarControl>();
            this.controller.AddToAllToolbars(Show, Hide, ApplicationLauncher.AppScenes.SPACECENTER, nameof(RealChute), nameof(RCToolbarManager),
                                             RCUtils.ToolbarIconURL, RCUtils.ToolbarIconURL, RCUtils.ToolbarIconURL, RCUtils.ToolbarIconURL, "RealChute Settings");
            GameEvents.onGUIEditorToolbarReady.Add(AddFilter);
        }

        private void OnDestroy()
        {
            if (Instance != this) return;

            Debug.Log("[RealChute]: Removing toolbar events");
            GameEvents.onGUIEditorToolbarReady.Remove(AddFilter);
            this.controller.OnDestroy();
            Destroy(this.controller);
            Instance = null;
        }
        #endregion
    }
}