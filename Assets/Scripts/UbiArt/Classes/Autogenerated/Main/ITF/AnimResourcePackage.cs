using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class AnimResourcePackage : CSerializable {
		public Path skeleton;
		public CListO<TextureBankPath> textureBank;
		public CListO<AnimPathAABB> animPathAABB;
		public bool needPack;
		public bool packed;
		public bool fromHD;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			skeleton = s.SerializeObject<Path>(skeleton, name: "skeleton");
			textureBank = s.SerializeObject<CListO<TextureBankPath>>(textureBank, name: "textureBank");
			animPathAABB = s.SerializeObject<CListO<AnimPathAABB>>(animPathAABB, name: "animPathAABB");
			needPack = s.Serialize<bool>(needPack, name: "needPack");
			packed = s.Serialize<bool>(packed, name: "packed");
			fromHD = s.Serialize<bool>(fromHD, name: "fromHD");
		}
	}
}

