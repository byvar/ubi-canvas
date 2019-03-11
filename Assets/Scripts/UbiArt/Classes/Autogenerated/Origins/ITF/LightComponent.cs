using UnityEngine;

namespace UbiArt.ITF {
	public partial class LightComponent : CSerializable {
		[Serialize("useOnActor")] public bool useOnActor;
		[Serialize("useOnFrize")] public bool useOnFrize;
		[Serialize("useBV"     )] public bool useBV;
		[Serialize("alpha"     )] public float alpha;
		[Serialize("red"       )] public float red;
		[Serialize("green"     )] public float green;
		[Serialize("blue"      )] public float blue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(useOnActor));
				SerializeField(s, nameof(useOnFrize));
				SerializeField(s, nameof(useBV));
				SerializeField(s, nameof(alpha));
				SerializeField(s, nameof(red));
				SerializeField(s, nameof(green));
				SerializeField(s, nameof(blue));
			}
		}
		public override uint? ClassCRC => 0x89DA5668;
	}
}

