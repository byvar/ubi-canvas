using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.COL)]
	public partial class EventStim : Event {
		[Serialize("pos"    )] public Vector2 pos;
		[Serialize("prevPos")] public Vector2 prevPos;
		[Serialize("angle"  )] public float angle;
		[Serialize("z"      )] public float z;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else {
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(prevPos));
				SerializeField(s, nameof(angle));
				SerializeField(s, nameof(z));
			}
		}
		public override uint? ClassCRC => 0x12E41BB6;
	}
}

