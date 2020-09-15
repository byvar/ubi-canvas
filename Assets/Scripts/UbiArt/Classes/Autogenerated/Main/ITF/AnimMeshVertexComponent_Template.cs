using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.VH | GameFlags.RL)]
	public partial class AnimMeshVertexComponent_Template : GraphicComponent_Template {
		public bool defaultUpdate;
		public bool draw2D;
		public Path amvPath;
		public Path texture;
		public GFXMaterialSerializable material;
		public bool useEditor;
		public bool useDataAnims;
		public bool useActorScale;
		public float stopDuration;
		public AnimResourcePackage animPackage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				defaultUpdate = s.Serialize<bool>(defaultUpdate, name: "defaultUpdate");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				useEditor = s.Serialize<bool>(useEditor, name: "useEditor");
				useDataAnims = s.Serialize<bool>(useDataAnims, name: "useDataAnims");
				useActorScale = s.Serialize<bool>(useActorScale, name: "useActorScale");
				stopDuration = s.Serialize<float>(stopDuration, name: "stopDuration");
				animPackage = s.SerializeObject<AnimResourcePackage>(animPackage, name: "animPackage");
			} else {
				defaultUpdate = s.Serialize<bool>(defaultUpdate, name: "defaultUpdate");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
				amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				useEditor = s.Serialize<bool>(useEditor, name: "useEditor");
				useDataAnims = s.Serialize<bool>(useDataAnims, name: "useDataAnims");
				useActorScale = s.Serialize<bool>(useActorScale, name: "useActorScale");
				stopDuration = s.Serialize<float>(stopDuration, name: "stopDuration");
			}
		}
		public override uint? ClassCRC => 0x35E20242;
	}
}

