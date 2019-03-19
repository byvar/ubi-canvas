using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GyroControllerComponent_Template : ActorComponent_Template {
		[Serialize("loopfx"                  )] public StringID loopfx;
		[Serialize("localLoopFx"             )] public StringID localLoopFx;
		[Serialize("localLoopForceFx"        )] public StringID localLoopForceFx;
		[Serialize("limitFx"                 )] public StringID limitFx;
		[Serialize("DRCScreenDepth"          )] public float DRCScreenDepth;
		[Serialize("tvOffDisplayTutoDuration")] public float tvOffDisplayTutoDuration;
		[Serialize("DRCScreenPath"           )] public Path DRCScreenPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(loopfx));
				SerializeField(s, nameof(localLoopFx));
				SerializeField(s, nameof(localLoopForceFx));
				SerializeField(s, nameof(limitFx));
				SerializeField(s, nameof(DRCScreenPath));
				SerializeField(s, nameof(DRCScreenDepth));
				SerializeField(s, nameof(tvOffDisplayTutoDuration));
			} else {
				SerializeField(s, nameof(loopfx));
				SerializeField(s, nameof(localLoopFx));
				SerializeField(s, nameof(localLoopForceFx));
				SerializeField(s, nameof(limitFx));
				SerializeField(s, nameof(DRCScreenDepth));
				SerializeField(s, nameof(tvOffDisplayTutoDuration));
			}
		}
		public override uint? ClassCRC => 0x553E0CDA;
	}
}

