using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TextBoxAttachedToBoneComponent_Template : ActorComponent_Template {
		[Serialize("boneName"    )] public StringID boneName;
		[Serialize("useBoneScale")] public bool useBoneScale;
		[Serialize("useBoneAngle")] public bool useBoneAngle;
		[Serialize("useBoneAlpha")] public bool useBoneAlpha;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(useBoneScale));
			SerializeField(s, nameof(useBoneAngle));
			SerializeField(s, nameof(useBoneAlpha));
		}
		public override uint? ClassCRC => 0x50CB8E1E;
	}
}

