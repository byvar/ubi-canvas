using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_135_sub_73FC80 : CSerializable {
		[Serialize("useSwitchChallenge")] public bool useSwitchChallenge;
		[Serialize("blockerOffset"     )] public Vector2 blockerOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useSwitchChallenge));
			SerializeField(s, nameof(blockerOffset));
		}
		public override uint? ClassCRC => 0x0A5EC37B;
	}
}

