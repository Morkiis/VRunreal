// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FeaturesVR_M1Target : TargetRules
{
	public FeaturesVR_M1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "FeaturesVR_M1" } );
	}
}
