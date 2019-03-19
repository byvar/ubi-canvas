using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_19_sub_7957A0 : CSerializable {
		[Serialize("brightnessTable"        )] public Placeholder brightnessTable;
		[Serialize("enableCloth"            )] public int enableCloth;
		[Serialize("enableCollisionCapsules")] public int enableCollisionCapsules;
		[Serialize("clothTeleportDistance"  )] public float clothTeleportDistance;
		[Serialize("renderToTexture"        )] public int renderToTexture;
		[Serialize("rttMaterial"            )] public Placeholder rttMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(brightnessTable));
			SerializeField(s, nameof(enableCloth));
			SerializeField(s, nameof(enableCollisionCapsules));
			SerializeField(s, nameof(clothTeleportDistance));
			SerializeField(s, nameof(renderToTexture));
			SerializeField(s, nameof(rttMaterial));
		}
		public override uint? ClassCRC => 0x825B7536;
	}
}

