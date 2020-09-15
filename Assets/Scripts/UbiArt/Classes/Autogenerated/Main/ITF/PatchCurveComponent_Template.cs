using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class PatchCurveComponent_Template : GraphicComponent_Template {
		public Path texture;
		public GFXMaterialSerializable material;
		public float widthStart;
		public float widthEnd;
		public float tileLength;
		public float uvScrollSpeed;
		public float zOffset;
		public float tessellationLength;
		public StringID parentBone;
		public StringID childBone;
		public float childOrientationInfluence;
		public bool attachToChild;
		public float width;
		public bool parentBoneEnd;
		public bool childBoneEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
				width = s.Serialize<float>(width, name: "width");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
				parentBone = s.SerializeObject<StringID>(parentBone, name: "parentBone");
				childBone = s.SerializeObject<StringID>(childBone, name: "childBone");
				childOrientationInfluence = s.Serialize<float>(childOrientationInfluence, name: "childOrientationInfluence");
				attachToChild = s.Serialize<bool>(attachToChild, name: "attachToChild");
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				widthStart = s.Serialize<float>(widthStart, name: "widthStart");
				widthEnd = s.Serialize<float>(widthEnd, name: "widthEnd");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
				parentBone = s.SerializeObject<StringID>(parentBone, name: "parentBone");
				parentBoneEnd = s.Serialize<bool>(parentBoneEnd, name: "parentBoneEnd", options: CSerializerObject.Options.BoolAsByte);
				childBone = s.SerializeObject<StringID>(childBone, name: "childBone");
				childBoneEnd = s.Serialize<bool>(childBoneEnd, name: "childBoneEnd", options: CSerializerObject.Options.BoolAsByte);
				childOrientationInfluence = s.Serialize<float>(childOrientationInfluence, name: "childOrientationInfluence");
				attachToChild = s.Serialize<bool>(attachToChild, name: "attachToChild", options: CSerializerObject.Options.BoolAsByte);
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				widthStart = s.Serialize<float>(widthStart, name: "widthStart");
				widthEnd = s.Serialize<float>(widthEnd, name: "widthEnd");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
				parentBone = s.SerializeObject<StringID>(parentBone, name: "parentBone");
				childBone = s.SerializeObject<StringID>(childBone, name: "childBone");
				childOrientationInfluence = s.Serialize<float>(childOrientationInfluence, name: "childOrientationInfluence");
				attachToChild = s.Serialize<bool>(attachToChild, name: "attachToChild");
			}
		}
		public override uint? ClassCRC => 0x807DC33A;
	}
}

