using UnityEngine;

namespace UbiArt.ITF {
	public partial class MetaFrieze : Pickable {
		[Serialize("PointsList"                )] public PolyPointList PointsList;
		[Serialize("PrimitiveParameters"       )] public CList<GFXPrimitiveParam> PrimitiveParameters;
		[Serialize("ConfigCRC"                 )] public uint ConfigCRC;
		[Serialize("ConfigName"                )] public Path ConfigName;
		[Serialize("SwitchExtremityStart"      )] public bool SwitchExtremityStart;
		[Serialize("SwitchExtremityStop"       )] public bool SwitchExtremityStop;
		[Serialize("SwitchTexturePipeExtremity")] public uint SwitchTexturePipeExtremity;
		[Serialize("IsFriendlyNameValid"       )] public bool IsFriendlyNameValid;
		[Serialize("FriezePath"                )] public Placeholder FriezePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(PointsList));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(FriezePath));
					SerializeField(s, nameof(PrimitiveParameters));
					SerializeField(s, nameof(ConfigCRC));
				}
				SerializeField(s, nameof(ConfigName));
				SerializeField(s, nameof(SwitchExtremityStart));
				SerializeField(s, nameof(SwitchExtremityStop));
				SerializeField(s, nameof(SwitchTexturePipeExtremity));
				SerializeField(s, nameof(IsFriendlyNameValid));
			} else {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(PointsList));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(PrimitiveParameters));
					SerializeField(s, nameof(ConfigCRC));
				}
				SerializeField(s, nameof(ConfigName));
				SerializeField(s, nameof(SwitchExtremityStart));
				SerializeField(s, nameof(SwitchExtremityStop));
				SerializeField(s, nameof(SwitchTexturePipeExtremity));
				SerializeField(s, nameof(IsFriendlyNameValid));
			}
		}
		public override uint? ClassCRC => 0xA2E15233;
	}
}

