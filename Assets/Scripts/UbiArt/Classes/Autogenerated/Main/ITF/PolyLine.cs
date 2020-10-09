using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class PolyLine : CSerializable {
		public PolyPointList PolyPointList;
		public AABB AABB;
		public PolyLine.Connection connection;
		public CListO<PolyLineEdge> POINTS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					POINTS = s.SerializeObject<CListO<PolyLineEdge>>(POINTS, name: "POINTS");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				PolyPointList = s.SerializeObject<PolyPointList>(PolyPointList, name: "PolyPointList");
				AABB = s.SerializeObject<AABB>(AABB, name: "AABB");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					AABB = s.SerializeObject<AABB>(AABB, name: "AABB");
				}
			} else {
				PolyPointList = s.SerializeObject<PolyPointList>(PolyPointList, name: "PolyPointList");
				AABB = s.SerializeObject<AABB>(AABB, name: "AABB");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					connection = s.SerializeObject<PolyLine.Connection>(connection, name: "Connection");
				}
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class Connection : CSerializable {
			public uint PreviousId;
			public Vec2d PosInit;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				PreviousId = s.Serialize<uint>(PreviousId, name: "PreviousId");
				PosInit = s.SerializeObject<Vec2d>(PosInit, name: "PosInit");
			}
		}
		public override uint? ClassCRC => 0x732A7AA3;
	}
}

