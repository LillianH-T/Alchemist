// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Latest_UE4_AlchemistEditorTarget : TargetRules
{
	public Latest_UE4_AlchemistEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Latest_UE4_Alchemist");
	}
}
