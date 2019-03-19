using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GameManagerConfig_Template : CSerializable {
		[Serialize("startScenePath"            )] public Path startScenePath;
		[Serialize("firstMapToLaunchPath"      )] public Path firstMapToLaunchPath;
		[Serialize("upsellScreenPath"          )] public Path upsellScreenPath;
		[Serialize("creditsScreenPath"         )] public PathRef creditsScreenPath;
		[Serialize("initialMapLocation"        )] public StringID initialMapLocation;
		[Serialize("initialMissionBuild"       )] public StringID initialMissionBuild;
		[Serialize("initialMapLocation_TRIAL"  )] public StringID initialMapLocation_TRIAL;
		[Serialize("initialMissionBuild_TRIAL" )] public StringID initialMissionBuild_TRIAL;
		[Serialize("mapLocationAfterEndCredits")] public StringID mapLocationAfterEndCredits;
		[Serialize("gameplayCameraPath"        )] public Path gameplayCameraPath;
		[Serialize("drawCameraPath"            )] public Path drawCameraPath;
		[Serialize("logoVideoIntroPath"        )] public Path logoVideoIntroPath;
		[Serialize("loadingScenePath"          )] public Path loadingScenePath;
		[Serialize("endCreditDialogData"       )] public Placeholder endCreditDialogData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startScenePath));
			SerializeField(s, nameof(firstMapToLaunchPath));
			SerializeField(s, nameof(upsellScreenPath));
			SerializeField(s, nameof(creditsScreenPath));
			SerializeField(s, nameof(initialMapLocation));
			SerializeField(s, nameof(initialMissionBuild));
			SerializeField(s, nameof(initialMapLocation_TRIAL));
			SerializeField(s, nameof(initialMissionBuild_TRIAL));
			SerializeField(s, nameof(mapLocationAfterEndCredits));
			SerializeField(s, nameof(gameplayCameraPath));
			SerializeField(s, nameof(drawCameraPath));
			SerializeField(s, nameof(logoVideoIntroPath));
			SerializeField(s, nameof(loadingScenePath));
			SerializeField(s, nameof(endCreditDialogData));
		}
		public override uint? ClassCRC => 0x8D6F0830;
	}
}

