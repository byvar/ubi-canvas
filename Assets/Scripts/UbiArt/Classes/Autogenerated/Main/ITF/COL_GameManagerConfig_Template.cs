using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GameManagerConfig_Template : CSerializable {
		public Path startScenePath;
		public Path firstMapToLaunchPath;
		public Path upsellScreenPath;
		public PathRef creditsScreenPath;
		public StringID initialMapLocation;
		public StringID initialMissionBuild;
		public StringID initialMapLocation_TRIAL;
		public StringID initialMissionBuild_TRIAL;
		public StringID mapLocationAfterEndCredits;
		public Path gameplayCameraPath;
		public Path drawCameraPath;
		public Path logoVideoIntroPath;
		public Path loadingScenePath;
		public Placeholder endCreditDialogData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startScenePath = s.SerializeObject<Path>(startScenePath, name: "startScenePath");
			firstMapToLaunchPath = s.SerializeObject<Path>(firstMapToLaunchPath, name: "firstMapToLaunchPath");
			upsellScreenPath = s.SerializeObject<Path>(upsellScreenPath, name: "upsellScreenPath");
			creditsScreenPath = s.SerializeObject<PathRef>(creditsScreenPath, name: "creditsScreenPath");
			initialMapLocation = s.SerializeObject<StringID>(initialMapLocation, name: "initialMapLocation");
			initialMissionBuild = s.SerializeObject<StringID>(initialMissionBuild, name: "initialMissionBuild");
			initialMapLocation_TRIAL = s.SerializeObject<StringID>(initialMapLocation_TRIAL, name: "initialMapLocation_TRIAL");
			initialMissionBuild_TRIAL = s.SerializeObject<StringID>(initialMissionBuild_TRIAL, name: "initialMissionBuild_TRIAL");
			mapLocationAfterEndCredits = s.SerializeObject<StringID>(mapLocationAfterEndCredits, name: "mapLocationAfterEndCredits");
			gameplayCameraPath = s.SerializeObject<Path>(gameplayCameraPath, name: "gameplayCameraPath");
			drawCameraPath = s.SerializeObject<Path>(drawCameraPath, name: "drawCameraPath");
			logoVideoIntroPath = s.SerializeObject<Path>(logoVideoIntroPath, name: "logoVideoIntroPath");
			loadingScenePath = s.SerializeObject<Path>(loadingScenePath, name: "loadingScenePath");
			endCreditDialogData = s.SerializeObject<Placeholder>(endCreditDialogData, name: "endCreditDialogData");
		}
		public override uint? ClassCRC => 0x8D6F0830;
	}
}

