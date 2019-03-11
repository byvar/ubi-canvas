using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenTranslationLine_Template : CSerializable {
		[Serialize("movement")] public Vector3 movement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(movement));
		}
		public override uint? ClassCRC => 0xE63A5FEA;
	}
}

