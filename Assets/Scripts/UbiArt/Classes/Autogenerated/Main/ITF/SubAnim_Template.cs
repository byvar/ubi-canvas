using UnityEngine;

namespace UbiArt.ITF {
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
		[Serialize("forceZOffset"   )] public bool forceZOffset;
		[Serialize("useRootFlip"    )] public bool useRootFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
		}
	}
}

