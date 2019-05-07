// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FeaturesVR_M1EditorTarget : TargetRules
{
	public FeaturesVR_M1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "FeaturesVR_M1" } );
	}
}
