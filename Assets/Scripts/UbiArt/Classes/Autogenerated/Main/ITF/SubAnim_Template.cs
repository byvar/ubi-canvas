using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class SubAnim_Template : CSerializable {
		[Serialize("friendlyName"   )] public StringID friendlyName;
		[Serialize("name"           )] public Path name;
		[Serialize("playRate"       )] public float playRate;
		[Serialize("loop"           )] public bool loop;
		[Serialize("flags"          )] public uint flags;
		[Serialize("useRootRotation")] public bool useRootRotation;
		[Serialize("reverse"        )] public bool reverse;
		[Serialize("defaultFlip"    )] public bool defaultFlip;
		[Serialize("markerStart"    )] public StringID markerStart;
		[Serialize("markerStop"     )] public StringID markerStop;
		[Serialize("procedural"     )] public bool procedural;
		[Serialize("sync"           )] public bool sync;
		[Serialize("syncEighthNote" )] public uint syncEighthNote;
		[Serialize("syncRatio"      )] public float syncRatio;
		[Serialize("allowSyncOffset")] public bool allowSyncOffset;
		[Serialize("shadowMul"      )] public float shadowMul;
		[Serialize("metronome"      )] public METRONOME_TYPE metronome;
		[Serialize("metronome"      )] public METRONOME_TYPE2 metronome2;
		[Serialize("metronome"      )] public METRONOME_TYPE3 metronome3;
		[Serialize("forceZOffset"   )] public bool forceZOffset;
		[Serialize("forceZOffset"   )] public BOOL forceZOffset2;
		[Serialize("useRootFlip"    )] public bool useRootFlip;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(friendlyName));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(useRootRotation));
				SerializeField(s, nameof(reverse));
				SerializeField(s, nameof(defaultFlip));
				SerializeField(s, nameof(markerStart));
				SerializeField(s, nameof(markerStop));
				SerializeField(s, nameof(procedural));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(syncEighthNote));
				SerializeField(s, nameof(syncRatio));
				SerializeField(s, nameof(allowSyncOffset));
				SerializeField(s, nameof(shadowMul));
				SerializeField(s, nameof(metronome2));
			} else if(Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(friendlyName));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(useRootRotation));
				SerializeField(s, nameof(reverse));
				SerializeField(s, nameof(defaultFlip));
				SerializeField(s, nameof(markerStart));
				SerializeField(s, nameof(markerStop));
				SerializeField(s, nameof(procedural));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(syncEighthNote));
				SerializeField(s, nameof(syncRatio));
				SerializeField(s, nameof(allowSyncOffset));
				SerializeField(s, nameof(shadowMul));
				SerializeField(s, nameof(metronome3));
				SerializeField(s, nameof(forceZOffset2));
			} else if(Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(friendlyName));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(useRootRotation), boolAsByte: true);
				SerializeField(s, nameof(reverse));
				SerializeField(s, nameof(defaultFlip));
				SerializeField(s, nameof(markerStart));
				SerializeField(s, nameof(markerStop));
				SerializeField(s, nameof(procedural));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(syncEighthNote));
				SerializeField(s, nameof(syncRatio));
				SerializeField(s, nameof(allowSyncOffset));
				SerializeField(s, nameof(shadowMul));
				SerializeField(s, nameof(metronome3));
				SerializeField(s, nameof(forceZOffset2));
			} else {
				SerializeField(s, nameof(friendlyName));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(flags));
				SerializeField(s, nameof(useRootRotation));
				SerializeField(s, nameof(reverse));
				SerializeField(s, nameof(defaultFlip));
				SerializeField(s, nameof(markerStart));
				SerializeField(s, nameof(markerStop));
				SerializeField(s, nameof(procedural));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(syncEighthNote));
				SerializeField(s, nameof(syncRatio));
				SerializeField(s, nameof(allowSyncOffset));
				SerializeField(s, nameof(shadowMul));
				SerializeField(s, nameof(metronome));
				SerializeField(s, nameof(forceZOffset));
				SerializeField(s, nameof(useRootFlip));
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

