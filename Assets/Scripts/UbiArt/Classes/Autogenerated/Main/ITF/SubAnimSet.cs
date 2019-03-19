using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SubAnimSet : CSerializable {
		[Serialize("animPackage")] public AnimResourcePackage animPackage;
		[Serialize("animations" )] public CList<SubAnim_Template> animations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPackage));
			SerializeField(s, nameof(animations));
		}
	}
}

