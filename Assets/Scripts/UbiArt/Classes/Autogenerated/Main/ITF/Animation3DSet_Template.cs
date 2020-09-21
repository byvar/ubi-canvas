using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Animation3DSet_Template : CSerializable {
		public CListO<Animation3DInfo_Template> animations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animations = s.SerializeObject<CListO<Animation3DInfo_Template>>(animations, name: "animations");
		}
	}
}

