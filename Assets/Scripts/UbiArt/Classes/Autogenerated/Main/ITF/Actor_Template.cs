using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor_Template : TemplatePickable {
		[Serialize("PROCEDURAL"        )] public bool PROCEDURAL;
		[Serialize("STARTPAUSED"       )] public bool STARTPAUSED;
		[Serialize("FORCEISENVIRONMENT")] public bool FORCEISENVIRONMENT;
		[Serialize("FORCEALWAYSACTIVE" )] public bool FORCEALWAYSACTIVE;
		[Serialize("COMPONENTS"        )] public CArray<Generic<ActorComponent_Template>> COMPONENTS;
		[Serialize("ANGLE"             )] public Angle ANGLE;
		[Serialize("SCALE"             )] public Vector2 SCALE;
		[Serialize("ObjectFamily"      )] public uint ObjectFamily;
		[Serialize("scaleForced"       )] public Vector2 scaleForced;
		[Serialize("scaleMin"          )] public Vector2 scaleMin;
		[Serialize("scaleMax"          )] public Vector2 scaleMax;
		[Serialize("xFLIPPED"          )] public bool xFLIPPED;
		[Serialize("zForced"           )] public float zForced;
		[Serialize("useZForced"        )] public bool useZForced;
		[Serialize("archetype"         )] public StringID archetype;
		[Serialize("type"              )] public StringID type;
		[Serialize("updatetype"        )] public Pickable__UpdateType_O updatetype;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ANGLE));
				SerializeField(s, nameof(SCALE));
				SerializeField(s, nameof(ObjectFamily));
				SerializeField(s, nameof(scaleForced));
				SerializeField(s, nameof(scaleMin));
				SerializeField(s, nameof(scaleMax));
				SerializeField(s, nameof(xFLIPPED));
				SerializeField(s, nameof(PROCEDURAL));
				SerializeField(s, nameof(STARTPAUSED));
				SerializeField(s, nameof(zForced));
				SerializeField(s, nameof(useZForced));
				SerializeField(s, nameof(archetype));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(updatetype));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(COMPONENTS));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(PROCEDURAL));
				SerializeField(s, nameof(STARTPAUSED));
				SerializeField(s, nameof(FORCEISENVIRONMENT));
				SerializeField(s, nameof(COMPONENTS));
			} else {
				SerializeField(s, nameof(PROCEDURAL));
				SerializeField(s, nameof(STARTPAUSED));
				SerializeField(s, nameof(FORCEISENVIRONMENT));
				SerializeField(s, nameof(FORCEALWAYSACTIVE));
				SerializeField(s, nameof(COMPONENTS));
			}
		}
		public enum Pickable__UpdateType_O {
			[Serialize("Pickable::UpdateType_OnlyIfVisible"   )] nlyIfVisible = 0,
			[Serialize("Pickable::UpdateType_OffscreenAllowed")] ffscreenAllowed = 1,
		}
		public override uint? ClassCRC => 0x1B857BCE;
	}
}

