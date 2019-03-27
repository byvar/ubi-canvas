using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_410_sub_B20F30 : RO2_SceneConfig_Base {
		[Serialize("packageDescriptors")] public CList<RO2_PackageDescriptor_Template> packageDescriptors;
		[Serialize("costumeDescriptors")] public CList<RO2_CostumeDescriptor_Template> costumeDescriptors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(packageDescriptors));
			SerializeField(s, nameof(costumeDescriptors));
		}
		public override uint? ClassCRC => 0x502B8E0B;
	}
}

