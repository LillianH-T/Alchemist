// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Latest_UE4_Alchemist : ModuleRules
{
	public Latest_UE4_Alchemist(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
