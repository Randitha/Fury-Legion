using UnrealBuildTool;

public class FuryLegionEditorTarget : TargetRules
{
	public FuryLegionEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FuryLegion");
	}
}
