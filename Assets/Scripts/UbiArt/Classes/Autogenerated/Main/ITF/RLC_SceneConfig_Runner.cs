using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_SceneConfig_Runner : RO2_SceneConfig_Platform {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3C601858;
	}
}

