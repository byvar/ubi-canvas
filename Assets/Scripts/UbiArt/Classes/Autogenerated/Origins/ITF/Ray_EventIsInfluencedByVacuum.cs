using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventIsInfluencedByVacuum : CSerializable {
		[Serialize("influenced")] public bool influenced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(influenced));
		}
		public override uint? ClassCRC => 0x74BE6E32;
	}
}

