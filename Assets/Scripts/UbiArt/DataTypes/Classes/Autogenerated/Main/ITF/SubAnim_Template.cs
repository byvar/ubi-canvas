namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.VH | GameFlags.RA)]
	public partial class SubAnim_Template : CSerializable {
		public StringID friendlyName;
		public Path name;
		public float playRate;
		public bool loop;
		public uint flags;
		public bool useRootRotation;
		public bool reverse;
		public bool defaultFlip;
		public StringID markerStart;
		public StringID markerStop;
		public bool procedural;
		public bool sync;
		public uint syncEighthNote;
		public float syncRatio;
		public bool allowSyncOffset;
		public float shadowMul;
		public METRONOME_TYPE metronome;
		public METRONOME_TYPE2 metronome2;
		public METRONOME_TYPE3 metronome3;
		public bool forceZOffset;
		public BOOL forceZOffset2;
		public bool useRootFlip;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				friendlyName = s.SerializeObject<StringID>(friendlyName, name: "friendlyName");
				name = s.SerializeObject<Path>(name, name: "name");
				playRate = s.Serialize<float>(playRate, name: "playRate");
				loop = s.Serialize<bool>(loop, name: "loop");
				useRootRotation = s.Serialize<bool>(useRootRotation, name: "useRootRotation");
				reverse = s.Serialize<bool>(reverse, name: "reverse");
				defaultFlip = s.Serialize<bool>(defaultFlip, name: "defaultFlip");
				markerStart = s.SerializeObject<StringID>(markerStart, name: "markerStart");
				markerStop = s.SerializeObject<StringID>(markerStop, name: "markerStop");
				procedural = s.Serialize<bool>(procedural, name: "procedural");
				sync = s.Serialize<bool>(sync, name: "sync");
				syncEighthNote = s.Serialize<uint>(syncEighthNote, name: "syncEighthNote");
				syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
				allowSyncOffset = s.Serialize<bool>(allowSyncOffset, name: "allowSyncOffset");
				shadowMul = s.Serialize<float>(shadowMul, name: "shadowMul");
				metronome2 = s.Serialize<METRONOME_TYPE2>(metronome2, name: "metronome");
			} else if(s.Settings.game == Settings.Game.RL) {
				friendlyName = s.SerializeObject<StringID>(friendlyName, name: "friendlyName");
				name = s.SerializeObject<Path>(name, name: "name");
				playRate = s.Serialize<float>(playRate, name: "playRate");
				loop = s.Serialize<bool>(loop, name: "loop");
				useRootRotation = s.Serialize<bool>(useRootRotation, name: "useRootRotation");
				reverse = s.Serialize<bool>(reverse, name: "reverse");
				defaultFlip = s.Serialize<bool>(defaultFlip, name: "defaultFlip");
				markerStart = s.SerializeObject<StringID>(markerStart, name: "markerStart");
				markerStop = s.SerializeObject<StringID>(markerStop, name: "markerStop");
				procedural = s.Serialize<bool>(procedural, name: "procedural");
				sync = s.Serialize<bool>(sync, name: "sync");
				syncEighthNote = s.Serialize<uint>(syncEighthNote, name: "syncEighthNote");
				syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
				allowSyncOffset = s.Serialize<bool>(allowSyncOffset, name: "allowSyncOffset");
				shadowMul = s.Serialize<float>(shadowMul, name: "shadowMul");
				metronome3 = s.Serialize<METRONOME_TYPE3>(metronome3, name: "metronome");
				forceZOffset2 = s.Serialize<BOOL>(forceZOffset2, name: "forceZOffset");
			} else if(s.Settings.game == Settings.Game.COL) {
				friendlyName = s.SerializeObject<StringID>(friendlyName, name: "friendlyName");
				name = s.SerializeObject<Path>(name, name: "name");
				playRate = s.Serialize<float>(playRate, name: "playRate");
				loop = s.Serialize<bool>(loop, name: "loop");
				useRootRotation = s.Serialize<bool>(useRootRotation, name: "useRootRotation", options: CSerializerObject.Options.BoolAsByte);
				reverse = s.Serialize<bool>(reverse, name: "reverse");
				defaultFlip = s.Serialize<bool>(defaultFlip, name: "defaultFlip");
				markerStart = s.SerializeObject<StringID>(markerStart, name: "markerStart");
				markerStop = s.SerializeObject<StringID>(markerStop, name: "markerStop");
				procedural = s.Serialize<bool>(procedural, name: "procedural");
				sync = s.Serialize<bool>(sync, name: "sync");
				syncEighthNote = s.Serialize<uint>(syncEighthNote, name: "syncEighthNote");
				syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
				allowSyncOffset = s.Serialize<bool>(allowSyncOffset, name: "allowSyncOffset");
				shadowMul = s.Serialize<float>(shadowMul, name: "shadowMul");
				metronome3 = s.Serialize<METRONOME_TYPE3>(metronome3, name: "metronome");
				forceZOffset2 = s.Serialize<BOOL>(forceZOffset2, name: "forceZOffset");
			} else {
				friendlyName = s.SerializeObject<StringID>(friendlyName, name: "friendlyName");
				name = s.SerializeObject<Path>(name, name: "name");
				playRate = s.Serialize<float>(playRate, name: "playRate");
				loop = s.Serialize<bool>(loop, name: "loop");
				flags = s.Serialize<uint>(flags, name: "flags");
				useRootRotation = s.Serialize<bool>(useRootRotation, name: "useRootRotation");
				reverse = s.Serialize<bool>(reverse, name: "reverse");
				defaultFlip = s.Serialize<bool>(defaultFlip, name: "defaultFlip");
				markerStart = s.SerializeObject<StringID>(markerStart, name: "markerStart");
				markerStop = s.SerializeObject<StringID>(markerStop, name: "markerStop");
				procedural = s.Serialize<bool>(procedural, name: "procedural");
				sync = s.Serialize<bool>(sync, name: "sync");
				syncEighthNote = s.Serialize<uint>(syncEighthNote, name: "syncEighthNote");
				syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
				allowSyncOffset = s.Serialize<bool>(allowSyncOffset, name: "allowSyncOffset");
				shadowMul = s.Serialize<float>(shadowMul, name: "shadowMul");
				metronome = s.Serialize<METRONOME_TYPE>(metronome, name: "metronome");
				forceZOffset = s.Serialize<bool>(forceZOffset, name: "forceZOffset");
				useRootFlip = s.Serialize<bool>(useRootFlip, name: "useRootFlip");
			}
		}
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
		}
		public enum METRONOME_TYPE2 {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_LUMKING" )] LUMKING = 3,
		}
		public enum METRONOME_TYPE3 {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
		}
		public enum BOOL {
			[Serialize("BOOL_false")] _false = 0,
			[Serialize("BOOL_true" )] _true = 1,
			[Serialize("BOOL_cond" )] cond = 2,
		}
	}
}

