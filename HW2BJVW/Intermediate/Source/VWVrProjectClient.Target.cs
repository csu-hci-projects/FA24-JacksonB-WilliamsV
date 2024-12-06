using UnrealBuildTool;

public class VWVrProjectClientTarget : TargetRules
{
	public VWVrProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("VWVrProject");
	}
}
