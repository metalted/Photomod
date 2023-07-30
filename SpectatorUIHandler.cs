using TMPro;
using UnityEngine;

namespace Photomod
{
    public class SpectatorUIHandler
    {
        public SpectatorCameraUI scui;

        private RectTransform target_rect;
        private Vector2 target_anchorMin;
        private Vector2 target_anchorMax;

        private RectTransform mode_rect;
        private Vector2 mode_anchorMin;
        private Vector2 mode_anchorMax;

        private RectTransform level_rect;
        private Vector2 level_anchorMin;
        private Vector2 level_anchorMax;

        private RectTransform fov_rect;
        private Vector2 fov_anchorMin;
        private Vector2 fov_anchorMax;

        private RectTransform timer_rect;
        private Vector2 timer_anchorMin;
        private Vector2 timer_anchorMax;

        private RectTransform tooltips_rect;
        private Vector2 tooltips_anchorMin;
        private Vector2 tooltips_anchorMax;

        //Modded
        private TextMeshProUGUI targetspeed_tmpro;
        private RectTransform targetspeed_rect;
        private Vector2 targetspeed_anchorMin;
        private Vector2 targetspeed_anchorMax;

        private RectTransform targetinput_rect;
        private Vector2 targetinput_anchorMin;
        private Vector2 targetinput_anchorMax;
        public SpectatorSpeedDisplay targetinput_speedDisplay;

        public enum ControlType { Target, Mode, Level, FOV, Timer, Tooltips, TargetSpeed, TargetInput };

        public SpectatorUIHandler(SpectatorCameraUI spectatorCameraUI, SpeedDisplay speedDisplay)
        {
            scui = spectatorCameraUI;

            target_rect = scui.Target.GetComponent<RectTransform>();
            target_anchorMin = target_rect.anchorMin;
            target_anchorMax = target_rect.anchorMax;

            mode_rect = scui.Mode.GetComponent<RectTransform>();
            mode_anchorMin = mode_rect.anchorMin;
            mode_anchorMax = mode_rect.anchorMax;

            level_rect = scui.LevelAndAuthor.GetComponent<RectTransform>();
            level_anchorMin = level_rect.anchorMin;
            level_anchorMax = level_rect.anchorMax;

            fov_rect = scui.FOV.GetComponent<RectTransform>();
            fov_anchorMin = fov_rect.anchorMin;
            fov_anchorMax = fov_rect.anchorMax;

            timer_rect = scui.Timer.GetComponent<RectTransform>();
            timer_anchorMin = timer_rect.anchorMin;
            timer_anchorMax = timer_rect.anchorMax;

            tooltips_rect = scui.SmallTooltips.GetComponent<RectTransform>();
            tooltips_anchorMin = tooltips_rect.anchorMin;
            tooltips_anchorMax = tooltips_rect.anchorMax;

            CreateCustomUI(speedDisplay);

            ApplyConfigValues();
        }

        public void UpdateSpeedText(float speed)
        {
            if(targetspeed_tmpro != null)
            {
                targetspeed_tmpro.text = "Speed: " + Mathf.RoundToInt(speed);
            }
        }

        private void CreateCustomUI(SpeedDisplay speedDisplay)
        {
            //Create the speed text components.
            targetspeed_tmpro = GameObject.Instantiate(mode_rect.gameObject, mode_rect.transform.parent).GetComponent<TextMeshProUGUI>();
            targetspeed_rect = targetspeed_tmpro.GetComponent<RectTransform>();

            //Calculate the distance between the target text and the mode text so we can apply the same spacing for the speed text.
            Vector2 targetModeDistance = new Vector2(0, target_anchorMin.y - mode_anchorMin.y);

            //Move the speed text down.
            targetspeed_rect.anchorMin -= targetModeDistance;
            targetspeed_rect.anchorMax -= targetModeDistance;

            //Save the anchors.
            targetspeed_anchorMin = targetspeed_rect.anchorMin;
            targetspeed_anchorMax = targetspeed_rect.anchorMax;

            //Create a copy of the speed display 
            targetinput_rect = GameObject.Instantiate(speedDisplay.gameObject, speedDisplay.transform.parent).GetComponent<RectTransform>();
            targetinput_speedDisplay = targetinput_rect.gameObject.AddComponent<SpectatorSpeedDisplay>();
            targetinput_speedDisplay.CopyAndDestroySpeedDisplay();

            //Calculate the size of the display
            Vector2 speedDisplaySize = targetinput_rect.anchorMax - targetinput_rect.anchorMin;

            //Calculate the anchor points
            targetinput_anchorMin = new Vector2(targetspeed_rect.anchorMin.x + 0.05f, targetspeed_rect.anchorMin.y - (speedDisplaySize.y * 1.5f));
            targetinput_anchorMax = targetinput_anchorMin + speedDisplaySize;

            //Set the anchor points
            targetinput_rect.anchorMin = targetinput_anchorMin;
            targetinput_rect.anchorMax = targetinput_anchorMax;

            //Set the parent to the photomode canvas.
            targetinput_rect.SetParent(targetspeed_rect.parent);
            targetinput_rect.gameObject.SetActive(true);
        }

        public void SetControl(ControlType controlType, int scale, Vector2 shift)
        {
            RectTransform rect = null;
            Vector2 anchorMin = Vector2.zero;
            Vector2 anchorMax = Vector2.zero;

            switch (controlType)
            {
                case ControlType.Target:
                    rect = target_rect;
                    anchorMin = target_anchorMin;
                    anchorMax = target_anchorMax;
                    break;
                case ControlType.Mode:
                    rect = mode_rect;
                    anchorMin = mode_anchorMin;
                    anchorMax = mode_anchorMax;
                    break;
                case ControlType.Level:
                    rect = level_rect;
                    anchorMin = level_anchorMin;
                    anchorMax = level_anchorMax;
                    break;
                case ControlType.FOV:
                    rect = fov_rect;
                    anchorMin = fov_anchorMin;
                    anchorMax = fov_anchorMax;
                    break;
                case ControlType.Timer:
                    rect = timer_rect;
                    anchorMin = timer_anchorMin;
                    anchorMax = timer_anchorMax;
                    break;
                case ControlType.Tooltips:
                    rect = tooltips_rect;
                    anchorMin = tooltips_anchorMin;
                    anchorMax = tooltips_anchorMax;
                    break;
                case ControlType.TargetSpeed:
                    rect = targetspeed_rect;
                    anchorMin = targetspeed_anchorMin;
                    anchorMax = targetspeed_anchorMax;
                    break;
                case ControlType.TargetInput:
                    rect = targetinput_rect;
                    anchorMin = targetinput_anchorMin;
                    anchorMax = targetinput_anchorMax;
                    break;
            }

            //Calculate the center using the anchors.
            Vector2 center = (anchorMax + anchorMin) / 2f;
            //Calculate the new distance from the center
            Vector2 newDistance = (anchorMax - center) * ((float)scale / 100f);

            Vector2 screenSpaceShift = shift / new Vector2(Screen.width, Screen.height);

            //Shift the center
            center.x += screenSpaceShift.x;
            center.y += screenSpaceShift.y;

            //Set the anchor points.
            rect.anchorMin = center - newDistance;
            rect.anchorMax = center + newDistance;

            rect.gameObject.SetActive(true);
        }

        public void ApplyConfigValues()
        {
            if (PhotomodConfig.target_visible)
            {
                SetControl(ControlType.Target, PhotomodConfig.target_scale, new Vector2(PhotomodConfig.target_shift_x, PhotomodConfig.target_shift_y));
            }
            else
            {
                target_rect.gameObject.SetActive(false);
            }

            if (PhotomodConfig.mode_visible)
            {
                SetControl(ControlType.Mode, PhotomodConfig.mode_scale, new Vector2(PhotomodConfig.mode_shift_x, PhotomodConfig.mode_shift_y));
            }
            else
            {
                mode_rect.gameObject.SetActive(false);
            }

            if (PhotomodConfig.fov_visible)
            {
                SetControl(ControlType.FOV, PhotomodConfig.fov_scale, new Vector2(PhotomodConfig.fov_shift_x, PhotomodConfig.fov_shift_y));
            }
            else
            {
                fov_rect.gameObject.SetActive(false);
            }

            if (PhotomodConfig.level_visible)
            {
                SetControl(ControlType.Level, PhotomodConfig.level_scale, new Vector2(PhotomodConfig.level_shift_x, PhotomodConfig.level_shift_y));
            }
            else
            {
                level_rect.gameObject.SetActive(false);
            }

            if (PhotomodConfig.timeleft_visible)
            {
                SetControl(ControlType.Timer, PhotomodConfig.timeleft_scale, new Vector2(PhotomodConfig.timeleft_shift_x, PhotomodConfig.timeleft_shift_y));
            }
            else
            {
                timer_rect.gameObject.SetActive(false);
            }

            if (PhotomodConfig.tooltips_visible)
            {
                SetControl(ControlType.Tooltips, PhotomodConfig.tooltips_scale, new Vector2(PhotomodConfig.tooltips_shift_x, PhotomodConfig.tooltips_shift_y));
            }
            else
            {
                tooltips_rect.gameObject.SetActive(false);
            }

            if (PhotomodConfig.targetspeed_visible)
            {
                SetControl(ControlType.TargetSpeed, PhotomodConfig.targetspeed_scale, new Vector2(PhotomodConfig.targetspeed_shift_x, PhotomodConfig.targetspeed_shift_y));
            }
            else
            {
                targetspeed_rect.gameObject.SetActive(false);
            }

            if (PhotomodConfig.targetinput_visible)
            {
                SetControl(ControlType.TargetInput, PhotomodConfig.targetinput_scale, new Vector2(PhotomodConfig.targetinput_shift_x, PhotomodConfig.targetinput_shift_y));
            }
            else
            {
                targetinput_rect.gameObject.SetActive(false);
            }
        }
    }
}
