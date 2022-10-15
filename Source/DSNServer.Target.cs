// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class DSNServerTarget : TargetRules //Change this line according to the name of your project
{
    public DSNServerTarget(TargetInfo Target) : base(Target) //Change this line according to the name of your project
    {
        Type = TargetType.Serverp;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("DSN"); //Change this line according to the name of your project
    }
}