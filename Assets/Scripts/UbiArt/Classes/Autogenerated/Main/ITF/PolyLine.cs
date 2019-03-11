using UnityEngine;

namespace UbiArt.ITF {
	public partial class PolyLine : CSerializable {
		[Serialize("PolyPointList")] public PolyPointList PolyPointList;
		[Serialize("AABB"         )] public AABB AABB;
		[Serialize("Connection"   )] public PolyLine.Connection Connection;
		[Serialize("POINTS"       )] public Placeholder POINTS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					SerializeField(s, nameof(POINTS));
				}
			} else {
				SerializeField(s, nameof(PolyPointList));
				SerializeField(s, nameof(AABB));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(Connection));
				}
			}
		}
		public partial class Connection : CSerializable {
			[Serialize("PreviousId")] public uint PreviousId;
			[Serialize("PosInit"   )] public Vector2 PosInit;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(PreviousId));
				SerializeField(s, nameof(PosInit));
			}
		}
		public override uint? ClassCRC => 0x732A7AA3;
	}
}

