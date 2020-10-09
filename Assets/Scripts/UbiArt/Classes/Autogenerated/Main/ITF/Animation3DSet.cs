using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Animation3DSet : CSerializable {
		public CListO<Animation3DInfo_Template> animations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animations = s.SerializeObject<CListO<Animation3DInfo_Template>>(animations, name: "animations");
		}
	}
}

