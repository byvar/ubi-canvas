using UnityEngine;

namespace UbiArt.ITF {
	public partial class Mesh3DComponent : GraphicComponent {
		[Serialize("materialList"         )] public CList<GFXMaterialSerializable> materialList;
		[Serialize("mesh3D"               )] public Path mesh3D;
		[Serialize("mesh3DList"           )] public CList<Path> mesh3DList;
		[Serialize("skeleton3D"           )] public Path skeleton3D;
		[Serialize("animation3D"          )] public Path animation3D;
		[Serialize("animation3DList"      )] public CList<Path> animation3DList;
		[Serialize("animation3DSet"       )] public Animation3DSet animation3DSet;
		[Serialize("animationNode"        )] public StringID animationNode;
		[Serialize("Animation_player_mode")] public Enum_Animation_player_mode Animation_player_mode;
		[Serialize("ScaleZ"               )] public float ScaleZ;
		[Serialize("orientation"          )] public Matrix44 orientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ScaleZ));
					SerializeField(s, nameof(materialList));
					SerializeField(s, nameof(mesh3D));
					SerializeField(s, nameof(mesh3DList));
					SerializeField(s, nameof(skeleton3D));
					SerializeField(s, nameof(animation3D));
					SerializeField(s, nameof(animation3DList));
					SerializeField(s, nameof(animation3DSet));
					SerializeField(s, nameof(animationNode));
					SerializeField(s, nameof(Animation_player_mode));
					SerializeField(s, nameof(orientation));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(materialList));
					SerializeField(s, nameof(mesh3D));
					SerializeField(s, nameof(mesh3DList));
					SerializeField(s, nameof(skeleton3D));
					SerializeField(s, nameof(animation3D));
					SerializeField(s, nameof(animation3DList));
					SerializeField(s, nameof(animation3DSet));
					SerializeField(s, nameof(animationNode));
					SerializeField(s, nameof(Animation_player_mode));
				}
			}
		}
		public enum Enum_Animation_player_mode {
			[Serialize("Cine"             )] Cine = 0,
			[Serialize("Contracted"       )] Contracted = 1,
			[Serialize("Expanded"         )] Expanded = 2,
			[Serialize("ExpandedAffectPos")] ExpandedAffectPos = 3,
		}
		public enum Enum_Animation_player_mode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x1A7E999A;
	}
}

