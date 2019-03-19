using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightMessageComponent_Template : CSerializable {
		[Description("Brush nib material")]
		[Serialize("brushNibMaterial"        )] public Placeholder brushNibMaterial;
		[Description("Interaction icon actor path")]
		[Serialize("interactionIconActorPath")] public Path interactionIconActorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(brushNibMaterial));
			SerializeField(s, nameof(interactionIconActorPath));
		}
		public override uint? ClassCRC => 0x0D66D118;
	}
}

