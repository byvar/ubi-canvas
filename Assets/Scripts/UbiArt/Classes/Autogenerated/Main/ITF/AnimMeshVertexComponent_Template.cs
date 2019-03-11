using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimMeshVertexComponent_Template : GraphicComponent_Template {
		[Serialize("defaultUpdate")] public bool defaultUpdate;
		[Serialize("draw2D"       )] public bool draw2D;
		[Serialize("amvPath"      )] public Path amvPath;
		[Serialize("texture"      )] public Path texture;
		[Serialize("material"     )] public GFXMaterialSerializable material;
		[Serialize("useEditor"    )] public bool useEditor;
		[Serialize("useDataAnims" )] public bool useDataAnims;
		[Serialize("useActorScale")] public bool useActorScale;
		[Serialize("stopDuration" )] public float stopDuration;
		[Serialize("animPackage"  )] public Placeholder animPackage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(defaultUpdate));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(amvPath));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(useEditor));
				SerializeField(s, nameof(useDataAnims));
				SerializeField(s, nameof(useActorScale));
				SerializeField(s, nameof(stopDuration));
				SerializeField(s, nameof(animPackage));
			} else {
				SerializeField(s, nameof(defaultUpdate));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(amvPath));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(useEditor));
				SerializeField(s, nameof(useDataAnims));
				SerializeField(s, nameof(useActorScale));
				SerializeField(s, nameof(stopDuration));
			}
		}
		public override uint? ClassCRC => 0x35E20242;
	}
}

