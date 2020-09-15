using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Actor_Template : TemplatePickable {
		[Serialize("PROCEDURAL"                                  )] public bool PROCEDURAL;
		[Serialize("STARTPAUSED"                                 )] public bool STARTPAUSED;
		[Serialize("FORCEISENVIRONMENT"                          )] public bool FORCEISENVIRONMENT;
		[Serialize("FORCEALWAYSACTIVE"                           )] public bool FORCEALWAYSACTIVE;
		[Serialize("UPDATEFREQUENCE"                             )] public uint UPDATEFREQUENCE;
		[Serialize("COMPONENTS"                                  )] public CArray<Generic<ActorComponent_Template>> COMPONENTS;
		[Serialize("scaleForced"                                 )] public Vec2d scaleForced;
		[Serialize("scaleMin"                                    )] public Vec2d scaleMin;
		[Serialize("scaleMax"                                    )] public Vec2d scaleMax;
		[Serialize("xFLIPPED"                                    )] public int xFLIPPED;
		[Serialize("zForced"                                     )] public float zForced;
		[Serialize("useZForced"                                  )] public int useZForced;
		[Serialize("archetype"                                   )] public StringID archetype;
		[Serialize("type"                                        )] public StringID type;
		[Serialize("updatetype"                                  )] public Pickable.UpdateType updatetype;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (this is FriseConfig) return;
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
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (this is FriseConfig) return;
				SerializeField(s, nameof(PROCEDURAL), boolAsByte: true);
				SerializeField(s, nameof(STARTPAUSED), boolAsByte: true);
				SerializeField(s, nameof(FORCEISENVIRONMENT), boolAsByte: true);
				SerializeField(s, nameof(COMPONENTS));
			} else if (Settings.s.game == Settings.Game.VH) {
				if (this is FriseConfig) return;
				SerializeField(s, nameof(PROCEDURAL));
				SerializeField(s, nameof(STARTPAUSED));
				SerializeField(s, nameof(FORCEISENVIRONMENT));
				SerializeField(s, nameof(FORCEALWAYSACTIVE));
				SerializeField(s, nameof(COMPONENTS));
			} else {
				SerializeField(s, nameof(PROCEDURAL));
				SerializeField(s, nameof(STARTPAUSED));
				SerializeField(s, nameof(FORCEISENVIRONMENT));
				SerializeField(s, nameof(FORCEALWAYSACTIVE));
				SerializeField(s, nameof(UPDATEFREQUENCE));
				SerializeField(s, nameof(COMPONENTS));
			}
		}
		public override uint? ClassCRC => 0x1B857BCE;
	}
}

