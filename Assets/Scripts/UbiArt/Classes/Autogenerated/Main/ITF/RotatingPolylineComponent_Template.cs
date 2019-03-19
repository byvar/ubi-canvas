using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class RotatingPolylineComponent_Template : PolylineComponent_Template {
		[Serialize("rotatingPolys")] public CList<RotatingPolylineComponent_Template.RotatingPoly> rotatingPolys;
		[Serialize("isEnvironment")] public int isEnvironment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(isEnvironment));
			} else {
				SerializeField(s, nameof(rotatingPolys));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class RotatingPoly : CSerializable {
			[Serialize("brake"          )] public float brake;
			[Serialize("forceMultiplier")] public float forceMultiplier;
			[Serialize("bone"           )] public StringID bone;
			[Serialize("polylines"      )] public CList<StringID> polylines;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(brake));
				SerializeField(s, nameof(forceMultiplier));
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(polylines));
			}
		}
		public override uint? ClassCRC => 0x94C84C69;
	}
}

