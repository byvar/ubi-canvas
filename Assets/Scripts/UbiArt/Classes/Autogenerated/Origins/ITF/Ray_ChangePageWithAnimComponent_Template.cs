using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ChangePageWithAnimComponent_Template : CSerializable {
		[Serialize("animPlayer" )] public StringID animPlayer;
		[Serialize("aspireAnim" )] public StringID aspireAnim;
		[Serialize("aspirePoint")] public StringID aspirePoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPlayer));
			SerializeField(s, nameof(aspireAnim));
			SerializeField(s, nameof(aspirePoint));
		}
		public override uint? ClassCRC => 0x86E7DE33;
	}
}

