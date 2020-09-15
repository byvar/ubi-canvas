using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class PolyLine : CSerializable {
		public PolyPointList PolyPointList;
		public AABB AABB;
		public PolyLine.Connection connection;
		public CList<PolyLineEdge> POINTS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					POINTS = s.SerializeObject<CList<PolyLineEdge>>(POINTS, name: "POINTS");
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
					connection = s.SerializeObject<PolyLine.Connection>(connection, name: "connection");
				}
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
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

