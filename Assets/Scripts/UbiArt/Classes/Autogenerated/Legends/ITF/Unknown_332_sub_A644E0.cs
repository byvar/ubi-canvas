using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_332_sub_A644E0 : CSerializable {
		[Serialize("fadeIn" )] public StringID fadeIn;
		[Serialize("fadeOut")] public StringID fadeOut;
		[Serialize("idle"   )] public StringID idle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fadeIn));
			SerializeField(s, nameof(fadeOut));
			SerializeField(s, nameof(idle));
		}
		public override uint? ClassCRC => 0xFE9FCB19;
	}
}

