namespace HCGames.ObserverSystem
{ 
    public static class ObserverEvent
    {
        public static readonly string RewardedAvailabilityChanged = "RewardedAvailabilityChanged";
        public static readonly string ToggleInputBlock = "ToggleInputBlock";
        public static readonly string ToggleGameplayInputBlock = "ToggleGameplayInputBlock";
        public static readonly string OnPowerChangeNotification = "OnPowerChangeNotification";
        public static readonly string ResetGameplayInputBlock = "ResetGameplayInputBlock";
        
        public static class UI
        {
            public static readonly string OnPopupOpen = "UI_OnPopupOpen";
            public static readonly string OnToggleIapPopup = "UI_OnToggleIapPopup";
            public static readonly string OnPlayPressed = "UI_OnPlayPressed";
            public static readonly string OnTrialPressed = "UI_OnTrialPressed";
            public static readonly string OnOpenPopupCountChanged = "UI_OnOpenPopupCountChanged";        
            public static readonly string OnToast = "UI_OnToast";
            public static readonly string OnOpenSummonPopup = "UI_OnOpenSummonPopup";
            public static readonly string OnOpenTalentPopup = "UI_OnOpenTalentPopup";
            public static readonly string OnOpenItemPopup = "UI_OnOpenItemPopup";
            public static readonly string OnCloseAllPopups = "UI_OnCloseAllPopups";
            public static readonly string OnOpenItemSlot = "UI_OnOpenItemSlot";
            public static readonly string OnAnimatePlayButton = "UI_OnAnimatePlayButton";
            public static readonly string OnFullscreenPopupOpen = "UI_OnFullscreenPopupOpen";
            public static readonly string OnFullscreenPopupClose = "UI_OnFullscreenPopupClose";
        }

        public static class OnMetaStateBegin
        {
            public static readonly string Preload = "OnMetaStateBegin_Preload";
            public static readonly string LoadingMainScene = "OnMetaStateBegin_LoadingMainScene";
            public static readonly string FadingOutFromLoadingScene = "OnMetaStateBegin_FadingOutFromLoadingScene";
            public static readonly string UnloadingLoadingScene = "OnMetaStateBegin_UnloadingLoadingScene";
            public static readonly string FadingInToMainMenu = "OnMetaStateBegin_FadingInToMainMenu";
            public static readonly string MainMenu = "OnMetaStateBegin_MainMenu";
            public static readonly string Gameplay = "OnMetaStateBegin_Gameplay";

        }

        public static class OnMetaStateEnd
        {
            public static readonly string Preload = "OnMetaStateEnd_Preload";
            public static readonly string LoadingMainScene = "OnMetaStateEnd_LoadingMainScene";
            public static readonly string FadingOutFromLoadingScene = "OnMetaStateEnd_FadingOutFromLoadingScene";
            public static readonly string UnloadingLoadingScene = "OnMetaStateEnd_UnloadingLoadingScene";
            public static readonly string FadingInToMainMenu = "OnMetaStateEnd_FadingInToMainMenu";
            public static readonly string MainMenu = "OnMetaStateEnd_MainMenu";
            public static readonly string Gameplay = "OnMetaStateEnd_Gameplay";

        }

        public static class OnEconomy
        {
            public static readonly string BalanceChanged = "OnEconomy_BalanceChanged";
            public static readonly string BalanceGained = "OnEconomy_BalanceGained";
            public static readonly string BalanceSpent = "OnEconomy_BalanceSpent";
            public static readonly string RewardsGained = "OnEconomy_RewardsGained";
            public static readonly string BalanceNotEnough = "OnEconomy_BalanceNotEnough";
        }

        public static class Gameplay
        {
            public static readonly string OnPortalHpChanged = "Gameplay_PortalHpChanged";
            public static readonly string OnPortalStaggerChanged = "Gameplay_OnPortalStaggerChanged";
            public static readonly string OnPortalDestroyed = "Gameplay_OnPortalDestroyed";
            public static readonly string OnEnemyDeath = "Gameplay_OnEnemyDeath";
            public static readonly string OnPlayWillHitEnemy = "Gameplay_OnPlayWillHitEnemy";
            public static readonly string OnRuneHit = "Gameplay_OnRuneHit";
            public static readonly string OnGameStateChanged = "Gameplay_OnGameStateChanged";
            public static readonly string OnSkillInitialized = "Gameplay_OnSkillInitialized";
            public static readonly string OnSkillFillChanged = "Gameplay_OnSkillFillChanged";
            public static readonly string OnSkillActivated = "Gameplay_OnSkillActivated";
            public static readonly string OnSkillDeactivated = "Gameplay_OnSkillDeactivated";
            public static readonly string OnSkillHit = "Gameplay_OnSkillHit";
            public static readonly string OnPlayerStateChanged = "Gameplay_OnPlayerStateChanged";
            public static readonly string OnGameOverUI = "Gameplay_OnGameOver";
            public static readonly string OnGameplayType = "Gameplay_OnGameplayType";
            public static readonly string OnEnemyJumped = "Gameplay_OnEnemyJumped";
            public static readonly string OnBossHit = "Gameplay_OnBossHit";
            public static readonly string OnBossWin = "Gameplay_OnBossWin";
            public static readonly string OnPortalHit = "Gameplay_OnPortalHit";
            public static readonly string OnRevivePopup = "Gameplay_OnRevivePopup";
            public static readonly string OnRevive = "Gameplay_OnRevive";
            public static readonly string OnPlayerRecovered = "Gameplay_OnPlayerRecovered";
            public static readonly string OnHitMarked = "Gameplay_OnHitMarked";
            public static readonly string OnClearInputQueue = "Gameplay_OnClearInputQueue";
            public static readonly string OnWaitPlayer = "Gameplay_OnWaitPlayer";
            public static readonly string OnGiveUp = "Gameplay_OnGiveUp";
            public static readonly string OnStaggerFill = "Gameplay_OnStaggerFill";
            public static readonly string OnPortalStaggered = "Gameplay_OnPortalStaggered";
            public static readonly string OnPlayerCheatDeath = "Gameplay_OnPlayerCheatDeath";
            public static readonly string OnDealDamage = "Gameplay_OnDealDamage";
            public static readonly string OnSkillUIDestroyed = "Gameplay_OnSkillUIDestroyed";
            public static readonly string OnDamageContextPosition = "Gameplay_OnDamageContextPosition";
            public static readonly string OnTutorialPopup = "Gameplay_OnTutorialPopup";
            public static readonly string OnTutorialPopupClose = "Gameplay_OnTutorialPopupClose";
        }

        public static class Item
        {
            public static readonly string OnItemEquipped = "Item_OnItemEquipped";
            public static readonly string OnWeaponChanged = "Item_OnWeaponChanged";
            public static readonly string OnItemChanged = "Item_OnItemChanged";
            public static readonly string OnItemUpgraded = "Item_OnItemUpgraded";
            public static readonly string OnItemInfo = "Item_OnItemInfo";
            public static readonly string OnItemGained = "Item_OnItemGained";
            public static readonly string OnItemInfoClosed = "Item_OnItemInfoClosed";
        }

        public static class OnObjectiveProgress
        {
            public static readonly string Journey = "OnObjectiveProgress_Journey";
        }

        public static class Sound
        {
            public static readonly string OnToggleSound = "Sound_OnToggleSound";
            public static readonly string OnToggleMusic = "Sound_OnToggleMusic";
            public static readonly string OnPlaySound = "Sound_OnPlaySound";
            public static readonly string OnPlayGameplaySound = "Sound_OnPlayGameplaySound";
            public static readonly string OnPlayMusic = "Sound_OnPlayMusic";
            public static readonly string OnStopGameplayMusic = "Sound_OnStopGameplayMusic";
        }

        public static class OnSummon
        {
            public static readonly string WithAd = "OnSummon_WithAd";
        }

        public static class TimedAttempt
        {
            public static readonly string OnAttemptGained = "TimedAttempt_OnAttemptGained";
            public static readonly string OnAttemptSpend = "TimedAttempt_OnAttemptSpend";
            public static readonly string OnTimedAttemptAdSuccess = "TimedAttempt_OnTimedAttemptAdSuccess";
        }
    }
}