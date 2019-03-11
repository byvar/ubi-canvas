using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BasicPlayerControllerComponent_Template : PlayerControllerComponent_Template {
		[Serialize("deathLumDropTemplateList")] public Placeholder deathLumDropTemplateList;
		[Serialize("deathLumPath"            )] public Path deathLumPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(deathLumDropTemplateList));
			SerializeField(s, nameof(deathLumPath));
		}
		public override uint? ClassCRC => 0xDB53DCEA;
	}
}

