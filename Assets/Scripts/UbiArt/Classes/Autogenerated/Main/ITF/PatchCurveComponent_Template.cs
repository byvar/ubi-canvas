using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
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
		[Serialize("width"                    )] public float width;
		[Serialize("parentBoneEnd"            )] public bool parentBoneEnd;
		[Serialize("childBoneEnd"             )] public bool childBoneEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(uvScrollSpeed));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(tessellationLength));
				SerializeField(s, nameof(parentBone));
				SerializeField(s, nameof(childBone));
				SerializeField(s, nameof(childOrientationInfluence));
				SerializeField(s, nameof(attachToChild));
			} else if (Settings.s.game == Settings.Game.COL) {
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
				SerializeField(s, nameof(parentBoneEnd), boolAsByte: true);
				SerializeField(s, nameof(childBone));
				SerializeField(s, nameof(childBoneEnd), boolAsByte: true);
				SerializeField(s, nameof(childOrientationInfluence));
				SerializeField(s, nameof(attachToChild), boolAsByte: true);
			} else {
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
		}
		public override uint? ClassCRC => 0x807DC33A;
	}
}

