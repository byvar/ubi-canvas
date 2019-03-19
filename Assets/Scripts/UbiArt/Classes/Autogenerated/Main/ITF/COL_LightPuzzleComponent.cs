using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightPuzzleComponent : CSerializable {
		[Serialize("drawDebug"      )] public bool drawDebug;
		[Serialize("ordered"        )] public bool ordered;
		[Serialize("failCooldown"   )] public float failCooldown;
		[Serialize("inRangeCoolDown")] public float inRangeCoolDown;
		[Serialize("failEvent"      )] public Placeholder failEvent;
		[Serialize("isSolved"       )] public int isSolved;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(drawDebug), boolAsByte: true);
			SerializeField(s, nameof(ordered), boolAsByte: true);
			SerializeField(s, nameof(failCooldown));
			SerializeField(s, nameof(inRangeCoolDown));
			SerializeField(s, nameof(failEvent));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isSolved));
			}
		}
		public override uint? ClassCRC => 0x1D019BC4;
	}
}

