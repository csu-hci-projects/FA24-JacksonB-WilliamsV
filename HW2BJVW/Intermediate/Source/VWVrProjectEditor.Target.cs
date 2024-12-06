using UnrealBuildTool;

public class VWVrProjectEditorTarget : TargetRules
{
	public VWVrProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("VWVrProject");
	}
}
