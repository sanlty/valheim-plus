﻿namespace ValheimPlus.Configurations.Sections
{
    public class StaminaConfiguration : ServerSyncConfig <StaminaConfiguration>
    {
        public float dodgeStaminaUsage { get; internal set; } = 0;
        public float encumberedStaminaDrain { get; internal set; } = 0;
        public float jumpStaminaDrain { get; internal set; } = 0;
        public float runStaminaDrain { get; internal set; } = 0;
        public float sneakStaminaDrain { get; internal set; } = 0;
        public float staminaRegen { get; internal set; } = 0;
        public float staminaRegenDelay { get; internal set; } = 0;
        public float swimStaminaDrain { get; internal set; } = 0;
    }
}
