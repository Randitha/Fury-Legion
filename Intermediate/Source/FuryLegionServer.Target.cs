using UnrealBuildTool;

public class FuryLegionServerTarget : TargetRules
{
	public FuryLegionServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FuryLegion");
	}
}
