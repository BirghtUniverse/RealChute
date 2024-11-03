using System;
using System.Collections.Generic;
using System.Text;
using ClickThroughFix;
using RealChute.Extensions;
using RealChute.Libraries;
using RealChute.Libraries.Presets;
using UnityEngine;
using KSP.Localization;

namespace RealChute
{
    public static class Local

    {
        /// <summary>
        /// 通用
        /// </summary>
        public static string RealChute = Localizer.Format("#RC_RealChute");
        public static string Close = Localizer.Format("#RC_Close");
        public static string Editor_Cancel = Localizer.Format("#RC_Editor_Cancel");
        public static string Editor_No = Localizer.Format("#RC_Editor_No");
        public static string Editor_Yes = Localizer.Format("#RC_Editor_Yes");
        public static string Editor_Error = Localizer.Format("#RC_Editor_Error");
        public static string Editor_Success = Localizer.Format("#RC_Editor_Success");
        public static string True = Localizer.Format("#RC_True");
        public static string False = Localizer.Format("#RC_False");

        /// <summary>
        /// Parachute Editor
        /// </summary>
        public static string RealChutechuteEditor = Localizer.Format("#RC_realchutechuteEditor");
        public static string Editor_Notapp = Localizer.Format("#RC_Editor_notapp");
        public static string Editor_Emptypresets = Localizer.Format("#RC_Editor_Empty");
        public static string Editor_Description = Localizer.Format("#RC_Editor_Description");
        public static string Applysetting = Localizer.Format("#RC_ApplySetting");
        public static string Targetplanet = Localizer.Format("#RC_Targetplanet");

        /// <summary>
        /// Editor Options
        /// </summary>
        public static string chutemodel = Localizer.Format("#RC_chutemodle");
        public static string Deployonground = Localizer.Format("#RC_Deployonground");
        public static string Deploymenttimer = Localizer.Format("#RC_Deploymenttimer");
        public static string Sparechutes = Localizer.Format("#RC_Sparechutes");
        public static string cutspeed = Localizer.Format("#RC_Autocutspeed");
        public static string Landingalt = Localizer.Format("#RC_Landingalt");
        public static string Cyclepartsize = Localizer.Format("#RC_Cyclepartsize");
        public static string Previoussize = Localizer.Format("#RC_Previoussize");
        public static string Nextsize = Localizer.Format("#RC_Nextsize");
        public static string Mainchute = Localizer.Format("#RC_Mainchute");
        public static string Secondarychute = Localizer.Format("#RC_Secondarychute");
        public static string Main = Localizer.Format("#RC_Main");//N
        public static string Drogue = Localizer.Format("#RC_Drogue");//N
        public static string Drag = Localizer.Format("#RC_Drag");//N
        public static string Combo = Localizer.Format("#RC_Combo");//N
        public static string top = Localizer.Format("#RC_top");
        public static string bottom = Localizer.Format("#RC_bottom");
        public static string Nylon = Localizer.Format("#RC_Nylon");
        public static string casetexture = Localizer.Format("#RC_casetexture");
        public static string chutetexture = Localizer.Format("#RC_chutetexture");
        public static string Automatic = Localizer.Format("#RC_Automatic");
        public static string Manual = Localizer.Format("#RC_Manual");
        public static string Usecraftmass = Localizer.Format("#RC_Usecraftmass");
        public static string Inputmass = Localizer.Format("#RC_Inputmass");
        public static string Drymass = Localizer.Format("#RC_Drymass");
        public static string Wetmass = Localizer.Format("#RC_Wetmass");
        public static string Currentlyusing = Localizer.Format("#RC_Currentlyusing");
        public static string Switchto = Localizer.Format("#RC_Switchto");
        public static string Masstouse = Localizer.Format("#RC_Masstouse");
        public static string Wantedtouchdownspeed = Localizer.Format("#RC_Wantedtouchdownspeed");
        public static string Wantedtargetalt = Localizer.Format("#RC_Wantedtargetalt");
        public static string Plannedlandingspeed = Localizer.Format("#RC_Plannedlandingspeed");
        public static string Targetaltitude = Localizer.Format("#RC_Targetaltitude");
        public static string Wanteddeceleration = Localizer.Format("#RC_Wanteddeceleration");
        public static string Parachutesused = Localizer.Format("#RC_Parachutesused");
        //Material
        public static string Currentmaterial = Localizer.Format("#RC_Currentmaterial");
        public static string Changematerial = Localizer.Format("#RC_Changematerial");
        public static string Choosematerial = Localizer.Format("#RC_Choosematerial");
        public static string Dragcoefficient = Localizer.Format("#RC_Dragcoefficient");
        public static string Areadensity = Localizer.Format("#RC_Areadensity");
        public static string Areacost = Localizer.Format("#RC_Areacost");
        public static string Maxtemperature = Localizer.Format("#RC_Maxtemperature");
        public static string Specificheat = Localizer.Format("#RC_Specificheat");
        public static string Emissivityconstant = Localizer.Format("#RC_Emissivityconstant");
        /// <summary>
        /// Preset
        /// </summary>
        public static string Editor_presets = Localizer.Format("#RC_Editor_presets");
        public static string Selectapreset = Localizer.Format("#RC_Selectapreset");
        public static string Saveaspreset = Localizer.Format("#RC_Saveaspreset");
        public static string Presetname = Localizer.Format("#RC_Editor_Presetname");
        public static string Presetnamenotempty = Localizer.Format("#RC_Presetnamenotempty");
        public static string Presetdescription = Localizer.Format("#RC_Presetdescription");
        public static string Selectpreset = Localizer.Format("#RC_Selectpreset");
        public static string Deletepreset = Localizer.Format("#RC_Deletepreset");
        public static string Save = Localizer.Format("#RC_Editor_Save");
        public static string Saved = Localizer.Format("#RC_Editor_Saved");
        public static string SaveWarning = Localizer.Format("#RC_Editor_SaveWarning");
        public static string DeleteWarning = Localizer.Format("#RC_Editor_DeleteWarning"); 

        /// <summary>
        /// Part info
        /// </summary>
        public static string Selectedpart = Localizer.Format("#RC_Selectedpart");
        public static string Casemass = Localizer.Format("#RC_Casemass");
        public static string Casecost = Localizer.Format("#RC_Casecost");
        public static string Totalpartmass = Localizer.Format("#RC_Totalpartmass");
        public static string Totalpartcost = Localizer.Format("#RC_Totalpartcost");
        public static string RCParachutes = Localizer.Format("#RC_RCParachutes");
        public static string Parachutes = Localizer.Format("#RC_Parachutes");
        public static string ProceduralChute = Localizer.Format("#RC_ProceduralChute");
        public static string RealChuteSettingsWindow = Localizer.Format("#RC_RealChuteSettingsWindow");
        public static string semiDeploy = Localizer.Format("#RC_semiDeploy");
        public static string godowndeploy = Localizer.Format("#RC_godowndeploy");
        public static string Calculationsmode = Localizer.Format("#RC_Calculationsmode");
        public static string Partname = Localizer.Format("#RC_Partname");
        public static string Symmetrycounterparts = Localizer.Format("#RC_Symmetrycounterparts");
        public static string Partmass = Localizer.Format("#RC_Partmass");
        public static string deploymentvelocity = Localizer.Format("#RC_deploymentvelocity");
        public static string Material = Localizer.Format("#RC_Material");
        public static string Predeployeddiameter = Localizer.Format("#RC_Predeployeddiameter");
        public static string Deployeddiameter = Localizer.Format("#RC_Deployeddiameter");
        public static string Area = Localizer.Format("#RC_Area");
        public static string Resultingarea = Localizer.Format("#RC_Resultingarea");
        /// <summary>
        /// Message
        /// </summary>
        public static string repackmessage = Localizer.Format("#RC_repackfailmessage");
        public static string succeedednotice = Localizer.Format("#RC_successnotice");
        public static string warningnotice = Localizer.Format("#RC_warningnotice");
        public static string Repackonlyenginer = Localizer.Format("#RC_Repackonlyenginer");
        public static string deploymentfailed = Localizer.Format("#RC_deploymentfailed");
        public static string Reasonfairings = Localizer.Format("#RC_Reasonfairings");
        public static string Reasonstopped = Localizer.Format("#RC_Reasonstopped");
        public static string Reasoninspace = Localizer.Format("#RC_Reasoninspace");
        public static string Reasontoohigh = Localizer.Format("#RC_Reasontoohigh");
        /// <summary>
        /// Setting
        /// </summary>
        public static string RealChuteSettings = Localizer.Format("#RC_RealChuteSettings");
        public static string Autoarm = Localizer.Format("#RC_Autoarm");
        public static string JokeActivated = Localizer.Format("#RC_JokeActivated");
        public static string ActivateNyan = Localizer.Format("#RC_ActivateNyan");
        public static string GuiResizeUpdates = Localizer.Format("#RC_GuiResizeUpdates");
        public static string MustBeEngineer = Localizer.Format("#RC_MustBeEngineer");        
        public static string MustBeEngineerlevel = Localizer.Format("#RC_MustBeEngineerlevel");
        //DeploymentSafety
        public static string Deploymentsafety = Localizer.Format("#RC_Deploymentsafety");
        public static string safe = Localizer.Format("#RC_safe");
        public static string risky = Localizer.Format("#RC_risky");
        public static string dangerous = Localizer.Format("#RC_dangerous");
        //Temperature info
        public static string Chutemaxtemperature = Localizer.Format("#RC_Chutemaxtemperature");
        public static string Currentchutetemperature = Localizer.Format("#RC_Currentchutetemperature");
        //Pressure/altitude predeployment toggle
        public static string Predeployment = Localizer.Format("#RC_Predeployment");
        public static string altitude = Localizer.Format("#RC_altitude");
        public static string pressure = Localizer.Format("#RC_pressure");
        public static string Altitudepredeployment = Localizer.Format("#RC_Altitudepredeployment");
        public static string Predeploymentaltitude = Localizer.Format("#RC_Predeploymentaltitude");
        public static string Pressurepredeployment = Localizer.Format("#RC_Pressurepredeployment");
        public static string Predeploymentpressure = Localizer.Format("#RC_Predeploymentpressure");
        //Predeployment pressure selection

        //Other labels
        public static string Autocutaltitude = Localizer.Format("#RC_Autocutaltitude");
        public static string Predeploymentspeed = Localizer.Format("#RC_Predeploymentspeed");
        public static string Deploymentspeed = Localizer.Format("#RC_Deploymentspeed");
        //Copies the given values to the other parachutes
        public static string Copytosymmetrycounterparts = Localizer.Format("#RC_CopyToSymmetryCounterparts");
        //Unknown:
        public static string Resultingpredeployedarea = Localizer.Format("#RC_Resultingpredeployedarea");
        public static string Resultingdeployedarea = Localizer.Format("#RC_Resultingdeployedarea");
    }
}

//Craft  n.载具;航天器
//Deployment v.部署；开伞