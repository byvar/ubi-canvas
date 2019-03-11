using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_219_sub_B857B0 : CSerializable {
		[Serialize("tweenId")] public Enum_tweenId tweenId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenId));
		}
		public enum Enum_tweenId {
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xBFB882A5;
	}
}

