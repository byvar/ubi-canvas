using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Camera3dComponent_Template : ActorComponent_Template {
		public StringID camBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			camBone = s.SerializeObject<StringID>(camBone, name: "camBone");
		}
		public override uint? ClassCRC => 0x64C53B66;
	}
}

