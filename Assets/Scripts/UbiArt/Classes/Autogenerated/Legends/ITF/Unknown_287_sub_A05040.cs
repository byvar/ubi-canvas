using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_287_sub_A05040 : CSerializable {
		[Serialize("Pos"            )] public Vector3 Pos;
		[Serialize("useInitModifier")] public bool useInitModifier;
		[Serialize("initModifier"   )] public Placeholder initModifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(Pos));
			}
			SerializeField(s, nameof(useInitModifier));
			SerializeField(s, nameof(initModifier));
		}
		public override uint? ClassCRC => 0x9AC515FF;
	}
}

