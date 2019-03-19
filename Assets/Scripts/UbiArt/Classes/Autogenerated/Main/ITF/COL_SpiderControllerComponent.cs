using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SpiderControllerComponent : CSerializable {
		[Serialize("travelDistance"    )] public float travelDistance;
		[Serialize("idleDuration"      )] public float idleDuration;
		[Serialize("travelDurationUp"  )] public float travelDurationUp;
		[Serialize("travelDurationDown")] public float travelDurationDown;
		[Serialize("useWeb"            )] public int useWeb;
		[Serialize("easeInDownMove"    )] public bool easeInDownMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(travelDistance));
			SerializeField(s, nameof(idleDuration));
			SerializeField(s, nameof(travelDurationUp));
			SerializeField(s, nameof(travelDurationDown));
			SerializeField(s, nameof(useWeb));
			SerializeField(s, nameof(easeInDownMove), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x522EFC51;
	}
}

