// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Latest_UE4_AlchemistTarget : TargetRules
{
	public Latest_UE4_AlchemistTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Latest_UE4_Alchemist");
	}
}
