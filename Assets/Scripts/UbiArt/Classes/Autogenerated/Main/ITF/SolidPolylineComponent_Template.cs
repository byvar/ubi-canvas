using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class SolidPolylineComponent_Template : PolylineComponent_Template {
		[Serialize("solidEdges"   )] public CList<SolidPolylineComponent_Template.SolidEdgeData> solidEdges;
		[Serialize("isEnvironment")] public int isEnvironment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(isEnvironment));
			} else {
				SerializeField(s, nameof(solidEdges));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class SolidEdgeData : CSerializable {
			[Serialize("bone"    )] public StringID bone;
			[Serialize("minDelta")] public float minDelta;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(minDelta));
			}
		}
		public override uint? ClassCRC => 0xDEC09000;
	}
}

