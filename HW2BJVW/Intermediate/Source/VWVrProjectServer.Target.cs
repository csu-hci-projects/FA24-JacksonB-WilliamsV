using UnrealBuildTool;

public class VWVrProjectServerTarget : TargetRules
{
	public VWVrProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("VWVrProject");
	}
}
