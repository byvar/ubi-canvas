using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_410_sub_B20F30 : CSerializable {
		[Serialize("packageDescriptors")] public Placeholder packageDescriptors;
		[Serialize("costumeDescriptors")] public Placeholder costumeDescriptors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(packageDescriptors));
			SerializeField(s, nameof(costumeDescriptors));
		}
		public override uint? ClassCRC => 0x502B8E0B;
	}
}

