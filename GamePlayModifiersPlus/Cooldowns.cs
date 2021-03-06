﻿namespace GamePlayModifiersPlus
{
    public class Cooldowns
    {
        public static bool globalCoolDown;
        public static bool speedCoolDown;
        public static bool healthCoolDown;
        public static bool daCoolDown;
        public static bool normalSizeCoolDown;
        public static bool randomCoolDown;
        public static bool noArrowsCooldown;
        public static bool njsRandomCoolDown;
        public static bool funkyCoolDown;
        public static bool rainbowCoolDown;
        public static bool bombCoolDown;

        public void SetCooldown(bool state, string cooldown)
        {
            cooldown = cooldown.ToLower();
            switch (cooldown)
            {
                case "global":
                    globalCoolDown = state;
                    break;
                case "speed":
                    speedCoolDown = state;
                    break;
                case "health":
                    healthCoolDown = state;
                    break;
                case "da":
                    daCoolDown = state;
                    break;
                case "normalsize":
                    normalSizeCoolDown = state;
                    break;
                case "random":
                    randomCoolDown = state;
                    break;
                case "noarrows":
                    noArrowsCooldown = state;
                    break;
                case "njsrandom":
                    njsRandomCoolDown = state;
                    break;
                case "funky":
                    funkyCoolDown = state;
                    break;
                case "rainbow":
                    rainbowCoolDown = state;
                    break;
                case "bombs":
                    bombCoolDown = state;
                    break;
                default:
                    break;
            }
        }

        public bool GetCooldown(string cooldown)
        {
            cooldown = cooldown.ToLower();
            switch (cooldown)
            {
                case "global":
                    return globalCoolDown;
                case "speed":
                    return speedCoolDown;
                case "health":
                    return healthCoolDown;
                case "da":
                    return daCoolDown;
                case "normalsize":
                    return normalSizeCoolDown;
                case "random":
                    return randomCoolDown;
                case "noarrows":
                    return noArrowsCooldown;
                case "njsrandom":
                    return njsRandomCoolDown;
                case "funky":
                    return funkyCoolDown;
                case "rainbow":
                    return rainbowCoolDown;
                case "bombs":
                    return bombCoolDown;
                default:
                    return false;
            }
        }

        public void ResetCooldowns()
        {
            globalCoolDown = false;
            speedCoolDown = false;
            healthCoolDown = false;
            normalSizeCoolDown = false;
            daCoolDown = false;
            njsRandomCoolDown = false;
            rainbowCoolDown = false;
            randomCoolDown = false;
            noArrowsCooldown = false;
            funkyCoolDown = false;
            bombCoolDown = false;
        }
    }
}
