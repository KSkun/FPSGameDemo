// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPSGameDemo : ModuleRules
{
	public FPSGameDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
