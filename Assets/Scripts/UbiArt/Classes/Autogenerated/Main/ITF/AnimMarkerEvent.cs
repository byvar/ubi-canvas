using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AnimMarkerEvent : Event {
		[Serialize("name"    )] public StringID name;
		[Serialize("posLocal")] public Vector2 posLocal;
		[Serialize("sender"  )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
			}
		}
		public override uint? ClassCRC => 0x2CF531DD;
	}
}

