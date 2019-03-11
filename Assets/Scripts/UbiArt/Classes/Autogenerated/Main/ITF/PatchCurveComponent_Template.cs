using UnityEngine;

namespace UbiArt.ITF {
	public partial class PatchCurveComponent_Template : GraphicComponent_Template {
		[Serialize("texture"                  )] public Path texture;
		[Serialize("material"                 )] public GFXMaterialSerializable material;
		[Serialize("widthStart"               )] public float widthStart;
		[Serialize("widthEnd"                 )] public float widthEnd;
		[Serialize("tileLength"               )] public float tileLength;
		[Serialize("uvScrollSpeed"            )] public float uvScrollSpeed;
		[Serialize("zOffset"                  )] public float zOffset;
		[Serialize("tessellationLength"       )] public float tessellationLength;
		[Serialize("parentBone"               )] public StringID parentBone;
		[Serialize("childBone"                )] public StringID childBone;
		[Serialize("childOrientationInfluence")] public float childOrientationInfluence;
		[Serialize("attachToChild"            )] public bool attachToChild;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(material));
			SerializeField(s, nameof(widthStart));
			SerializeField(s, nameof(widthEnd));
			SerializeField(s, nameof(tileLength));
			SerializeField(s, nameof(uvScrollSpeed));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(tessellationLength));
			SerializeField(s, nameof(parentBone));
			SerializeField(s, nameof(childBone));
			SerializeField(s, nameof(childOrientationInfluence));
			SerializeField(s, nameof(attachToChild));
		}
		public override uint? ClassCRC => 0x807DC33A;
	}
}

