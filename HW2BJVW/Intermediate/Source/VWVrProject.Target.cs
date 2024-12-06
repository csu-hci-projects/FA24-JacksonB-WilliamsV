using UnrealBuildTool;

public class VWVrProjectTarget : TargetRules
{
	public VWVrProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VWVrProject");
	}
}
