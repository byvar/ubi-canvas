using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionCharge_Template : CSerializable {
		[Serialize("name"               )] public StringID name;
		[Serialize("animCharge"         )] public StringID animCharge;
		[Serialize("detectionShape"     )] public Placeholder detectionShape;
		[Serialize("targetDistThreshold")] public float targetDistThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(animCharge));
			SerializeField(s, nameof(detectionShape));
			SerializeField(s, nameof(targetDistThreshold));
		}
		public override uint? ClassCRC => 0x105C82C9;
	}
}

