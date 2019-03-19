using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionAlerted_Template : CSerializable {
		[Serialize("name"               )] public StringID name;
		[Serialize("timeBeforeCharge"   )] public float timeBeforeCharge;
		[Serialize("ignoreZ"            )] public bool ignoreZ;
		[Serialize("animStandToAlerted" )] public StringID animStandToAlerted;
		[Serialize("animAlerted"        )] public StringID animAlerted;
		[Serialize("animAlertedToStand" )] public StringID animAlertedToStand;
		[Serialize("animAlertedToCharge")] public StringID animAlertedToCharge;
		[Serialize("detectionShape"     )] public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(timeBeforeCharge));
			SerializeField(s, nameof(ignoreZ), boolAsByte: true);
			SerializeField(s, nameof(animStandToAlerted));
			SerializeField(s, nameof(animAlerted));
			SerializeField(s, nameof(animAlertedToStand));
			SerializeField(s, nameof(animAlertedToCharge));
			SerializeField(s, nameof(detectionShape));
		}
		public override uint? ClassCRC => 0x081FB5C8;
	}
}

