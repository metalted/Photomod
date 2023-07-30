using System;
using UnityEngine;
using BepInEx.Configuration;

namespace Photomod
{
    public static class PhotomodConfig
    {
        public static ConfigFile config;
        public static int configLabelLength = 38;

        public static bool target_visible = true;
        public static bool mode_visible = true;
        public static bool fov_visible = true;
        public static bool level_visible = true;
        public static bool timeleft_visible = true;
        public static bool tooltips_visible = true;
        public static bool targetspeed_visible = true;
        public static bool targetinput_visible = true;

        public static int target_shift_x = 0;
        public static int target_shift_y = 0;
        public static int mode_shift_x = 0;
        public static int mode_shift_y = 0;
        public static int fov_shift_x = 0;
        public static int fov_shift_y = 0;
        public static int level_shift_x = 0;
        public static int level_shift_y = 0;
        public static int timeleft_shift_x = 0;
        public static int timeleft_shift_y = 0;
        public static int tooltips_shift_x = 0;
        public static int tooltips_shift_y = 0;
        public static int targetspeed_shift_x = 0;
        public static int targetspeed_shift_y = 0;
        public static int targetinput_shift_x = 0;
        public static int targetinput_shift_y = 0;

        public static bool target_toggleable = true;
        public static bool mode_toggleable = true;
        public static bool fov_toggleable = true;
        public static bool level_toggleable = true;
        public static bool timeleft_toggleable = true;
        public static bool tooltips_toggleable = true;
        public static bool targetspeed_toggleable = true;
        public static bool targetinput_toggleable = true;

        public static KeyCode target_key = KeyCode.Keypad0;
        public static KeyCode mode_key = KeyCode.Keypad1;
        public static KeyCode fov_key = KeyCode.Keypad2;
        public static KeyCode level_key = KeyCode.Keypad3;
        public static KeyCode timeleft_key = KeyCode.Keypad4;
        public static KeyCode tooltips_key = KeyCode.Keypad5;
        public static KeyCode targetspeed_key = KeyCode.Keypad6;
        public static KeyCode targetinput_key = KeyCode.Keypad7;

        public static int target_scale = 100;
        public static int mode_scale = 100;
        public static int fov_scale = 100;
        public static int level_scale = 100;
        public static int timeleft_scale = 100;
        public static int tooltips_scale = 100;
        public static int targetspeed_scale = 100;
        public static int targetinput_scale = 100;

        public static string targetTitle = "1. Target";
        public static string settings_target_visible = CreateConfigLabel(1, "Visible");
        public static string settings_target_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_target_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_target_scale = CreateConfigLabel(4, "Scale (%)");
        public static string settings_target_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_target_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static string modeTitle = "2. Mode";
        public static string settings_mode_visible = CreateConfigLabel(1, "Visible");
        public static string settings_mode_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_mode_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_mode_scale = CreateConfigLabel(4, "Scale (%)");
        public static string settings_mode_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_mode_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static string fovTitle = "3. FOV";
        public static string settings_fov_visible = CreateConfigLabel(1, "Visible");
        public static string settings_fov_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_fov_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_fov_scale = CreateConfigLabel(4, "Scale (%)");
        public static string settings_fov_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_fov_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static string levelTitle = "4. Level";
        public static string settings_level_visible = CreateConfigLabel(1, "Visible");
        public static string settings_level_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_level_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_level_scale = CreateConfigLabel(4, "Scale (%)");
        public static string settings_level_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_level_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static string timeleftTitle = "5. Time Left";
        public static string settings_timeleft_visible = CreateConfigLabel(1, "Visible");
        public static string settings_timeleft_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_timeleft_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_timeleft_scale = CreateConfigLabel(4, "Scale");
        public static string settings_timeleft_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_timeleft_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static string tooltipsTitle = "6. Tooltips";
        public static string settings_tooltips_visible = CreateConfigLabel(1, "Visible");
        public static string settings_tooltips_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_tooltips_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_tooltips_scale = CreateConfigLabel(4, "Scale (%)");
        public static string settings_tooltips_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_tooltips_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static string targetspeedTitle = "7. Target Speed";
        public static string settings_targetspeed_visible = CreateConfigLabel(1, "Visible");
        public static string settings_targetspeed_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_targetspeed_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_targetspeed_scale = CreateConfigLabel(4, "Scale (%)");
        public static string settings_targetspeed_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_targetspeed_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static string targetinputTitle = "8. Target Input";
        public static string settings_targetinput_visible = CreateConfigLabel(1, "Visible");
        public static string settings_targetinput_toggleable = CreateConfigLabel(2, "Toggleable");
        public static string settings_targetinput_key = CreateConfigLabel(3, "Toggle key");
        public static string settings_targetinput_scale = CreateConfigLabel(4, "Scale (%)");
        public static string settings_targetinput_shift_x = CreateConfigLabel(5, "Position Shift X (px)");
        public static string settings_targetinput_shift_y = CreateConfigLabel(6, "Position Shift Y (px)");

        public static void ForceReload()
        {
            Cfg_SettingsChanged(null, null);
        }

        public static void InitializeConfig(ConfigFile cfg)
        {
            config = cfg;
            ConfigEntry<bool> cfg_target_visible = config.Bind(targetTitle, settings_target_visible, target_visible, "");
            ConfigEntry<bool> cfg_target_toggleable = config.Bind(targetTitle, settings_target_toggleable, target_toggleable, "");
            ConfigEntry<KeyCode> cfg_target_key = config.Bind(targetTitle, settings_target_key, target_key, "");
            ConfigEntry<int> cfg_target_scale = config.Bind(targetTitle, settings_target_scale, target_scale, "");
            ConfigEntry<int> cfg_target_shift_x = config.Bind(targetTitle, settings_target_shift_x, target_shift_x, "");            
            ConfigEntry<int> cfg_target_shift_y = config.Bind(targetTitle, settings_target_shift_y, target_shift_y, "");

            ConfigEntry<bool> cfg_mode_visible = config.Bind(modeTitle, settings_mode_visible, mode_visible, "");
            ConfigEntry<bool> cfg_mode_toggleable = config.Bind(modeTitle, settings_mode_toggleable, mode_toggleable, "");
            ConfigEntry<KeyCode> cfg_mode_key = config.Bind(modeTitle, settings_mode_key, mode_key, "");
            ConfigEntry<int> cfg_mode_scale = config.Bind(modeTitle, settings_mode_scale, mode_scale, "");
            ConfigEntry<int> cfg_mode_shift_x = config.Bind(modeTitle, settings_mode_shift_x, mode_shift_x, "");
            ConfigEntry<int> cfg_mode_shift_y = config.Bind(modeTitle, settings_mode_shift_y, mode_shift_y, "");

            ConfigEntry<bool> cfg_fov_visible = config.Bind(fovTitle, settings_fov_visible, fov_visible, "");
            ConfigEntry<bool> cfg_fov_toggleable = config.Bind(fovTitle, settings_fov_toggleable, fov_toggleable, "");
            ConfigEntry<KeyCode> cfg_fov_key = config.Bind(fovTitle, settings_fov_key, fov_key, "");
            ConfigEntry<int> cfg_fov_scale = config.Bind(fovTitle, settings_fov_scale, fov_scale, "");
            ConfigEntry<int> cfg_fov_shift_x = config.Bind(fovTitle, settings_fov_shift_x, fov_shift_x, "");
            ConfigEntry<int> cfg_fov_shift_y = config.Bind(fovTitle, settings_fov_shift_y, fov_shift_y, "");

            ConfigEntry<bool> cfg_level_visible = config.Bind(levelTitle, settings_level_visible, level_visible, "");
            ConfigEntry<bool> cfg_level_toggleable = config.Bind(levelTitle, settings_level_toggleable, level_toggleable, "");
            ConfigEntry<KeyCode> cfg_level_key = config.Bind(levelTitle, settings_level_key, level_key, "");
            ConfigEntry<int> cfg_level_scale = config.Bind(levelTitle, settings_level_scale, level_scale, "");
            ConfigEntry<int> cfg_level_shift_x = config.Bind(levelTitle, settings_level_shift_x, level_shift_x, "");
            ConfigEntry<int> cfg_level_shift_y = config.Bind(levelTitle, settings_level_shift_y, level_shift_y, "");

            ConfigEntry<bool> cfg_timeleft_visible = config.Bind(timeleftTitle, settings_timeleft_visible, timeleft_visible, "");
            ConfigEntry<bool> cfg_timeleft_toggleable = config.Bind(timeleftTitle, settings_timeleft_toggleable, timeleft_toggleable, "");
            ConfigEntry<KeyCode> cfg_timeleft_key = config.Bind(timeleftTitle, settings_timeleft_key, timeleft_key, "");
            ConfigEntry<int> cfg_timeleft_scale = config.Bind(timeleftTitle, settings_timeleft_scale, timeleft_scale, "");
            ConfigEntry<int> cfg_timeleft_shift_x = config.Bind(timeleftTitle, settings_timeleft_shift_x, timeleft_shift_x, "");
            ConfigEntry<int> cfg_timeleft_shift_y = config.Bind(timeleftTitle, settings_timeleft_shift_y, timeleft_shift_y, "");

            ConfigEntry<bool> cfg_tooltips_visible = config.Bind(tooltipsTitle, settings_tooltips_visible, tooltips_visible, "");
            ConfigEntry<bool> cfg_tooltips_toggleable = config.Bind(tooltipsTitle, settings_tooltips_toggleable, tooltips_toggleable, "");
            ConfigEntry<KeyCode> cfg_tooltips_key = config.Bind(tooltipsTitle, settings_tooltips_key, tooltips_key, "");
            ConfigEntry<int> cfg_tooltips_scale = config.Bind(tooltipsTitle, settings_tooltips_scale, tooltips_scale, "");
            ConfigEntry<int> cfg_tooltips_shift_x = config.Bind(tooltipsTitle, settings_tooltips_shift_x, tooltips_shift_x, "");
            ConfigEntry<int> cfg_tooltips_shift_y = config.Bind(tooltipsTitle, settings_tooltips_shift_y, tooltips_shift_y, "");

            ConfigEntry<bool> cfg_targetspeed_visible = config.Bind(targetspeedTitle, settings_targetspeed_visible, targetspeed_visible, "");
            ConfigEntry<bool> cfg_targetspeed_toggleable = config.Bind(targetspeedTitle, settings_targetspeed_toggleable, targetspeed_toggleable, "");
            ConfigEntry<KeyCode> cfg_targetspeed_key = config.Bind(targetspeedTitle, settings_targetspeed_key, targetspeed_key, "");
            ConfigEntry<int> cfg_targetspeed_scale = config.Bind(targetspeedTitle, settings_targetspeed_scale, targetspeed_scale, "");
            ConfigEntry<int> cfg_targetspeed_shift_x = config.Bind(targetspeedTitle, settings_targetspeed_shift_x, targetspeed_shift_x, "");
            ConfigEntry<int> cfg_targetspeed_shift_y = config.Bind(targetspeedTitle, settings_targetspeed_shift_y, targetspeed_shift_y, "");

            ConfigEntry<bool> cfg_targetinput_visible = config.Bind(targetinputTitle, settings_targetinput_visible, targetinput_visible, "");
            ConfigEntry<bool> cfg_targetinput_toggleable = config.Bind(targetinputTitle, settings_targetinput_toggleable, targetinput_toggleable, "");
            ConfigEntry<KeyCode> cfg_targetinput_key = config.Bind(targetinputTitle, settings_targetinput_key, targetinput_key, "");
            ConfigEntry<int> cfg_targetinput_scale = config.Bind(targetinputTitle, settings_targetinput_scale, targetinput_scale, "");
            ConfigEntry<int> cfg_targetinput_shift_x = config.Bind(targetinputTitle, settings_targetinput_shift_x, targetinput_shift_x, "");
            ConfigEntry<int> cfg_targetinput_shift_y = config.Bind(targetinputTitle, settings_targetinput_shift_y, targetinput_shift_y, "");

            cfg.SettingChanged += Cfg_SettingsChanged;
            ForceReload();
        }

        private static void Cfg_SettingsChanged(object sender, SettingChangedEventArgs e)
        {
            try
            {
                target_visible = (bool)config[targetTitle, settings_target_visible].BoxedValue;
                target_toggleable = (bool)config[targetTitle, settings_target_toggleable].BoxedValue;
                target_key = (KeyCode)config[targetTitle, settings_target_key].BoxedValue;
                target_scale = (int)config[targetTitle, settings_target_scale].BoxedValue;
                target_shift_x = (int)config[targetTitle, settings_target_shift_x].BoxedValue;
                target_shift_y = (int)config[targetTitle, settings_target_shift_y].BoxedValue;

                mode_visible = (bool)config[modeTitle, settings_mode_visible].BoxedValue;
                mode_toggleable = (bool)config[modeTitle, settings_mode_toggleable].BoxedValue;
                mode_key = (KeyCode)config[modeTitle, settings_mode_key].BoxedValue;
                mode_scale = (int)config[modeTitle, settings_mode_scale].BoxedValue;
                mode_shift_x = (int)config[modeTitle, settings_mode_shift_x].BoxedValue;
                mode_shift_y = (int)config[modeTitle, settings_mode_shift_y].BoxedValue;

                fov_visible = (bool)config[fovTitle, settings_fov_visible].BoxedValue;
                fov_toggleable = (bool)config[fovTitle, settings_fov_toggleable].BoxedValue;
                fov_key = (KeyCode)config[fovTitle, settings_fov_key].BoxedValue;
                fov_scale = (int)config[fovTitle, settings_fov_scale].BoxedValue;
                fov_shift_x = (int)config[fovTitle, settings_fov_shift_x].BoxedValue;
                fov_shift_y = (int)config[fovTitle, settings_fov_shift_y].BoxedValue;

                level_visible = (bool)config[levelTitle, settings_level_visible].BoxedValue;
                level_toggleable = (bool)config[levelTitle, settings_level_toggleable].BoxedValue;
                level_key = (KeyCode)config[levelTitle, settings_level_key].BoxedValue;
                level_scale = (int)config[levelTitle, settings_level_scale].BoxedValue;
                level_shift_x = (int)config[levelTitle, settings_level_shift_x].BoxedValue;
                level_shift_y = (int)config[levelTitle, settings_level_shift_y].BoxedValue;

                timeleft_visible = (bool)config[timeleftTitle, settings_timeleft_visible].BoxedValue;
                timeleft_toggleable = (bool)config[timeleftTitle, settings_timeleft_toggleable].BoxedValue;
                timeleft_key = (KeyCode)config[timeleftTitle, settings_timeleft_key].BoxedValue;
                timeleft_scale = (int)config[timeleftTitle, settings_timeleft_scale].BoxedValue;
                timeleft_shift_x = (int)config[timeleftTitle, settings_timeleft_shift_x].BoxedValue;
                timeleft_shift_y = (int)config[timeleftTitle, settings_timeleft_shift_y].BoxedValue;

                tooltips_visible = (bool)config[tooltipsTitle, settings_tooltips_visible].BoxedValue;
                tooltips_toggleable = (bool)config[tooltipsTitle, settings_tooltips_toggleable].BoxedValue;
                tooltips_key = (KeyCode)config[tooltipsTitle, settings_tooltips_key].BoxedValue;
                tooltips_scale = (int)config[tooltipsTitle, settings_tooltips_scale].BoxedValue;
                tooltips_shift_x = (int)config[tooltipsTitle, settings_tooltips_shift_x].BoxedValue;
                tooltips_shift_y = (int)config[tooltipsTitle, settings_tooltips_shift_y].BoxedValue;

                targetspeed_visible = (bool)config[targetspeedTitle, settings_targetspeed_visible].BoxedValue;
                targetspeed_toggleable = (bool)config[targetspeedTitle, settings_targetspeed_toggleable].BoxedValue;
                targetspeed_key = (KeyCode)config[targetspeedTitle, settings_targetspeed_key].BoxedValue;
                targetspeed_scale = (int)config[targetspeedTitle, settings_targetspeed_scale].BoxedValue;
                targetspeed_shift_x = (int)config[targetspeedTitle, settings_targetspeed_shift_x].BoxedValue;
                targetspeed_shift_y = (int)config[targetspeedTitle, settings_targetspeed_shift_y].BoxedValue;

                targetinput_visible = (bool)config[targetinputTitle, settings_targetinput_visible].BoxedValue;
                targetinput_toggleable = (bool)config[targetinputTitle, settings_targetinput_toggleable].BoxedValue;
                targetinput_key = (KeyCode)config[targetinputTitle, settings_targetinput_key].BoxedValue;
                targetinput_scale = (int)config[targetinputTitle, settings_targetinput_scale].BoxedValue;
                targetinput_shift_x = (int)config[targetinputTitle, settings_targetinput_shift_x].BoxedValue;
                targetinput_shift_y = (int)config[targetinputTitle, settings_targetinput_shift_y].BoxedValue;

                PhotomodManager.ConfigChanged();
            }
            catch
            {

            }
        }

        private static string CreateConfigLabel(int index, string label)
        {
            string formattedIndex = index < 10 ? $"0{index}" : index.ToString();
            return ($"{formattedIndex}. {label}").PadRight(configLabelLength) + "|";
        }
    }
}
