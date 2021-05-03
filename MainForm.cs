using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

using System.Windows.Forms;
using Config.Utils;

namespace Config
{
    public partial class MainForm : Form
    {
        private readonly ConfigFile _conf;

        private bool _ready;

        public MainForm()
        {
            InitializeComponent();
    
            // Load Configurations
            _conf = new ConfigFile(Path.Combine(Environment.CurrentDirectory, "metin2.cfg"));
        }


        private void Form1Load(object sender, EventArgs e)
        {



            Icon = Properties.Resources.metin2;
            // Resolution
            List<Resolution> resolutions = Win32.EnumAvailableResolutions();
    
            var res = _conf.GetResolution();

            if (!resolutions.Contains(res))
                resolutions.Add(res);
            comboResolution.DataSource = resolutions;
            comboResolution.SelectedItem = res;
#if !DEBUG
            try
            {
#endif
                // HFR
                checkHFR.Checked = _conf.Read("HFR_MODE", false);
                // Fullscreen
                checkWindowed.Checked = _conf.Read( "WINDOWED", true);
                // Antialiasing
                Utils.Utils.SafeSetIndex(comboAntialias, _conf.Read("ANTIALIAS_LEVEL", 0));

            // Fog
            Utils.Utils.SafeSetIndex(comboFog, _conf.Read("VISIBILITY", 3) - 1);


            // Shadows
            Utils.Utils.SafeSetIndex(comboShadows, _conf.Read("SHADOW_LEVEL", 3));
       
            // Tiling
            Utils.Utils.SafeSetIndex(comboTNL, _conf.Read("SOFTWARE_TILING", 0) );

                // Music volume
                trackMusic.Value = (int) (_conf.Read("MUSIC_VOLUME", 1.0f)*100);
                // SFX Volume
                trackSFX.Value = _conf.Read("VOICE_VOLUME", 5);
                // Always ShowName
                checkShowname.Checked = _conf.Read("ALWAYS_VIEW_NAME", false);
                // Show damage
                checkShowDmg.Checked = _conf.Read("SHOW_DAMAGE", true);
                // View Chat
                checkShowChat.Checked = _conf.Read("VIEW_CHAT", true);
                // Show salestext
                checkShowshopnames.Checked = _conf.Read("SHOW_SALESTEXT", true);
                // Decompressed DDS
                checkDecompresstexture.Checked = _conf.Read("DECOMPRESSED_TEXTURE", true);
                // ExternalIME
                checkDefaultIME.Checked = _conf.Read("USE_DEFAULT_IME", true);
                // SoftwareCursor
                checkSoftwarecursor.Checked = _conf.Read("SOFTWARE_CURSOR", false);
                // Mute
                checkMute.Checked = _conf.Read("NO_SOUND_CARD", false);
                // Object Culling
                checkObjectCulling.Checked = _conf.Read("OBJECT_CULLING", false);
            // BPP
            Utils.Utils.SafeSetIndex(checkBpp, _conf.Read("BPP", 32) == 16 ? 0 : 1);

                // Snow 
                checkSnow.Checked = _conf.Read("XMAS_SNOW", true);
                // DLC
                checkDaylight.Checked = _conf.Read("DAY_CYCLE", true);
                // Light
                checkLightMode.Checked = _conf.Read("LIGHT_MODE", false);

                checkFastText.Checked = _conf.Read("FAST_FONT", false);

                checkDisableLod.Checked = _conf.Read("DISABLE_LOD", false);

            checkDiscord.Checked = _conf.Read("DISCORD_INTEGRATION", true);

                Utils.Utils.SafeSetIndex(comboReShade, _conf.Read("RESHADE_LEVEL", 0));
#if !DEBUG
            }
            catch (Exception ex)
            {
                if (
                    MessageBox.Show("Looks like the configuration file is corrupted. Do you want to delete it?", "Error",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Reopen the configuration.");
                    File.Delete("metin2.cfg");
                    Environment.Exit(0);
                }
            }
#endif

            _ready = true;
        }

        private void ComboResolutionSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.SetResolution((Resolution) comboResolution.SelectedItem);
        }

        private void ComboAntialiasSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ready) 
            _conf.Write("ANTIALIAS_LEVEL", comboAntialias.SelectedIndex);
        }

        private void ComboFogSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("VISIBILITY", comboFog.SelectedIndex+1);
        }

        private void ComboShadowsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("SHADOW_LEVEL", comboShadows.SelectedIndex );
        }

        private void TrackSfxScroll(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("VOICE_VOLUME", trackSFX.Value);
        }

        private void TrackMusicScroll(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("MUSIC_VOLUME", (float)trackMusic.Value / (float)100);
        }

        private void CheckFullscreenCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("WINDOWED", checkWindowed.Checked);
        }

        private void CheckShownameCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("ALWAYS_VIEW_NAME", checkShowname.Checked);
        }

        private void CheckShowDmgCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("SHOW_DAMAGE", checkShowDmg.Checked);
        }

        private void CheckShowChatCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("VIEW_CHAT", checkShowChat.Checked);
        }

        private void CheckShowshopnamesCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("SHOW_SALESTEXT", checkShowshopnames.Checked);
        }

        private void ComboTnlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("SOFTWARE_TILING", comboTNL.SelectedIndex);
        }

        private void CheckExternalImeCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("USE_DEFAULT_IME", checkDefaultIME.Checked);
        }

        private void CheckSoftwarecursorCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("SOFTWARE_CURSOR", checkSoftwarecursor.Checked);
        }

        private void CheckDecompresstextureCheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("DECOMPRESSED_TEXTURE", checkDecompresstexture.Checked);

        }



        private void checkMute_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("NO_SOUND_CARD", checkMute.Checked);
        }

        private void checkObjectCulling_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("OBJECT_CULLING", checkObjectCulling.Checked);
        }

        private void checkBpp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write( "BPP", checkBpp.SelectedIndex == 0 ? 16: 32);
        }


    

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _conf.Save();
        }








        private void checkSnow_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("XMAS_SNOW", checkSnow.Checked);
        }

        private void checkDaylight_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("DAY_CYCLE", checkDaylight.Checked);
        }

        private void checkHFR_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("HFR_MODE", checkHFR.Checked);
        }

        private void labelTNL_Click(object sender, EventArgs e)
        {

        }

        private void checkLightMode_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("LIGHT_MODE", checkLightMode.Checked);
        }

        private void checkFastText_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("FAST_FONT", checkFastText.Checked);
        }

        private void checkDisableLod_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("DISABLE_LOD", checkDisableLod.Checked);
        }
        private void checkDiscord_CheckedChanged(object sender, EventArgs e)
        {
            if (_ready)
                _conf.Write("DISCORD_INTEGRATION", checkDiscord.Checked);

        }


        string[] ReShadePresetNames =
        {
            "",
            "reshade-presets/Low.ini",
            "reshade-presets/Mid.ini",
            "reshade-presets/Extreme.ini",
        };

        bool IsReshadeEnabled()
        {
            return File.Exists("d3d9.dll") && File.Exists("ReShade.ini");
        }

        void EnableReshade()
        {
            if(File.Exists("_d3d9.dll"))
                File.Copy("_d3d9.dll", "d3d9.dll");
            if (File.Exists("_ReShade.ini"))
                File.Copy("_ReShade.ini", "ReShade.ini");

        }
        bool DisableReshade()
        {
            try
            {
                if (File.Exists("d3d9.dll"))
                    File.Delete("d3d9.dll");
                if (File.Exists("ReShade.ini"))
                    File.Delete("ReShade.ini");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Failed to disable ReShade. If the client is running, please close it.");
                return false;
            }
            return true;
        }


        private void comboReShade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_ready)
            {



                _conf.Write("RESHADE_LEVEL", comboReShade.SelectedIndex);
                switch (comboReShade.SelectedIndex)
                {
                    case 1: // Low
                    case 2: // Mid
                    case 3: // Extreme
                        if(!IsReshadeEnabled())
                        {
                            if(MessageBox.Show("WARNING! ReShade will decrease your game performance.\nOnly enable it on modern PCs. Do you want to proceed?", "ReShade Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)
                            {
                                comboReShade.SelectedIndex = 0;
                                return;
                            }
                            EnableReshade();
                        }
                        if (File.Exists("Preset.ini"))
                            File.Delete("Preset.ini");
                        File.Copy(ReShadePresetNames[comboReShade.SelectedIndex], "Preset.ini");



                        break;
                    default:
                        DisableReshade();
                       
                        break;
                }


            }
        }


    }
}
