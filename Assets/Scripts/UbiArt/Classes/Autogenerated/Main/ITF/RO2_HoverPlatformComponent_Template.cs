using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_HoverPlatformComponent_Template : ActorComponent_Template {
		[Serialize("movePhase"         )] public float movePhase;
		[Serialize("waitPhase"         )] public float waitPhase;
		[Serialize("fxReactor01Enabled")] public bool fxReactor01Enabled;
		[Serialize("fxReactor02Enabled")] public bool fxReactor02Enabled;
		[Serialize("fxReactor03Enabled")] public bool fxReactor03Enabled;
		[Serialize("landEnabled"       )] public bool landEnabled;
		[Serialize("chainEnabled"      )] public bool chainEnabled;
		[Serialize("chainPath"         )] public Path chainPath;
		[Serialize("animDeathEnabled"  )] public bool animDeathEnabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(movePhase));
				SerializeField(s, nameof(waitPhase));
				SerializeField(s, nameof(fxReactor01Enabled));
				SerializeField(s, nameof(fxReactor02Enabled));
				SerializeField(s, nameof(fxReactor03Enabled));
				SerializeField(s, nameof(landEnabled));
				SerializeField(s, nameof(chainEnabled));
				SerializeField(s, nameof(chainPath));
				SerializeField(s, nameof(animDeathEnabled));
			} else {
				SerializeField(s, nameof(movePhase));
				SerializeField(s, nameof(waitPhase));
				SerializeField(s, nameof(fxReactor01Enabled));
				SerializeField(s, nameof(fxReactor02Enabled));
				SerializeField(s, nameof(fxReactor03Enabled));
				SerializeField(s, nameof(landEnabled));
				SerializeField(s, nameof(chainEnabled));
				SerializeField(s, nameof(chainPath));
			}
		}
		public override uint? ClassCRC => 0x5A8B0C8F;
	}
}

