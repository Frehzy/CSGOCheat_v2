using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enFrenzyHack.Helper
{
    class OffsetsUpdater
    {
        public static string path = Application.StartupPath + $"/csgo.cs";

        #region Запуск hazedumper и чистка от лишних символов
        public static void GetOffsets()
        {
            //удаляем прошлый csgo.cs
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            //запуск программы
            string file = Application.StartupPath + "/hazedumper.exe";
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = file;
            start.WindowStyle = ProcessWindowStyle.Hidden;
            var process = Process.Start(start);
            process.WaitForExit();

            //проверка, запущена кс или нет
            bool is_okay = false;
            string log = Application.StartupPath + "/hazedumper.log";
            if (File.Exists(log))
            {
                string line;
                string csgo_is_open = "Could not open process csgo.exe!";
                using (FileStream f = new FileStream(log, FileMode.Open))
                using (StreamReader sr = new StreamReader(f, Encoding.Default))
                    while ((line = sr.ReadLine()) != null)
                        if (line.Contains(csgo_is_open))
                        {
                            is_okay = true;
                        }
            }

            //провоерка, запущена кс или нет
            if (is_okay == true)
            {
                File.Delete(log);
                if (File.Exists(path))
                    File.Delete(path);
                MessageBox.Show("Could not find the game process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Process[] listprosecc = Process.GetProcesses();
                try
                {
                    foreach (Process proc in Process.GetProcessesByName(Variable.CheatName))
                        proc.Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //обработка полученного файла
            string[] file_data = File.ReadAllLines(path);
            var temp_str = new List<string>();
            foreach (var line in file_data)
            {
                if (line.Contains("timestamp"))
                    continue;

                if (line.Contains("Int32"))
                    temp_str.Add(line.Substring(8, line.Length - 8));
            }
            File.WriteAllLines(path, temp_str.ToArray());
        }
        #endregion

        #region Берём оффсеты из скачанного файла, обрабатываем и передаём в метод Update()
        public static Int32 PutOffsets(string GlobalOffset)
        {
            try
            {
                string offset = GlobalOffset + " ="; //оффсет, который нужно обновить
                string text = File.ReadAllText(path, Encoding.Default); //файл, из которого берём оффсеты
                text = text.Substring(text.IndexOf(offset) + offset.Length);
                text = text.Remove(text.IndexOf("\r\n"));
                if (text.Contains(";")) text = text.Remove(text.IndexOf(";"));
                text = text.Replace(" ", "");
                int result = (int)new System.ComponentModel.Int32Converter().ConvertFromString(text);
                return result;
            }
            catch
            {
                //MessageBox.Show("Offset: " + GlobalOffset + " is not okay", "Error OffsetsUpdater", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0x00000000;
            }
        }
        #endregion

        #region Втыкивалка оффсетов в наши переменные из Offsets.cs
        public static void Update()
        {
            netvars.cs_gamerules_data = PutOffsets("cs_gamerules_data");
            netvars.m_ArmorValue = PutOffsets("m_ArmorValue");
            netvars.m_Collision = PutOffsets("m_Collision");
            netvars.m_CollisionGroup = PutOffsets("m_CollisionGroup");
            netvars.m_Local = PutOffsets("m_Local");
            netvars.m_MoveType = PutOffsets("m_MoveType");
            netvars.m_OriginalOwnerXuidHigh = PutOffsets("m_OriginalOwnerXuidHigh");
            netvars.m_OriginalOwnerXuidLow = PutOffsets("m_OriginalOwnerXuidLow");
            netvars.m_SurvivalGameRuleDecisionTypes = PutOffsets("m_SurvivalGameRuleDecisionTypes");
            netvars.m_SurvivalRules = PutOffsets("m_SurvivalRules");
            netvars.m_aimPunchAngle = PutOffsets("m_aimPunchAngle");
            netvars.m_aimPunchAngleVel = PutOffsets("m_aimPunchAngleVel");
            netvars.m_angEyeAnglesX = PutOffsets("m_angEyeAnglesX");
            netvars.m_angEyeAnglesY = PutOffsets("m_angEyeAnglesY");
            netvars.m_bBombPlanted = PutOffsets("m_bBombPlanted");
            netvars.m_bFreezePeriod = PutOffsets("m_bFreezePeriod");
            netvars.m_bGunGameImmunity = PutOffsets("m_bGunGameImmunity");
            netvars.m_bHasDefuser = PutOffsets("m_bHasDefuser");
            netvars.m_bHasHelmet = PutOffsets("m_bHasHelmet");
            netvars.m_bInReload = PutOffsets("m_bInReload");
            netvars.m_bIsDefusing = PutOffsets("m_bIsDefusing");
            netvars.m_bIsQueuedMatchmaking = PutOffsets("m_bIsQueuedMatchmaking");
            netvars.m_bIsScoped = PutOffsets("m_bIsScoped");
            netvars.m_bIsValveDS = PutOffsets("m_bIsValveDS");
            netvars.m_bSpotted = PutOffsets("m_bSpotted");
            netvars.m_bSpottedByMask = PutOffsets("m_bSpottedByMask");
            netvars.m_bStartedArming = PutOffsets("m_bStartedArming");
            netvars.m_clrRender = PutOffsets("m_clrRender");
            netvars.m_dwBoneMatrix = PutOffsets("m_dwBoneMatrix");
            netvars.m_fAccuracyPenalty = PutOffsets("m_fAccuracyPenalty");
            netvars.m_fFlags = PutOffsets("m_fFlags");
            netvars.m_flC4Blow = PutOffsets("m_flC4Blow");
            netvars.m_flDefuseCountDown = PutOffsets("m_flDefuseCountDown");
            netvars.m_flDefuseLength = PutOffsets("m_flDefuseLength");
            netvars.m_flFallbackWear = PutOffsets("m_flFallbackWear");
            netvars.m_flFlashDuration = PutOffsets("m_flFlashDuration");
            netvars.m_flFlashMaxAlpha = PutOffsets("m_flFlashMaxAlpha");
            netvars.m_flLastBoneSetupTime = PutOffsets("m_flLastBoneSetupTime");
            netvars.m_flLowerBodyYawTarget = PutOffsets("m_flLowerBodyYawTarget");
            netvars.m_flNextAttack = PutOffsets("m_flNextAttack");
            netvars.m_flNextPrimaryAttack = PutOffsets("m_flNextPrimaryAttack");
            netvars.m_flSimulationTime = PutOffsets("m_flSimulationTime");
            netvars.m_flTimerLength = PutOffsets("m_flTimerLength");
            netvars.m_hActiveWeapon = PutOffsets("m_hActiveWeapon");
            netvars.m_hMyWeapons = PutOffsets("m_hMyWeapons");
            netvars.m_hObserverTarget = PutOffsets("m_hObserverTarget");
            netvars.m_hOwner = PutOffsets("m_hOwner");
            netvars.m_hOwnerEntity = PutOffsets("m_hOwnerEntity");
            netvars.m_iAccountID = PutOffsets("m_iAccountID");
            netvars.m_iClip1 = PutOffsets("m_iClip1");
            netvars.m_iCompetitiveRanking = PutOffsets("m_iCompetitiveRanking");
            netvars.m_iCompetitiveWins = PutOffsets("m_iCompetitiveWins");
            netvars.m_iCrosshairId = PutOffsets("m_iCrosshairId");
            netvars.m_iEntityQuality = PutOffsets("m_iEntityQuality");
            netvars.m_iFOV = PutOffsets("m_iFOV");
            netvars.m_iFOVStart = PutOffsets("m_iFOVStart");
            netvars.m_iGlowIndex = PutOffsets("m_iGlowIndex");
            netvars.m_iHealth = PutOffsets("m_iHealth");
            netvars.m_iItemDefinitionIndex = PutOffsets("m_iItemDefinitionIndex");
            netvars.m_iItemIDHigh = PutOffsets("m_iItemIDHigh");
            netvars.m_iMostRecentModelBoneCounter = PutOffsets("m_iMostRecentModelBoneCounter");
            netvars.m_iObserverMode = PutOffsets("m_iObserverMode");
            netvars.m_iShotsFired = PutOffsets("m_iShotsFired");
            netvars.m_iState = PutOffsets("m_iState");
            netvars.m_iTeamNum = PutOffsets("m_iTeamNum");
            netvars.m_lifeState = PutOffsets("m_lifeState");
            netvars.m_nFallbackPaintKit = PutOffsets("m_nFallbackPaintKit");
            netvars.m_nFallbackSeed = PutOffsets("m_nFallbackSeed");
            netvars.m_nFallbackStatTrak = PutOffsets("m_nFallbackStatTrak");
            netvars.m_nForceBone = PutOffsets("m_nForceBone");
            netvars.m_nTickBase = PutOffsets("m_nTickBase");
            netvars.m_rgflCoordinateFrame = PutOffsets("m_rgflCoordinateFrame");
            netvars.m_szCustomName = PutOffsets("m_szCustomName");
            netvars.m_szLastPlaceName = PutOffsets("m_szLastPlaceName");
            netvars.m_thirdPersonViewAngles = PutOffsets("m_thirdPersonViewAngles");
            netvars.m_vecOrigin = PutOffsets("m_vecOrigin");
            netvars.m_vecVelocity = PutOffsets("m_vecVelocity");
            netvars.m_vecViewOffset = PutOffsets("m_vecViewOffset");
            netvars.m_viewPunchAngle = PutOffsets("m_viewPunchAngle");
            signatures.clientstate_choked_commands = PutOffsets("clientstate_choked_commands");
            signatures.clientstate_delta_ticks = PutOffsets("clientstate_delta_ticks");
            signatures.clientstate_last_outgoing_command = PutOffsets("clientstate_last_outgoing_command");
            signatures.clientstate_net_channel = PutOffsets("clientstate_net_channel");
            signatures.convar_name_hash_table = PutOffsets("convar_name_hash_table");
            signatures.dwClientState = PutOffsets("dwClientState");
            signatures.dwClientState_GetLocalPlayer = PutOffsets("dwClientState_GetLocalPlayer");
            signatures.dwClientState_IsHLTV = PutOffsets("dwClientState_IsHLTV");
            signatures.dwClientState_Map = PutOffsets("dwClientState_Map");
            signatures.dwClientState_MapDirectory = PutOffsets("dwClientState_MapDirectory");
            signatures.dwClientState_MaxPlayer = PutOffsets("dwClientState_MaxPlayer");
            signatures.dwClientState_PlayerInfo = PutOffsets("dwClientState_PlayerInfo");
            signatures.dwClientState_State = PutOffsets("dwClientState_State");
            signatures.dwClientState_ViewAngles = PutOffsets("dwClientState_ViewAngles");
            signatures.dwEntityList = PutOffsets("dwEntityList");
            signatures.dwForceAttack = PutOffsets("dwForceAttack");
            signatures.dwForceAttack2 = PutOffsets("dwForceAttack2");
            signatures.dwForceBackward = PutOffsets("dwForceBackward");
            signatures.dwForceForward = PutOffsets("dwForceForward");
            signatures.dwForceJump = PutOffsets("dwForceJump");
            signatures.dwForceLeft = PutOffsets("dwForceLeft");
            signatures.dwForceRight = PutOffsets("dwForceRight");
            signatures.dwGameDir = PutOffsets("dwGameDir");
            signatures.dwGetAllClasses = PutOffsets("dwGetAllClasses");
            signatures.dwGlobalVars = PutOffsets("dwGlobalVars");
            signatures.dwGlowObjectManager = PutOffsets("dwGlowObjectManager");
            signatures.dwInput = PutOffsets("dwInput");
            signatures.dwLocalPlayer = PutOffsets("dwLocalPlayer");
            signatures.dwMouseEnable = PutOffsets("dwMouseEnable");
            signatures.dwMouseEnablePtr = PutOffsets("dwMouseEnablePtr");
            signatures.dwPlayerResource = PutOffsets("dwPlayerResource");
            signatures.dwRadarBase = PutOffsets("dwRadarBase");
            signatures.dwSensitivity = PutOffsets("dwSensitivity");
            signatures.dwSensitivityPtr = PutOffsets("dwSensitivityPtr");
            signatures.dwSetClanTag = PutOffsets("dwSetClanTag");
            signatures.dwViewMatrix = PutOffsets("dwViewMatrix");
            signatures.dwWeaponTable = PutOffsets("dwWeaponTable");
            signatures.dwWeaponTableIndex = PutOffsets("dwWeaponTableIndex");
            signatures.dwYawPtr = PutOffsets("dwYawPtr");
            signatures.dwZoomSensitivityRatioPtr = PutOffsets("dwZoomSensitivityRatioPtr");
            signatures.dwbSendPackets = PutOffsets("dwbSendPackets");
            signatures.dwppDirect3DDevice9 = PutOffsets("dwppDirect3DDevice9");
            signatures.force_update_spectator_glow = PutOffsets("force_update_spectator_glow");
            signatures.interface_engine_cvar = PutOffsets("interface_engine_cvar");
            signatures.is_c4_owner = PutOffsets("is_c4_owner");
            signatures.m_bDormant = PutOffsets("m_bDormant");
            signatures.m_pStudioHdr = PutOffsets("m_pStudioHdr");
            signatures.m_pitchClassPtr = PutOffsets("m_pitchClassPtr");
            signatures.m_yawClassPtr = PutOffsets("m_yawClassPtr");
            signatures.model_ambient_min = PutOffsets("model_ambient_min");
            signatures.set_abs_angles = PutOffsets("set_abs_angles");
            signatures.set_abs_origin = PutOffsets("set_abs_origin");
        }
        #endregion

        #region Удаление файла с оффсетами, которые скачали
        public static void DeleteFile()
        {
            if (File.Exists(path))
                File.Delete(path);
            string log = System.Windows.Forms.Application.StartupPath + "/hazedumper.log";
            if (File.Exists(log))
                File.Delete(log);
            string csgo_hpp = System.Windows.Forms.Application.StartupPath + "/csgo.hpp";
            if (File.Exists(csgo_hpp))
                File.Delete(csgo_hpp);
            string csgo_json = System.Windows.Forms.Application.StartupPath + "/csgo.json";
            if (File.Exists(csgo_json))
                File.Delete(csgo_json);
            string csgo_min_json = System.Windows.Forms.Application.StartupPath + "/csgo.min.json";
            if (File.Exists(csgo_min_json))
                File.Delete(csgo_min_json);
            string csgo_toml = System.Windows.Forms.Application.StartupPath + "/csgo.toml";
            if (File.Exists(csgo_toml))
                File.Delete(csgo_toml);
            string csgo_vb = System.Windows.Forms.Application.StartupPath + "/csgo.vb";
            if (File.Exists(csgo_vb))
                File.Delete(csgo_vb);
            string csgo_yaml = System.Windows.Forms.Application.StartupPath + "/csgo.yaml";
            if (File.Exists(csgo_yaml))
                File.Delete(csgo_yaml);
        }
        #endregion

    }
}
