using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SequencePlayerComponent : ActorComponent {
		[Serialize("bankState"        )] public uint bankState;
		[Serialize("allowPrefetch"    )] public bool allowPrefetch;
		[Serialize("useCustomAABB"    )] public bool useCustomAABB;
		[Serialize("customAABB"       )] public EditableShape customAABB;
		[Serialize("overrideActorAABB")] public bool overrideActorAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(bankState));
			} else {
				SerializeField(s, nameof(bankState));
				SerializeField(s, nameof(allowPrefetch));
				SerializeField(s, nameof(useCustomAABB));
				SerializeField(s, nameof(customAABB));
				SerializeField(s, nameof(overrideActorAABB));
			}
		}
		public override uint? ClassCRC => 0x35A4CFCF;
	}
}

