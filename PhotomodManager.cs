using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Photomod
{
    public static class PhotomodManager
    {
        //Is the mod enabled? Not enabled in the level editor.
        public static bool modEnabled = true;
        //References to the game.
        public static FlyingCameraScript fcs;
        public static PhotomodTargetView targetView = new PhotomodTargetView();
        public static SpectatorUIHandler spectatorUIHandler;

        public static void SetFlyingCameraScript(FlyingCameraScript flyingCameraScript){ fcs = flyingCameraScript; }
        public static void InitializeSpectatorCameraUI(SpectatorCameraUI spectatorCameraUI) 
        {
            GameObject gameplayCanvas = GameObject.Find("Gameplay Canvas");
            Transform playerPanel = gameplayCanvas.transform.GetChild(0).GetChild(0);
            SpeedDisplay speedDisplay = playerPanel.GetChild(playerPanel.childCount - 1).GetComponent<SpeedDisplay>();

            spectatorUIHandler = new SpectatorUIHandler(spectatorCameraUI, speedDisplay);
        }

        public static void Update()
        {
            if (!modEnabled) { return; }
            if(fcs == null) { return; }
            if(spectatorUIHandler == null) { return; }
            if(spectatorUIHandler.scui == null) { return; }
            if (fcs.currentTarget == null) { return; }
            
            //Update the target view with the current target.
            targetView.Update(fcs.currentTarget);

            //Update the visual with the data from the target view.
            spectatorUIHandler.targetinput_speedDisplay.UpdateIndicator(targetView.steering_axis, targetView.brake, targetView.armsUp);
            spectatorUIHandler.UpdateSpeedText(targetView.speed);

            HandleInputs();
        }
        
        public static void ConfigChanged()
        {
            if (!modEnabled) { return; }
            if (fcs == null) { return; }
            if (spectatorUIHandler == null) { return; }
            if (spectatorUIHandler.scui == null) { return; }

            spectatorUIHandler.ApplyConfigValues();
        }

        public static void HandleInputs()
        {
            //Get any toggle inputs
            if (PhotomodConfig.target_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.target_key))
                {
                    PhotomodConfig.config[PhotomodConfig.targetTitle, PhotomodConfig.settings_target_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.targetTitle, PhotomodConfig.settings_target_visible].BoxedValue;
                }
            }

            if (PhotomodConfig.mode_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.mode_key))
                {
                    PhotomodConfig.config[PhotomodConfig.modeTitle, PhotomodConfig.settings_mode_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.modeTitle, PhotomodConfig.settings_mode_visible].BoxedValue;
                }
            }

            if (PhotomodConfig.fov_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.fov_key))
                {
                    PhotomodConfig.config[PhotomodConfig.fovTitle, PhotomodConfig.settings_fov_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.fovTitle, PhotomodConfig.settings_fov_visible].BoxedValue;
                }
            }

            if (PhotomodConfig.level_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.level_key))
                {
                    PhotomodConfig.config[PhotomodConfig.levelTitle, PhotomodConfig.settings_level_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.levelTitle, PhotomodConfig.settings_level_visible].BoxedValue;
                }
            }

            if (PhotomodConfig.timeleft_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.timeleft_key))
                {
                    PhotomodConfig.config[PhotomodConfig.timeleftTitle, PhotomodConfig.settings_timeleft_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.timeleftTitle, PhotomodConfig.settings_timeleft_visible].BoxedValue;
                }
            }

            if (PhotomodConfig.tooltips_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.tooltips_key))
                {
                    PhotomodConfig.config[PhotomodConfig.tooltipsTitle, PhotomodConfig.settings_tooltips_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.tooltipsTitle, PhotomodConfig.settings_tooltips_visible].BoxedValue;
                }
            }

            if (PhotomodConfig.targetspeed_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.targetspeed_key))
                {
                    PhotomodConfig.config[PhotomodConfig.targetspeedTitle, PhotomodConfig.settings_targetspeed_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.targetspeedTitle, PhotomodConfig.settings_targetspeed_visible].BoxedValue;
                }
            }

            if (PhotomodConfig.targetinput_toggleable)
            {
                if (Input.GetKeyDown(PhotomodConfig.targetinput_key))
                {
                    PhotomodConfig.config[PhotomodConfig.targetinputTitle, PhotomodConfig.settings_targetinput_visible].BoxedValue = !(bool)PhotomodConfig.config[PhotomodConfig.targetinputTitle, PhotomodConfig.settings_targetinput_visible].BoxedValue;
                }
            }
        }
    }          
}
