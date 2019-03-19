using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GraphicActorInfo : CSerializable {
		[Serialize("amvPath" )] public Path amvPath;
		[Serialize("material")] public GFXMaterialSerializable material;
		[Serialize("scale"   )] public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(amvPath));
			SerializeField(s, nameof(material));
			SerializeField(s, nameof(scale));
		}
	}
}

