﻿using RaidCrawler.Properties;

namespace RaidCrawler.Subforms
{
    public partial class ConfigWindow : Form
    {
        public ConfigWindow()
        {
            InitializeComponent();

            PlayTone.Checked = Settings.Default.CfgPlaySound;
            FocusWindow.Checked = Settings.Default.CfgFocusWindow;
            EnableAlert.Checked = Settings.Default.CfgEnableAlertWindow;
            AlertMessage.Text = Settings.Default.CfgAlertWindowMessage;
            AlertMessage.Enabled = EnableAlert.Checked;

            BaseDelay.Value = Settings.Default.CfgBaseDelay;
            OpenHome.Value = Settings.Default.CfgOpenHome;
            NavigateToSettings.Value = Settings.Default.CfgNavigateToSettings;
            OpenSettings.Value = Settings.Default.CfgOpenSettings;
            Hold.Value = Settings.Default.CfgHold;
            SystemDDownPresses.Value = Settings.Default.CfgSystemDDownPresses;
            Submenu.Value = Settings.Default.CfgSubmenu;
            DateChange.Value = Settings.Default.CfgDateChange;
            DaysToSkip.Value = Settings.Default.CfgDaysToSkip;
            ReturnHome.Value = Settings.Default.CfgReturnHome;
            ReturnGame.Value = Settings.Default.CfgReturnGame;
        }

        private void EnableAlert_CheckedChanged(object sender, EventArgs e)
        {
            AlertMessage.Enabled = EnableAlert.Checked;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Settings.Default.CfgPlaySound = PlayTone.Checked;
            Settings.Default.CfgFocusWindow = FocusWindow.Checked;
            Settings.Default.CfgEnableAlertWindow = EnableAlert.Checked;
            Settings.Default.CfgAlertWindowMessage = AlertMessage.Text;

            Settings.Default.CfgBaseDelay = BaseDelay.Value;
            Settings.Default.CfgOpenHome = OpenHome.Value;
            Settings.Default.CfgNavigateToSettings = NavigateToSettings.Value;
            Settings.Default.CfgOpenSettings = OpenSettings.Value;
            Settings.Default.CfgHold = Hold.Value;
            Settings.Default.CfgSystemDDownPresses = SystemDDownPresses.Value;
            Settings.Default.CfgSubmenu = Submenu.Value;
            Settings.Default.CfgDateChange = DateChange.Value;
            Settings.Default.CfgDaysToSkip = DaysToSkip.Value;
            Settings.Default.CfgReturnHome = ReturnHome.Value;
            Settings.Default.CfgReturnGame = ReturnGame.Value;

            Settings.Default.Save();

            Close();
        }
    }
}
