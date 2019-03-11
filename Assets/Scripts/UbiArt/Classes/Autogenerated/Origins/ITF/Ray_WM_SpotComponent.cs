using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_SpotComponent : CSerializable {
		[Serialize("tag"        )] public StringID tag;
		[Serialize("isStandSwim")] public bool isStandSwim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tag));
			SerializeField(s, nameof(isStandSwim));
		}
		public override uint? ClassCRC => 0xCD2A03CA;
	}
}

