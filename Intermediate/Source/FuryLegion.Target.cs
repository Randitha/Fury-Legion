using UnrealBuildTool;

public class FuryLegionTarget : TargetRules
{
	public FuryLegionTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FuryLegion");
	}
}
