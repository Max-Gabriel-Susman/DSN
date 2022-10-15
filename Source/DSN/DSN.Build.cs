// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DSN : ModuleRules
{
	public DSN(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
