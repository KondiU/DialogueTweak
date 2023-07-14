﻿using System;
using System.Collections.Generic;
using DialogueTweak.CrossModHelper;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DialogueTweak;

public partial class DialogueTweak : Mod
{
    internal static DialogueTweak Instance;

    public override void Load() {
        Instance = this;
    }

    public override void Unload() {
        Instance = null;
        Configuration.Instance = null;
    }

    // Test code
    /*
    public override void PostSetupContent() {
	    DialogueTweakHelper.ReplaceButtonIcon(
		    DialogueTweakHelper.ReplacementType.Shop,
		    NPCID.Guide, // NPC ID
		    "Head"); // Then the NPC's head texture will be shown
		    
        DialogueTweakHelper.ReplaceButtonIcon(DialogueTweakHelper.ReplacementType.Extra, NPCID.GoblinTinkerer, () => "Terraria/Images/UI/Bestiary/Icon_Tags_Shadow", frame: () => {
            if (Main.LocalPlayer.direction == -1)
                return new Rectangle(0, 0, 80, 80);
            return new Rectangle(0, 0, 30, 30);
        }, customTextOffset: () => 80);
        DialogueTweakHelper.AddButton(
            NPCID.Angler,
            () => "Sandstorm (1 Gold)",
            () => "Terraria/Images/UI/Bestiary/Icon_Tags_Shadow",
            () => {
                if (Main.mouseLeft && Main.mouseLeftRelease)
                    Main.NewText("这是假的关闭按钮哦");
            },
            () => true,
            () => {
                if (Main.LocalPlayer.direction == -1)
                    return new Rectangle(0, 0, 22, 22);
                return new Rectangle(10, 10, 11, 11);
            },
            () => {
                return 44;
            });
    }
    */
}
public static class ModAsset
{
	private static AssetRepository _repo;
	static ModAsset()
	{
		_repo = ModLoader.GetMod("DialogueTweak").Assets;
	}
	public const string how_icon_is_alignedPath = @"CrossModHelper/how_icon_is_aligned";
	public static Asset<Texture2D> how_icon_is_aligned => _repo.Request<Texture2D>(how_icon_is_alignedPath, AssetRequestMode.ImmediateLoad);
	public const string how_offset_worksPath = @"CrossModHelper/how_offset_works";
	public static Asset<Texture2D> how_offset_works => _repo.Request<Texture2D>(how_offset_worksPath, AssetRequestMode.ImmediateLoad);
	public const string icon_workshopPath = @"icon_workshop";
	public static Asset<Texture2D> icon_workshop => _repo.Request<Texture2D>(icon_workshopPath, AssetRequestMode.ImmediateLoad);
	public const string ButtonSeperatorPath = @"Interfaces/Assets/ButtonSeperator";
	public static Asset<Texture2D> ButtonSeperator => _repo.Request<Texture2D>(ButtonSeperatorPath, AssetRequestMode.ImmediateLoad);
	public const string Button_BackPath = @"Interfaces/Assets/Button_Back";
	public static Asset<Texture2D> Button_Back => _repo.Request<Texture2D>(Button_BackPath, AssetRequestMode.ImmediateLoad);
	public const string Button_HappinessPath = @"Interfaces/Assets/Button_Happiness";
	public static Asset<Texture2D> Button_Happiness => _repo.Request<Texture2D>(Button_HappinessPath, AssetRequestMode.ImmediateLoad);
	public const string Icon_DefaultPath = @"Interfaces/Assets/Icon_Default";
	public static Asset<Texture2D> Icon_Default => _repo.Request<Texture2D>(Icon_DefaultPath, AssetRequestMode.ImmediateLoad);
	public const string Icon_EditPath = @"Interfaces/Assets/Icon_Edit";
	public static Asset<Texture2D> Icon_Edit => _repo.Request<Texture2D>(Icon_EditPath, AssetRequestMode.ImmediateLoad);
	public const string Icon_HammerPath = @"Interfaces/Assets/Icon_Hammer";
	public static Asset<Texture2D> Icon_Hammer => _repo.Request<Texture2D>(Icon_HammerPath, AssetRequestMode.ImmediateLoad);
	public const string Icon_HelpPath = @"Interfaces/Assets/Icon_Help";
	public static Asset<Texture2D> Icon_Help => _repo.Request<Texture2D>(Icon_HelpPath, AssetRequestMode.ImmediateLoad);
	public const string Icon_Old_ManPath = @"Interfaces/Assets/Icon_Old_Man";
	public static Asset<Texture2D> Icon_Old_Man => _repo.Request<Texture2D>(Icon_Old_ManPath, AssetRequestMode.ImmediateLoad);
	public const string PortraitPanel_FrontPath = @"Interfaces/Assets/PortraitPanel_Front";
	public static Asset<Texture2D> PortraitPanel_Front => _repo.Request<Texture2D>(PortraitPanel_FrontPath, AssetRequestMode.ImmediateLoad);
	public const string PortraitPanel_OverlayPath = @"Interfaces/Assets/PortraitPanel_Overlay";
	public static Asset<Texture2D> PortraitPanel_Overlay => _repo.Request<Texture2D>(PortraitPanel_OverlayPath, AssetRequestMode.ImmediateLoad);
	public const string de_DE_Mods_DialogueTweakPath = @"Localization\de-DE_Mods.DialogueTweak.hjson";
	public const string en_US_Mods_DialogueTweakPath = @"Localization\en-US_Mods.DialogueTweak.hjson";
	public const string es_ES_Mods_DialogueTweakPath = @"Localization\es-ES_Mods.DialogueTweak.hjson";
	public const string fr_FR_Mods_DialogueTweakPath = @"Localization\fr-FR_Mods.DialogueTweak.hjson";
	public const string it_IT_Mods_DialogueTweakPath = @"Localization\it-IT_Mods.DialogueTweak.hjson";
	public const string pl_PL_Mods_DialogueTweakPath = @"Localization\pl-PL_Mods.DialogueTweak.hjson";
	public const string pt_BR_Mods_DialogueTweakPath = @"Localization\pt-BR_Mods.DialogueTweak.hjson";
	public const string ru_RU_Mods_DialogueTweakPath = @"Localization\ru-RU_Mods.DialogueTweak.hjson";
	public const string zh_Hans_Mods_DialogueTweakPath = @"Localization\zh-Hans_Mods.DialogueTweak.hjson";
	public const string description_workshopPath = @"description_workshop.txt";
	public const string LICENSEPath = @"LICENSE.txt";
	public const string iconPath = @"icon";
	public static Asset<Texture2D> icon => _repo.Request<Texture2D>(iconPath, AssetRequestMode.ImmediateLoad);

}