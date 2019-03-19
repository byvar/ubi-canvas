using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_200_sub_790030 : CSerializable {
		[Serialize("circles"    )] public Placeholder circles;
		[Serialize("transitions")] public Placeholder transitions;
		[Serialize("texturePath")] public Path texturePath;
		[Serialize("material"   )] public Placeholder material;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(circles));
			SerializeField(s, nameof(transitions));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texturePath));
			}
			SerializeField(s, nameof(material));
		}
		public override uint? ClassCRC => 0x31D38AFF;
	}
}

