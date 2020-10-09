using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GyroControllerComponent_Template : ActorComponent_Template {
		public StringID loopfx;
		public StringID localLoopFx;
		public StringID localLoopForceFx;
		public StringID limitFx;
		public float DRCScreenDepth;
		public float tvOffDisplayTutoDuration;
		public Path DRCScreenPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				loopfx = s.SerializeObject<StringID>(loopfx, name: "loopfx");
				localLoopFx = s.SerializeObject<StringID>(localLoopFx, name: "localLoopFx");
				localLoopForceFx = s.SerializeObject<StringID>(localLoopForceFx, name: "localLoopForceFx");
				limitFx = s.SerializeObject<StringID>(limitFx, name: "limitFx");
				DRCScreenPath = s.SerializeObject<Path>(DRCScreenPath, name: "DRCScreenPath");
				DRCScreenDepth = s.Serialize<float>(DRCScreenDepth, name: "DRCScreenDepth");
				tvOffDisplayTutoDuration = s.Serialize<float>(tvOffDisplayTutoDuration, name: "tvOffDisplayTutoDuration");
			} else {
				loopfx = s.SerializeObject<StringID>(loopfx, name: "loopfx");
				localLoopFx = s.SerializeObject<StringID>(localLoopFx, name: "localLoopFx");
				localLoopForceFx = s.SerializeObject<StringID>(localLoopForceFx, name: "localLoopForceFx");
				limitFx = s.SerializeObject<StringID>(limitFx, name: "limitFx");
				DRCScreenDepth = s.Serialize<float>(DRCScreenDepth, name: "DRCScreenDepth");
				tvOffDisplayTutoDuration = s.Serialize<float>(tvOffDisplayTutoDuration, name: "tvOffDisplayTutoDuration");
			}
		}
		public override uint? ClassCRC => 0x553E0CDA;
	}
}

