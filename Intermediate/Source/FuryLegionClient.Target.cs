using UnrealBuildTool;

public class FuryLegionClientTarget : TargetRules
{
	public FuryLegionClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FuryLegion");
	}
}
