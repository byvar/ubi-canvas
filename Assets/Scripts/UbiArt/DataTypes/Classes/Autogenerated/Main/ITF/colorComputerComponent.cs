using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class colorComputerComponent : ActorComponent {
		public float near;
		public float far;
		public Color nearColor;
		public Color farColor;
		public uint tagId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				near = s.Serialize<float>(near, name: "near");
				far = s.Serialize<float>(far, name: "far");
				nearColor = s.SerializeObject<Color>(nearColor, name: "nearColor");
				farColor = s.SerializeObject<Color>(farColor, name: "farColor");
				tagId = s.Serialize<uint>(tagId, name: "tagId");
			}
		}
		public override uint? ClassCRC => 0xD052E936;
	}
}

