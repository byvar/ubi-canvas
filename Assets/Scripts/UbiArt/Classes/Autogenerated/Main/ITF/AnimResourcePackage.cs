using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimResourcePackage : CSerializable {
		[Serialize("skeleton"    )] public Path skeleton;
		[Serialize("textureBank" )] public CList<TextureBankPath> textureBank;
		[Serialize("animPathAABB")] public CList<AnimPathAABB> animPathAABB;
		[Serialize("needPack"    )] public bool needPack;
		[Serialize("packed"      )] public bool packed;
		[Serialize("fromHD"      )] public bool fromHD;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(skeleton));
			SerializeField(s, nameof(textureBank));
			SerializeField(s, nameof(animPathAABB));
			SerializeField(s, nameof(needPack));
			SerializeField(s, nameof(packed));
			SerializeField(s, nameof(fromHD));
		}
	}
}

