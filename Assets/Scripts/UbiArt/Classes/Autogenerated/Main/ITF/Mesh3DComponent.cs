using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class Mesh3DComponent : GraphicComponent {
		public float ScaleZ;
		public CList<GFXMaterialSerializable> materialList;
		public Path mesh3D;
		public CList<Path> mesh3DList;
		public Path skeleton3D;
		public Path animation3D;
		public CList<Path> animation3DList;
		public Animation3DSet animation3DSet;
		public StringID animationNode;
		public Enum_Animation_player_mode Animation_player_mode;
		public Matrix44 orientation;
		public bool rotateOnFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					ScaleZ = s.Serialize<float>(ScaleZ, name: "ScaleZ");
					materialList = s.SerializeObject<CList<GFXMaterialSerializable>>(materialList, name: "materialList");
					mesh3D = s.SerializeObject<Path>(mesh3D, name: "mesh3D");
					mesh3DList = s.SerializeObject<CList<Path>>(mesh3DList, name: "mesh3DList");
					skeleton3D = s.SerializeObject<Path>(skeleton3D, name: "skeleton3D");
					animation3D = s.SerializeObject<Path>(animation3D, name: "animation3D");
					animation3DList = s.SerializeObject<CList<Path>>(animation3DList, name: "animation3DList");
					animation3DSet = s.SerializeObject<Animation3DSet>(animation3DSet, name: "animation3DSet");
					animationNode = s.SerializeObject<StringID>(animationNode, name: "animationNode");
					Animation_player_mode = s.Serialize<Enum_Animation_player_mode>(Animation_player_mode, name: "Animation_player_mode");
					orientation = s.SerializeObject<Matrix44>(orientation, name: "orientation");
					rotateOnFlip = s.Serialize<bool>(rotateOnFlip, name: "rotateOnFlip", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					ScaleZ = s.Serialize<float>(ScaleZ, name: "ScaleZ");
					materialList = s.SerializeObject<CList<GFXMaterialSerializable>>(materialList, name: "materialList");
					mesh3D = s.SerializeObject<Path>(mesh3D, name: "mesh3D");
					mesh3DList = s.SerializeObject<CList<Path>>(mesh3DList, name: "mesh3DList");
					skeleton3D = s.SerializeObject<Path>(skeleton3D, name: "skeleton3D");
					animation3D = s.SerializeObject<Path>(animation3D, name: "animation3D");
					animation3DList = s.SerializeObject<CList<Path>>(animation3DList, name: "animation3DList");
					animation3DSet = s.SerializeObject<Animation3DSet>(animation3DSet, name: "animation3DSet");
					animationNode = s.SerializeObject<StringID>(animationNode, name: "animationNode");
					Animation_player_mode = s.Serialize<Enum_Animation_player_mode>(Animation_player_mode, name: "Animation_player_mode");
					orientation = s.SerializeObject<Matrix44>(orientation, name: "orientation");
				}
			}
		}
		public enum Enum_Animation_player_mode {
			[Serialize("Cine"             )] Cine = 0,
			[Serialize("Contracted"       )] Contracted = 1,
			[Serialize("Expanded"         )] Expanded = 2,
			[Serialize("ExpandedAffectPos")] ExpandedAffectPos = 3,
		}
		public override uint? ClassCRC => 0x1A7E999A;
	}
}

